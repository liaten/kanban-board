using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Arij
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TableLayoutPanel.RowStyles.Clear();
            TableLayoutPanel.ColumnStyles.Clear();
            TableLayoutPanel.Controls.Clear();

            // for debug
            TableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;

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
            ChangeTextInTicket("ticket21", "Head", "Текстовый текст");

            // Для заголовков
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // Заголовки
            AddControlToPanel(new Label()
            {
                Text = "Что-то начать сделать",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Tahoma", 9.75F, FontStyle.Regular),
                Margin = new Padding(5)
            }, 0, 0);

            AddControlToPanel(new Label()
            {
                Text = "Что-то делают",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Tahoma", 9.75F, FontStyle.Regular),
                Margin = new Padding(5)
            }, 1, 0);

            AddControlToPanel(new Label()
            {
                Text = "Что-то сделано",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Tahoma", 9.75F, FontStyle.Regular),
                Margin = new Padding(5)
            }, 2, 0);

            AddControlToPanel(new Label()
            {
                Text = "Что-то нужно сдать",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Tahoma", 9.75F, FontStyle.Regular),
                Margin = new Padding(5)
            }, 3, 0);

            ForAutoSizeInPanel();
        }

        private void ChangeTextInTicket(string kanbanTicketPanelColumnRow, string whichLabel, string inputText)
        {
            // kanbanTicketPanelColumnRow — ticket{column}{row}
            // whichLabel — Head/Ticket/People
            // inputText — любой текст

            try {
                TableLayoutPanel.Controls.OfType<TicketPanel>().First(x => x.Name == kanbanTicketPanelColumnRow)
                    .Controls.OfType<Label>().First(x => x.Name == whichLabel)
                    .Text = inputText;
            } catch { }
        }

        private void AddControlToPanel(Control control, int column, int row)
        {
            // Инициализация имени панели тикета
            control.Name = $"ticket{column}{row}";
            control.Click += (s, a) => MessageBox.Show(control.Name);

            // Нужно ли добавлять доп. строки и/или колонки
            if (TableLayoutPanel.RowStyles.Count <= row) TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            if (TableLayoutPanel.ColumnStyles.Count <= column) TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            TableLayoutPanel.Controls.Add(control, column, row);
        }

        // Добавление пустых лейблов в добавленные специально колонки и строки с абсолютным размером в 0 для корректной работы автосайза.
        private void ForAutoSizeInPanel()
        {
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 0F));
            TableLayoutPanel.Controls.Add(new Label(), TableLayoutPanel.ColumnStyles.Count - 1, 1);

            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            TableLayoutPanel.Controls.Add(new Label(), 0, TableLayoutPanel.RowStyles.Count - 1);
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
    }
}
