using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Runtime.CompilerServices;

namespace kanbanboard
{
    public partial class MainForm : Form
    {
        private static User _user;

        public MainForm(string username)
        {
            InitializeComponent();
            ListBoxOfProjectNames.Items.Clear();

            // Вернуться в LoginForm по ESC
            KeyDown += (s, a) =>
            {
                if (a.KeyValue == (int)Keys.Escape) ExitButton.PerformClick();
            };

            // Отправить сообщение по Enter
            MessengerTextBox.KeyPress += (fsa, key) =>
            {
                if (key.KeyChar == (int)Keys.Enter)
                {
                    SendMessage();
                    MessengerTextBox.Clear();
                }
            };

            // Событие при изменении размера таблицы
            TableLayoutPanel.Resize += (s, a) => ResizeTable();

            // Установка двойной буферизации для устранения мерцания
            SetDoubleBuffered(TableLayoutPanel);
            SetDoubleBuffered(BasicContentPanel);
            SetDoubleBuffered(MessengerListBox);

            // Создаём экземпляр через который будем работать с базой
            _user = new User(username);
            UserInfoLabel.Text = _user.Role;

            Load += (s, a) =>
            {
                if (LoginForm.Username == "")
                {
                    UsernameLabel.Text = "Гость";
                    UserInfoLabel.Text = "";
                    return;
                }

                // Проекты пользователя
                ListBoxOfProjectNames.Items.Clear();
                ListBoxOfProjectNames.Items.AddRange(_user.ProjectNames.Cast<object>().ToArray());
                ListBoxOfProjectNames.SelectedValueChanged += (ss, aa) => {
                    try
                    {
                        TableFromFirebase(ListBoxOfProjectNames.SelectedItem.ToString());
                        ShowMessages();
                    }
                    catch {
                        // ignored
                    } };

                // Стартовый вид -> панель с профилем
                UserControlsPanel_Click(null, null);
                UsernameLabel.Text = LoginForm.Username;

                // Подсказка на кнопку с плюсом
                new ToolTip().SetToolTip(AddTitleButton, "Добавить столбец");
                
                // Сохранение данных в базу
                // Сохраняется только активная таблица (выбранная в listbox)
                FormClosing += (b, q) => {
                    if (ListBoxOfProjectNames.SelectedItem != null) Upload(ListBoxOfProjectNames.SelectedItem.ToString());
                };

                // Загрузка первого элемента из списка
                try { ListBoxOfProjectNames.SelectedIndex = 0; }
                catch { }
            };
        }

        // Показ сообщений
        private void ShowMessages()
        {
            MessengerListBox.Items.Clear();
            var messages = _user.GetMessages(ListBoxOfProjectNames.SelectedItem.ToString());
            if (messages != null)
            {
                foreach (var dic in messages)
                {
                    foreach (var item in dic)
                    {
                        MessengerListBox.Items.Add($"{item.Key}: {item.Value}");
                    }
                }

                try { MessengerListBox.TopIndex = MessengerListBox.Items.Count - 1; }
                catch { }
            }
        }

        // Процедура загрузки в базу
        private void Upload(string project)
        {
            if (TableLayoutPanel.Controls.Count == 0) return;
            var allData = new Dictionary<string, Dictionary<string, List<Dictionary<string, string>>>>();
            var projectName = project;
            var columnDate = new Dictionary<string, List<Dictionary<string, string>>>();
            for (var column = 0; column < TableLayoutPanel.ColumnStyles.Count; column++)
            {
                var ticket = new List<Dictionary<string, string>>();

                for (var row = 1; row < TableLayoutPanel.RowStyles.Count; row++)
                {
                    if (TableLayoutPanel.GetControlFromPosition(column, row) != null)
                        ticket.Add(new Dictionary<string, string>()
                        {
                            {"Title", ((TicketPanel)TableLayoutPanel.GetControlFromPosition(column, row)).Title.Text},
                            {"Ticket", ((TicketPanel)TableLayoutPanel.GetControlFromPosition(column, row)).Ticket.Text},
                            {"People", ((TicketPanel)TableLayoutPanel.GetControlFromPosition(column, row)).People.Text}
                        });
                }

                if ((TitlePanel)TableLayoutPanel.GetControlFromPosition(column, 0) != null)
                    columnDate.Add($"{column + 1}-" + ((TitlePanel)TableLayoutPanel.GetControlFromPosition(column, 0)).TitleColumnLabel.Text, ticket);
            }
            allData.Add(projectName, columnDate);

            // Вызов процедуры загрузки данных в базу
            Firebase.UploadData(allData);
        }

