using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ContentAlignment = System.Drawing.ContentAlignment;

namespace kanbanboard
{
    public partial class MainForm : Form
    {
        private User _user;

        public MainForm()
        {
            InitializeComponent();

            // Событие при изменении размера таблицы
            TableLayoutPanel.Resize += (s, a) => ResizeTable();

            // Установка двойной буферизации для устранения мерцания
            SetDoubleBuffered(TableLayoutPanel);
            SetDoubleBuffered(BasicContentPanel);

            Load += (s, a) =>
            {
                _user = new User();

                // Проекты пользователя
                ListBoxOfProjectNames.Items.Clear();
                ListBoxOfProjectNames.Items.AddRange(_user.ProjectNames.Cast<object>().ToArray());
                ListBoxOfProjectNames.SelectedValueChanged += (ss, aa) => TableFromFirebase(ListBoxOfProjectNames.SelectedItem.ToString());

                UserControlsPanel_Click(null, null);
                UsernameLabel.Text = Login.Username;

                // Подсказка на кнопку с плюсом
                new ToolTip().SetToolTip(AddTitleButton, "Добавить столбец");
                
                // Добавить колонку
                AddTitleButton.Click += (u, p) =>
                {
                    AddTitleToPanel("Это тест", TableLayoutPanel.ColumnStyles.Count);
                    AddControlToPanel("test", "test", "test", TableLayoutPanel.ColumnStyles.Count, 1);
                };

                // Сохранение данных в базу
                // Сохраняется только активная таблица (выбранная в listbox)
                FormClosing += (b, q) =>
                {
                    if (TableLayoutPanel.Controls.Count == 0) return;
                    var allData = new Dictionary<string, Dictionary<string, List<Dictionary<string, string>>>>();
                    var projectName = ListBoxOfProjectNames.SelectedItem.ToString();
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
                            
                        columnDate.Add($"{column + 1}-" + ((Label)TableLayoutPanel.GetControlFromPosition(column, 0)).Text, ticket);
                    }
                    allData.Add(projectName, columnDate);
                    
                    // Вызов процедуры загрузки данных в базу
                    _user.UploadData(allData);
                };
            };
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
                    SetTitle(titles.Key.Substring(2).FirstCharToUpper(), column);
                    foreach (var tasks in titles.Value)
                    {
                        var ticket = new TicketPanel();
                        try { ticket.Title.Text = tasks["Title"] ?? ""; } catch { ticket.Title.Text = "";}
                        try { ticket.Ticket.Text = tasks["Ticket"] ?? ""; } catch { ticket.Ticket.Text = ""; }
                        try { ticket.People.Text = tasks["People"] ?? ""; } catch { ticket.People.Text = ""; }
                        AddControlToPanel(ticket.Title.Text, ticket.Ticket.Text, ticket.People.Text, column, row++);
                    }
                    column++;
                    row = 1;
                }
            }
        }

        // События на кнопки
        private void SetEvents(TicketPanel x)
        {
            // Событие по клику на каждый тикет. Открывает панель для выполнения изменений выбранного тикета
            x.Click += (sender, args) =>
            {
                // Показ панели. Возврат к тикетам. Масштабируемость
                TicketsChangePanel.BringToFront();
                ChangingPanel.ToCenter(TicketsChangePanel);

                TicketsChangePanel.Click += (o, eventArgs) =>
                {
                    PanelWithTable.BringToFront();
                    ChangingPanel.Controls.OfType<TextBox>().ToList().ForEach(y => y.Clear());
                };

                TicketsChangePanel.Resize += (o, eventArgs) => ChangingPanel.ToCenter(TicketsChangePanel);

                // Показываем значения лейблов тикета
                ChangingTitleTextBox.Text = x.Title.Text;
                ChangingTicketTextBox.Text = x.Ticket.Text;
                ChangingPeopleTextBox.Text = x.People.Text;

                // Изменяем при нажатии на кнопку сохранения
                SaveChangesButton.Click += (o, eventArgs) =>
                {
                    x.Title.Text = ChangingTitleTextBox.Text;
                    x.Ticket.Text = ChangingTicketTextBox.Text;
                    x.People.Text = ChangingPeopleTextBox.Text;
                    MessageBox.Show("Успешно сохранено", "Изменения", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                };
            };

            // перемещение тикетов влево, вправо и удаление тикета
            x.LeftButton.Click += (sender, w) =>
            {
                var column = TableLayoutPanel.GetPositionFromControl(x).Column - 1;
                if (column < 0) return;

                for (var i = 1; i < TableLayoutPanel.RowCount; i++)
                {
                    if (TableLayoutPanel.GetControlFromPosition(column, i) != null) continue;
                    AddControlToPanel(x, column, i);
                    ResizeTable();
                    return;
                }
            };

            x.RightButton.Click += (sender, w) =>
            {
                var column = TableLayoutPanel.GetPositionFromControl(x).Column + 1;
                if (column > TableLayoutPanel.ColumnCount) return;

                for (var i = 1; i < TableLayoutPanel.RowCount; i++)
                {
                    if (TableLayoutPanel.GetControlFromPosition(column, i) != null) continue;
                    AddControlToPanel(x, column, i);
                    ResizeTable();
                    return;
                }
            };

            x.DelButton.Click += (sender, w) => TableLayoutPanel.Controls.Remove(x);
        }

        // Добавление заголовков
        private void SetTitle(string text, int column)
        {
            if (TableLayoutPanel.ColumnCount <= column)
            {
                TableLayoutPanel.ColumnCount++;
                TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }

            AddTitleToPanel(text, column);
        }

        private void AddTitleToPanel(string textOfLabel, int column)
        {
            var label = new Label()
            {
                Text = textOfLabel,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Tahoma", 9.75F, FontStyle.Regular),
                ForeColor = Color.FromArgb(160, 160, 160),
                Margin = new Padding(5),
                AutoSize = true
            };

            label.Name = $"title{column}{0}";

            TableLayoutPanel.SuspendLayout();
            TableLayoutPanel.Controls.Add(label, column, 0);
            TableLayoutPanel.ResumeLayout();
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
        }

        // Добавить тикет в таблицу
        private void AddControlToPanel(string title, string ticket, string people, int column, int row)
        {
            var control = new TicketPanel();
            control.Title.Text = title;
            control.Ticket.Text = ticket;
            control.People.Text = people;

            // Добавляем события на кнопки
            SetEvents(control);

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
        }
        
        // Обработчик мессенджера
        private void MessengerButton_Click(object sender, EventArgs e)
        {
            LabelHead.Text = "Мессенджер";
            DialogPanel.BringToFront();
            // перемещение панельки выделения
            StripPanel.Location = MessengerButton.Location;
            // изменение размера панельки выделения
            StripPanel.Size = new Size(StripPanel.Size.Width, MessengerButton.Size.Height);
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
            var LoginForm = new Login();
            LoginForm.Show();
        }

        // масштабируемость канбан доски
        private void ResizeTable()
        {
            foreach (ColumnStyle column in TableLayoutPanel.ColumnStyles)
            {
                column.SizeType = SizeType.Percent;
                //column.Width = 100 / TableLayoutPanel.ColumnCount;
                column.Width = 25;
            }
            TableLayoutPanel.Controls.OfType<TicketPanel>().ToList().ForEach(x => x.Width = TableLayoutPanel.Width / TableLayoutPanel.ColumnCount);
            TableLayoutPanel.RowStyles[0].SizeType = SizeType.AutoSize;

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
    }
}
