using kanbanboard.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace kanbanboard.Windows
{
    public partial class LoginForm
    {
        // Кнопка назад внутри окна регистрации
        private void RegPanelBackButton(object sender, EventArgs e)
        {
            MainPanel.BringToFront();
        }
        // Кнопка регистрации после кнопки регистрации
        private void RegPanelButton_Click(object sender, EventArgs e)
        {
            var login = RegLoginTextBox.Text;
            var email = RegEmailTextBox.Text;
            var password = RegPasswordTextBox.Text;
            var role = RegRoleComboBox.SelectedItem?.ToString();
            var projects = RegProjectsTextBox.Text;

            if (new List<string>() { login, email, password, role, projects }.Any(x => string.IsNullOrEmpty(x)))
            {
                MessageBox.Show(@"Мало данных.");
                return;
            }

            if (_users.ContainsKey(login))
            {
                MessageBox.Show(@"Пользователь с таким именем уже существует.");
                return;
            }

            if (!email.ValidEmail())
            {
                MessageBox.Show(@"Неправильная почта.");
                return;
            }

            var newUser = new User(
                login,
                MD5.Encrypt(password),
                email,
                projects.Split(' ').ToList(),
                role.ToEnum<Roles>());

            _users.Add(newUser.Username, newUser);
            Firebase.CreateUser(newUser);

            // Вопрос на выполнение логина после регистрации
            if (MessageBox.Show($@"Пользователь зарегистрирован.{Environment.NewLine}Войти в созданную учётную запись?", "Регистрация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MainPanel.BringToFront();
                textBoxLogin.Text = login;
                textBoxPassword.Text = password;
                LoginButton.PerformClick();
            }
            else MainPanel.BringToFront();

            // Очистка введенного текста
            new List<TextBox>
            {
                RegLoginTextBox,
                RegEmailTextBox,
                RegPasswordTextBox,
                RegProjectsTextBox
            }.ForEach(x => x.Text = "");
            RegRoleComboBox.SelectedIndex = -1;
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            // Перекидываем введенные данные на панель регистрации, если они есть
            RegLoginTextBox.Text = textBoxLogin.Text.ValidEmail() ? "" : textBoxLogin.Text;
            RegEmailTextBox.Text = textBoxLogin.Text.ValidEmail() ? textBoxLogin.Text : "";
            RegPasswordTextBox.Text = textBoxPassword.Text;
            // Переносим панельку с регистрацией на передний план
            RegPanel.BringToFront();
            // Чистим текстбоксы
            textBoxLogin.Clear();
            textBoxPassword.Clear();
        }
    }
}
