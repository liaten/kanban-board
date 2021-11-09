using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace kanbanboard1
{
    sealed class TicketPanel : Panel
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr Round(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        
        public TicketPanel() 
        {
            // Свойства панели
            Dock = DockStyle.Fill;
            Margin = new Padding(3);
            BackColor = Color.FromArgb(0, 126, 249);
            AutoSize = true;
            DoubleBuffered = true;

            // Заголовок, текст, исполнители (может быть изменено). Из чего то мб сделать другой контрол
            Controls.AddRange(new Control[] {
                // Заголовок
                new Label()
                {
                    Name = "Head", Text = "Заголовок",
                    Location = new Point(0, 5),
                    Margin = new Padding(20),
                    MaximumSize = Size,
                    AutoSize = true,
                }, 

                // Основной текст
                new Label()
                {
                    Name = "Ticket", Text = "Текст тикета",
                    Margin = new Padding(5),
                    Location = new Point(0, 50),
                    MaximumSize = Size,
                    AutoSize = true,
                }, 

                // Исполнители
                new Label()
                {
                    Name = "People", Text = "Разработчики",
                    Margin = new Padding(5),
                    Location = new Point(0, 150),
                    MaximumSize = Size,
                    AutoSize = true,
                }
            });
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Сглаживание углов
            const int ellipse = 15;
            Region = Region.FromHrgn(Round(0, 0, Width, Height, ellipse, ellipse));
        }
    }
}