        // Загрузить данные в tablelayoutpanel
        private void TableFromFirebase(string selectedProject)
        {
            TableLayoutPanel.RowStyles.Clear();
            TableLayoutPanel.ColumnStyles.Clear();
            TableLayoutPanel.Controls.Clear();

            foreach (var projects in _user.ProjectsData.Where(item => item.Key == selectedProject))
            {
                int column = 0, row = 1;
                foreach (var titles in projects.Value)
                {
                    AddTitleToPanel(titles.Key.Substring(2).FirstCharToUpper(), column);
                    foreach (var tasks in titles.Value)
                    {
                        var ticket = new TicketPanel();
                        try { ticket.Title.Text = tasks["Title"] ?? ""; } catch { ticket.Title.Text = ""; }
                        try { ticket.Ticket.Text = tasks["Ticket"] ?? ""; } catch { ticket.Ticket.Text = ""; }
                        try { ticket.People.Text = tasks["People"] ?? ""; } catch { ticket.People.Text = ""; }
                        AddControlToPanel(ticket.Title.Text, ticket.Ticket.Text, ticket.People.Text, column, row++);
                    }
                    column++;
                    row = 1;
                }
            }
            ResizeTable();
        }

        // События на кнопки
        private void SetEventsOnTicket(TicketPanel ticketPanel)
        {
            // Событие по клику на каждый тикет. Открывает панель для выполнения изменений выбранного тикета
            ticketPanel.Click += (sender, args) =>
            {
                // Показ панели. Возврат к тикетам. Масштабируемость
                if (!Application.OpenForms.OfType<TicketsChangeForm>().Any()) new TicketsChangeForm(this, ticketPanel).Show();
            };

            // перемещение тикетов влево, вправо и 
            ticketPanel.LeftButton.Click += (sender, w) =>
            {
                var column = TableLayoutPanel.GetPositionFromControl(ticketPanel).Column - 1;
                if (column < 0) return;

                for (var i = 1; i < TableLayoutPanel.RowCount; i++)
                {
                    if (TableLayoutPanel.GetControlFromPosition(column, i) != null) continue;
                    AddControlToPanel(ticketPanel, column, i);
                    ResizeTable();
                    return;
                }
            };

            // Перемещение вправо
            ticketPanel.RightButton.Click += (sender, w) =>
            {
                var column = TableLayoutPanel.GetPositionFromControl(ticketPanel).Column + 1;
                if (column > TableLayoutPanel.ColumnCount) return;

                for (var i = 1; i < TableLayoutPanel.RowCount; i++)
                {
                    if (TableLayoutPanel.GetControlFromPosition(column, i) != null) continue;
                    AddControlToPanel(ticketPanel, column, i);
                    ResizeTable();
                    return;
                }
            };

            // Удаление тикета
            ticketPanel.DelButton.Click += (sender, w) => TableLayoutPanel.Controls.Remove(ticketPanel);
        }

