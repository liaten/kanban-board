using System.Linq;
using kanbanboard.Classes;

namespace kanbanboard.Forms
{
    partial class MainForm
    {
        // Мессенджер
        // Отправка сообщений
        private async void SendMessage()
        {
            // Проверка валидности текста
            if (string.IsNullOrEmpty(MessengerTextBox.Text) || string.IsNullOrWhiteSpace(MessengerTextBox.Text)) return;
            MessengerListBox.Items.Add($"{_user.Username}: {MessengerTextBox.Text.Trim()}");

            await _user.SaveMessage(ListBoxOfProjectNames.SelectedItem.ToString(), MessengerTextBox.Text);

            // В конец сообщений
            MessengerListBox.TopIndex = MessengerListBox.Items.Count - 1;
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
    }
}
