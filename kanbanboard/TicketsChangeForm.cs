using System;
using System.Drawing;
using System.Windows.Forms;

namespace kanbanboard
{
    public partial class TicketsChangeForm : Form
    {
        public new MainForm Owner { get; }
        private readonly TicketPanel _ticket;

        public TicketsChangeForm(MainForm owner, TicketPanel ticket)
        {
            Owner = owner;
            _ticket = ticket;
            InitializeComponent();

            Resize += (o, eventArgs) => ChangingPanel.ToCenter(this);

            KeyDown += (s, a) => {
                if (a.KeyValue == (int)Keys.Enter || a.KeyValue == (int)Keys.Escape) SaveChangesButton.PerformClick();
            };
        }

        // Изменяем при нажатии на кнопку сохранения
        private void SaveChangesButton_Click(object sender, EventArgs e) => Close();

        // Показываем значения лейблов тикета
        private void TicketsChangeForm_Load(object sender, EventArgs e)
        {
            ChangingTitleTextBox.Text = _ticket.Title.Text;
            ChangingTicketTextBox.Text = _ticket.Ticket.Text;
            ChangingPeopleTextBox.Text = _ticket.People.Text;
        }

        // Сохранить при закрытии
        private void TicketsChangeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _ticket.Title.Text = ChangingTitleTextBox.Text;
            _ticket.Ticket.Text = ChangingTicketTextBox.Text;
            _ticket.People.Text = ChangingPeopleTextBox.Text;
        }

        private void ChangingTitleTextBox_MouseEnter(object sender, EventArgs e)
        {
            ChangingTitleLabel.ForeColor = Color.FromArgb(114, 119, 139);
        }

        private void ChangingTitleTextBox_MouseLeave(object sender, EventArgs e)
        {
            ChangingTitleLabel.ForeColor = Color.FromArgb(74, 79, 99);
        }

        private void ChangingPeopleTextBox_MouseEnter(object sender, EventArgs e)
        {
            ChangingPeopleLabel.ForeColor = Color.FromArgb(114, 119, 139);
        }

        private void ChangingPeopleTextBox_MouseLeave(object sender, EventArgs e)
        {
            ChangingPeopleLabel.ForeColor = Color.FromArgb(74, 79, 99);
        }

        private void ChangingTicketTextBox_MouseEnter(object sender, EventArgs e)
        {
            ChangingTicketLabel.ForeColor = Color.FromArgb(114, 119, 139); 
        }

        private void ChangingTicketTextBox_MouseLeave(object sender, EventArgs e)
        {
            ChangingTicketLabel.ForeColor = Color.FromArgb(74, 79, 99);
        }
    }
}
