using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace kanbanboard
{
    internal sealed class TicketPanel : Panel
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr Round(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public Label Title { get; set; }
        public Label Ticket { get; set; }
        public Label People { get; set; }
        public Button DelButton { get; set; }
        public Button LeftButton { get; set; }
        public Button RightButton { get; set; }


        public TicketPanel()
        {
            // Свойства панели
            Dock = DockStyle.Fill;
            BackColor = GetColor();
            AutoSize = true;
            DoubleBuffered = true;

            // Заголовок, текст, исполнители (может быть изменено). Из чего-то мб сделать другой контрол
            Title = new Label()
            {
                Name = "Title",
                Text = "Заголовок",
                Font = new Font("Tahoma", 9.25f, FontStyle.Bold),
                Location = new Point(Size.Width - Size.Width + 5, Size.Height - Size.Height + 5),
                Margin = new Padding(20, 20, 40, 20),
            };
            Ticket = new Label()
            {
                Name = "Ticket",
                Text = "Текст тикета",
                Margin = new Padding(5),
                Location = new Point(Size.Width - Size.Width + 5, Size.Height / 2),
            };
            People = new Label()
            {
                Name = "People",
                Text = "Разработчики",
                Margin = new Padding(5),
                Location = new Point(Size.Width - Size.Width + 5, Size.Height - 5),
            };
            new List<Label> { Title, Ticket, People }.ForEach(x =>
            {
                x.ForeColor = Color.WhiteSmoke;
                x.AutoSize = true;
            });

            // Добавляем панель с кнопками перемещий и удаления тикета

            // кнопка удаления тикета, перемещения ВПРАВО, перемещения ВЛЕВО
            DelButton = new Button()
            {
                Size = new Size(30, 30),
                Name = "delButton",
                Text = "✖",
                Font = new Font("Tahoma", 8.5f),
            };
            LeftButton = new Button()
            {
                Name = "leftButton",
                Text = "«",
                Font = DelButton.Font,
            };
            RightButton = new Button()
            {
                Name = "rightButton",
                Text = "»",
                Font = DelButton.Font
            };
            new List<Button>() { DelButton, LeftButton, RightButton }.ForEach(x =>
             {
                 x.BackColor = Color.Transparent;
                 x.FlatAppearance.MouseDownBackColor = Color.Transparent;
                 x.FlatAppearance.MouseOverBackColor = Color.Transparent;
                 x.AutoSize = true;
                 x.Size = new Size(35, 35);
                 x.FlatStyle = FlatStyle.Flat;
                 x.FlatAppearance.BorderSize = 0;
                 x.ForeColor = Color.WhiteSmoke;
                 x.MouseEnter += (s, a) => x.ForeColor = Color.Red;
                 x.MouseLeave += (s, a) => x.ForeColor = Color.WhiteSmoke;
             });

            Controls.AddRange(new Control[] { DelButton, LeftButton, RightButton });
            Controls.AddRange(new Control[] { Title, Ticket, People });
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Сглаживание углов
            const int ellipse = 15;
            Region = Region.FromHrgn(Round(0, 0, Width, Height, ellipse, ellipse));

            BeginInvoke((MethodInvoker)(() =>
            {
                // Изменение локаций лейблов в панели
                Title.Location = new Point(Size.Width - Size.Width + 5, Size.Height - Size.Height + 15);
                Ticket.Location = new Point(Size.Width - Size.Width + 5, Title.Location.Y + 50);
                People.Location = new Point(Size.Width - Size.Width + 5, Size.Height - 50);

                // кнопок
                DelButton.Location = new Point(Size.Width - DelButton.Size.Width, 0);
                LeftButton.Location = new Point(0, Size.Height - LeftButton.Size.Height);
                RightButton.Location = new Point(Size.Width - RightButton.Size.Width, Size.Height - RightButton.Size.Height);

                new List<Control> { Title, Ticket, People }.ForEach(x => x.MaximumSize = new Size(Size.Width - 5, Size.Height));
            }));
        }

        public static Color GetColor() => Color.FromArgb(13, 77, 109);
    }
}
