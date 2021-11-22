﻿using System;
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
                //_user.CreateProject("info");
                //_user.CreateProject("simplex");
                //_user.CreateProject("kanban");

                TableFromFirebase();

                //// Начальные данные *тестовые*
                //Table();

                UserControlsPanel_Click(null, null);
                UsernameLabel.Text = Login.Username;

                // Событие по клику на каждый тикет. Открывает панель для выполнения изменений выбранного тикета
                TableLayoutPanel.Controls.OfType<TicketPanel>().ToList().ForEach(
                    x => x.Click += (sender, args) =>
                    {
                        // Показ панели. Возврат к тикетам. Масштабируемость
                        TicketsChangePanel.BringToFront();
                        ChangingPanel.ToCenter(TicketsChangePanel);

                        TicketsChangePanel.Click += (o, eventArgs) =>
                        {
                            TableLayoutPanel.BringToFront();
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
                            MessageBox.Show("Успешно сохранено", "Изменения", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        };
                    });

                // перемещение тикетов влево, вправо и удаление тикета
                TableLayoutPanel.Controls.OfType<TicketPanel>().ToList().ForEach(x =>
                {
                    x.LeftButton.Click += (sender, w) =>
                    {
                        var column = TableLayoutPanel.GetPositionFromControl(x).Column - 1;
                        if (column < 0) return;

                        var check = true;
                        for (var i = 1; i < TableLayoutPanel.RowCount || !check; i++)
                        {
                            if (TableLayoutPanel.GetControlFromPosition(column, i) != null) continue;
                            check = true;
                            AddControlToPanel(x, column, i);
                            ResizeTable();
                            return;
                        }
                    };

                    x.RightButton.Click += (sender, w) =>
                    {
                        var column = TableLayoutPanel.GetPositionFromControl(x).Column + 1;
                        if (column > TableLayoutPanel.ColumnCount) return;

                        var check = true;
                        for (var i = 1; i < TableLayoutPanel.RowCount || !check; i++)
                        {
                            if (TableLayoutPanel.GetControlFromPosition(column, i) != null) continue;
                            check = true;
                            AddControlToPanel(x, column, i);
                            ResizeTable();
                            return;
                        }

                        // var controlPositionRow = (from Control control in TableLayoutPanel.Controls where TableLayoutPanel.GetPositionFromControl(control).Column == column select TableLayoutPanel.GetRow(control)).ToList();
                        // AddControlToPanel(x, column, controlPositionRow.Max() + 1);
                    };

                    x.DelButton.Click += (sender, w) => TableLayoutPanel.Controls.Remove(x);
                });
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
                        ticket.Title.Text = tasks["Title"];
                        ticket.Ticket.Text = tasks["Ticket"];
                        ticket.People.Text = tasks["People"];
                        AddControlToPanel(ticket, column, row++);
                    }
                    column++;
                    row = 1;
                }
            }
        }

        // Таблица с тикетами
        private void Table()
        {
            TableLayoutPanel.RowStyles.Clear();
            TableLayoutPanel.ColumnStyles.Clear();
            TableLayoutPanel.Controls.Clear();

            AddControlToPanel(new TicketPanel(), 0, 1);
            AddControlToPanel(new TicketPanel(), 1, 1);
            AddControlToPanel(new TicketPanel(), 2, 1);
            AddControlToPanel(new TicketPanel(), 3, 1);
            AddControlToPanel(new TicketPanel(), 3, 2);
            AddControlToPanel(new TicketPanel(), 0, 2);
            AddControlToPanel(new TicketPanel(), 2, 2);

            // Тикеты
            ChangeTextInTicket("ticket21", "People", "Работяги");
            ChangeTextInTicket("ticket21", "Title", "Тайтл");
            ChangeTextInTicket("ticket21", "Ticket", "Текстовый текст");
            ChangeTextInTicket("ticket21", "Title", "Текстовый текст номер два точка ноль точка");

            // Для заголовков
            // TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // Заголовки
            SetTitle("Что-то начать делать", 0);
            SetTitle("Что-то делают", 1);
            SetTitle("Что-то сделано", 2);
            SetTitle("Что-то нужно сдать", 3);

            BasicContentPanel.Controls.Add(TableLayoutPanel);
        }

        // Добавление заголовков
        private void SetTitle(string text, int column)
        {
            if (TableLayoutPanel.ColumnCount <= column)
            {
                TableLayoutPanel.ColumnCount++;
                TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }
            
            AddTitleToPanel(new Label()
            {
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Tahoma", 9.75F, FontStyle.Regular),
                ForeColor = Color.FromArgb(160, 160, 160),
                Margin = new Padding(5),
                AutoSize = true
            }, column, 0);
        }

        private void AddTitleToPanel(Label label, int column, int row)
        {
            label.Name = $"title{column}{row}";

            TableLayoutPanel.SuspendLayout();
            TableLayoutPanel.Controls.Add(label, column, row);
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

            // перемещение панельки выделения
            StripPanel.Location = TasksButton.Location;
            // изменение размера панельки выделения
            StripPanel.Size = new Size(StripPanel.Size.Width, TasksButton.Size.Height);
            LabelHead.Text = "Задачи";
            TableLayoutPanel.BringToFront();

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
