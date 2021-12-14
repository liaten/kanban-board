using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using kanbanboard.Classes;
using kanbanboard.Properties;

namespace kanbanboard.Windows
{
    public partial class LoginForm : Form
    {
        public static string Username;

        public LoginForm()
        {
            InitializeComponent();

            KeyDown += (s, a) =>
            {
                if (a.KeyValue == (int)Keys.Enter) LoginButton.PerformClick();
            };
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoginPanel.Width = Size.Width / 2;
            MinimumSize = new Size(350, 375 - EmailLabelPanel.Height);
            Size = new Size(350, 375 - EmailLabelPanel.Height);

            var headerPadding = (Width - AuthorizationLabel.Width - AuthorizationPictureBox.Width) / 2;
            HeaderLabelPanel.Padding = new Padding(headerPadding, 15, headerPadding, 15);
            CheckBoxRegistration.ForeColor = Color.FromArgb(200, 200, 200);
            checkPass.ForeColor = Color.FromArgb(200, 200, 200);

            EmailLabelPanel.Hide();
            EmailTextBoxPanel.Hide();
        }

        private bool ValidEmail(string email) => new Regex(@"^(\w|\d|\.|_|-)+@(\w|\d){1,}\.[\w]{1,}\.?[\w]*$", RegexOptions.IgnoreCase).IsMatch(email);

        private void TextBoxLogin_MouseEnter(object sender, EventArgs e) => LoginLabel.ForeColor = Color.FromArgb(114, 119, 139);
        private void TextBoxLogin_MouseLeave(object sender, EventArgs e) => LoginLabel.ForeColor = Color.FromArgb(74, 79, 99);
        private void TextBoxPass_MouseEnter(object sender, EventArgs e) => PassLabel.ForeColor = Color.FromArgb(114, 119, 139);
        private void TextBoxPass_MouseLeave(object sender, EventArgs e) => PassLabel.ForeColor = Color.FromArgb(74, 79, 99);

        // Логин в приложение
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Username = textBoxLogin.Text;
            if (Username.CheckUser() && !string.IsNullOrEmpty(Username))
            {
                if (CheckPassword())
                {
                    var mainForm = new MainForm(Username);
                    Hide();
                    mainForm.Show();
                }
                else MessageBox.Show("Неверный пароль", "Ошибка");
            }
            else MessageBox.Show("Пользователя не существует");
        }

        // Верификация пароля (возвращает true/false)
        public bool CheckPassword() => Username.CheckPassword(MD5.Encrypt(textBoxPassword.Text));

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            StayLoggedCheckBox.ForeColor = Color.FromArgb(200, StayLoggedCheckBox.Checked ? 255 : 200, 200);
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
                CheckBoxRegistration.ForeColor = Color.FromArgb(200, 250, 200);
                EmailLabelPanel.Show();
                EmailTextBoxPanel.Show();
                for (var i = 0; i <= EmailTextBoxPanel.Size.Height; i++)
                {
                    Size = new Size(350, 375 - EmailTextBoxPanel.Size.Height + i);
                    await Task.Delay(1);
                }
            }
            else
            {
                CheckBoxRegistration.ForeColor = Color.FromArgb(200, 200, 200);
                for (var i = 0; i <= EmailTextBoxPanel.Size.Height; i++)
                {
                    Size = new Size(350, 375 - i);
                    await Task.Delay(1);
                }
                EmailLabelPanel.Hide();
                EmailTextBoxPanel.Hide();
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            Username = textBoxLogin.Text;

            if (Username.CheckUser())
                MessageBox.Show("Пользователь уже существует");
            else
            {
                if (textBoxPassword.Text == "")
                {
                    MessageBox.Show("Укажите пароль"); return;
                }

                if (!string.IsNullOrEmpty(textBoxEmail.Text))
                {
                    if (ValidEmail(textBoxEmail.Text))
                        Username.CreateUser(textBoxPassword.Text, email: textBoxEmail.Text);
                    else MessageBox.Show("Неправильный email. Попробуй ещё раз");
                }
                else Username.CreateUser(textBoxPassword.Text);
            }
        }

        public void CheckPass_CheckedChanged(object sender, EventArgs e)
        {
            checkPass.ForeColor = Color.FromArgb(200, checkPass.Checked ? 255 : 200, 200);
            textBoxPassword.PasswordChar = checkPass.Checked ? '\0' : '*';
        }
    }
}
