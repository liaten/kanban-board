using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace kanbanboard
{
    sealed class TicketPanel : Panel
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr Round(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private readonly Label _head;
        private readonly Label _ticket;
        private readonly Label _people;

        public TicketPanel()
        {
            // Свойства панели
            Dock = DockStyle.Fill;
            Margin = new Padding(3);
            BackColor = Color.FromArgb(109, 145, 180);
            AutoSize = true;
            DoubleBuffered = true;

            // Заголовок, текст, исполнители (может быть изменено). Из чего то мб сделать другой контрол

            _head = new Label()
            {
                Name = "Head",
                Text = "Заголовок",
                Location = new Point(Size.Width - Size.Width + 5, Size.Height - Size.Height + 5),
                Margin = new Padding(20),
                MaximumSize = Size,
                AutoSize = true,
            };
            _ticket = new Label()
            {
                Name = "Ticket",
                Text = "Текст тикета",
                Margin = new Padding(5),
                Location = new Point(Size.Width - Size.Width + 5, Size.Height / 2),
                MaximumSize = Size,
                AutoSize = true,
            };
            _people = new Label()
            {
                Name = "People",
                Text = "Разработчики",
                Margin = new Padding(5),
                Location = new Point(Size.Width - Size.Width + 5, Size.Height - 5),
                MaximumSize = Size,
                AutoSize = true,
            };

            Controls.Clear();
            Controls.AddRange(new Control[] { _head, _ticket, _people });
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Сглаживание углов
            const int ellipse = 15;
            Region = Region.FromHrgn(Round(0, 0, Width, Height, ellipse, ellipse));
            _head.Location = new Point(Size.Width - Size.Width + 5, Size.Height - Size.Height + 15);
            _ticket.Location = new Point(Size.Width - Size.Width + 5, Size.Height / 2);
            _people.Location = new Point(Size.Width - Size.Width + 5, Size.Height - 30);
        }
    }
}