        // Добавление заголовков
        private void AddTitleToPanel(string textOfLabel, int column)
        {
            var titlePanel = new TitlePanel { Name = $"title{column}{0}" };
            titlePanel.TitleColumnLabel.Text = textOfLabel;

            TableLayoutPanel.SuspendLayout();

            if (TableLayoutPanel.ColumnCount <= column)
            {
                TableLayoutPanel.ColumnCount++;
                TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }

            TableLayoutPanel.Controls.Add(titlePanel, column, 0);
            TableLayoutPanel.ResumeLayout();

            // Изменить заголовок
            titlePanel.TitleColumnLabel.Click += (s, a) =>
            {
                if (!Application.OpenForms.OfType<ChangeTitleForm>().Any()) new ChangeTitleForm(this, titlePanel).Show();
            };

            // Добавляем события на кнопки
            titlePanel.PlusButton.Click += (s, a) =>
            {
                for (var row = 1; row <= TableLayoutPanel.RowStyles.Count; row++)
                {
                    if (!(TableLayoutPanel.GetControlFromPosition(column, row) is null)) continue;
                    AddControlToPanel("Заголовок", "Описание", "Разработчики", column, row);
                    break;
                }
            };

            // Удалить колонку
            titlePanel.DelColumnButton.Click += (s, a) => {
                for (var i = 1; i < TableLayoutPanel.ColumnStyles.Count; i++)
                {
                    TableLayoutPanel.Controls.Remove(TableLayoutPanel.GetControlFromPosition(TableLayoutPanel.GetPositionFromControl(titlePanel).Column, i));
                }

                var col = TableLayoutPanel.GetPositionFromControl(titlePanel).Column + 1;
                TableLayoutPanel.Controls.Remove(titlePanel);

                for (; col < TableLayoutPanel.ColumnStyles.Count; col++)
                {
                    for (var row = 0; row < TableLayoutPanel.RowStyles.Count; row++)
                    {
                        if (TableLayoutPanel.GetControlFromPosition(col, row) == null) continue;
                        AddControlToPanel(TableLayoutPanel.GetControlFromPosition(col, row), col - 1, row);
                    }
                }
                
                TableLayoutPanel.ColumnCount--;
                ResizeTable();
            };

            // Изменить заголовок
            titlePanel.Click += (s, a) =>
            {
                if (!Application.OpenForms.OfType<ChangeTitleForm>().Any())
                    new ChangeTitleForm(this, titlePanel).Show();
            };
        }

        // Добавить контрол (в основном тикет) в таблицу
        private void AddControlToPanel(Control control, int column, int row)
        {
            // Инициализация имени панели тикета
            control.Name = $"ticket{column}{row}";

            // Нужно ли добавлять доп. строки и/или колонки
            if (TableLayoutPanel.RowStyles.Count <= row)
            {
                TableLayoutPanel.RowCount++;
                TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent));
            }

