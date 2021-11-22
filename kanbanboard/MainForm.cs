using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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
                TableFromFirebase();

                //// Начальные данные *тестовые*
                //Table();

                UserControlsPanel_Click(null, null);
                UsernameLabel.Text = Login.Username;

                // Подсказка на кнопку с плюсом
                new ToolTip().SetToolTip(AddTitleButton, "Добавить столбец");
                
                AddTitleButton.Click += (u, p) =>
                {
                    AddTitleToPanel("Это тест", TableLayoutPanel.ColumnStyles.Count);
                    AddControlToPanel("Заголовок", "Описаг", "test", TableLayoutPanel.ColumnStyles.Count, 1);
                };
            };
        }

        private void TableFromFirebase()
        {
            TableLayoutPanel.RowStyles.Clear();
            TableLayoutPanel.ColumnStyles.Clear();
            TableLayoutPanel.Controls.Clear();

            foreach (var projects in _user.ProjectsData.Where(item => item.Key == "simplex"))
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
                ChangingTitleTextBox.Text = GetTextFromTicket(x.Name, "Title");
                ChangingTicketTextBox.Text = GetTextFromTicket(x.Name, "Ticket");
                ChangingPeopleTextBox.Text = GetTextFromTicket(x.Name, "People");

                // Изменяем при нажатии на кнопку сохранения
                SaveChangesButton.Click += (o, eventArgs) =>
                {
                    ChangeTextInTicket(x.Name, "Title", ChangingTitleTextBox.Text);
                    ChangeTextInTicket(x.Name, "Ticket", ChangingTicketTextBox.Text);
                    ChangeTextInTicket(x.Name, "People", ChangingPeopleTextBox.Text);
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

        // Получить текст из тикета
        private string GetTextFromTicket(string kanbanTicketPanelColumnRow, string whichLabel)
        {
            // kanbanTicketPanelColumnRow — ticket{column}{row}
            // whichLabel — Title/Ticket/People
            // inputText — любой текст

            try
            {
                return TableLayoutPanel.Controls.OfType<TicketPanel>().First(x => x.Name == kanbanTicketPanelColumnRow)
                    .Controls.OfType<Label>().First(x => x.Name == whichLabel)
                    .Text;
            }
            catch
            {
                return "";
            }
        }

        // Изменение текста в тикетах
        private void ChangeTextInTicket(string kanbanTicketPanelColumnRow, string whichLabel, string inputText)
        {
            // kanbanTicketPanelColumnRow — ticket{column}{row}
            // whichLabel — Title/Ticket/People
            // inputText — любой текст

            try
            {
                TableLayoutPanel.Controls.OfType<TicketPanel>().First(x => x.Name == kanbanTicketPanelColumnRow)
                    .Controls.OfType<Label>().First(x => x.Name == whichLabel)
                    .Text = inputText;
            }
            catch { }
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
