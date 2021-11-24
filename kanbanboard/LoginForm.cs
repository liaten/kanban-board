using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kanbanboard
{
    public partial class LoginForm : Form
    {
        // FirestoreDb database;

        public LoginForm()
        {
            InitializeComponent();

            KeyDown += (s, a) =>
            {
                if (a.KeyValue == (int)Keys.Enter) LoginButton.PerformClick();
            };
        }

        public static string Username;

        private void Login_Load(object sender, EventArgs e)
        {
            //string path = AppDomain.CurrentDomain.BaseDirectory + @"kanban-board.json";
            // Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            // database = FirestoreDb.Create("kanban-board-fvdi");
            LoginPanel.Width = Size.Width / 2;
            MinimumSize = new Size(350, 360 - EmailLabelPanel.Height);
            Size = new Size(350, 360 - EmailLabelPanel.Height);
            int headerPadding = (Width - AuthorizationLabel.Width - AuthorizationPictureBox.Width) / 2;
            HeaderLabelPanel.Padding = new Padding(headerPadding, 15, headerPadding, 15);
            CheckBoxRegistration.ForeColor = Color.FromArgb(200, 200, 200);
        }

        private bool ValidEmail(string email) => new Regex(@"^(\w|\d|\.|_|-)+@(\w|\d){1,10}\.([a-z]|.){2,10}$", RegexOptions.IgnoreCase).IsMatch(email);

        private void TextBox1_MouseEnter(object sender, EventArgs e)
        {
            loginLabel.ForeColor = Color.FromArgb(114, 119, 139);
        }

        private void TextBox1_MouseLeave(object sender, EventArgs e)
        {
            loginLabel.ForeColor = Color.FromArgb(74, 79, 99);
        }

        private void TextBox2_MouseEnter(object sender, EventArgs e)
        {
            passLabel.ForeColor = Color.FromArgb(114, 119, 139);
        }

        private void TextBox2_MouseLeave(object sender, EventArgs e)
        {
            passLabel.ForeColor = Color.FromArgb(74, 79, 99);
        }

        private void Button1_Click(object sender, EventArgs e) // логин в приложение
        {
            Username = textBoxLogin.Text;
            LoginButton.Image = Properties.Resources.check;
            Hide();
            var main = new MainForm();
            main.Show();
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (StayLoggedCheckBox.Checked)
            {
                StayLoggedCheckBox.ForeColor = Color.FromArgb(200, 255, 200);
            }
            else
            {
                StayLoggedCheckBox.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void TextBoxEmail_MouseEnter(object sender, EventArgs e)
        {
            EmailLabel.ForeColor = Color.FromArgb(114, 119, 139);
        }

        private void TextBoxEmail_MouseLeave(object sender, EventArgs e)
        {
            EmailLabel.ForeColor = Color.FromArgb(74, 79, 99);
        }

        private void TextBoxEmail_Click(object sender, EventArgs e)
        {
            textBoxEmail.Text = "";
        }
        private void Login_Resize(object sender, EventArgs e)
        {
            LoginPanel.Width = Size.Width / 2;
            int HeaderPadding = (Width - AuthorizationLabel.Width - AuthorizationPictureBox.Width) / 2;
            HeaderLabelPanel.Padding = new Padding(HeaderPadding, 15, HeaderPadding, 15);
        }

        private async void CheckBoxRegistration_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxRegistration.Checked)
            {
                EmailLabelPanel.Show();
                EmailTextBoxPanel.Show();

                for (var i = 0; i <= EmailTextBoxPanel.Size.Height; i++)
                {
                    Size = new Size(350, 360 - EmailTextBoxPanel.Size.Height + i);
                    await Task.Delay(1);
                }
                CheckBoxRegistration.ForeColor = Color.FromArgb(200, 250, 200);
            }
            else {
                for (var i = 0; i <= EmailTextBoxPanel.Size.Height; i++)
                {
                    Size = new Size(350, 360 - i);
                    await Task.Delay(1);
                }

                EmailLabelPanel.Hide();
                EmailTextBoxPanel.Hide();

                CheckBoxRegistration.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            ValidEmail(textBoxEmail.Text);
        }
    }
}
