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
            //
        }
        // Кнопка регистрации после кнопки регистрации
        private void RegPanelButton_Click(object sender, EventArgs e)
        {
            var potentialListOfDataUser = new List<string> {
                RegLoginTextBox.Text,
                RegEmailTextBox.Text,
                RegPasswordTextBox.Text,
                RegRoleComboBox.SelectedItem?.ToString(),
                RegProjectsTextBox.Text
            };

            if (potentialListOfDataUser.Any(x => string.IsNullOrEmpty(x)))
            {
                MessageBox.Show(@"Мало данных.");
                return;
            }

            if (_users.ContainsKey(potentialListOfDataUser[0]))
            {
                MessageBox.Show(@"Пользователь с таким именем уже существует.");
                return;
            }

            if (!potentialListOfDataUser[1].ValidEmail())
            {
                MessageBox.Show(@"Неправильная почта.");
                return;
            }

            var newUser = new User(
                potentialListOfDataUser[0],
                MD5.Encrypt(potentialListOfDataUser[2]),
                potentialListOfDataUser[1],
                potentialListOfDataUser.Last().Split(' ').ToList(),
                potentialListOfDataUser[3].ToEnum<Roles>());

            _users.Add(newUser.Username, newUser);
            Firebase.CreateUser(newUser);

            // Вопрос на выполнение логина после регистрации
            if (MessageBox.Show($@"Пользователь зарегистрирован.{Environment.NewLine}Войти в созданную учётную запись?", "Регистрация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MainPanel.BringToFront();
                textBoxLogin.Text = potentialListOfDataUser[0];
                textBoxPassword.Text = potentialListOfDataUser[2];
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
            // Перекидываем введенные на панель регистрации, если они есть
            RegLoginTextBox.Text = textBoxLogin.Text.ValidEmail() ? "" : textBoxLogin.Text;
            RegEmailTextBox.Text = textBoxLogin.Text.ValidEmail() ? textBoxLogin.Text : "";
            RegPasswordTextBox.Text = textBoxPassword.Text;
            
            RegPanel.BringToFront();

            textBoxLogin.Clear();
            textBoxPassword.Clear();
        }
    }
}
