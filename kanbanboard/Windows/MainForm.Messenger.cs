using kanbanboard.Classes;

namespace kanbanboard.Windows
{
    partial class MainForm
    {
        // Мессенджер
        // Отправка сообщений
        private void SendMessage()
        {
            // Проверка валидности текста
            if (string.IsNullOrEmpty(MessengerTextBox.Text) || string.IsNullOrWhiteSpace(MessengerTextBox.Text)) return;
            MessengerListBox.Items.Add($"{_user.Username}: {MessengerTextBox.Text.Trim()}");

            _user.SaveMessage(ListBoxOfProjectNames.SelectedItem.ToString(), MessengerTextBox.Text);

            // В конец сообщений
            MessengerListBox.TopIndex = MessengerListBox.Items.Count - 1;
        }

        // Показ сообщений
        private void ShowMessages()
        {
            MessengerListBox.Items.Clear();
            var messages = _user.GetMessages(ListBoxOfProjectNames.SelectedItem.ToString());
            if (messages != null)
            {
                foreach (var dic in messages)
                {
                    foreach (var item in dic)
                    {
                        MessengerListBox.Items.Add($"{item.Key}: {item.Value}");
                    }
                }

                try { MessengerListBox.TopIndex = MessengerListBox.Items.Count - 1; }
                catch { }
            }
        }
    }
}
