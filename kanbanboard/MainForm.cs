using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ContentAlignment = System.Drawing.ContentAlignment;

namespace kanbanboard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Load += (s, a) =>
            {
                UsernameLabel.Text = Login.Username;
                StripPanel.Location = ProfileButton.Location;
                Table();
                SetDoubleBuffered(TableLayoutPanel);
                MainForm_Resize(null, null);
            };
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
            AddTitle("Что-то начать делать", 0);
            AddTitle("Что-то делают", 1);
            AddTitle("Что-то сделано", 2);
            AddTitle("Что-то нужно сдать", 3);

            TableLayoutPanel.RowCount -= 1;
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
                Font = new Font("Tahoma", 9.75F, FontStyle.Regular),
                ForeColor = Color.FromArgb(160,160,160),
                Margin = new Padding(5),
                AutoSize = true
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
            } catch { }
        }

        // Добавить контрол (в основном тикет) в таблицу
        private void AddControlToPanel(Control control, int column, int row)
        {
            // Инициализация имени панели тикета
            control.Name = $"ticket{column}{row}";
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
            var row = 0;
            var verticalOffset = 0;
            foreach (var h in TableLayoutPanel.GetRowHeights())
            {
                var column = 0;
                var horizontalOffset = 0;
                foreach (var w in TableLayoutPanel.GetColumnWidths())
                {
                    var rectangle = new Rectangle(horizontalOffset, verticalOffset, w, h);
                    if (rectangle.Contains(e.Location))
                    {
                        MessageBox.Show($"row {row}, column {column} was clicked");
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

        // Событие при изменении размера формы
        private void MainForm_Resize(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)(() =>
            {
                foreach (ColumnStyle column in TableLayoutPanel.ColumnStyles)
                {
                    column.SizeType = SizeType.Percent;
                    column.Width = 100 / TableLayoutPanel.ColumnCount;
                }
                TableLayoutPanel.Controls.OfType<TicketPanel>().ToList().ForEach(x => x.Width = TableLayoutPanel.Width / TableLayoutPanel.ColumnCount);

                for (int i = 1; i < TableLayoutPanel.RowCount; i++)
                {
                    TableLayoutPanel.RowStyles[i].SizeType = SizeType.Percent;
                    TableLayoutPanel.RowStyles[i].Height = 100 / TableLayoutPanel.RowCount;
                }
                TableLayoutPanel.Controls.OfType<TicketPanel>().ToList().ForEach(x =>
                {
                    if (TableLayoutPanel.GetCellPosition(x).Row != 0) x.Height = TableLayoutPanel.Height / TableLayoutPanel.RowCount;
                });
            }));
        }

        // Обработчик задач
        private void TasksButton_Click(object sender, EventArgs e)
        {
            LabelHead.Text = "Задачи";
            
            TableLayoutPanel.BringToFront();

            StripPanel.Location = TasksButton.Location;
        }

        // Обработчик профиля
        private void ProfileButton_Click(object sender, EventArgs e)
        {
            LabelHead.Text = "Профиль";
            
            UserPanel.BringToFront();

            StripPanel.Location = ProfileButton.Location;
        }

        // Обработчик мессенджера
        private void MessengerButton_Click(object sender, EventArgs e)
        {
            LabelHead.Text = "Мессенджер";
            BasicContentPanel.Controls.Clear();
            var MsgrTab = new Messenger() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            MsgrTab.FormBorderStyle = FormBorderStyle.None;
            BasicContentPanel.Controls.Add(MsgrTab);
            MsgrTab.Show();

            StripPanel.Location = MessengerButton.Location;
        }

        // Обработчик календаря
        private void CalendarButton_Click(object sender, EventArgs e)
        {
            LabelHead.Text = "Календарь";
            BasicContentPanel.Controls.Clear();
            var calenderTab = new Calendar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            BasicContentPanel.Controls.Add(calenderTab);
            calenderTab.Show();

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
            Hide();
            var LoginForm = new Login();
            LoginForm.Show();
        }
        
        private void UserPanel_Resize(object sender, EventArgs e)
        {
            UserLabel.ToCenter(UserPanel);
        }
    }
}
