using kanbanboard.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace kanbanboard.Windows
{
    public partial class LoginForm : Form
    {
        private static Dictionary<string, User> _users;

        public LoginForm()
        {
            InitializeComponent();

            // Вход по Enter
            KeyDown += (s, a) =>
            {
                if (MainPanel.IsControlAtFront() && a.KeyValue == (int)Keys.Enter) LoginButton.PerformClick();
                else if (RegPanel.IsControlAtFront() && a.KeyValue == (int)Keys.Escape) MainPanel.BringToFront();
                else if (RegPanel.IsControlAtFront() && a.KeyValue == (int)Keys.Enter) RegPanelButton.PerformClick();
            };

            var toolTipForProjectNames = new ToolTip { AutomaticDelay = 100 };
            toolTipForProjectNames.SetToolTip(RegProjectsTextBox, "Формат ввода строго через пробел: Проект1 Проект2 Проект3...");
            toolTipForProjectNames.SetToolTip(RegProjectsLabel, "Формат ввода строго через пробел: Проект1 Проект2 Проект3...");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Получаем всех пользователей
            _users = Firebase.GetAllUsers();
        }

        // Логин в приложение
        private void LoginButton_Click(object sender, EventArgs e)
        {
            var username = textBoxLogin.Text;
            if (_users.ContainsKey(username))
            {
                if (_users[username].Password == MD5.Encrypt(textBoxPassword.Text))
                {
                    var mainForm = new MainForm(username);
                    Hide();
                    mainForm.Show();

                    return;
                }
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
        private void CheckBox1_CheckedChanged(object sender, EventArgs e) => StayLoggedCheckBox.ForeColor = Color.FromArgb(200, StayLoggedCheckBox.Checked ? 255 : 200, 200);
    }
}
