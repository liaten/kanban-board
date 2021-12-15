using kanbanboard.Classes;
using kanbanboard.Controls;
using System.Windows.Forms;

namespace kanbanboard.Windows
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
                // Загрузка шрифта для всех элементов
                this.InitRoboto();
            };

            // Сохранение
            FormClosing += (sender, args) =>
            {
                _titlePanel.TitleColumnLabel.Text = ChangingTextBox.Text;
            };
        }

        public ChangeForm(MainForm owner, string username)
        {
            Owner = owner;
            InitializeComponent();

            Text = "Создать новый проект";

            KeyDown += (s, a) =>
            {
                if (a.KeyValue == (int)Keys.Enter || a.KeyValue == (int)Keys.Escape) Close();
            };

            // Сохранение
            FormClosing += (sender, args) =>
            {
                if (!string.IsNullOrEmpty(ChangingTextBox.Text)) username.CreateProject(ChangingTextBox.Text);
            };
        }
    }
}
