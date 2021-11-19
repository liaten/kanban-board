
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UserInfoLabel = new System.Windows.Forms.Label();
            this.UserPhotoPanel = new System.Windows.Forms.Panel();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.LabelHead = new System.Windows.Forms.Label();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BasicPanel = new System.Windows.Forms.Panel();
            this.BasicContentPanel = new System.Windows.Forms.Panel();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.UserLabel = new System.Windows.Forms.Label();
            this.TicketsChangePanel = new System.Windows.Forms.Panel();
            this.ChangingPanel = new System.Windows.Forms.Panel();
            this.ChangingTicketTextBox = new System.Windows.Forms.TextBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangingPeopleTextBox = new System.Windows.Forms.TextBox();
            this.ChangingTitleTextBox = new System.Windows.Forms.TextBox();
            this.CalendarPanel = new System.Windows.Forms.Panel();
            this.CalendarLabel = new System.Windows.Forms.Label();
            this.DialogPanel = new System.Windows.Forms.Panel();
            this.DialogNamesPanel = new System.Windows.Forms.Panel();
            this.DialogSearchPanel = new System.Windows.Forms.Panel();
            this.DialogSearchTextBox = new System.Windows.Forms.TextBox();
            this.DialogSearchTitlePanel = new System.Windows.Forms.Panel();
            this.DialogSearchTitleLabel = new System.Windows.Forms.Label();
            this.DialogMainPanel = new System.Windows.Forms.Panel();
            this.DialogTitlePanel = new System.Windows.Forms.Panel();
            this.DialogTitleLabel = new System.Windows.Forms.Label();
            this.MessageMainPanel = new System.Windows.Forms.Panel();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SendMessageButtonPanel = new System.Windows.Forms.Panel();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.ControlsPanel.SuspendLayout();
            this.ExitButtonPanel.SuspendLayout();
            this.UserControlsPanel.SuspendLayout();
            this.UserPhotoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.BasicPanel.SuspendLayout();
            this.BasicContentPanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.TicketsChangePanel.SuspendLayout();
            this.ChangingPanel.SuspendLayout();
            this.CalendarPanel.SuspendLayout();
            this.DialogPanel.SuspendLayout();
            this.DialogNamesPanel.SuspendLayout();
            this.DialogSearchPanel.SuspendLayout();
            this.DialogSearchTitlePanel.SuspendLayout();
            this.DialogMainPanel.SuspendLayout();
            this.DialogTitlePanel.SuspendLayout();
            this.MessageMainPanel.SuspendLayout();
            this.MessagePanel.SuspendLayout();
            this.SendMessageButtonPanel.SuspendLayout();
            this.HeadPanel.SuspendLayout();
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
            this.ControlsPanel.MinimumSize = new System.Drawing.Size(205, 450);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(205, 565);
            this.ControlsPanel.TabIndex = 0;
            // 
            // ExitButtonPanel
            // 
            this.ExitButtonPanel.Controls.Add(this.ExitButton);
            this.ExitButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitButtonPanel.Location = new System.Drawing.Point(0, 509);
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
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.StripPanel.Location = new System.Drawing.Point(0, 70);
            this.StripPanel.Name = "StripPanel";
            this.StripPanel.Size = new System.Drawing.Size(2, 50);
            this.StripPanel.TabIndex = 0;
            // 
            // CalendarButton
            // 
            this.CalendarButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CalendarButton.FlatAppearance.BorderSize = 0;
            this.CalendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalendarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.MessengerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.TasksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.UserControlsPanel.Controls.Add(this.UsernameLabel);
            this.UserControlsPanel.Controls.Add(this.UserInfoLabel);
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
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UsernameLabel.Location = new System.Drawing.Point(87, 14);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(79, 16);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // UserInfoLabel
            // 
            this.UserInfoLabel.AutoSize = true;
            this.UserInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserInfoLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.UserInfoLabel.Location = new System.Drawing.Point(87, 40);
            this.UserInfoLabel.Name = "UserInfoLabel";
            this.UserInfoLabel.Size = new System.Drawing.Size(53, 13);
            this.UserInfoLabel.TabIndex = 2;
            this.UserInfoLabel.Text = "User_Info";
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
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserPictureBox.Image = global::kanbanboard.Properties.Resources.user;
            this.UserPictureBox.Location = new System.Drawing.Point(15, 15);
            this.UserPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(40, 40);
            this.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPictureBox.TabIndex = 0;
            this.UserPictureBox.TabStop = false;
            // 
            // LabelHead
            // 
            this.LabelHead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHead.AutoSize = true;
            this.LabelHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelHead.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelHead.Location = new System.Drawing.Point(28, 17);
            this.LabelHead.Name = "LabelHead";
            this.LabelHead.Size = new System.Drawing.Size(150, 37);
            this.LabelHead.TabIndex = 1;
            this.LabelHead.Text = "Профиль";
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.AutoScroll = true;
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
            this.TableLayoutPanel.Size = new System.Drawing.Size(979, 495);
            this.TableLayoutPanel.TabIndex = 1;
            this.TableLayoutPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.TableLayoutPanel_DragDrop);
            this.TableLayoutPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.TableLayoutPanel_DragEnter);
            this.TableLayoutPanel.DragLeave += new System.EventHandler(this.TableLayoutPanel_DragLeave);
            this.TableLayoutPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TableLayoutPanel_MouseClick);
            // 
            // BasicPanel
            // 
            this.BasicPanel.AutoSize = true;
            this.BasicPanel.Controls.Add(this.BasicContentPanel);
            this.BasicPanel.Controls.Add(this.HeadPanel);
            this.BasicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasicPanel.Location = new System.Drawing.Point(205, 0);
            this.BasicPanel.Name = "BasicPanel";
            this.BasicPanel.Size = new System.Drawing.Size(979, 565);
            this.BasicPanel.TabIndex = 3;
            // 
            // BasicContentPanel
            // 
            this.BasicContentPanel.Controls.Add(this.TableLayoutPanel);
            this.BasicContentPanel.Controls.Add(this.UserPanel);
            this.BasicContentPanel.Controls.Add(this.TicketsChangePanel);
            this.BasicContentPanel.Controls.Add(this.CalendarPanel);
            this.BasicContentPanel.Controls.Add(this.DialogPanel);
            this.BasicContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasicContentPanel.Location = new System.Drawing.Point(0, 70);
            this.BasicContentPanel.Name = "BasicContentPanel";
            this.BasicContentPanel.Size = new System.Drawing.Size(979, 495);
            this.BasicContentPanel.TabIndex = 2;
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.UserLabel);
            this.UserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserPanel.Location = new System.Drawing.Point(0, 0);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(979, 495);
            this.UserPanel.TabIndex = 0;
            this.UserPanel.Resize += new System.EventHandler(this.UserPanel_Resize);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UserLabel.Location = new System.Drawing.Point(245, 169);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(292, 42);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "Текст профиля";
            // 
            // TicketsChangePanel
            // 
            this.TicketsChangePanel.Controls.Add(this.ChangingPanel);
            this.TicketsChangePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketsChangePanel.Location = new System.Drawing.Point(0, 0);
            this.TicketsChangePanel.Name = "TicketsChangePanel";
            this.TicketsChangePanel.Size = new System.Drawing.Size(979, 495);
            this.TicketsChangePanel.TabIndex = 1;
            // 
            // ChangingPanel
            // 
            this.ChangingPanel.Controls.Add(this.ChangingTicketTextBox);
            this.ChangingPanel.Controls.Add(this.SaveChangesButton);
            this.ChangingPanel.Controls.Add(this.label3);
            this.ChangingPanel.Controls.Add(this.label2);
            this.ChangingPanel.Controls.Add(this.label1);
            this.ChangingPanel.Controls.Add(this.ChangingPeopleTextBox);
            this.ChangingPanel.Controls.Add(this.ChangingTitleTextBox);
            this.ChangingPanel.Location = new System.Drawing.Point(216, 23);
            this.ChangingPanel.Name = "ChangingPanel";
            this.ChangingPanel.Size = new System.Drawing.Size(351, 345);
            this.ChangingPanel.TabIndex = 0;
            // 
            // ChangingTicketTextBox
            // 
            this.ChangingTicketTextBox.Location = new System.Drawing.Point(57, 102);
            this.ChangingTicketTextBox.Multiline = true;
            this.ChangingTicketTextBox.Name = "ChangingTicketTextBox";
            this.ChangingTicketTextBox.Size = new System.Drawing.Size(236, 135);
            this.ChangingTicketTextBox.TabIndex = 7;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.FlatAppearance.BorderSize = 0;
            this.SaveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChangesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.SaveChangesButton.Location = new System.Drawing.Point(0, 309);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(348, 38);
            this.SaveChangesButton.TabIndex = 6;
            this.SaveChangesButton.Text = "Сохранить";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(70, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выполняющие";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(99, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Описание";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(97, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Заголовок";
            // 
            // ChangingPeopleTextBox
            // 
            this.ChangingPeopleTextBox.Location = new System.Drawing.Point(57, 279);
            this.ChangingPeopleTextBox.Name = "ChangingPeopleTextBox";
            this.ChangingPeopleTextBox.Size = new System.Drawing.Size(236, 20);
            this.ChangingPeopleTextBox.TabIndex = 2;
            // 
            // ChangingTitleTextBox
            // 
            this.ChangingTitleTextBox.Location = new System.Drawing.Point(57, 33);
            this.ChangingTitleTextBox.Multiline = true;
            this.ChangingTitleTextBox.Name = "ChangingTitleTextBox";
            this.ChangingTitleTextBox.Size = new System.Drawing.Size(236, 34);
            this.ChangingTitleTextBox.TabIndex = 0;
            // 
            // CalendarPanel
            // 
            this.CalendarPanel.Controls.Add(this.CalendarLabel);
            this.CalendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalendarPanel.Location = new System.Drawing.Point(0, 0);
            this.CalendarPanel.Name = "CalendarPanel";
            this.CalendarPanel.Size = new System.Drawing.Size(979, 495);
            this.CalendarPanel.TabIndex = 1;
            this.CalendarPanel.Resize += new System.EventHandler(this.CalendarPanel_Resize);
            // 
            // CalendarLabel
            // 
            this.CalendarLabel.AutoSize = true;
            this.CalendarLabel.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalendarLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CalendarLabel.Location = new System.Drawing.Point(28, 148);
            this.CalendarLabel.MaximumSize = new System.Drawing.Size(800, 480);
            this.CalendarLabel.Name = "CalendarLabel";
            this.CalendarLabel.Size = new System.Drawing.Size(726, 84);
            this.CalendarLabel.TabIndex = 1;
            this.CalendarLabel.Text = "Здесь должен быть календарь, но его пока что нет.";
            // 
            // DialogPanel
            // 
            this.DialogPanel.Controls.Add(this.DialogNamesPanel);
            this.DialogPanel.Controls.Add(this.DialogMainPanel);
            this.DialogPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DialogPanel.Location = new System.Drawing.Point(0, 0);
            this.DialogPanel.Name = "DialogPanel";
            this.DialogPanel.Size = new System.Drawing.Size(979, 495);
            this.DialogPanel.TabIndex = 1;
            // 
            // DialogNamesPanel
            // 
            this.DialogNamesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(63)))));
            this.DialogNamesPanel.Controls.Add(this.DialogSearchPanel);
            this.DialogNamesPanel.Controls.Add(this.DialogSearchTitlePanel);
            this.DialogNamesPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DialogNamesPanel.Location = new System.Drawing.Point(0, 0);
            this.DialogNamesPanel.Name = "DialogNamesPanel";
            this.DialogNamesPanel.Size = new System.Drawing.Size(221, 495);
            this.DialogNamesPanel.TabIndex = 4;
            // 
            // DialogSearchPanel
            // 
            this.DialogSearchPanel.Controls.Add(this.DialogSearchTextBox);
            this.DialogSearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DialogSearchPanel.Location = new System.Drawing.Point(0, 52);
            this.DialogSearchPanel.Name = "DialogSearchPanel";
            this.DialogSearchPanel.Padding = new System.Windows.Forms.Padding(15);
            this.DialogSearchPanel.Size = new System.Drawing.Size(221, 57);
            this.DialogSearchPanel.TabIndex = 5;
            // 
            // DialogSearchTextBox
            // 
            this.DialogSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DialogSearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.DialogSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DialogSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DialogSearchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.DialogSearchTextBox.Location = new System.Drawing.Point(15, 18);
            this.DialogSearchTextBox.Name = "DialogSearchTextBox";
            this.DialogSearchTextBox.Size = new System.Drawing.Size(191, 20);
            this.DialogSearchTextBox.TabIndex = 0;
            // 
            // DialogSearchTitlePanel
            // 
            this.DialogSearchTitlePanel.Controls.Add(this.DialogSearchTitleLabel);
            this.DialogSearchTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DialogSearchTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.DialogSearchTitlePanel.Name = "DialogSearchTitlePanel";
            this.DialogSearchTitlePanel.Padding = new System.Windows.Forms.Padding(15);
            this.DialogSearchTitlePanel.Size = new System.Drawing.Size(221, 52);
            this.DialogSearchTitlePanel.TabIndex = 5;
            // 
            // DialogSearchTitleLabel
            // 
            this.DialogSearchTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DialogSearchTitleLabel.AutoSize = true;
            this.DialogSearchTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DialogSearchTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.DialogSearchTitleLabel.Location = new System.Drawing.Point(43, 18);
            this.DialogSearchTitleLabel.Name = "DialogSearchTitleLabel";
            this.DialogSearchTitleLabel.Size = new System.Drawing.Size(135, 16);
            this.DialogSearchTitleLabel.TabIndex = 1;
            this.DialogSearchTitleLabel.Text = "Поиск по именам";
            this.DialogSearchTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DialogMainPanel
            // 
            this.DialogMainPanel.AutoSize = true;
            this.DialogMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DialogMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(63)))));
            this.DialogMainPanel.Controls.Add(this.DialogTitlePanel);
            this.DialogMainPanel.Controls.Add(this.MessageMainPanel);
            this.DialogMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DialogMainPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DialogMainPanel.Location = new System.Drawing.Point(0, 0);
            this.DialogMainPanel.Name = "DialogMainPanel";
            this.DialogMainPanel.Size = new System.Drawing.Size(979, 495);
            this.DialogMainPanel.TabIndex = 5;
            // 
            // DialogTitlePanel
            // 
            this.DialogTitlePanel.Controls.Add(this.DialogTitleLabel);
            this.DialogTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DialogTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.DialogTitlePanel.Name = "DialogTitlePanel";
            this.DialogTitlePanel.Padding = new System.Windows.Forms.Padding(15);
            this.DialogTitlePanel.Size = new System.Drawing.Size(979, 52);
            this.DialogTitlePanel.TabIndex = 4;
            // 
            // DialogTitleLabel
            // 
            this.DialogTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DialogTitleLabel.AutoSize = true;
            this.DialogTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DialogTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.DialogTitleLabel.Location = new System.Drawing.Point(15, 18);
            this.DialogTitleLabel.Name = "DialogTitleLabel";
            this.DialogTitleLabel.Size = new System.Drawing.Size(129, 16);
            this.DialogTitleLabel.TabIndex = 2;
            this.DialogTitleLabel.Text = "Dialog Username";
            // 
            // MessageMainPanel
            // 
            this.MessageMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(63)))));
            this.MessageMainPanel.Controls.Add(this.MessagePanel);
            this.MessageMainPanel.Controls.Add(this.SendMessageButtonPanel);
            this.MessageMainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MessageMainPanel.Location = new System.Drawing.Point(0, 412);
            this.MessageMainPanel.Name = "MessageMainPanel";
            this.MessageMainPanel.Size = new System.Drawing.Size(979, 83);
            this.MessageMainPanel.TabIndex = 3;
            // 
            // MessagePanel
            // 
            this.MessagePanel.Controls.Add(this.MessageTextBox);
            this.MessagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagePanel.Location = new System.Drawing.Point(0, 0);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Padding = new System.Windows.Forms.Padding(15);
            this.MessagePanel.Size = new System.Drawing.Size(891, 83);
            this.MessagePanel.TabIndex = 1;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.MessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.MessageTextBox.Location = new System.Drawing.Point(15, 15);
            this.MessageTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(861, 53);
            this.MessageTextBox.TabIndex = 2;
            // 
            // SendMessageButtonPanel
            // 
            this.SendMessageButtonPanel.Controls.Add(this.SendMessageButton);
            this.SendMessageButtonPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SendMessageButtonPanel.Location = new System.Drawing.Point(891, 0);
            this.SendMessageButtonPanel.Name = "SendMessageButtonPanel";
            this.SendMessageButtonPanel.Size = new System.Drawing.Size(88, 83);
            this.SendMessageButtonPanel.TabIndex = 0;
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.AutoSize = true;
            this.SendMessageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendMessageButton.FlatAppearance.BorderSize = 0;
            this.SendMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendMessageButton.Image = global::kanbanboard.Properties.Resources.send_message__1_;
            this.SendMessageButton.Location = new System.Drawing.Point(0, 0);
            this.SendMessageButton.Margin = new System.Windows.Forms.Padding(10);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(88, 83);
            this.SendMessageButton.TabIndex = 3;
            this.SendMessageButton.UseVisualStyleBackColor = true;
            // 
            // HeadPanel
            // 
            this.HeadPanel.Controls.Add(this.LabelHead);
            this.HeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(979, 70);
            this.HeadPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1184, 565);
            this.Controls.Add(this.BasicPanel);
            this.Controls.Add(this.ControlsPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Канбан-доска";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ControlsPanel.ResumeLayout(false);
            this.ExitButtonPanel.ResumeLayout(false);
            this.UserControlsPanel.ResumeLayout(false);
            this.UserControlsPanel.PerformLayout();
            this.UserPhotoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            this.BasicPanel.ResumeLayout(false);
            this.BasicContentPanel.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            this.TicketsChangePanel.ResumeLayout(false);
            this.ChangingPanel.ResumeLayout(false);
            this.ChangingPanel.PerformLayout();
            this.CalendarPanel.ResumeLayout(false);
            this.CalendarPanel.PerformLayout();
            this.DialogPanel.ResumeLayout(false);
            this.DialogPanel.PerformLayout();
            this.DialogNamesPanel.ResumeLayout(false);
            this.DialogSearchPanel.ResumeLayout(false);
            this.DialogSearchPanel.PerformLayout();
            this.DialogSearchTitlePanel.ResumeLayout(false);
            this.DialogSearchTitlePanel.PerformLayout();
            this.DialogMainPanel.ResumeLayout(false);
            this.DialogTitlePanel.ResumeLayout(false);
            this.DialogTitlePanel.PerformLayout();
            this.MessageMainPanel.ResumeLayout(false);
            this.MessagePanel.ResumeLayout(false);
            this.MessagePanel.PerformLayout();
            this.SendMessageButtonPanel.ResumeLayout(false);
            this.SendMessageButtonPanel.PerformLayout();
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
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
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Panel DialogPanel;
        private System.Windows.Forms.Panel DialogNamesPanel;
        private System.Windows.Forms.Panel DialogSearchPanel;
        private System.Windows.Forms.TextBox DialogSearchTextBox;
        private System.Windows.Forms.Panel DialogSearchTitlePanel;
        private System.Windows.Forms.Label DialogSearchTitleLabel;
        private System.Windows.Forms.Panel DialogMainPanel;
        private System.Windows.Forms.Panel DialogTitlePanel;
        private System.Windows.Forms.Label DialogTitleLabel;
        private System.Windows.Forms.Panel MessageMainPanel;
        private System.Windows.Forms.Panel MessagePanel;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Panel SendMessageButtonPanel;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.Panel CalendarPanel;
        private System.Windows.Forms.Label CalendarLabel;
        private System.Windows.Forms.Panel TicketsChangePanel;
        private System.Windows.Forms.Panel ChangingPanel;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ChangingPeopleTextBox;
        private System.Windows.Forms.TextBox ChangingTitleTextBox;
        private System.Windows.Forms.TextBox ChangingTicketTextBox;
    }
}

