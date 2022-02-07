using kanbanboard.Classes;
using System;
using System.Drawing;
using System.Linq;

namespace kanbanboard.Forms
{
    partial class MainForm
    {
        // Мессенджер отправка сообщений
        private async void SendMessageButton_Click(object sender, EventArgs e)
        {
            // Проверка валидности текста
            if (string.IsNullOrEmpty(MessengerTextBox.Text) || string.IsNullOrWhiteSpace(MessengerTextBox.Text)) return;

            var msg = MessengerTextBox.Text.Trim();
            MessengerListBox.Items.Add($"{_user.Username}: {msg}");
            MessengerTextBox.Clear();

            // В конец сообщений
            MessengerListBox.TopIndex = MessengerListBox.Items.Count - 1;

            await _user.SaveMessage(ListBoxOfProjectNames.SelectedItem.ToString(), msg).ConfigureAwait(false);
        }

        // Показ сообщений
        private void ShowMessages()
        {
            MessengerListBox.Items.Clear();
            var messages = _user.GetMessages(ListBoxOfProjectNames.SelectedItem.ToString());

            if (messages == null) return;
            foreach (var item in messages.SelectMany(dic => dic))
                MessengerListBox.Items.Add($"{item.Key}: {item.Value}");

            try { MessengerListBox.TopIndex = MessengerListBox.Items.Count - 1; }
            catch { }
        }

        private void SendMessageButton_MouseEnter(object sender, EventArgs e)
        {
            SendMessageButton.ForeColor = Color.FromArgb(46, 51, 73);
        }
    }
}