            if (TableLayoutPanel.ColumnStyles.Count <= column)
            {
                TableLayoutPanel.ColumnCount++;
                TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent));
            }

            TableLayoutPanel.SuspendLayout();
            TableLayoutPanel.Controls.Add(control, column, row);
            TableLayoutPanel.ResumeLayout();

            ResizeTable();
        }

        // Добавить тикет в таблицу
        private void AddControlToPanel(string title, string ticket, string people, int column, int row)
        {
            var control = new TicketPanel();
            control.Title.Text = title;
            control.Ticket.Text = ticket;
            control.People.Text = people;

            // Добавляем события на кнопки
            SetEventsOnTicket(control);

            // Инициализация имени панели тикета
            control.Name = $"ticket{column}{row}";

            // Нужно ли добавлять доп. строки и/или колонки
            if (TableLayoutPanel.RowStyles.Count <= row)
            {
                TableLayoutPanel.RowCount++;
                TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent));
            }

            if (TableLayoutPanel.ColumnStyles.Count <= column)
            {
                TableLayoutPanel.ColumnCount++;
                TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent));
            }

            TableLayoutPanel.SuspendLayout();
            TableLayoutPanel.Controls.Add(control, column, row);
            TableLayoutPanel.ResumeLayout();

            ResizeTable();
        }

        // Устранение мерцания при изменении размеров таблицы
        public static void SetDoubleBuffered(Control c)
        {
            if (SystemInformation.TerminalServerSession)
                return;
            var aProp = typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);
            aProp?.SetValue(c, true, null);
        }

        // Обработчик задач
        private void TasksButton_Click(object sender, EventArgs e)
        {
            LabelHead.Text = "Задачи";

            // перемещение панельки выделения
            StripPanel.Location = TasksButton.Location;
            // изменение размера панельки выделения
            StripPanel.Size = new Size(StripPanel.Size.Width, TasksButton.Size.Height);

            PanelWithTable.BringToFront();


            ListBoxOfProjectNames.Visible = true;
        }

        // Клик на профиль. Открытие панели с данными текущего профиля
        private void UserControlsPanel_Click(object sender, EventArgs e)
        {
            LabelHead.Text = "Профиль";
            UserPanel.BringToFront();
            // перемещение панельки выделения
            StripPanel.Location = UserControlsPanel.Location;
            // изменение размера панельки выделения
            StripPanel.Size = new Size(StripPanel.Size.Width, UserControlsPanel.Size.Height);
            ListBoxOfProjectNames.Visible = false;
        }

        // Обработчик мессенджера
        private void MessengerButton_Click(object sender, EventArgs e)
        {
            LabelHead.Text = "Мессенджер";
            MessengerPanel.BringToFront();

            // перемещение панельки выделения
            StripPanel.Location = MessengerButton.Location;

            // изменение размера панельки выделения
            StripPanel.Size = new Size(StripPanel.Size.Width, MessengerButton.Size.Height);
            
            MessengerTextBox.Focus();

            ListBoxOfProjectNames.Visible = true;
        }

        // Обработчик календаря
        private void CalendarButton_Click(object sender, EventArgs e)
        {
            LabelHead.Text = "Календарь";

            CalendarPanel_Resize(null, null);

            CalendarPanel.BringToFront();
            // перемещение панельки выделения
            StripPanel.Location = CalendarButton.Location;
            // изменение размера панельки выделения
            StripPanel.Size = new Size(StripPanel.Size.Width, CalendarButton.Size.Height);
            ListBoxOfProjectNames.Visible = false;
        }
        private void CalendarPanel_Resize(object sender, EventArgs e)
        {
            CalendarLabel.ToCenter(CalendarPanel);
            CalendarLabel.MaximumSize = CalendarPanel.Size;
        }

        // Выход из мейнформы
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
            var LoginForm = new LoginForm();
            LoginForm.Show();
        }

        // Масштабируемость канбан доски
        private void ResizeTable()
        {
            try
            {
                foreach (ColumnStyle column in TableLayoutPanel.ColumnStyles)
                {
                    column.SizeType = SizeType.Percent;
                    //column.Width = 100 / TableLayoutPanel.ColumnCount;
                    column.Width = 25;
                }
                TableLayoutPanel.Controls.OfType<TicketPanel>().ToList().ForEach(x => x.Width = TableLayoutPanel.Width / TableLayoutPanel.ColumnCount);

                TableLayoutPanel.RowStyles[0].SizeType = SizeType.Absolute;
                TableLayoutPanel.RowStyles[0].Height = 25;

                // Строки
                foreach (var row in TableLayoutPanel.RowStyles.Cast<RowStyle>().ToList().Skip(1))
                {
                    row.SizeType = SizeType.Absolute;
                    row.Height = 150;
                }

                TableLayoutPanel.Controls.OfType<TicketPanel>().ToList().ForEach(x =>
                {
                    if (TableLayoutPanel.GetCellPosition(x).Row != 0) x.Height = TableLayoutPanel.Height / TableLayoutPanel.RowCount;
                });
            }
            catch (Exception e) { Console.WriteLine("Ошибка" + e.Message); }
        }

        // Добавить колонку
        private void AddTitleButton_Click(object sender, EventArgs e)
        {
            AddTitleToPanel("Это тайтл", TableLayoutPanel.ColumnStyles.Count);
            AddControlToPanel("Заголовок", "Описание", "Разработчики", TableLayoutPanel.ColumnStyles.Count, 1);
        }

        // Показать пароль
        private void PasswordShowLinkLabel_Click(object sender, EventArgs e)
        {
            using (var tripleDes = new TripleDESCryptoServiceProvider()
            {
                Key = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes("R0CK5T4R")),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            })
            {
                var data = Convert.FromBase64String(_user.Password);
                PasswordShowLabel.Text = Encoding.UTF8.GetString(tripleDes.CreateDecryptor().TransformFinalBlock(data, 0, data.Length));
                PasswordShowLabel.Visible = true;
            }
        }

        // Доп. ручное сохранение
        private void SaveProjectButton_Click(object sender, EventArgs e)
        {
            if (ListBoxOfProjectNames.SelectedItem != null)
                Upload(ListBoxOfProjectNames.SelectedItem.ToString());
        }

        // Дальше идут три события, связанные с DRAG AND DROP
        private void TableLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void TableLayoutPanel_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void TableLayoutPanel_DragLeave(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Мессенджер
        // Отправка сообщений
        private void SendMessage()
        {
            // Проверка валидности текста
            if (string.IsNullOrEmpty(MessengerTextBox.Text) || string.IsNullOrWhiteSpace(MessengerTextBox.Text)) return;
            MessengerListBox.Items.Add($"{_user.Username}: {MessengerTextBox.Text.Trim()}");

            _user.SaveMessage(ListBoxOfProjectNames.SelectedItem.ToString(), MessengerTextBox.Text);

            // В конец сообщений
            MessengerListBox.TopIndex = MessengerListBox.Items.Count - 1;
        }
    }
}
