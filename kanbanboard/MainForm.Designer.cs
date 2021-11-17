
namespace kanbanboard
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.ExitButtonPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StripPanel = new System.Windows.Forms.Panel();
            this.CalendarButton = new System.Windows.Forms.Button();
            this.MessengerButton = new System.Windows.Forms.Button();
            this.TasksButton = new System.Windows.Forms.Button();
            this.UserControlsPanel = new System.Windows.Forms.Panel();
            this.UserNamePanel = new System.Windows.Forms.Panel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UserInfoPanel = new System.Windows.Forms.Panel();
            this.UserInfoLabel = new System.Windows.Forms.Label();
            this.UserPhotoPanel = new System.Windows.Forms.Panel();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.LabelHead = new System.Windows.Forms.Label();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BasicPanel = new System.Windows.Forms.Panel();
            this.BasicContentPanel = new System.Windows.Forms.Panel();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.FullNamePanel = new System.Windows.Forms.Panel();
            this.FullNameGetLabelPanel = new System.Windows.Forms.Panel();
            this.FULLNAME_GET = new System.Windows.Forms.Label();
            this.FullNameLabelPanel = new System.Windows.Forms.Panel();
            this.FullName = new System.Windows.Forms.Label();
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.NickNamePanel = new System.Windows.Forms.Panel();
            this.NickNameGetPanel = new System.Windows.Forms.Panel();
            this.NICKNAME_GET = new System.Windows.Forms.Label();
            this.NickNameLabelPanel = new System.Windows.Forms.Panel();
            this.NickName = new System.Windows.Forms.Label();
            this.TimeZonePanel = new System.Windows.Forms.Panel();
            this.TimeZoneGetPanel = new System.Windows.Forms.Panel();
            this.TIMEZONE_GET = new System.Windows.Forms.Label();
            this.TimeZoneLabelPanel = new System.Windows.Forms.Panel();
            this.TimeZoneLabel = new System.Windows.Forms.Label();
            this.OrganizationPanel = new System.Windows.Forms.Panel();
            this.OrganizationGetPanel = new System.Windows.Forms.Panel();
            this.ORGANIZATION_GET = new System.Windows.Forms.Label();
            this.OrganizationLabelPanel = new System.Windows.Forms.Panel();
            this.OrganizationLabel = new System.Windows.Forms.Label();
            this.ControlsPanel.SuspendLayout();
            this.ExitButtonPanel.SuspendLayout();
            this.UserControlsPanel.SuspendLayout();
            this.UserNamePanel.SuspendLayout();
            this.UserInfoPanel.SuspendLayout();
            this.UserPhotoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.BasicPanel.SuspendLayout();
            this.BasicContentPanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.FullNamePanel.SuspendLayout();
            this.FullNameGetLabelPanel.SuspendLayout();
            this.FullNameLabelPanel.SuspendLayout();
            this.HeadPanel.SuspendLayout();
            this.NickNamePanel.SuspendLayout();
            this.NickNameGetPanel.SuspendLayout();
            this.NickNameLabelPanel.SuspendLayout();
            this.TimeZonePanel.SuspendLayout();
            this.TimeZoneGetPanel.SuspendLayout();
            this.TimeZoneLabelPanel.SuspendLayout();
            this.OrganizationPanel.SuspendLayout();
            this.OrganizationGetPanel.SuspendLayout();
            this.OrganizationLabelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ControlsPanel.Controls.Add(this.ExitButtonPanel);
            this.ControlsPanel.Controls.Add(this.StripPanel);
            this.ControlsPanel.Controls.Add(this.CalendarButton);
            this.ControlsPanel.Controls.Add(this.MessengerButton);
            this.ControlsPanel.Controls.Add(this.TasksButton);
            this.ControlsPanel.Controls.Add(this.UserControlsPanel);
            this.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlsPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlsPanel.MinimumSize = new System.Drawing.Size(205, 400);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(205, 441);
            this.ControlsPanel.TabIndex = 0;
            // 
            // ExitButtonPanel
            // 
            this.ExitButtonPanel.Controls.Add(this.ExitButton);
            this.ExitButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitButtonPanel.Location = new System.Drawing.Point(0, 385);
            this.ExitButtonPanel.Name = "ExitButtonPanel";
            this.ExitButtonPanel.Padding = new System.Windows.Forms.Padding(10);
            this.ExitButtonPanel.Size = new System.Drawing.Size(205, 56);
            this.ExitButtonPanel.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ExitButton.FlatAppearance.BorderSize = 2;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ExitButton.Location = new System.Drawing.Point(10, 10);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(185, 36);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Выход из аккаунта";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StripPanel
            // 
            this.StripPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.StripPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StripPanel.Location = new System.Drawing.Point(3, 76);
            this.StripPanel.Name = "StripPanel";
            this.StripPanel.Size = new System.Drawing.Size(2, 52);
            this.StripPanel.TabIndex = 0;
            // 
            // CalendarButton
            // 
            this.CalendarButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CalendarButton.FlatAppearance.BorderSize = 0;
            this.CalendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalendarButton.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalendarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CalendarButton.Location = new System.Drawing.Point(0, 170);
            this.CalendarButton.Name = "CalendarButton";
            this.CalendarButton.Size = new System.Drawing.Size(205, 50);
            this.CalendarButton.TabIndex = 4;
            this.CalendarButton.Text = "Календарь";
            this.CalendarButton.UseVisualStyleBackColor = true;
            this.CalendarButton.Click += new System.EventHandler(this.CalendarButton_Click);
            // 
            // MessengerButton
            // 
            this.MessengerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MessengerButton.FlatAppearance.BorderSize = 0;
            this.MessengerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessengerButton.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessengerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.MessengerButton.Location = new System.Drawing.Point(0, 120);
            this.MessengerButton.Name = "MessengerButton";
            this.MessengerButton.Size = new System.Drawing.Size(205, 50);
            this.MessengerButton.TabIndex = 3;
            this.MessengerButton.Text = "Мессенджер";
            this.MessengerButton.UseVisualStyleBackColor = true;
            this.MessengerButton.Click += new System.EventHandler(this.MessengerButton_Click);
            // 
            // TasksButton
            // 
            this.TasksButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TasksButton.FlatAppearance.BorderSize = 0;
            this.TasksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TasksButton.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TasksButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.TasksButton.Location = new System.Drawing.Point(0, 70);
            this.TasksButton.Name = "TasksButton";
            this.TasksButton.Size = new System.Drawing.Size(205, 50);
            this.TasksButton.TabIndex = 2;
            this.TasksButton.Text = "Задачи";
            this.TasksButton.UseVisualStyleBackColor = true;
            this.TasksButton.Click += new System.EventHandler(this.TasksButton_Click);
            // 
            // UserControlsPanel
            // 
            this.UserControlsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.UserControlsPanel.Controls.Add(this.UserNamePanel);
            this.UserControlsPanel.Controls.Add(this.UserInfoPanel);
            this.UserControlsPanel.Controls.Add(this.UserPhotoPanel);
            this.UserControlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserControlsPanel.Location = new System.Drawing.Point(0, 0);
            this.UserControlsPanel.Name = "UserControlsPanel";
            this.UserControlsPanel.Size = new System.Drawing.Size(205, 70);
            this.UserControlsPanel.TabIndex = 0;
            this.UserControlsPanel.Click += new System.EventHandler(this.UserControlsPanel_Click);
            this.UserControlsPanel.MouseEnter += new System.EventHandler(this.UserPanel_MouseEnter);
            this.UserControlsPanel.MouseLeave += new System.EventHandler(this.UserPanel_MouseLeave);
            // 
            // UserNamePanel
            // 
            this.UserNamePanel.Controls.Add(this.UsernameLabel);
            this.UserNamePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserNamePanel.Location = new System.Drawing.Point(70, 30);
            this.UserNamePanel.Name = "UserNamePanel";
            this.UserNamePanel.Padding = new System.Windows.Forms.Padding(3);
            this.UserNamePanel.Size = new System.Drawing.Size(135, 17);
            this.UserNamePanel.TabIndex = 3;
            this.UserNamePanel.Click += new System.EventHandler(this.UserControlsPanel_Click);
            this.UserNamePanel.MouseEnter += new System.EventHandler(this.UserPanel_MouseEnter);
            this.UserNamePanel.MouseLeave += new System.EventHandler(this.UserPanel_MouseLeave);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsernameLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UsernameLabel.Location = new System.Drawing.Point(3, 3);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(105, 15);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "USERNAME_GET";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UsernameLabel.Click += new System.EventHandler(this.UserControlsPanel_Click);
            this.UsernameLabel.MouseEnter += new System.EventHandler(this.UserPanel_MouseEnter);
            this.UsernameLabel.MouseLeave += new System.EventHandler(this.UserPanel_MouseLeave);
            // 
            // UserInfoPanel
            // 
            this.UserInfoPanel.Controls.Add(this.UserInfoLabel);
            this.UserInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserInfoPanel.Location = new System.Drawing.Point(70, 47);
            this.UserInfoPanel.Name = "UserInfoPanel";
            this.UserInfoPanel.Padding = new System.Windows.Forms.Padding(3);
            this.UserInfoPanel.Size = new System.Drawing.Size(135, 23);
            this.UserInfoPanel.TabIndex = 4;
            this.UserInfoPanel.Click += new System.EventHandler(this.UserControlsPanel_Click);
            this.UserInfoPanel.MouseEnter += new System.EventHandler(this.UserPanel_MouseEnter);
            this.UserInfoPanel.MouseLeave += new System.EventHandler(this.UserPanel_MouseLeave);
            // 
            // UserInfoLabel
            // 
            this.UserInfoLabel.AutoSize = true;
            this.UserInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserInfoLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserInfoLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.UserInfoLabel.Location = new System.Drawing.Point(3, 3);
            this.UserInfoLabel.Name = "UserInfoLabel";
            this.UserInfoLabel.Size = new System.Drawing.Size(85, 13);
            this.UserInfoLabel.TabIndex = 2;
            this.UserInfoLabel.Text = "USERINFO_GET";
            this.UserInfoLabel.Click += new System.EventHandler(this.UserControlsPanel_Click);
            this.UserInfoLabel.MouseEnter += new System.EventHandler(this.UserPanel_MouseEnter);
            this.UserInfoLabel.MouseLeave += new System.EventHandler(this.UserPanel_MouseLeave);
            // 
            // UserPhotoPanel
            // 
            this.UserPhotoPanel.Controls.Add(this.UserPictureBox);
            this.UserPhotoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.UserPhotoPanel.Location = new System.Drawing.Point(0, 0);
            this.UserPhotoPanel.Name = "UserPhotoPanel";
            this.UserPhotoPanel.Padding = new System.Windows.Forms.Padding(15);
            this.UserPhotoPanel.Size = new System.Drawing.Size(70, 70);
            this.UserPhotoPanel.TabIndex = 2;
            this.UserPhotoPanel.Click += new System.EventHandler(this.UserControlsPanel_Click);
            this.UserPhotoPanel.MouseEnter += new System.EventHandler(this.UserPanel_MouseEnter);
            this.UserPhotoPanel.MouseLeave += new System.EventHandler(this.UserPanel_MouseLeave);
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UserPictureBox.Image")));
            this.UserPictureBox.Location = new System.Drawing.Point(15, 15);
            this.UserPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(40, 40);
            this.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPictureBox.TabIndex = 0;
            this.UserPictureBox.TabStop = false;
            this.UserPictureBox.Click += new System.EventHandler(this.UserControlsPanel_Click);
            this.UserPictureBox.MouseEnter += new System.EventHandler(this.UserPanel_MouseEnter);
            this.UserPictureBox.MouseLeave += new System.EventHandler(this.UserPanel_MouseLeave);
            // 
            // LabelHead
            // 
            this.LabelHead.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelHead.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelHead.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelHead.Location = new System.Drawing.Point(15, 17);
            this.LabelHead.Name = "LabelHead";
            this.LabelHead.Size = new System.Drawing.Size(749, 38);
            this.LabelHead.TabIndex = 1;
            this.LabelHead.Text = "Профиль";
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.AutoScroll = true;
            this.TableLayoutPanel.AutoSize = true;
            this.TableLayoutPanel.ColumnCount = 3;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 681F));
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 4;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(779, 371);
            this.TableLayoutPanel.TabIndex = 1;
            this.TableLayoutPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TableLayoutPanel_MouseClick);
            this.TableLayoutPanel.Resize += new System.EventHandler(this.TableLayoutPanel_Resize);
            // 
            // BasicPanel
            // 
            this.BasicPanel.AutoSize = true;
            this.BasicPanel.Controls.Add(this.BasicContentPanel);
            this.BasicPanel.Controls.Add(this.HeadPanel);
            this.BasicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasicPanel.Location = new System.Drawing.Point(205, 0);
            this.BasicPanel.Name = "BasicPanel";
            this.BasicPanel.Size = new System.Drawing.Size(779, 441);
            this.BasicPanel.TabIndex = 3;
            // 
            // BasicContentPanel
            // 
            this.BasicContentPanel.Controls.Add(this.UserPanel);
            this.BasicContentPanel.Controls.Add(this.TableLayoutPanel);
            this.BasicContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasicContentPanel.Location = new System.Drawing.Point(0, 70);
            this.BasicContentPanel.Name = "BasicContentPanel";
            this.BasicContentPanel.Size = new System.Drawing.Size(779, 371);
            this.BasicContentPanel.TabIndex = 2;
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.TimeZonePanel);
            this.UserPanel.Controls.Add(this.OrganizationPanel);
            this.UserPanel.Controls.Add(this.NickNamePanel);
            this.UserPanel.Controls.Add(this.FullNamePanel);
            this.UserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserPanel.Location = new System.Drawing.Point(0, 0);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(779, 371);
            this.UserPanel.TabIndex = 0;
            this.UserPanel.Resize += new System.EventHandler(this.UserPanel_Resize);
            // 
            // FullNamePanel
            // 
            this.FullNamePanel.Controls.Add(this.FullNameGetLabelPanel);
            this.FullNamePanel.Controls.Add(this.FullNameLabelPanel);
            this.FullNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FullNamePanel.Location = new System.Drawing.Point(0, 0);
            this.FullNamePanel.Name = "FullNamePanel";
            this.FullNamePanel.Size = new System.Drawing.Size(779, 36);
            this.FullNamePanel.TabIndex = 2;
            // 
            // FullNameGetLabelPanel
            // 
            this.FullNameGetLabelPanel.Controls.Add(this.FULLNAME_GET);
            this.FullNameGetLabelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FullNameGetLabelPanel.Location = new System.Drawing.Point(55, 0);
            this.FullNameGetLabelPanel.Name = "FullNameGetLabelPanel";
            this.FullNameGetLabelPanel.Padding = new System.Windows.Forms.Padding(5);
            this.FullNameGetLabelPanel.Size = new System.Drawing.Size(724, 36);
            this.FullNameGetLabelPanel.TabIndex = 4;
            // 
            // FULLNAME_GET
            // 
            this.FULLNAME_GET.AutoSize = true;
            this.FULLNAME_GET.Font = new System.Drawing.Font("Roboto", 12.25F);
            this.FULLNAME_GET.ForeColor = System.Drawing.SystemColors.Control;
            this.FULLNAME_GET.Location = new System.Drawing.Point(5, 5);
            this.FULLNAME_GET.Name = "FULLNAME_GET";
            this.FULLNAME_GET.Size = new System.Drawing.Size(135, 20);
            this.FULLNAME_GET.TabIndex = 1;
            this.FULLNAME_GET.Text = "FULLNAME_GET";
            // 
            // FullNameLabelPanel
            // 
            this.FullNameLabelPanel.Controls.Add(this.FullName);
            this.FullNameLabelPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FullNameLabelPanel.Location = new System.Drawing.Point(0, 0);
            this.FullNameLabelPanel.Name = "FullNameLabelPanel";
            this.FullNameLabelPanel.Padding = new System.Windows.Forms.Padding(5);
            this.FullNameLabelPanel.Size = new System.Drawing.Size(55, 36);
            this.FullNameLabelPanel.TabIndex = 3;
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FullName.Font = new System.Drawing.Font("Roboto", 12.25F, System.Drawing.FontStyle.Bold);
            this.FullName.ForeColor = System.Drawing.SystemColors.Control;
            this.FullName.Location = new System.Drawing.Point(5, 5);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(47, 20);
            this.FullName.TabIndex = 0;
            this.FullName.Text = "ФИО";
            // 
            // HeadPanel
            // 
            this.HeadPanel.Controls.Add(this.LabelHead);
            this.HeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadPanel.MinimumSize = new System.Drawing.Size(779, 70);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Padding = new System.Windows.Forms.Padding(15);
            this.HeadPanel.Size = new System.Drawing.Size(779, 70);
            this.HeadPanel.TabIndex = 3;
            // 
            // NickNamePanel
            // 
            this.NickNamePanel.Controls.Add(this.NickNameGetPanel);
            this.NickNamePanel.Controls.Add(this.NickNameLabelPanel);
            this.NickNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NickNamePanel.Location = new System.Drawing.Point(0, 36);
            this.NickNamePanel.Name = "NickNamePanel";
            this.NickNamePanel.Size = new System.Drawing.Size(779, 36);
            this.NickNamePanel.TabIndex = 3;
            // 
            // NickNameGetPanel
            // 
            this.NickNameGetPanel.Controls.Add(this.NICKNAME_GET);
            this.NickNameGetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NickNameGetPanel.Location = new System.Drawing.Point(154, 0);
            this.NickNameGetPanel.Name = "NickNameGetPanel";
            this.NickNameGetPanel.Padding = new System.Windows.Forms.Padding(3);
            this.NickNameGetPanel.Size = new System.Drawing.Size(625, 36);
            this.NickNameGetPanel.TabIndex = 4;
            // 
            // NICKNAME_GET
            // 
            this.NICKNAME_GET.AutoSize = true;
            this.NICKNAME_GET.Font = new System.Drawing.Font("Roboto", 12.25F);
            this.NICKNAME_GET.ForeColor = System.Drawing.SystemColors.Control;
            this.NICKNAME_GET.Location = new System.Drawing.Point(3, 3);
            this.NICKNAME_GET.Name = "NICKNAME_GET";
            this.NICKNAME_GET.Size = new System.Drawing.Size(136, 20);
            this.NICKNAME_GET.TabIndex = 1;
            this.NICKNAME_GET.Text = "NICKNAME_GET";
            // 
            // NickNameLabelPanel
            // 
            this.NickNameLabelPanel.Controls.Add(this.NickName);
            this.NickNameLabelPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NickNameLabelPanel.Location = new System.Drawing.Point(0, 0);
            this.NickNameLabelPanel.Name = "NickNameLabelPanel";
            this.NickNameLabelPanel.Padding = new System.Windows.Forms.Padding(3);
            this.NickNameLabelPanel.Size = new System.Drawing.Size(154, 36);
            this.NickNameLabelPanel.TabIndex = 3;
            // 
            // NickName
            // 
            this.NickName.AutoSize = true;
            this.NickName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NickName.Font = new System.Drawing.Font("Roboto", 12.25F, System.Drawing.FontStyle.Bold);
            this.NickName.ForeColor = System.Drawing.SystemColors.Control;
            this.NickName.Location = new System.Drawing.Point(3, 3);
            this.NickName.Name = "NickName";
            this.NickName.Size = new System.Drawing.Size(144, 20);
            this.NickName.TabIndex = 0;
            this.NickName.Text = "Никнейм / логин";
            // 
            // TimeZonePanel
            // 
            this.TimeZonePanel.Controls.Add(this.TimeZoneGetPanel);
            this.TimeZonePanel.Controls.Add(this.TimeZoneLabelPanel);
            this.TimeZonePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimeZonePanel.Location = new System.Drawing.Point(0, 108);
            this.TimeZonePanel.Name = "TimeZonePanel";
            this.TimeZonePanel.Size = new System.Drawing.Size(779, 36);
            this.TimeZonePanel.TabIndex = 4;
            // 
            // TimeZoneGetPanel
            // 
            this.TimeZoneGetPanel.Controls.Add(this.TIMEZONE_GET);
            this.TimeZoneGetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeZoneGetPanel.Location = new System.Drawing.Point(154, 0);
            this.TimeZoneGetPanel.Name = "TimeZoneGetPanel";
            this.TimeZoneGetPanel.Padding = new System.Windows.Forms.Padding(3);
            this.TimeZoneGetPanel.Size = new System.Drawing.Size(625, 36);
            this.TimeZoneGetPanel.TabIndex = 4;
            // 
            // TIMEZONE_GET
            // 
            this.TIMEZONE_GET.AutoSize = true;
            this.TIMEZONE_GET.Font = new System.Drawing.Font("Roboto", 12.25F);
            this.TIMEZONE_GET.ForeColor = System.Drawing.SystemColors.Control;
            this.TIMEZONE_GET.Location = new System.Drawing.Point(3, 3);
            this.TIMEZONE_GET.Name = "TIMEZONE_GET";
            this.TIMEZONE_GET.Size = new System.Drawing.Size(133, 20);
            this.TIMEZONE_GET.TabIndex = 1;
            this.TIMEZONE_GET.Text = "TIMEZONE_GET";
            // 
            // TimeZoneLabelPanel
            // 
            this.TimeZoneLabelPanel.Controls.Add(this.TimeZoneLabel);
            this.TimeZoneLabelPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TimeZoneLabelPanel.Location = new System.Drawing.Point(0, 0);
            this.TimeZoneLabelPanel.Name = "TimeZoneLabelPanel";
            this.TimeZoneLabelPanel.Padding = new System.Windows.Forms.Padding(3);
            this.TimeZoneLabelPanel.Size = new System.Drawing.Size(154, 36);
            this.TimeZoneLabelPanel.TabIndex = 3;
            // 
            // TimeZoneLabel
            // 
            this.TimeZoneLabel.AutoSize = true;
            this.TimeZoneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeZoneLabel.Font = new System.Drawing.Font("Roboto", 12.25F, System.Drawing.FontStyle.Bold);
            this.TimeZoneLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TimeZoneLabel.Location = new System.Drawing.Point(3, 3);
            this.TimeZoneLabel.Name = "TimeZoneLabel";
            this.TimeZoneLabel.Size = new System.Drawing.Size(142, 20);
            this.TimeZoneLabel.TabIndex = 0;
            this.TimeZoneLabel.Text = "Временная зона";
            // 
            // OrganizationPanel
            // 
            this.OrganizationPanel.Controls.Add(this.OrganizationGetPanel);
            this.OrganizationPanel.Controls.Add(this.OrganizationLabelPanel);
            this.OrganizationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrganizationPanel.Location = new System.Drawing.Point(0, 72);
            this.OrganizationPanel.Name = "OrganizationPanel";
            this.OrganizationPanel.Size = new System.Drawing.Size(779, 36);
            this.OrganizationPanel.TabIndex = 5;
            // 
            // OrganizationGetPanel
            // 
            this.OrganizationGetPanel.Controls.Add(this.ORGANIZATION_GET);
            this.OrganizationGetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrganizationGetPanel.Location = new System.Drawing.Point(126, 0);
            this.OrganizationGetPanel.Name = "OrganizationGetPanel";
            this.OrganizationGetPanel.Padding = new System.Windows.Forms.Padding(3);
            this.OrganizationGetPanel.Size = new System.Drawing.Size(653, 36);
            this.OrganizationGetPanel.TabIndex = 4;
            // 
            // ORGANIZATION_GET
            // 
            this.ORGANIZATION_GET.AutoSize = true;
            this.ORGANIZATION_GET.Font = new System.Drawing.Font("Roboto", 12.25F);
            this.ORGANIZATION_GET.ForeColor = System.Drawing.SystemColors.Control;
            this.ORGANIZATION_GET.Location = new System.Drawing.Point(3, 3);
            this.ORGANIZATION_GET.Name = "ORGANIZATION_GET";
            this.ORGANIZATION_GET.Size = new System.Drawing.Size(170, 20);
            this.ORGANIZATION_GET.TabIndex = 1;
            this.ORGANIZATION_GET.Text = "ORGANIZATION_GET";
            // 
            // OrganizationLabelPanel
            // 
            this.OrganizationLabelPanel.Controls.Add(this.OrganizationLabel);
            this.OrganizationLabelPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.OrganizationLabelPanel.Location = new System.Drawing.Point(0, 0);
            this.OrganizationLabelPanel.Name = "OrganizationLabelPanel";
            this.OrganizationLabelPanel.Padding = new System.Windows.Forms.Padding(3);
            this.OrganizationLabelPanel.Size = new System.Drawing.Size(126, 36);
            this.OrganizationLabelPanel.TabIndex = 3;
            // 
            // OrganizationLabel
            // 
            this.OrganizationLabel.AutoSize = true;
            this.OrganizationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrganizationLabel.Font = new System.Drawing.Font("Roboto", 12.25F, System.Drawing.FontStyle.Bold);
            this.OrganizationLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.OrganizationLabel.Location = new System.Drawing.Point(3, 3);
            this.OrganizationLabel.Name = "OrganizationLabel";
            this.OrganizationLabel.Size = new System.Drawing.Size(115, 20);
            this.OrganizationLabel.TabIndex = 0;
            this.OrganizationLabel.Text = "Организация";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(984, 441);
            this.Controls.Add(this.BasicPanel);
            this.Controls.Add(this.ControlsPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Канбан-доска";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ControlsPanel.ResumeLayout(false);
            this.ExitButtonPanel.ResumeLayout(false);
            this.UserControlsPanel.ResumeLayout(false);
            this.UserNamePanel.ResumeLayout(false);
            this.UserNamePanel.PerformLayout();
            this.UserInfoPanel.ResumeLayout(false);
            this.UserInfoPanel.PerformLayout();
            this.UserPhotoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            this.BasicPanel.ResumeLayout(false);
            this.BasicContentPanel.ResumeLayout(false);
            this.BasicContentPanel.PerformLayout();
            this.UserPanel.ResumeLayout(false);
            this.FullNamePanel.ResumeLayout(false);
            this.FullNameGetLabelPanel.ResumeLayout(false);
            this.FullNameGetLabelPanel.PerformLayout();
            this.FullNameLabelPanel.ResumeLayout(false);
            this.FullNameLabelPanel.PerformLayout();
            this.HeadPanel.ResumeLayout(false);
            this.NickNamePanel.ResumeLayout(false);
            this.NickNameGetPanel.ResumeLayout(false);
            this.NickNameGetPanel.PerformLayout();
            this.NickNameLabelPanel.ResumeLayout(false);
            this.NickNameLabelPanel.PerformLayout();
            this.TimeZonePanel.ResumeLayout(false);
            this.TimeZoneGetPanel.ResumeLayout(false);
            this.TimeZoneGetPanel.PerformLayout();
            this.TimeZoneLabelPanel.ResumeLayout(false);
            this.TimeZoneLabelPanel.PerformLayout();
            this.OrganizationPanel.ResumeLayout(false);
            this.OrganizationGetPanel.ResumeLayout(false);
            this.OrganizationGetPanel.PerformLayout();
            this.OrganizationLabelPanel.ResumeLayout(false);
            this.OrganizationLabelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ControlsPanel;
        private System.Windows.Forms.Panel UserControlsPanel;
        private System.Windows.Forms.Button TasksButton;
        private System.Windows.Forms.Button CalendarButton;
        private System.Windows.Forms.Button MessengerButton;
        private System.Windows.Forms.PictureBox UserPictureBox;
        private System.Windows.Forms.Label UserInfoLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label LabelHead;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel StripPanel;
        private System.Windows.Forms.Panel BasicPanel;
        private System.Windows.Forms.Panel UserPhotoPanel;
        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.Panel ExitButtonPanel;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Panel BasicContentPanel;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Panel UserInfoPanel;
        private System.Windows.Forms.Panel UserNamePanel;
        private System.Windows.Forms.Label FULLNAME_GET;
        private System.Windows.Forms.Panel FullNamePanel;
        private System.Windows.Forms.Panel FullNameGetLabelPanel;
        private System.Windows.Forms.Panel FullNameLabelPanel;
        private System.Windows.Forms.Panel NickNamePanel;
        private System.Windows.Forms.Panel NickNameGetPanel;
        private System.Windows.Forms.Label NICKNAME_GET;
        private System.Windows.Forms.Panel NickNameLabelPanel;
        private System.Windows.Forms.Label NickName;
        private System.Windows.Forms.Panel TimeZonePanel;
        private System.Windows.Forms.Panel TimeZoneGetPanel;
        private System.Windows.Forms.Label TIMEZONE_GET;
        private System.Windows.Forms.Panel TimeZoneLabelPanel;
        private System.Windows.Forms.Label TimeZoneLabel;
        private System.Windows.Forms.Panel OrganizationPanel;
        private System.Windows.Forms.Panel OrganizationGetPanel;
        private System.Windows.Forms.Label ORGANIZATION_GET;
        private System.Windows.Forms.Panel OrganizationLabelPanel;
        private System.Windows.Forms.Label OrganizationLabel;
    }
}

