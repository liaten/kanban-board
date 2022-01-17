using System;
using System.Linq;
using System.Windows.Forms;
using kanbanboard.Classes;
using kanbanboard.Controls;

namespace kanbanboard.Forms
{
    public partial class ChangeForm : Form
    {
        public new MainForm Owner { get; }
        private readonly TitlePanel _titlePanel;

        public ChangeForm(MainForm owner, TitlePanel titlePanel)
        {
            Owner = owner;
            _titlePanel = titlePanel;
            InitializeComponent();

            Text = "Изменение заголовка";

            KeyDown += (s, a) =>
            {
                if (a.KeyValue == (int)Keys.Enter || a.KeyValue == (int)Keys.Escape) Close();
            };

            // Начальный текст
            Load += (sender, args) =>
            {
                ChangingTextBox.Text = _titlePanel.TitleColumnLabel.Text;
                ChangingTextBox.Focus();
            };

            // Сохранение
            FormClosing += (sender, args) =>
            {
                _titlePanel.TitleColumnLabel.Text = ChangingTextBox.Text;
            };
        }

        public ChangeForm(MainForm owner, User user)
        {
            Owner = owner;
            InitializeComponent();

            Text = "Создать новый проект";

            KeyDown += (s, a) =>
            {
                if (a.KeyValue == (int)Keys.Enter || a.KeyValue == (int)Keys.Escape) Close();
            };

            // Сохранение
            FormClosing += async (sender, args) =>
            {
                if (!string.IsNullOrEmpty(ChangingTextBox.Text))
                {
                    if (await user.CreateProject(ChangingTextBox.Text) == "OK")
                        Owner.Controls.OfType<ListBox>().Where(x => string.Equals(x.Name, "ListBoxOfProjectNames")).ToList().ForEach(
                            x =>
                            {
                                x.Items.Clear();
                                x.Items.AddRange(user.ProjectNames().Cast<object>().ToArray());
                            });
                }
            };
        }
    }
}
