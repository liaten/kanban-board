﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ContentAlignment = System.Drawing.ContentAlignment;

namespace kanbanboard
{
    public partial class MainForm : Form
    {
        private bool Form_Is_Maximized()
        {
            return (this.WindowState == FormWindowState.Maximized);
        }
        private bool Table_Is_Visible = false;
        public MainForm()
        {
            InitializeComponent();

            Load += (s, a) =>
            {
                UsernameLabel.Text = Login.Username;
                StripPanel.Visible = false;
                Table();
                SetDoubleBuffered(TableLayoutPanel);
                ResizeTable();
            };
        }

        // Изменение размера таблицы
        private void ResizeTable()
        {
            BeginInvoke((MethodInvoker)(() =>
            {
                foreach (ColumnStyle column in TableLayoutPanel.ColumnStyles)
                {
                    column.SizeType = SizeType.Percent;
                    //column.Width = 100 / TableLayoutPanel.ColumnCount;
                    column.Width = 25;
                }
                TableLayoutPanel.Controls.OfType<TicketPanel>().ToList().ForEach(x => x.Width = TableLayoutPanel.Width / TableLayoutPanel.ColumnCount);
                TableLayoutPanel.RowStyles[0].SizeType = SizeType.Absolute;
                TableLayoutPanel.RowStyles[0].Height = 30;
                for (int i = 1; i < TableLayoutPanel.RowStyles.Count; i++)
                {
                    TableLayoutPanel.RowStyles[i].SizeType = SizeType.Absolute;
                    TableLayoutPanel.RowStyles[i].Height = 100;
                }

                TableLayoutPanel.Controls.OfType<TicketPanel>().ToList().ForEach(x =>
                {
                    if (TableLayoutPanel.GetCellPosition(x).Row != 0) x.Height = TableLayoutPanel.Height / TableLayoutPanel.RowCount;
                });
            }));
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
            AddControlToPanel(new TicketPanel(), 0, 2);
            AddControlToPanel(new TicketPanel(), 2, 2);

            // Тикеты
            ChangeTextInTicket("ticket21", "People", "Работяги");
            ChangeTextInTicket("ticket21", "Head", "Тайтл");
            ChangeTextInTicket("ticket21", "Ticket", "Текстовый текст");
            ChangeTextInTicket("ticket21", "Head", "Текстовый текст номер два точка ноль точка");

            // Для заголовков
            // TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // Заголовки
            AddTitle("Сделать", 0);
            AddTitle("В процессе", 1);
            AddTitle("На рассмотрении", 2);
            AddTitle("Готово", 3);

            //TableLayoutPanel.RowCount -= 1;
            BasicContentPanel.Controls.Add(TableLayoutPanel);
        }

        // Добавление заголовков
        private void AddTitle(string text, int column)
        {
            if (TableLayoutPanel.ColumnCount <= column) TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            AddControlToPanel(new Label()
            {
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Roboto", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(160, 160, 160),
                Margin = new Padding(5),
                AutoSize = true,
                Dock = DockStyle.Fill
            }, column, 0);
        }

        // Изменение текста в тикетах
        private void ChangeTextInTicket(string kanbanTicketPanelColumnRow, string whichLabel, string inputText)
        {
            // kanbanTicketPanelColumnRow — ticket{column}{row}
            // whichLabel — Head/Ticket/People
            // inputText — любой текст

            try
            {
                TableLayoutPanel.Controls.OfType<TicketPanel>().First(x => x.Name == kanbanTicketPanelColumnRow)
                    .Controls.OfType<Label>().First(x => x.Name == whichLabel)
                    .Text = inputText;
            }
            catch { }
        }

        // Добавить контрол (в основном тикет) в таблицу
        private void AddControlToPanel(Control control, int column, int row)
        {
            // Инициализация имени панели тикета
            control.Name = $"ticket c{column}r{row}";
            control.Click += (s, a) => MessageBox.Show(control.Name);

            // Нужно ли добавлять доп. строки и/или колонки
            if (TableLayoutPanel.RowStyles.Count <= row)
                TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            if (TableLayoutPanel.ColumnStyles.Count <= column)
                TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            TableLayoutPanel.Controls.Add(control, column, row);
        }

        // *Для дебага. Получить позицию при клике
        private void TableLayoutPanel_MouseClick(object sender, MouseEventArgs e)
        {
            int row = 0;
            int verticalOffset = 0;
            foreach (int h in TableLayoutPanel.GetRowHeights())
            {
                int column = 0;
                int horizontalOffset = 0;
                foreach (var w in TableLayoutPanel.GetColumnWidths())
                {
                    var rectangle = new Rectangle(horizontalOffset, verticalOffset, w, h);
                    if (rectangle.Contains(e.Location))
                    {
                        MessageBox.Show($"row {row}, column {column + 1} was clicked");
                        return;
                    }

                    horizontalOffset += w;
                    column++;
                }
                verticalOffset += h;
                row++;
            }
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
            Table_Is_Visible = true;
            StripPanel.Visible = true;
            LabelHead.Text = "Задачи";

            TableLayoutPanel.BringToFront();

            StripPanel.Location = TasksButton.Location;
        }

        // Обработчик мессенджера
        private void MessengerButton_Click(object sender, EventArgs e)
        {
            Table_Is_Visible = false;
            StripPanel.Visible = true;
            LabelHead.Text = "Мессенджер";
            UserPanel.BringToFront();
            StripPanel.Location = MessengerButton.Location;
        }

        // Обработчик календаря
        private void CalendarButton_Click(object sender, EventArgs e)
        {
            Table_Is_Visible = false;
            StripPanel.Visible = true;
            LabelHead.Text = "Календарь";
            UserPanel.BringToFront();
            StripPanel.Location = CalendarButton.Location;
        }

        private void UserPanel_MouseEnter(object sender, EventArgs e)
        {
            UserControlsPanel.BackColor = Color.FromArgb(14, 20, 44);
        }

        private void UserPanel_MouseLeave(object sender, EventArgs e)
        {
            UserControlsPanel.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Table_Is_Visible = false;
            Hide();
            var LoginForm = new Login();
            LoginForm.Show();
        }

        private void UserPanel_Resize(object sender, EventArgs e)
        {
            FullName.ToCenter(UserPanel);
        }

        private void TableLayoutPanel_Resize(object sender, EventArgs e)
        {
            if (Table_Is_Visible)
            {
                ResizeTable();
            }
        }

        private void UserControlsPanel_Click(object sender, EventArgs e)
        {
            Table_Is_Visible = false;
            LabelHead.Text = "Профиль";
            UserPanel.BringToFront();
            StripPanel.Visible = false;
        }
    }
}
