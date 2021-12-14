using kanbanboard.Classes;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace kanbanboard.Windows
{
    public partial class LoginForm : Form
    {
        public static string Username;

        public LoginForm()
        {
            InitializeComponent();

            // Вход по Enter
            KeyDown += (s, a) =>
            {
                if (RegPanel.IsControlAtFront() && a.KeyValue == (int)Keys.Enter) RegPanelButton.PerformClick();
                if (a.KeyValue == (int)Keys.Enter) LoginButton.PerformClick();
            };

            var toolTipForProjectNames = new ToolTip { AutomaticDelay = 100 };
            toolTipForProjectNames.SetToolTip(RegProjectsTextBox, "Формат ввода через пробел: Проект1 Проект2 Проект3.");
            toolTipForProjectNames.SetToolTip(RegProjectsLabel, "Формат ввода через пробел: Проект1 Проект2 Проект3.");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoginPanel.Width = Size.Width / 2;

            var headerPadding = (Width - AuthorizationLabel.Width - AuthorizationPictureBox.Width) / 2;
            HeaderLabelPanel.Padding = new Padding(headerPadding, 15, headerPadding, 15);
            checkPass.ForeColor = Color.FromArgb(200, 200, 200);
        }

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
        private void Login_Resize(object sender, EventArgs e)
        {
            LoginPanel.Width = Size.Width / 2;
            var HeaderPadding = (Width - AuthorizationLabel.Width - AuthorizationPictureBox.Width) / 2;
            HeaderLabelPanel.Padding = new Padding(HeaderPadding, 15, HeaderPadding, 15);
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            Username = textBoxLogin.Text;

            RegLoginTextBox.Text = textBoxLogin.Text.ValidEmail() ? "" : textBoxLogin.Text;
            RegEmailTextBox.Text = textBoxLogin.Text.ValidEmail() ? textBoxLogin.Text : "";
            RegPasswordTextBox.Text = textBoxPassword.Text;

            RegPanel.BringToFront();
        }

        public void CheckPass_CheckedChanged(object sender, EventArgs e)
        {
            checkPass.ForeColor = Color.FromArgb(200, checkPass.Checked ? 255 : 200, 200);
            textBoxPassword.PasswordChar = checkPass.Checked ? '\0' : '*';
        }

        // Кнопка регистрации после кнопки регистрации
        private void RegPanelButton_Click(object sender, EventArgs e)
        {
            Username = RegLoginTextBox.Text;

            if (Username.CheckUser())
                MessageBox.Show("Пользователь уже существует");
            else
            {
                if (RegPasswordTextBox.Text == "")
                {
                    MessageBox.Show("Укажите пароль"); return;
                }

                if (!string.IsNullOrEmpty(RegEmailTextBox.Text))
                {
                    if (!RegEmailTextBox.Text.ValidEmail())
                    {
                        MessageBox.Show("Неправильный email. Попробуй ещё раз");
                        return;
                    }

                    if (!string.IsNullOrEmpty(RegEmailTextBox.Text))
                        Username.CreateUser(RegPasswordTextBox.Text, email: RegEmailTextBox.Text);
                    else Username.CreateUser(textBoxPassword.Text);

                    Username.CreateProjects(RegProjectsTextBox.Text.Split().ToList());

                    MessageBox.Show("Успешно зарегистрирован");
                    MainPanel.BringToFront();

                    textBoxLogin.Text = RegLoginTextBox.Text;
                    textBoxPassword.Text = RegPasswordTextBox.Text;
                    LoginButton.PerformClick();

                    RegPanel.Controls.OfType<TextBox>().ToList().ForEach(x => x.Clear());
                }
            }
        }
    }
}
