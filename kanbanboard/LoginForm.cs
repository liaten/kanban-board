using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kanbanboard
{
    public partial class LoginForm : Form
    {
        public static string Username { get; set; }

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
            MinimumSize = new Size(350, 360 - EmailLabelPanel.Height);
            Size = new Size(350, 360 - EmailLabelPanel.Height);

            var headerPadding = (Width - AuthorizationLabel.Width - AuthorizationPictureBox.Width) / 2;
            HeaderLabelPanel.Padding = new Padding(headerPadding, 15, headerPadding, 15);
            CheckBoxRegistration.ForeColor = Color.FromArgb(200, 200, 200);

            EmailLabelPanel.Hide();
            EmailTextBoxPanel.Hide();
        }

        private static bool ValidEmail(string email) => new Regex(@"^(\w|\d|\.|_|-)+@(\w|\d){1,}\.[\w]{1,}\.?[\w]*$", RegexOptions.IgnoreCase).IsMatch(email);

        private void TextBoxLogin_MouseEnter(object sender, EventArgs e) => LoginLabel.ForeColor = Color.FromArgb(114, 119, 139);
        private void TextBoxLogin_MouseLeave(object sender, EventArgs e) => LoginLabel.ForeColor = Color.FromArgb(74, 79, 99);
        private void TextBoxPass_MouseEnter(object sender, EventArgs e) => PassLabel.ForeColor = Color.FromArgb(114, 119, 139);
        private void TextBoxPass_MouseLeave(object sender, EventArgs e) => PassLabel.ForeColor = Color.FromArgb(74, 79, 99);

        // Логин в приложение
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Username = textBoxLogin.Text;

            if (CheckPassword() is false) {
                MessageBox.Show("Неверный пароль", "Ошибка");
                return;
            }

            LoginButton.Image = Properties.Resources.check;
            Hide();
            var main = new MainForm(Username);
            main.Show();
        }

        // Верификация пароля (возвращает true/false)
        public bool CheckPassword()
        {
            // Переводим в массив битов строку из пароля
            var data = Encoding.UTF8.GetBytes(textBoxPassword.Text);

            // Шифрование (MD5)
            // ComputeHash — хэш (ключ к расшифровке). 
            using (var tripleDes = new TripleDESCryptoServiceProvider() { Key = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes("R0CK5T4R")),
                Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                return new User(Username).CheckPassword(Convert.ToBase64String(tripleDes.CreateEncryptor().TransformFinalBlock(data, 0, data.Length)));
        }

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
                EmailLabelPanel.Show();
                EmailTextBoxPanel.Show();

                for (var i = 0; i <= EmailTextBoxPanel.Size.Height; i++)
                {
                    Size = new Size(350, 360 - EmailTextBoxPanel.Size.Height + i);
                    await Task.Delay(1);
                }
                CheckBoxRegistration.ForeColor = Color.FromArgb(200, 250, 200);
            }
            else
            {
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
    }
}
