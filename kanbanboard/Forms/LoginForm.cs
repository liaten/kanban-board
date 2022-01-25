using kanbanboard.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace kanbanboard.Forms
{
    public partial class LoginForm : Form
    {
        private static Dictionary<string, User> _users;

        public LoginForm()
        {
            InitializeComponent();

            // Вход по Enter,
            // ESCAPE на регистрации (возврат к панели логина),
            // Регистрация по Enter
            KeyDown += (_, a) =>
            {
                if (MainPanel.IsControlAtFront() && a.KeyValue == (int)Keys.Enter) LoginButton.PerformClick();
                else if (RegPanel.IsControlAtFront() && a.KeyValue == (int)Keys.Escape) MainPanel.BringToFront();
                else if (RegPanel.IsControlAtFront() && a.KeyValue == (int)Keys.Enter) RegOfRegBackButton.PerformClick();
            };

            ToolTip toolTipForProjectNames = new() { AutomaticDelay = 100 };
            toolTipForProjectNames.SetToolTip(RegProjectsTextBox, "Формат ввода строго через пробел: Проект1 Проект2 Проект3...");
            toolTipForProjectNames.SetToolTip(RegProjectsLabel, "Формат ввода строго через пробел: Проект1 Проект2 Проект3...");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Получаем всех пользователей
            _users = Firebase.GetAllUsers();

            // Меняем размер на изначальный
            Size = new Size(350, 245);

            // Двигаем главную панельку на передний план
            MainPanel.BringToFront();
        }

        // Логин в приложение
        private void LoginButton_Click(object sender, EventArgs e)
        {
            var username = textBoxLogin.Text;

            if (_users.ContainsKey(username) && _users[username].Password == MD5.Encrypt(textBoxPassword.Text))
            {
                MainForm mainForm = new(_users[username]);
                Hide();
                mainForm.Show();
                return;
            }
            MessageBox.Show(@"Неверный логин или пароль");
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void CheckPass_CheckedChanged(object sender, EventArgs e)
        {
            checkPass.ForeColor = Color.FromArgb(200, checkPass.Checked ? 255 : 200, 200);
            textBoxPassword.PasswordChar = checkPass.Checked ? '\0' : '*';
        }

        private void TextBoxLogin_MouseEnter(object sender, EventArgs e) => LoginLabel.ForeColor = Color.FromArgb(114, 119, 139);
        private void TextBoxLogin_MouseLeave(object sender, EventArgs e) => LoginLabel.ForeColor = Color.FromArgb(74, 79, 99);
        private void TextBoxPass_MouseEnter(object sender, EventArgs e) => PassLabel.ForeColor = Color.FromArgb(114, 119, 139);
        private void TextBoxPass_MouseLeave(object sender, EventArgs e) => PassLabel.ForeColor = Color.FromArgb(74, 79, 99);
        private void RegLoginTextBox_TextChanged(object sender, EventArgs e)
        {
            string loginTextBox = RegLoginTextBox.Text;
            RegLoginCheck.ForeColor = _users.ContainsKey(loginTextBox) || loginTextBox.Trim().Equals("")
                ? Color.Red
                : Color.Green;
        }
        private void RegLoginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
