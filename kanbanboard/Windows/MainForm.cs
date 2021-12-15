using kanbanboard.Classes;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kanbanboard.Windows
{
    public partial class MainForm : Form
    {
        private static User _user;

        public MainForm(string username)
        {
            InitializeComponent();

            // Вернуться в LoginForm по ESC
            KeyDown += (s, a) =>
            {
                if (a.KeyValue == (int)Keys.Escape) ExitButton.PerformClick();
            };

            // Отправить сообщение по Enter
            MessengerTextBox.KeyPress += (fsa, key) =>
            {
                if (key.KeyChar == (int)Keys.Enter)
                {
                    SendMessage();
                    MessengerTextBox.Clear();
                }
            };

            // Событие при изменении размера таблицы
            TableLayoutPanel.Resize += (s, a) => ResizeTable();

            // Установка двойной буферизации для устранения мерцания
            SetDoubleBuffered(TableLayoutPanel);
            SetDoubleBuffered(BasicContentPanel);
            SetDoubleBuffered(MessengerListBox);

            // Создаём экземпляр через который будем работать с базой
            _user = new User(username);
            UserInfoLabel.Text = "Роль:" + _user.Role;

            // Событие при изменении выбранной строки в listbox
            ListBoxOfProjectNames.Items.Clear();
            ListBoxOfProjectNames.SelectedIndexChanged += (ss, aa) =>
            {
                try
                {
                    Parallel.Invoke(
                        () => Invoke((MethodInvoker)(() => TableFromFirebase(ListBoxOfProjectNames.SelectedItem.ToString()))),
                        () => Invoke((MethodInvoker)(() => ShowMessages()))
                        );
                }
                catch { }
            };

            // Сохранение данных в базу
            // Сохраняется только активная таблица (выбранная в listbox)
            FormClosing += (b, q) =>
            {
                if (ListBoxOfProjectNames.SelectedItem != null) Upload(ListBoxOfProjectNames.SelectedItem.ToString());
            };

            // Подсказка на кнопку с плюсом
            new ToolTip().SetToolTip(AddTitleButton, "Добавить столбец");

            Load += (s, a) =>
            {
                if (LoginForm.Username == "")
                {
                    UsernameLabel.Text = "Гость";
                    UserInfoLabel.Text = "";
                    return;
                }

                SetUserProjectNames();

                // Стартовый вид -> панель с профилем
                UserControlsPanel_Click(null, null);
                UsernameLabel.Text = LoginForm.Username;

                // Загрузка первого элемента из списка
                try { ListBoxOfProjectNames.SelectedIndex = 0; }
                catch { }
            };
        }

        // Проекты пользователя
        private void SetUserProjectNames()
        {
            ListBoxOfProjectNames.Items.AddRange(_user.ProjectNames.Cast<object>().ToArray());
        }

        // Устранение мерцания при изменении размеров таблицы
        public static void SetDoubleBuffered(Control c)
        {
            if (SystemInformation.TerminalServerSession)
                return;
            var aProp = typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);
            aProp?.SetValue(c, true, null);
        }

        // Обработчик задач
        private void TasksButton_Click(object sender, EventArgs e)
        {
            LabelHead.Text = "Задачи";

            // перемещение панельки выделения
            StripPanel.Location = TasksButton.Location;
            // изменение размера панельки выделения
            StripPanel.Size = new Size(StripPanel.Size.Width, TasksButton.Size.Height);

            PanelWithTable.BringToFront();


            ListBoxOfProjectNames.Visible = true;
        }

        // Клик на профиль. Открытие панели с данными текущего профиля
        private void UserControlsPanel_Click(object sender, EventArgs e)
        {
            LabelHead.Text = "Профиль";
            UserPanel.BringToFront();
            // перемещение панельки выделения
            StripPanel.Location = UserControlsPanel.Location;
            // изменение размера панельки выделения
            StripPanel.Size = new Size(StripPanel.Size.Width, UserControlsPanel.Size.Height);
            ListBoxOfProjectNames.Visible = false;
        }

        // Обработчик мессенджера
        private void MessengerButton_Click(object sender, EventArgs e)
        {
            LabelHead.Text = "Мессенджер";
            MessengerPanel.BringToFront();

            // перемещение панельки выделения
            StripPanel.Location = MessengerButton.Location;

            // изменение размера панельки выделения
            StripPanel.Size = new Size(StripPanel.Size.Width, MessengerButton.Size.Height);

            MessengerTextBox.Focus();

            ListBoxOfProjectNames.Visible = true;
        }

        // Обработчик календаря
        private void CalendarButton_Click(object sender, EventArgs e)
        {
            LabelHead.Text = "Календарь";

            CalendarPanel_Resize(null, null);

            CalendarPanel.BringToFront();
            // перемещение панельки выделения
            StripPanel.Location = CalendarButton.Location;
            // изменение размера панельки выделения
            StripPanel.Size = new Size(StripPanel.Size.Width, CalendarButton.Size.Height);
            ListBoxOfProjectNames.Visible = false;
        }
        private void CalendarPanel_Resize(object sender, EventArgs e)
        {
            CalendarLabel.ToCenter(CalendarPanel);
            CalendarLabel.MaximumSize = CalendarPanel.Size;
        }

        // Кнопка по созданию проекта
        private void CreateProjectButton_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<ChangeForm>().Any()) new ChangeForm(this, _user.Username).Show();
        }

        // Выход из мейнформы
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
            var LoginForm = new LoginForm();
            LoginForm.Show();
        }

        // Показать пароль
        private void PasswordShowLinkLabel_Click(object sender, EventArgs e)
        {
            if (!PasswordShowLabel.Visible)
            {
                PasswordShowLabel.Text = MD5.Decrypt(_user.Password);
                PasswordShowLabel.Visible = true;
                PasswordShowLinkLabel.Text = "Скрыть";
            }
            else
            {
                PasswordShowLabel.Visible = false;
                PasswordShowLinkLabel.Text = "Показать";
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
