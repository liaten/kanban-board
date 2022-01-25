using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using kanbanboard.Classes;

namespace kanbanboard.Forms
{
    public partial class MainForm : Form
    {
        private static User _user;
        private static int _projectIndex;

        public MainForm(User user)
        {
            InitializeComponent();

            // Вернуться в LoginForm по ESC
            KeyDown += (_, a) =>
            {
                if (a.KeyValue == (int)Keys.Escape) ExitButton.PerformClick();
            };

            // Отправить сообщение по Enter
            MessengerTextBox.KeyPress += (_, key) =>
            {
                if (key.KeyChar == (int)Keys.Enter)
                    SendMessageButton.PerformClick();
            };

            // Событие при изменении размера таблицы
            TableLayoutPanel.Resize += (_, _) => ResizeTable();

            // Установка двойной буферизации для устранения мерцания
            SetDoubleBuffered(TableLayoutPanel);
            SetDoubleBuffered(BasicContentPanel);
            SetDoubleBuffered(MessengerListBox);
            SetDoubleBuffered(ListBoxOfProjectNames);

            // Данные пользователя
            _user = user;

            UserInfoLabel.Text = $"Роль: {_user.Role}";
            UsernameLabel.Text = _user.Username;
            OrganizationLabel.Text = _user.Organization;
            NickNameLabel.Text = _user.Username;
            FullNameLabel.Text = _user.FullName;
            int utc = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).Hours;
            TimeZoneLabel.Text = utc >= 0 ? $"UTC+{utc}" : $"UTC-{utc}";

            // Событие при изменении выбранной строки в listbox
            ListBoxOfProjectNames.Items.Clear();
            ListBoxOfProjectNames.SelectedIndexChanged += (_, _) =>
            {
                // Сохраняем предыдущий проект, с которым работали
                if (ListBoxOfProjectNames.SelectedItem != null)
                {
                    try { Upload(ListBoxOfProjectNames.Items[_projectIndex].ToString()); }
                    catch {}
                }

                // Переназначаем индекс
                _projectIndex = ListBoxOfProjectNames.SelectedIndex;

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
            FormClosing += (_, _) =>
            {
                if (ListBoxOfProjectNames.SelectedItem != null)
                {
                    try { Upload(ListBoxOfProjectNames.SelectedItem.ToString()); }
                    finally { Application.Exit(); }
                }
            };

            // Подсказка на кнопку с плюсом
            new ToolTip().SetToolTip(AddTitleButton, "Добавить столбец");

            Load += (_, _) =>
            {
                if (string.IsNullOrEmpty(user.ToString()))
                {
                    UsernameLabel.Text = "Гость";
                    UserInfoLabel.Text = "";
                    return;
                }

                // Загоняем в listbox названия проектов текущего пользователя
                SetUserProjectNames();

                // Стартовый вид -> панель с профилем
                UserControlsPanel_Click(null, null);

                // Начальное состояние после входа
                try { ListBoxOfProjectNames.SelectedIndex = 0; }
                catch {}
                finally { UserPanel.BringToFront();}
            };
        }

        // Проекты пользователя
        private void SetUserProjectNames()
        {
            ListBoxOfProjectNames.Items.Clear();
            ListBoxOfProjectNames.Items.AddRange(_user.ProjectNames().Cast<object>().ToArray());
        }


        // Устранение мерцания
        public static void SetDoubleBuffered(Control c)
        {
            if (SystemInformation.TerminalServerSession)
            {
                return;
            }
            PropertyInfo aProp = typeof(Control).GetProperty("DoubleBuffered",
                BindingFlags.NonPublic |
                BindingFlags.Instance);
            aProp?.SetValue(c, true, null);
        }

        // Кпнока по создаю нового проекта
        private async void CreateProjectButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!Application.OpenForms.OfType<ChangeForm>().Any())
                {
                    ChangeForm changeForm = new ChangeForm(this, _user);
                    changeForm.Show();

                    while (true)
                    {
                        await Task.Delay(50);

                        if (changeForm.IsDisposed)
                        {
                            SetUserProjectNames();
                            break;
                        }
                    }

                    SetUserProjectNames();
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                try { TrashButton.PerformClick(); }
                finally { SetUserProjectNames(); }
            }
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
            CalendarPanel.BringToFront();
            // перемещение панельки выделения
            StripPanel.Location = CalendarButton.Location;
            // изменение размера панельки выделения
            StripPanel.Size = new Size(StripPanel.Size.Width, CalendarButton.Size.Height);
            ListBoxOfProjectNames.Visible = false;
        }

        // Выход из мейнформы
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
        }

        // Показать пароль
        private void PasswordShowLinkLabel_Click(object sender, EventArgs e)
        {
            if (PasswordShowLabel.Visible)
            {
                PasswordShowLabel.Visible = false;
                PasswordShowLinkLabel.Text = "Показать";
            }
            else
            {
                PasswordShowLabel.Text = MD5.Decrypt(_user.Password);
                PasswordShowLabel.Visible = true;
                PasswordShowLinkLabel.Text = "Скрыть";
            }
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            SendMessage();
            MessengerTextBox.Clear();
        }

        private void SendMessageButton_MouseEnter(object sender, EventArgs e)
        {
            SendMessageButton.ForeColor = Color.FromArgb(46, 51, 73);
        }
    }
}
