using kanbanboard.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace kanbanboard.Forms
{
    public partial class LoginForm
    {
        // Кнопка назад внутри окна регистрации
        private void RegOfRegButton_Click(object sender, EventArgs e)
        {
            // Главную панельку на передний план
            MainPanel.BringToFront();
            // Меняем размер панельки
            this.Size = new Size(350, 245);
            // Меняем текст окна
            Text = "Авторизация";
        }

        // Кнопка регистрации после кнопки регистрации
        private void RegPanelButton_Click(object sender, EventArgs e)
        {
            var login = RegLoginTextBox.Text;
            var email = RegEmailTextBox.Text;
            var password = RegPasswordTextBox.Text;
            var role = RegRoleComboBox.SelectedItem?.ToString();
            var projects = RegProjectsTextBox.Text;
            var org = RegOrgTextBox.Text;
            var fullname = RegFullNameTextBox.Text;

            var currentTimeZoneHours = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).Hours;
            var utc = currentTimeZoneHours switch
            {
                > 0 => $"+{currentTimeZoneHours}",
                < 0 => $"-{currentTimeZoneHours}",
                0 => $"{currentTimeZoneHours}"
            };

            if (new List<string> { login, email, password, role, projects, utc, org, fullname }.Any(x => string.IsNullOrEmpty(x)))
            {
                MessageBox.Show(@"Не все поля заполнены.");
                return;
            }

            if (_users.ContainsKey(login))
            {
                MessageBox.Show(@"Пользователь с таким логином уже существует.");
                return;
            }

            if (!email.ValidEmail())
            {
                MessageBox.Show(@"Неправильно введена почта.\nВведите почту в формате any@anymail.com");
                return;
            }

            var newUser = new User
                (
                    login,
                    MD5.Encrypt(password),
                    email,
                    projects.Split(' ').ToList(),
                    role.ToEnum<Roles>(),
                    org,
                    fullname,
                    utc
                );

            _users.Add(newUser.Username, newUser);
            newUser.CreateUser();

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
            // Устанавливаем название окна - "Регистрация"
            Text = "Регистрация";
            this.Size = new Size(350, 465);
        }
    }
}
