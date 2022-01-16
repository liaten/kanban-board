
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace kanbanboard.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            this.ControlsPanel = new Panel();
            this.ProjectsPanel = new Panel();
            this.panel1 = new Panel();
            this.CreateProjectButton = new Button();
            this.SaveProjectPanel = new Panel();
            this.SaveProjectButton = new Button();
            this.ListBoxOfProjectNames = new ListBox();
            this.ExitButtonPanel = new Panel();
            this.ExitButton = new Button();
            this.StripPanel = new Panel();
            this.CalendarButton = new Button();
            this.MessengerButton = new Button();
            this.TasksButton = new Button();
            this.UserControlsPanel = new Panel();
            this.UserNamePanel = new Panel();
            this.UsernameLabel = new Label();
            this.UserInfoPanel = new Panel();
            this.UserInfoLabel = new Label();
            this.UserPhotoPanel = new Panel();
            this.UserPictureBox = new PictureBox();
            this.LabelHead = new Label();
            this.TableLayoutPanel = new TableLayoutPanel();
            this.BasicPanel = new Panel();
            this.BasicContentPanel = new Panel();
            this.PanelWithTable = new Panel();
            this.AddingPanel = new Panel();
            this.AddTitleButton = new Button();
            this.LoadPanel = new Panel();
            this.LoadLabel = new Label();
            this.CalendarPanel = new Panel();
            this.CalendarDateTimePicker = new DateTimePicker();
            this.MessengerPanel = new Panel();
            this.MessengerMainPanel = new Panel();
            this.MessengerShowPanel = new Panel();
            this.MessengerListBox = new ListBox();
            this.MessengerSendPanel = new Panel();
            this.SendMessageButtonPanel = new Panel();
            this.SendMessageButton = new Button();
            this.MessengerTextBoxPanel = new Panel();
            this.MessengerTextBox = new TextBox();
            this.UserPanel = new Panel();
            this.PasswordPanel = new Panel();
            this.PasswordShowPanel = new Panel();
            this.PasswordShowLabel = new Label();
            this.PasswordShowLinkLabel = new LinkLabel();
            this.PasswordGetPanel = new Panel();
            this.PasswordGetLabel = new Label();
            this.TimeZonePanel = new Panel();
            this.TimeZoneGetPanel = new Panel();
            this.TimeZoneLabel = new Label();
            this.TimeZoneLabelPanel = new Panel();
            this.TimeZoneTitleLabel = new Label();
            this.OrganizationPanel = new Panel();
            this.OrganizationGetPanel = new Panel();
            this.OrganizationLabel = new Label();
            this.OrganizationLabelPanel = new Panel();
            this.OrganizationTitleLabel = new Label();
            this.NickNamePanel = new Panel();
            this.NickNameGetPanel = new Panel();
            this.NickNameLabel = new Label();
            this.NickNameLabelPanel = new Panel();
            this.NickNameTitleLabel = new Label();
            this.FullNamePanel = new Panel();
            this.FullNameGetLabelPanel = new Panel();
            this.FullNameLabel = new Label();
            this.FullNameLabelPanel = new Panel();
            this.FullNameTitleLabel = new Label();
            this.HeadPanel = new Panel();
            this.ControlsPanel.SuspendLayout();
            this.ProjectsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SaveProjectPanel.SuspendLayout();
            this.ExitButtonPanel.SuspendLayout();
            this.UserControlsPanel.SuspendLayout();
            this.UserNamePanel.SuspendLayout();
            this.UserInfoPanel.SuspendLayout();
            this.UserPhotoPanel.SuspendLayout();
            ((ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.BasicPanel.SuspendLayout();
            this.BasicContentPanel.SuspendLayout();
            this.PanelWithTable.SuspendLayout();
            this.AddingPanel.SuspendLayout();
            this.LoadPanel.SuspendLayout();
            this.CalendarPanel.SuspendLayout();
            this.MessengerPanel.SuspendLayout();
            this.MessengerMainPanel.SuspendLayout();
            this.MessengerShowPanel.SuspendLayout();
            this.MessengerSendPanel.SuspendLayout();
            this.SendMessageButtonPanel.SuspendLayout();
            this.MessengerTextBoxPanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.PasswordPanel.SuspendLayout();
            this.PasswordShowPanel.SuspendLayout();
            this.PasswordGetPanel.SuspendLayout();
            this.TimeZonePanel.SuspendLayout();
            this.TimeZoneGetPanel.SuspendLayout();
            this.TimeZoneLabelPanel.SuspendLayout();
            this.OrganizationPanel.SuspendLayout();
            this.OrganizationGetPanel.SuspendLayout();
            this.OrganizationLabelPanel.SuspendLayout();
            this.NickNamePanel.SuspendLayout();
            this.NickNameGetPanel.SuspendLayout();
            this.NickNameLabelPanel.SuspendLayout();
            this.FullNamePanel.SuspendLayout();
            this.FullNameGetLabelPanel.SuspendLayout();
            this.FullNameLabelPanel.SuspendLayout();
            this.HeadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.BackColor = Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ControlsPanel.Controls.Add(this.ProjectsPanel);
            this.ControlsPanel.Controls.Add(this.ExitButtonPanel);
            this.ControlsPanel.Controls.Add(this.StripPanel);
            this.ControlsPanel.Controls.Add(this.CalendarButton);
            this.ControlsPanel.Controls.Add(this.MessengerButton);
            this.ControlsPanel.Controls.Add(this.TasksButton);
            this.ControlsPanel.Controls.Add(this.UserControlsPanel);
            this.ControlsPanel.Dock = DockStyle.Left;
            this.ControlsPanel.Location = new Point(0, 0);
            this.ControlsPanel.MinimumSize = new Size(205, 450);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new Size(205, 565);
            this.ControlsPanel.TabIndex = 0;
            // 
            // ProjectsPanel
            // 
            this.ProjectsPanel.AutoSize = true;
            this.ProjectsPanel.Controls.Add(this.panel1);
            this.ProjectsPanel.Controls.Add(this.SaveProjectPanel);
            this.ProjectsPanel.Controls.Add(this.ListBoxOfProjectNames);
            this.ProjectsPanel.Dock = DockStyle.Bottom;
            this.ProjectsPanel.Location = new Point(0, 285);
            this.ProjectsPanel.Name = "ProjectsPanel";
            this.ProjectsPanel.Size = new Size(205, 224);
            this.ProjectsPanel.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CreateProjectButton);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 112);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Padding(10);
            this.panel1.Size = new Size(205, 56);
            this.panel1.TabIndex = 8;
            // 
            // CreateProjectButton
            // 
            this.CreateProjectButton.Dock = DockStyle.Fill;
            this.CreateProjectButton.FlatAppearance.BorderColor = Color.Indigo;
            this.CreateProjectButton.FlatAppearance.BorderSize = 2;
            this.CreateProjectButton.FlatStyle = FlatStyle.Flat;
            this.CreateProjectButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.CreateProjectButton.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CreateProjectButton.Location = new Point(10, 10);
            this.CreateProjectButton.Name = "CreateProjectButton";
            this.CreateProjectButton.Size = new Size(185, 36);
            this.CreateProjectButton.TabIndex = 5;
            this.CreateProjectButton.Text = "Создать проект";
            this.CreateProjectButton.UseVisualStyleBackColor = true;
            this.CreateProjectButton.MouseDown += new MouseEventHandler(this.CreateProjectButton_MouseDown);
            // 
            // SaveProjectPanel
            // 
            this.SaveProjectPanel.Controls.Add(this.SaveProjectButton);
            this.SaveProjectPanel.Dock = DockStyle.Bottom;
            this.SaveProjectPanel.Location = new Point(0, 168);
            this.SaveProjectPanel.Name = "SaveProjectPanel";
            this.SaveProjectPanel.Padding = new Padding(10);
            this.SaveProjectPanel.Size = new Size(205, 56);
            this.SaveProjectPanel.TabIndex = 7;
            // 
            // SaveProjectButton
            // 
            this.SaveProjectButton.Dock = DockStyle.Fill;
            this.SaveProjectButton.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(109)))));
            this.SaveProjectButton.FlatAppearance.BorderSize = 2;
            this.SaveProjectButton.FlatStyle = FlatStyle.Flat;
            this.SaveProjectButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.SaveProjectButton.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.SaveProjectButton.Location = new Point(10, 10);
            this.SaveProjectButton.Name = "SaveProjectButton";
            this.SaveProjectButton.Size = new Size(185, 36);
            this.SaveProjectButton.TabIndex = 5;
            this.SaveProjectButton.Text = "Сохранить проект";
            this.SaveProjectButton.UseVisualStyleBackColor = true;
            this.SaveProjectButton.Click += new EventHandler(this.SaveProjectButton_Click);
            // 
            // ListBoxOfProjectNames
            // 
            this.ListBoxOfProjectNames.BackColor = Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ListBoxOfProjectNames.BorderStyle = BorderStyle.None;
            this.ListBoxOfProjectNames.Dock = DockStyle.Top;
            this.ListBoxOfProjectNames.Font = new Font("Microsoft Sans Serif", 11.25F);
            this.ListBoxOfProjectNames.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ListBoxOfProjectNames.FormattingEnabled = true;
            this.ListBoxOfProjectNames.IntegralHeight = false;
            this.ListBoxOfProjectNames.ItemHeight = 18;
            this.ListBoxOfProjectNames.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.ListBoxOfProjectNames.Location = new Point(0, 0);
            this.ListBoxOfProjectNames.Name = "ListBoxOfProjectNames";
            this.ListBoxOfProjectNames.Size = new Size(205, 112);
            this.ListBoxOfProjectNames.Sorted = true;
            this.ListBoxOfProjectNames.TabIndex = 6;
            // 
            // ExitButtonPanel
            // 
            this.ExitButtonPanel.Controls.Add(this.ExitButton);
            this.ExitButtonPanel.Dock = DockStyle.Bottom;
            this.ExitButtonPanel.Location = new Point(0, 509);
            this.ExitButtonPanel.Name = "ExitButtonPanel";
            this.ExitButtonPanel.Padding = new Padding(10);
            this.ExitButtonPanel.Size = new Size(205, 56);
            this.ExitButtonPanel.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = DockStyle.Fill;
            this.ExitButton.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ExitButton.FlatAppearance.BorderSize = 2;
            this.ExitButton.FlatStyle = FlatStyle.Flat;
            this.ExitButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ExitButton.Location = new Point(10, 10);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new Size(185, 36);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Выйти из аккаунта";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new EventHandler(this.ExitButton_Click);
            // 
            // StripPanel
            // 
            this.StripPanel.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.StripPanel.ForeColor = SystemColors.ControlText;
            this.StripPanel.Location = new Point(0, 70);
            this.StripPanel.Name = "StripPanel";
            this.StripPanel.Size = new Size(2, 50);
            this.StripPanel.TabIndex = 0;
            // 
            // CalendarButton
            // 
            this.CalendarButton.Dock = DockStyle.Top;
            this.CalendarButton.FlatAppearance.BorderSize = 0;
            this.CalendarButton.FlatStyle = FlatStyle.Flat;
            this.CalendarButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.CalendarButton.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CalendarButton.Location = new Point(0, 170);
            this.CalendarButton.Name = "CalendarButton";
            this.CalendarButton.Size = new Size(205, 50);
            this.CalendarButton.TabIndex = 4;
            this.CalendarButton.Text = "Календарь";
            this.CalendarButton.UseVisualStyleBackColor = true;
            this.CalendarButton.Click += new EventHandler(this.CalendarButton_Click);
            // 
            // MessengerButton
            // 
            this.MessengerButton.Dock = DockStyle.Top;
            this.MessengerButton.FlatAppearance.BorderSize = 0;
            this.MessengerButton.FlatStyle = FlatStyle.Flat;
            this.MessengerButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.MessengerButton.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.MessengerButton.Location = new Point(0, 120);
            this.MessengerButton.Name = "MessengerButton";
            this.MessengerButton.Size = new Size(205, 50);
            this.MessengerButton.TabIndex = 3;
            this.MessengerButton.Text = "Мессенджер";
            this.MessengerButton.UseVisualStyleBackColor = true;
            this.MessengerButton.Click += new EventHandler(this.MessengerButton_Click);
            // 
            // TasksButton
            // 
            this.TasksButton.Dock = DockStyle.Top;
            this.TasksButton.FlatAppearance.BorderSize = 0;
            this.TasksButton.FlatStyle = FlatStyle.Flat;
            this.TasksButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.TasksButton.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.TasksButton.Location = new Point(0, 70);
            this.TasksButton.Name = "TasksButton";
            this.TasksButton.Size = new Size(205, 50);
            this.TasksButton.TabIndex = 2;
            this.TasksButton.Text = "Задачи";
            this.TasksButton.UseVisualStyleBackColor = true;
            this.TasksButton.Click += new EventHandler(this.TasksButton_Click);
            // 
            // UserControlsPanel
            // 
            this.UserControlsPanel.BackColor = Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.UserControlsPanel.Controls.Add(this.UserNamePanel);
            this.UserControlsPanel.Controls.Add(this.UserInfoPanel);
            this.UserControlsPanel.Controls.Add(this.UserPhotoPanel);
            this.UserControlsPanel.Dock = DockStyle.Top;
            this.UserControlsPanel.Location = new Point(0, 0);
            this.UserControlsPanel.Name = "UserControlsPanel";
            this.UserControlsPanel.Size = new Size(205, 70);
            this.UserControlsPanel.TabIndex = 5;
            this.UserControlsPanel.Click += new EventHandler(this.UserControlsPanel_Click);
            // 
            // UserNamePanel
            // 
            this.UserNamePanel.Controls.Add(this.UsernameLabel);
            this.UserNamePanel.Dock = DockStyle.Bottom;
            this.UserNamePanel.Location = new Point(70, 30);
            this.UserNamePanel.Name = "UserNamePanel";
            this.UserNamePanel.Padding = new Padding(3);
            this.UserNamePanel.Size = new Size(135, 17);
            this.UserNamePanel.TabIndex = 3;
            this.UserNamePanel.Click += new EventHandler(this.UserControlsPanel_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = Color.Transparent;
            this.UsernameLabel.Dock = DockStyle.Fill;
            this.UsernameLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.UsernameLabel.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UsernameLabel.Location = new Point(3, 3);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new Size(131, 16);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "USERNAME_GET";
            this.UsernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.UsernameLabel.Click += new EventHandler(this.UserControlsPanel_Click);
            // 
            // UserInfoPanel
            // 
            this.UserInfoPanel.Controls.Add(this.UserInfoLabel);
            this.UserInfoPanel.Dock = DockStyle.Bottom;
            this.UserInfoPanel.Location = new Point(70, 47);
            this.UserInfoPanel.Name = "UserInfoPanel";
            this.UserInfoPanel.Padding = new Padding(3);
            this.UserInfoPanel.Size = new Size(135, 23);
            this.UserInfoPanel.TabIndex = 4;
            this.UserInfoPanel.Click += new EventHandler(this.UserControlsPanel_Click);
            // 
            // UserInfoLabel
            // 
            this.UserInfoLabel.AutoSize = true;
            this.UserInfoLabel.Dock = DockStyle.Fill;
            this.UserInfoLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.UserInfoLabel.ForeColor = SystemColors.ControlDark;
            this.UserInfoLabel.Location = new Point(3, 3);
            this.UserInfoLabel.Name = "UserInfoLabel";
            this.UserInfoLabel.Size = new Size(90, 13);
            this.UserInfoLabel.TabIndex = 2;
            this.UserInfoLabel.Text = "USERINFO_GET";
            this.UserInfoLabel.Click += new EventHandler(this.UserControlsPanel_Click);
            // 
            // UserPhotoPanel
            // 
            this.UserPhotoPanel.Controls.Add(this.UserPictureBox);
            this.UserPhotoPanel.Dock = DockStyle.Left;
            this.UserPhotoPanel.Location = new Point(0, 0);
            this.UserPhotoPanel.Name = "UserPhotoPanel";
            this.UserPhotoPanel.Padding = new Padding(15);
            this.UserPhotoPanel.Size = new Size(70, 70);
            this.UserPhotoPanel.TabIndex = 2;
            this.UserPhotoPanel.Click += new EventHandler(this.UserControlsPanel_Click);
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.Dock = DockStyle.Fill;
            this.UserPictureBox.Image = ((Image)(resources.GetObject("UserPictureBox.Image")));
            this.UserPictureBox.Location = new Point(15, 15);
            this.UserPictureBox.Margin = new Padding(0);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new Size(40, 40);
            this.UserPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.UserPictureBox.TabIndex = 0;
            this.UserPictureBox.TabStop = false;
            this.UserPictureBox.Click += new EventHandler(this.UserControlsPanel_Click);
            // 
            // LabelHead
            // 
            this.LabelHead.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
                                                      | AnchorStyles.Left) 
                                                     | AnchorStyles.Right)));
            this.LabelHead.AutoSize = true;
            this.LabelHead.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.LabelHead.ForeColor = SystemColors.ControlDark;
            this.LabelHead.Location = new Point(28, 17);
            this.LabelHead.Name = "LabelHead";
            this.LabelHead.Size = new Size(150, 37);
            this.LabelHead.TabIndex = 1;
            this.LabelHead.Text = "Профиль";
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.AutoScroll = true;
            this.TableLayoutPanel.AutoSize = true;
            this.TableLayoutPanel.BackColor = Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(63)))));
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 681F));
            this.TableLayoutPanel.Dock = DockStyle.Fill;
            this.TableLayoutPanel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.TableLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            this.TableLayoutPanel.Location = new Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.Padding = new Padding(10, 10, 10, 30);
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
            this.TableLayoutPanel.Size = new Size(937, 494);
            this.TableLayoutPanel.TabIndex = 1;
            this.TableLayoutPanel.DragDrop += new DragEventHandler(this.TableLayoutPanel_DragDrop);
            this.TableLayoutPanel.DragEnter += new DragEventHandler(this.TableLayoutPanel_DragEnter);
            this.TableLayoutPanel.DragLeave += new EventHandler(this.TableLayoutPanel_DragLeave);
            // 
            // BasicPanel
            // 
            this.BasicPanel.AutoSize = true;
            this.BasicPanel.Controls.Add(this.BasicContentPanel);
            this.BasicPanel.Controls.Add(this.HeadPanel);
            this.BasicPanel.Dock = DockStyle.Fill;
            this.BasicPanel.Location = new Point(205, 0);
            this.BasicPanel.Name = "BasicPanel";
            this.BasicPanel.Size = new Size(979, 565);
            this.BasicPanel.TabIndex = 3;
            // 
            // BasicContentPanel
            // 
            this.BasicContentPanel.Controls.Add(this.PanelWithTable);
            this.BasicContentPanel.Controls.Add(this.LoadPanel);
            this.BasicContentPanel.Controls.Add(this.CalendarPanel);
            this.BasicContentPanel.Controls.Add(this.MessengerPanel);
            this.BasicContentPanel.Controls.Add(this.UserPanel);
            this.BasicContentPanel.Dock = DockStyle.Fill;
            this.BasicContentPanel.Location = new Point(0, 70);
            this.BasicContentPanel.Name = "BasicContentPanel";
            this.BasicContentPanel.Size = new Size(979, 495);
            this.BasicContentPanel.TabIndex = 2;
            // 
            // PanelWithTable
            // 
            this.PanelWithTable.AutoSize = true;
            this.PanelWithTable.Controls.Add(this.TableLayoutPanel);
            this.PanelWithTable.Controls.Add(this.AddingPanel);
            this.PanelWithTable.Dock = DockStyle.Fill;
            this.PanelWithTable.Location = new Point(0, 0);
            this.PanelWithTable.Name = "PanelWithTable";
            this.PanelWithTable.Padding = new Padding(0, 0, 0, 1);
            this.PanelWithTable.Size = new Size(979, 495);
            this.PanelWithTable.TabIndex = 0;
            // 
            // AddingPanel
            // 
            this.AddingPanel.BackColor = Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AddingPanel.Controls.Add(this.AddTitleButton);
            this.AddingPanel.Dock = DockStyle.Right;
            this.AddingPanel.Location = new Point(937, 0);
            this.AddingPanel.Name = "AddingPanel";
            this.AddingPanel.Size = new Size(42, 494);
            this.AddingPanel.TabIndex = 0;
            // 
            // AddTitleButton
            // 
            this.AddTitleButton.Dock = DockStyle.Top;
            this.AddTitleButton.FlatAppearance.BorderSize = 0;
            this.AddTitleButton.FlatStyle = FlatStyle.Flat;
            this.AddTitleButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.AddTitleButton.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.AddTitleButton.Location = new Point(0, 0);
            this.AddTitleButton.Name = "AddTitleButton";
            this.AddTitleButton.Size = new Size(42, 36);
            this.AddTitleButton.TabIndex = 3;
            this.AddTitleButton.Text = "+";
            this.AddTitleButton.UseVisualStyleBackColor = true;
            this.AddTitleButton.Click += new EventHandler(this.AddTitleButton_Click);
            // 
            // LoadPanel
            // 
            this.LoadPanel.BackColor = Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(63)))));
            this.LoadPanel.Controls.Add(this.LoadLabel);
            this.LoadPanel.Dock = DockStyle.Fill;
            this.LoadPanel.Location = new Point(0, 0);
            this.LoadPanel.Name = "LoadPanel";
            this.LoadPanel.Size = new Size(979, 495);
            this.LoadPanel.TabIndex = 3;
            this.LoadPanel.Paint += new PaintEventHandler(this.LoadPanel_Paint);
            // 
            // LoadLabel
            // 
            this.LoadLabel.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
                                                      | AnchorStyles.Left) 
                                                     | AnchorStyles.Right)));
            this.LoadLabel.AutoSize = true;
            this.LoadLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.LoadLabel.ForeColor = SystemColors.ControlDark;
            this.LoadLabel.Location = new Point(444, 241);
            this.LoadLabel.Name = "LoadLabel";
            this.LoadLabel.Size = new Size(63, 13);
            this.LoadLabel.TabIndex = 3;
            this.LoadLabel.Text = "Загрузка...";
            // 
            // CalendarPanel
            // 
            this.CalendarPanel.BackColor = Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(63)))));
            this.CalendarPanel.Controls.Add(this.CalendarDateTimePicker);
            this.CalendarPanel.Dock = DockStyle.Fill;
            this.CalendarPanel.Location = new Point(0, 0);
            this.CalendarPanel.Name = "CalendarPanel";
            this.CalendarPanel.Size = new Size(979, 495);
            this.CalendarPanel.TabIndex = 1;
            // 
            // CalendarDateTimePicker
            // 
            this.CalendarDateTimePicker.Font = new Font("Microsoft Sans Serif", 11.25F);
            this.CalendarDateTimePicker.Location = new Point(35, 36);
            this.CalendarDateTimePicker.MinDate = new DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.CalendarDateTimePicker.Name = "CalendarDateTimePicker";
            this.CalendarDateTimePicker.Size = new Size(161, 24);
            this.CalendarDateTimePicker.TabIndex = 2;
            // 
            // MessengerPanel
            // 
            this.MessengerPanel.Controls.Add(this.MessengerMainPanel);
            this.MessengerPanel.Dock = DockStyle.Fill;
            this.MessengerPanel.Location = new Point(0, 0);
            this.MessengerPanel.Name = "MessengerPanel";
            this.MessengerPanel.Size = new Size(979, 495);
            this.MessengerPanel.TabIndex = 1;
            // 
            // MessengerMainPanel
            // 
            this.MessengerMainPanel.Controls.Add(this.MessengerShowPanel);
            this.MessengerMainPanel.Controls.Add(this.MessengerSendPanel);
            this.MessengerMainPanel.Dock = DockStyle.Fill;
            this.MessengerMainPanel.Location = new Point(0, 0);
            this.MessengerMainPanel.Name = "MessengerMainPanel";
            this.MessengerMainPanel.Size = new Size(979, 495);
            this.MessengerMainPanel.TabIndex = 5;
            // 
            // MessengerShowPanel
            // 
            this.MessengerShowPanel.Controls.Add(this.MessengerListBox);
            this.MessengerShowPanel.Dock = DockStyle.Fill;
            this.MessengerShowPanel.Location = new Point(0, 0);
            this.MessengerShowPanel.Name = "MessengerShowPanel";
            this.MessengerShowPanel.Padding = new Padding(10, 10, 10, 0);
            this.MessengerShowPanel.Size = new Size(979, 455);
            this.MessengerShowPanel.TabIndex = 1;
            // 
            // MessengerListBox
            // 
            this.MessengerListBox.BackColor = Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.MessengerListBox.BorderStyle = BorderStyle.None;
            this.MessengerListBox.Dock = DockStyle.Fill;
            this.MessengerListBox.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Bold);
            this.MessengerListBox.ForeColor = SystemColors.ControlDark;
            this.MessengerListBox.FormattingEnabled = true;
            this.MessengerListBox.ItemHeight = 17;
            this.MessengerListBox.Location = new Point(10, 10);
            this.MessengerListBox.Name = "MessengerListBox";
            this.MessengerListBox.Size = new Size(959, 445);
            this.MessengerListBox.TabIndex = 0;
            // 
            // MessengerSendPanel
            // 
            this.MessengerSendPanel.Controls.Add(this.SendMessageButtonPanel);
            this.MessengerSendPanel.Controls.Add(this.MessengerTextBoxPanel);
            this.MessengerSendPanel.Dock = DockStyle.Bottom;
            this.MessengerSendPanel.Location = new Point(0, 455);
            this.MessengerSendPanel.Margin = new Padding(0);
            this.MessengerSendPanel.Name = "MessengerSendPanel";
            this.MessengerSendPanel.Size = new Size(979, 40);
            this.MessengerSendPanel.TabIndex = 4;
            // 
            // SendMessageButtonPanel
            // 
            this.SendMessageButtonPanel.Controls.Add(this.SendMessageButton);
            this.SendMessageButtonPanel.Dock = DockStyle.Right;
            this.SendMessageButtonPanel.Location = new Point(939, 0);
            this.SendMessageButtonPanel.Name = "SendMessageButtonPanel";
            this.SendMessageButtonPanel.Padding = new Padding(7);
            this.SendMessageButtonPanel.Size = new Size(40, 40);
            this.SendMessageButtonPanel.TabIndex = 5;
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.BackgroundImage = ((Image)(resources.GetObject("SendMessageButton.BackgroundImage")));
            this.SendMessageButton.BackgroundImageLayout = ImageLayout.Stretch;
            this.SendMessageButton.Dock = DockStyle.Fill;
            this.SendMessageButton.FlatAppearance.BorderSize = 0;
            this.SendMessageButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SendMessageButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SendMessageButton.FlatStyle = FlatStyle.Flat;
            this.SendMessageButton.Location = new Point(7, 7);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new Size(26, 26);
            this.SendMessageButton.TabIndex = 1;
            this.SendMessageButton.UseVisualStyleBackColor = false;
            this.SendMessageButton.Click += new EventHandler(this.SendMessageButton_Click);
            this.SendMessageButton.MouseEnter += new EventHandler(this.SendMessageButton_MouseEnter);
            // 
            // MessengerTextBoxPanel
            // 
            this.MessengerTextBoxPanel.Controls.Add(this.MessengerTextBox);
            this.MessengerTextBoxPanel.Dock = DockStyle.Fill;
            this.MessengerTextBoxPanel.Location = new Point(0, 0);
            this.MessengerTextBoxPanel.Name = "MessengerTextBoxPanel";
            this.MessengerTextBoxPanel.Padding = new Padding(10, 10, 50, 10);
            this.MessengerTextBoxPanel.Size = new Size(979, 40);
            this.MessengerTextBoxPanel.TabIndex = 4;
            // 
            // MessengerTextBox
            // 
            this.MessengerTextBox.AcceptsReturn = true;
            this.MessengerTextBox.AcceptsTab = true;
            this.MessengerTextBox.BackColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.MessengerTextBox.BorderStyle = BorderStyle.None;
            this.MessengerTextBox.Dock = DockStyle.Fill;
            this.MessengerTextBox.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.MessengerTextBox.ForeColor = Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.MessengerTextBox.Location = new Point(10, 10);
            this.MessengerTextBox.Margin = new Padding(0);
            this.MessengerTextBox.Name = "MessengerTextBox";
            this.MessengerTextBox.Size = new Size(919, 20);
            this.MessengerTextBox.TabIndex = 3;
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(63)))));
            this.UserPanel.Controls.Add(this.PasswordPanel);
            this.UserPanel.Controls.Add(this.TimeZonePanel);
            this.UserPanel.Controls.Add(this.OrganizationPanel);
            this.UserPanel.Controls.Add(this.NickNamePanel);
            this.UserPanel.Controls.Add(this.FullNamePanel);
            this.UserPanel.Dock = DockStyle.Fill;
            this.UserPanel.Location = new Point(0, 0);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new Size(979, 495);
            this.UserPanel.TabIndex = 2;
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.Controls.Add(this.PasswordShowPanel);
            this.PasswordPanel.Controls.Add(this.PasswordGetPanel);
            this.PasswordPanel.Dock = DockStyle.Top;
            this.PasswordPanel.Location = new Point(0, 144);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new Size(979, 36);
            this.PasswordPanel.TabIndex = 6;
            // 
            // PasswordShowPanel
            // 
            this.PasswordShowPanel.Controls.Add(this.PasswordShowLabel);
            this.PasswordShowPanel.Controls.Add(this.PasswordShowLinkLabel);
            this.PasswordShowPanel.Dock = DockStyle.Fill;
            this.PasswordShowPanel.Location = new Point(88, 0);
            this.PasswordShowPanel.Name = "PasswordShowPanel";
            this.PasswordShowPanel.Padding = new Padding(5);
            this.PasswordShowPanel.Size = new Size(891, 36);
            this.PasswordShowPanel.TabIndex = 4;
            // 
            // PasswordShowLabel
            // 
            this.PasswordShowLabel.AutoSize = true;
            this.PasswordShowLabel.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold);
            this.PasswordShowLabel.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PasswordShowLabel.Location = new Point(113, 5);
            this.PasswordShowLabel.Name = "PasswordShowLabel";
            this.PasswordShowLabel.Size = new Size(0, 20);
            this.PasswordShowLabel.TabIndex = 1;
            this.PasswordShowLabel.Visible = false;
            // 
            // PasswordShowLinkLabel
            // 
            this.PasswordShowLinkLabel.AutoSize = true;
            this.PasswordShowLinkLabel.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold);
            this.PasswordShowLinkLabel.LinkColor = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PasswordShowLinkLabel.Location = new Point(10, 5);
            this.PasswordShowLinkLabel.Name = "PasswordShowLinkLabel";
            this.PasswordShowLinkLabel.Size = new Size(98, 20);
            this.PasswordShowLinkLabel.TabIndex = 0;
            this.PasswordShowLinkLabel.TabStop = true;
            this.PasswordShowLinkLabel.Text = "Показать";
            this.PasswordShowLinkLabel.Click += new EventHandler(this.PasswordShowLinkLabel_Click);
            // 
            // PasswordGetPanel
            // 
            this.PasswordGetPanel.AutoSize = true;
            this.PasswordGetPanel.Controls.Add(this.PasswordGetLabel);
            this.PasswordGetPanel.Dock = DockStyle.Left;
            this.PasswordGetPanel.Location = new Point(0, 0);
            this.PasswordGetPanel.Name = "PasswordGetPanel";
            this.PasswordGetPanel.Padding = new Padding(5);
            this.PasswordGetPanel.Size = new Size(88, 36);
            this.PasswordGetPanel.TabIndex = 3;
            // 
            // PasswordGetLabel
            // 
            this.PasswordGetLabel.AutoSize = true;
            this.PasswordGetLabel.Dock = DockStyle.Fill;
            this.PasswordGetLabel.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold);
            this.PasswordGetLabel.ForeColor = SystemColors.Control;
            this.PasswordGetLabel.Location = new Point(5, 5);
            this.PasswordGetLabel.Name = "PasswordGetLabel";
            this.PasswordGetLabel.Size = new Size(78, 20);
            this.PasswordGetLabel.TabIndex = 0;
            this.PasswordGetLabel.Text = "Пароль";
            // 
            // TimeZonePanel
            // 
            this.TimeZonePanel.Controls.Add(this.TimeZoneGetPanel);
            this.TimeZonePanel.Controls.Add(this.TimeZoneLabelPanel);
            this.TimeZonePanel.Dock = DockStyle.Top;
            this.TimeZonePanel.Location = new Point(0, 108);
            this.TimeZonePanel.Name = "TimeZonePanel";
            this.TimeZonePanel.Size = new Size(979, 36);
            this.TimeZonePanel.TabIndex = 4;
            // 
            // TimeZoneGetPanel
            // 
            this.TimeZoneGetPanel.Controls.Add(this.TimeZoneLabel);
            this.TimeZoneGetPanel.Dock = DockStyle.Fill;
            this.TimeZoneGetPanel.Location = new Point(167, 0);
            this.TimeZoneGetPanel.Name = "TimeZoneGetPanel";
            this.TimeZoneGetPanel.Padding = new Padding(3);
            this.TimeZoneGetPanel.Size = new Size(812, 36);
            this.TimeZoneGetPanel.TabIndex = 4;
            // 
            // TimeZoneLabel
            // 
            this.TimeZoneLabel.AutoSize = true;
            this.TimeZoneLabel.Font = new Font("Microsoft Sans Serif", 12.25F);
            this.TimeZoneLabel.ForeColor = SystemColors.Control;
            this.TimeZoneLabel.Location = new Point(3, 3);
            this.TimeZoneLabel.Name = "TimeZoneLabel";
            this.TimeZoneLabel.Size = new Size(136, 20);
            this.TimeZoneLabel.TabIndex = 1;
            this.TimeZoneLabel.Text = "TIMEZONE_GET";
            // 
            // TimeZoneLabelPanel
            // 
            this.TimeZoneLabelPanel.AutoSize = true;
            this.TimeZoneLabelPanel.Controls.Add(this.TimeZoneTitleLabel);
            this.TimeZoneLabelPanel.Dock = DockStyle.Left;
            this.TimeZoneLabelPanel.Location = new Point(0, 0);
            this.TimeZoneLabelPanel.Name = "TimeZoneLabelPanel";
            this.TimeZoneLabelPanel.Padding = new Padding(3);
            this.TimeZoneLabelPanel.Size = new Size(167, 36);
            this.TimeZoneLabelPanel.TabIndex = 3;
            // 
            // TimeZoneTitleLabel
            // 
            this.TimeZoneTitleLabel.AutoSize = true;
            this.TimeZoneTitleLabel.Dock = DockStyle.Fill;
            this.TimeZoneTitleLabel.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold);
            this.TimeZoneTitleLabel.ForeColor = SystemColors.Control;
            this.TimeZoneTitleLabel.Location = new Point(3, 3);
            this.TimeZoneTitleLabel.Name = "TimeZoneTitleLabel";
            this.TimeZoneTitleLabel.Size = new Size(161, 20);
            this.TimeZoneTitleLabel.TabIndex = 0;
            this.TimeZoneTitleLabel.Text = "Временная зона";
            // 
            // OrganizationPanel
            // 
            this.OrganizationPanel.Controls.Add(this.OrganizationGetPanel);
            this.OrganizationPanel.Controls.Add(this.OrganizationLabelPanel);
            this.OrganizationPanel.Dock = DockStyle.Top;
            this.OrganizationPanel.Location = new Point(0, 72);
            this.OrganizationPanel.Name = "OrganizationPanel";
            this.OrganizationPanel.Size = new Size(979, 36);
            this.OrganizationPanel.TabIndex = 5;
            // 
            // OrganizationGetPanel
            // 
            this.OrganizationGetPanel.Controls.Add(this.OrganizationLabel);
            this.OrganizationGetPanel.Dock = DockStyle.Fill;
            this.OrganizationGetPanel.Location = new Point(136, 0);
            this.OrganizationGetPanel.Name = "OrganizationGetPanel";
            this.OrganizationGetPanel.Padding = new Padding(3);
            this.OrganizationGetPanel.Size = new Size(843, 36);
            this.OrganizationGetPanel.TabIndex = 4;
            // 
            // OrganizationLabel
            // 
            this.OrganizationLabel.AutoSize = true;
            this.OrganizationLabel.Font = new Font("Microsoft Sans Serif", 12.25F);
            this.OrganizationLabel.ForeColor = SystemColors.Control;
            this.OrganizationLabel.Location = new Point(3, 3);
            this.OrganizationLabel.Name = "OrganizationLabel";
            this.OrganizationLabel.Size = new Size(176, 20);
            this.OrganizationLabel.TabIndex = 1;
            this.OrganizationLabel.Text = "ORGANIZATION_GET";
            // 
            // OrganizationLabelPanel
            // 
            this.OrganizationLabelPanel.AutoSize = true;
            this.OrganizationLabelPanel.Controls.Add(this.OrganizationTitleLabel);
            this.OrganizationLabelPanel.Dock = DockStyle.Left;
            this.OrganizationLabelPanel.Location = new Point(0, 0);
            this.OrganizationLabelPanel.Name = "OrganizationLabelPanel";
            this.OrganizationLabelPanel.Padding = new Padding(3);
            this.OrganizationLabelPanel.Size = new Size(136, 36);
            this.OrganizationLabelPanel.TabIndex = 3;
            // 
            // OrganizationTitleLabel
            // 
            this.OrganizationTitleLabel.AutoSize = true;
            this.OrganizationTitleLabel.Dock = DockStyle.Fill;
            this.OrganizationTitleLabel.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold);
            this.OrganizationTitleLabel.ForeColor = SystemColors.Control;
            this.OrganizationTitleLabel.Location = new Point(3, 3);
            this.OrganizationTitleLabel.Name = "OrganizationTitleLabel";
            this.OrganizationTitleLabel.Size = new Size(130, 20);
            this.OrganizationTitleLabel.TabIndex = 0;
            this.OrganizationTitleLabel.Text = "Организация";
            // 
            // NickNamePanel
            // 
            this.NickNamePanel.Controls.Add(this.NickNameGetPanel);
            this.NickNamePanel.Controls.Add(this.NickNameLabelPanel);
            this.NickNamePanel.Dock = DockStyle.Top;
            this.NickNamePanel.Location = new Point(0, 36);
            this.NickNamePanel.Name = "NickNamePanel";
            this.NickNamePanel.Size = new Size(979, 36);
            this.NickNamePanel.TabIndex = 3;
            // 
            // NickNameGetPanel
            // 
            this.NickNameGetPanel.Controls.Add(this.NickNameLabel);
            this.NickNameGetPanel.Dock = DockStyle.Fill;
            this.NickNameGetPanel.Location = new Point(167, 0);
            this.NickNameGetPanel.Name = "NickNameGetPanel";
            this.NickNameGetPanel.Padding = new Padding(3);
            this.NickNameGetPanel.Size = new Size(812, 36);
            this.NickNameGetPanel.TabIndex = 4;
            // 
            // NickNameLabel
            // 
            this.NickNameLabel.AutoSize = true;
            this.NickNameLabel.Font = new Font("Microsoft Sans Serif", 12.25F);
            this.NickNameLabel.ForeColor = SystemColors.Control;
            this.NickNameLabel.Location = new Point(3, 3);
            this.NickNameLabel.Name = "NickNameLabel";
            this.NickNameLabel.Size = new Size(139, 20);
            this.NickNameLabel.TabIndex = 1;
            this.NickNameLabel.Text = "NICKNAME_GET";
            // 
            // NickNameLabelPanel
            // 
            this.NickNameLabelPanel.AutoSize = true;
            this.NickNameLabelPanel.Controls.Add(this.NickNameTitleLabel);
            this.NickNameLabelPanel.Dock = DockStyle.Left;
            this.NickNameLabelPanel.Location = new Point(0, 0);
            this.NickNameLabelPanel.Name = "NickNameLabelPanel";
            this.NickNameLabelPanel.Padding = new Padding(3);
            this.NickNameLabelPanel.Size = new Size(167, 36);
            this.NickNameLabelPanel.TabIndex = 3;
            // 
            // NickNameTitleLabel
            // 
            this.NickNameTitleLabel.AutoSize = true;
            this.NickNameTitleLabel.Dock = DockStyle.Fill;
            this.NickNameTitleLabel.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold);
            this.NickNameTitleLabel.ForeColor = SystemColors.Control;
            this.NickNameTitleLabel.Location = new Point(3, 3);
            this.NickNameTitleLabel.Name = "NickNameTitleLabel";
            this.NickNameTitleLabel.Size = new Size(161, 20);
            this.NickNameTitleLabel.TabIndex = 0;
            this.NickNameTitleLabel.Text = "Никнейм / логин";
            // 
            // FullNamePanel
            // 
            this.FullNamePanel.Controls.Add(this.FullNameGetLabelPanel);
            this.FullNamePanel.Controls.Add(this.FullNameLabelPanel);
            this.FullNamePanel.Dock = DockStyle.Top;
            this.FullNamePanel.Location = new Point(0, 0);
            this.FullNamePanel.Name = "FullNamePanel";
            this.FullNamePanel.Size = new Size(979, 36);
            this.FullNamePanel.TabIndex = 2;
            // 
            // FullNameGetLabelPanel
            // 
            this.FullNameGetLabelPanel.Controls.Add(this.FullNameLabel);
            this.FullNameGetLabelPanel.Dock = DockStyle.Fill;
            this.FullNameGetLabelPanel.Location = new Point(62, 0);
            this.FullNameGetLabelPanel.Name = "FullNameGetLabelPanel";
            this.FullNameGetLabelPanel.Padding = new Padding(5);
            this.FullNameGetLabelPanel.Size = new Size(917, 36);
            this.FullNameGetLabelPanel.TabIndex = 4;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new Font("Microsoft Sans Serif", 12.25F);
            this.FullNameLabel.ForeColor = SystemColors.Control;
            this.FullNameLabel.Location = new Point(5, 5);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new Size(142, 20);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "FULLNAME_GET";
            // 
            // FullNameLabelPanel
            // 
            this.FullNameLabelPanel.AutoSize = true;
            this.FullNameLabelPanel.Controls.Add(this.FullNameTitleLabel);
            this.FullNameLabelPanel.Dock = DockStyle.Left;
            this.FullNameLabelPanel.Location = new Point(0, 0);
            this.FullNameLabelPanel.Name = "FullNameLabelPanel";
            this.FullNameLabelPanel.Padding = new Padding(5);
            this.FullNameLabelPanel.Size = new Size(62, 36);
            this.FullNameLabelPanel.TabIndex = 3;
            // 
            // FullNameTitleLabel
            // 
            this.FullNameTitleLabel.AutoSize = true;
            this.FullNameTitleLabel.Dock = DockStyle.Fill;
            this.FullNameTitleLabel.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold);
            this.FullNameTitleLabel.ForeColor = SystemColors.Control;
            this.FullNameTitleLabel.Location = new Point(5, 5);
            this.FullNameTitleLabel.Name = "FullNameTitleLabel";
            this.FullNameTitleLabel.Size = new Size(52, 20);
            this.FullNameTitleLabel.TabIndex = 0;
            this.FullNameTitleLabel.Text = "ФИО";
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.HeadPanel.Controls.Add(this.LabelHead);
            this.HeadPanel.Dock = DockStyle.Top;
            this.HeadPanel.Location = new Point(0, 0);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new Size(979, 70);
            this.HeadPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new Size(1184, 565);
            this.Controls.Add(this.BasicPanel);
            this.Controls.Add(this.ControlsPanel);
            this.DoubleBuffered = true;
            this.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new Size(1200, 600);
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Канбан-доска";
            this.ControlsPanel.ResumeLayout(false);
            this.ControlsPanel.PerformLayout();
            this.ProjectsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.SaveProjectPanel.ResumeLayout(false);
            this.ExitButtonPanel.ResumeLayout(false);
            this.UserControlsPanel.ResumeLayout(false);
            this.UserNamePanel.ResumeLayout(false);
            this.UserNamePanel.PerformLayout();
            this.UserInfoPanel.ResumeLayout(false);
            this.UserInfoPanel.PerformLayout();
            this.UserPhotoPanel.ResumeLayout(false);
            ((ISupportInitialize)(this.UserPictureBox)).EndInit();
            this.BasicPanel.ResumeLayout(false);
            this.BasicContentPanel.ResumeLayout(false);
            this.BasicContentPanel.PerformLayout();
            this.PanelWithTable.ResumeLayout(false);
            this.PanelWithTable.PerformLayout();
            this.AddingPanel.ResumeLayout(false);
            this.LoadPanel.ResumeLayout(false);
            this.LoadPanel.PerformLayout();
            this.CalendarPanel.ResumeLayout(false);
            this.MessengerPanel.ResumeLayout(false);
            this.MessengerMainPanel.ResumeLayout(false);
            this.MessengerShowPanel.ResumeLayout(false);
            this.MessengerSendPanel.ResumeLayout(false);
            this.SendMessageButtonPanel.ResumeLayout(false);
            this.MessengerTextBoxPanel.ResumeLayout(false);
            this.MessengerTextBoxPanel.PerformLayout();
            this.UserPanel.ResumeLayout(false);
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.PasswordShowPanel.ResumeLayout(false);
            this.PasswordShowPanel.PerformLayout();
            this.PasswordGetPanel.ResumeLayout(false);
            this.PasswordGetPanel.PerformLayout();
            this.TimeZonePanel.ResumeLayout(false);
            this.TimeZonePanel.PerformLayout();
            this.TimeZoneGetPanel.ResumeLayout(false);
            this.TimeZoneGetPanel.PerformLayout();
            this.TimeZoneLabelPanel.ResumeLayout(false);
            this.TimeZoneLabelPanel.PerformLayout();
            this.OrganizationPanel.ResumeLayout(false);
            this.OrganizationPanel.PerformLayout();
            this.OrganizationGetPanel.ResumeLayout(false);
            this.OrganizationGetPanel.PerformLayout();
            this.OrganizationLabelPanel.ResumeLayout(false);
            this.OrganizationLabelPanel.PerformLayout();
            this.NickNamePanel.ResumeLayout(false);
            this.NickNamePanel.PerformLayout();
            this.NickNameGetPanel.ResumeLayout(false);
            this.NickNameGetPanel.PerformLayout();
            this.NickNameLabelPanel.ResumeLayout(false);
            this.NickNameLabelPanel.PerformLayout();
            this.FullNamePanel.ResumeLayout(false);
            this.FullNamePanel.PerformLayout();
            this.FullNameGetLabelPanel.ResumeLayout(false);
            this.FullNameGetLabelPanel.PerformLayout();
            this.FullNameLabelPanel.ResumeLayout(false);
            this.FullNameLabelPanel.PerformLayout();
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel ControlsPanel;
        private Button TasksButton;
        private Button CalendarButton;
        private Button MessengerButton;
        private Label LabelHead;
        private Button ExitButton;
        private Panel StripPanel;
        private Panel BasicPanel;
        private Panel HeadPanel;
        private Panel ExitButtonPanel;
        private TableLayoutPanel TableLayoutPanel;
        private Panel BasicContentPanel;
        private Panel MessengerPanel;
        private Panel CalendarPanel;
        private Panel UserPanel;
        private Panel TimeZonePanel;
        private Panel TimeZoneGetPanel;
        private Label TimeZoneLabel;
        private Panel TimeZoneLabelPanel;
        private Label TimeZoneTitleLabel;
        private Panel OrganizationPanel;
        private Panel OrganizationGetPanel;
        private Label OrganizationLabel;
        private Panel OrganizationLabelPanel;
        private Label OrganizationTitleLabel;
        private Panel NickNamePanel;
        private Panel NickNameGetPanel;
        private Label NickNameLabel;
        private Panel NickNameLabelPanel;
        private Label NickNameTitleLabel;
        private Panel FullNamePanel;
        private Panel FullNameGetLabelPanel;
        private Label FullNameLabel;
        private Panel FullNameLabelPanel;
        private Label FullNameTitleLabel;
        private Panel UserControlsPanel;
        private Panel UserNamePanel;
        private Label UsernameLabel;
        private Panel UserInfoPanel;
        private Label UserInfoLabel;
        private Panel UserPhotoPanel;
        private PictureBox UserPictureBox;
        private Panel AddingPanel;
        private Button AddTitleButton;
        private Panel PanelWithTable;
        private ListBox ListBoxOfProjectNames;
        private Panel ProjectsPanel;
        private Panel SaveProjectPanel;
        private Button SaveProjectButton;
        private Panel PasswordPanel;
        private Panel PasswordShowPanel;
        private Panel PasswordGetPanel;
        private Label PasswordGetLabel;
        private Label PasswordShowLabel;
        private LinkLabel PasswordShowLinkLabel;
        private Panel MessengerMainPanel;
        private Panel MessengerShowPanel;
        private ListBox MessengerListBox;
        private Panel MessengerSendPanel;
        private TextBox MessengerTextBox;
        private Panel panel1;
        private Button CreateProjectButton;
        private Panel SendMessageButtonPanel;
        private Button SendMessageButton;
        private Panel MessengerTextBoxPanel;
        private DateTimePicker CalendarDateTimePicker;
        private Panel LoadPanel;
        private Label LoadLabel;
    }
}

