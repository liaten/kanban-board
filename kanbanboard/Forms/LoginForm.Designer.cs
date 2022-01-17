
using System.ComponentModel;
using System.Windows.Forms;

namespace kanbanboard.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.LoginPasswordMailPanel = new System.Windows.Forms.Panel();
            this.PanelOfTextBoxes = new System.Windows.Forms.Panel();
            this.PasswordTextBoxPanel = new System.Windows.Forms.Panel();
            this.LoginTextBoxPanel = new System.Windows.Forms.Panel();
            this.LabelsPanel = new System.Windows.Forms.Panel();
            this.PasswordLabelPanel = new System.Windows.Forms.Panel();
            this.loginLabelPanel = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PanelOfCheckBoxes = new System.Windows.Forms.Panel();
            this.checkPass = new System.Windows.Forms.CheckBox();
            this.PanelOfButtons = new System.Windows.Forms.Panel();
            this.RegButtonPanel = new System.Windows.Forms.Panel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLabelPanel = new System.Windows.Forms.Panel();
            this.AuthorizationLabel = new System.Windows.Forms.Label();
            this.AuthorizationPictureBox = new System.Windows.Forms.PictureBox();
            this.RegPanel = new System.Windows.Forms.Panel();
            this.RegButtonsPanel = new System.Windows.Forms.Panel();
            this.RegOfRegPanel = new System.Windows.Forms.Panel();
            this.RegOfRegButton = new System.Windows.Forms.Button();
            this.RegBackPanel = new System.Windows.Forms.Panel();
            this.RegOfRegBackButton = new System.Windows.Forms.Button();
            this.OrgPanel = new System.Windows.Forms.Panel();
            this.OrgLabel = new System.Windows.Forms.Label();
            this.OrgTextBox = new System.Windows.Forms.TextBox();
            this.TimeZonePanel = new System.Windows.Forms.Panel();
            this.TimeZoneCB = new System.Windows.Forms.ComboBox();
            this.TimeZoneLabel = new System.Windows.Forms.Label();
            this.FullNamePanel = new System.Windows.Forms.Panel();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.ProjectsPanel = new System.Windows.Forms.Panel();
            this.RegProjectsLabel = new System.Windows.Forms.Label();
            this.RegProjectsTextBox = new System.Windows.Forms.TextBox();
            this.RolePanel = new System.Windows.Forms.Panel();
            this.RegRoleComboBox = new System.Windows.Forms.ComboBox();
            this.RegRoleLabel = new System.Windows.Forms.Label();
            this.RegPasswordPanel = new System.Windows.Forms.Panel();
            this.RegPasswordLabel = new System.Windows.Forms.Label();
            this.RegPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RegEmailPanel = new System.Windows.Forms.Panel();
            this.RegEmailLabel = new System.Windows.Forms.Label();
            this.RegEmailTextBox = new System.Windows.Forms.TextBox();
            this.RegLoginPanel = new System.Windows.Forms.Panel();
            this.RegLoginLabel = new System.Windows.Forms.Label();
            this.RegLoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginPasswordMailPanel.SuspendLayout();
            this.PanelOfTextBoxes.SuspendLayout();
            this.PasswordTextBoxPanel.SuspendLayout();
            this.LoginTextBoxPanel.SuspendLayout();
            this.LabelsPanel.SuspendLayout();
            this.PasswordLabelPanel.SuspendLayout();
            this.loginLabelPanel.SuspendLayout();
            this.PanelOfCheckBoxes.SuspendLayout();
            this.PanelOfButtons.SuspendLayout();
            this.RegButtonPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.HeaderLabelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorizationPictureBox)).BeginInit();
            this.RegPanel.SuspendLayout();
            this.RegButtonsPanel.SuspendLayout();
            this.RegOfRegPanel.SuspendLayout();
            this.RegBackPanel.SuspendLayout();
            this.OrgPanel.SuspendLayout();
            this.TimeZonePanel.SuspendLayout();
            this.FullNamePanel.SuspendLayout();
            this.ProjectsPanel.SuspendLayout();
            this.RolePanel.SuspendLayout();
            this.RegPasswordPanel.SuspendLayout();
            this.RegEmailPanel.SuspendLayout();
            this.RegLoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrationButton.BackColor = System.Drawing.Color.Transparent;
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.RegistrationButton.Location = new System.Drawing.Point(18, 11);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(137, 24);
            this.RegistrationButton.TabIndex = 2;
            this.RegistrationButton.Text = "Регистрация";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.textBoxLogin.Location = new System.Drawing.Point(15, 11);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(194, 17);
            this.textBoxLogin.TabIndex = 3;
            this.textBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLogin.MouseEnter += new System.EventHandler(this.TextBoxLogin_MouseEnter);
            this.textBoxLogin.MouseLeave += new System.EventHandler(this.TextBoxLogin_MouseLeave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.textBoxPassword.Location = new System.Drawing.Point(15, 9);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(194, 17);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.MouseEnter += new System.EventHandler(this.TextBoxPass_MouseEnter);
            this.textBoxPassword.MouseLeave += new System.EventHandler(this.TextBoxPass_MouseLeave);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.LoginLabel.Location = new System.Drawing.Point(15, 10);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(89, 16);
            this.LoginLabel.TabIndex = 6;
            this.LoginLabel.Text = "Логин | Email";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.PassLabel.Location = new System.Drawing.Point(15, 10);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(56, 16);
            this.PassLabel.TabIndex = 7;
            this.PassLabel.Text = "Пароль";
            this.PassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPasswordMailPanel
            // 
            this.LoginPasswordMailPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.LoginPasswordMailPanel.Controls.Add(this.PanelOfTextBoxes);
            this.LoginPasswordMailPanel.Controls.Add(this.LabelsPanel);
            this.LoginPasswordMailPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginPasswordMailPanel.Location = new System.Drawing.Point(0, 70);
            this.LoginPasswordMailPanel.Name = "LoginPasswordMailPanel";
            this.LoginPasswordMailPanel.Size = new System.Drawing.Size(334, 80);
            this.LoginPasswordMailPanel.TabIndex = 9;
            // 
            // PanelOfTextBoxes
            // 
            this.PanelOfTextBoxes.Controls.Add(this.PasswordTextBoxPanel);
            this.PanelOfTextBoxes.Controls.Add(this.LoginTextBoxPanel);
            this.PanelOfTextBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelOfTextBoxes.Location = new System.Drawing.Point(110, 0);
            this.PanelOfTextBoxes.Name = "PanelOfTextBoxes";
            this.PanelOfTextBoxes.Size = new System.Drawing.Size(224, 80);
            this.PanelOfTextBoxes.TabIndex = 1;
            // 
            // PasswordTextBoxPanel
            // 
            this.PasswordTextBoxPanel.Controls.Add(this.textBoxPassword);
            this.PasswordTextBoxPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PasswordTextBoxPanel.Location = new System.Drawing.Point(0, 40);
            this.PasswordTextBoxPanel.Name = "PasswordTextBoxPanel";
            this.PasswordTextBoxPanel.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.PasswordTextBoxPanel.Size = new System.Drawing.Size(224, 40);
            this.PasswordTextBoxPanel.TabIndex = 10;
            // 
            // LoginTextBoxPanel
            // 
            this.LoginTextBoxPanel.Controls.Add(this.textBoxLogin);
            this.LoginTextBoxPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginTextBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginTextBoxPanel.Name = "LoginTextBoxPanel";
            this.LoginTextBoxPanel.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.LoginTextBoxPanel.Size = new System.Drawing.Size(224, 40);
            this.LoginTextBoxPanel.TabIndex = 9;
            // 
            // LabelsPanel
            // 
            this.LabelsPanel.Controls.Add(this.PasswordLabelPanel);
            this.LabelsPanel.Controls.Add(this.loginLabelPanel);
            this.LabelsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelsPanel.Location = new System.Drawing.Point(0, 0);
            this.LabelsPanel.Name = "LabelsPanel";
            this.LabelsPanel.Size = new System.Drawing.Size(110, 80);
            this.LabelsPanel.TabIndex = 0;
            // 
            // PasswordLabelPanel
            // 
            this.PasswordLabelPanel.Controls.Add(this.PassLabel);
            this.PasswordLabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PasswordLabelPanel.Location = new System.Drawing.Point(0, 40);
            this.PasswordLabelPanel.Name = "PasswordLabelPanel";
            this.PasswordLabelPanel.Padding = new System.Windows.Forms.Padding(15, 10, 5, 5);
            this.PasswordLabelPanel.Size = new System.Drawing.Size(110, 40);
            this.PasswordLabelPanel.TabIndex = 11;
            // 
            // loginLabelPanel
            // 
            this.loginLabelPanel.Controls.Add(this.LoginLabel);
            this.loginLabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginLabelPanel.Location = new System.Drawing.Point(0, 0);
            this.loginLabelPanel.Name = "loginLabelPanel";
            this.loginLabelPanel.Padding = new System.Windows.Forms.Padding(15, 10, 5, 5);
            this.loginLabelPanel.Size = new System.Drawing.Size(110, 40);
            this.loginLabelPanel.TabIndex = 10;
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LoginButton.Location = new System.Drawing.Point(12, 11);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(0);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(137, 24);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PanelOfCheckBoxes
            // 
            this.PanelOfCheckBoxes.AutoSize = true;
            this.PanelOfCheckBoxes.Controls.Add(this.checkPass);
            this.PanelOfCheckBoxes.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelOfCheckBoxes.Location = new System.Drawing.Point(0, 150);
            this.PanelOfCheckBoxes.Name = "PanelOfCheckBoxes";
            this.PanelOfCheckBoxes.Size = new System.Drawing.Size(334, 35);
            this.PanelOfCheckBoxes.TabIndex = 12;
            // 
            // checkPass
            // 
            this.checkPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.checkPass.Location = new System.Drawing.Point(95, 8);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(136, 24);
            this.checkPass.TabIndex = 12;
            this.checkPass.Text = "Показать пароль";
            this.checkPass.UseVisualStyleBackColor = true;
            this.checkPass.CheckedChanged += new System.EventHandler(this.CheckPass_CheckedChanged);
            // 
            // PanelOfButtons
            // 
            this.PanelOfButtons.Controls.Add(this.RegButtonPanel);
            this.PanelOfButtons.Controls.Add(this.LoginPanel);
            this.PanelOfButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelOfButtons.Location = new System.Drawing.Point(0, 185);
            this.PanelOfButtons.Name = "PanelOfButtons";
            this.PanelOfButtons.Size = new System.Drawing.Size(334, 46);
            this.PanelOfButtons.TabIndex = 11;
            // 
            // RegButtonPanel
            // 
            this.RegButtonPanel.Controls.Add(this.RegistrationButton);
            this.RegButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RegButtonPanel.Location = new System.Drawing.Point(161, 0);
            this.RegButtonPanel.Name = "RegButtonPanel";
            this.RegButtonPanel.Padding = new System.Windows.Forms.Padding(10, 0, 60, 0);
            this.RegButtonPanel.Size = new System.Drawing.Size(173, 46);
            this.RegButtonPanel.TabIndex = 4;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Padding = new System.Windows.Forms.Padding(60, 0, 10, 0);
            this.LoginPanel.Size = new System.Drawing.Size(161, 46);
            this.LoginPanel.TabIndex = 3;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.PanelOfButtons);
            this.MainPanel.Controls.Add(this.PanelOfCheckBoxes);
            this.MainPanel.Controls.Add(this.LoginPasswordMailPanel);
            this.MainPanel.Controls.Add(this.HeaderPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(334, 480);
            this.MainPanel.TabIndex = 13;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.HeaderLabelPanel);
            this.HeaderPanel.Controls.Add(this.AuthorizationPictureBox);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(334, 70);
            this.HeaderPanel.TabIndex = 12;
            // 
            // HeaderLabelPanel
            // 
            this.HeaderLabelPanel.Controls.Add(this.AuthorizationLabel);
            this.HeaderLabelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderLabelPanel.Location = new System.Drawing.Point(70, 0);
            this.HeaderLabelPanel.Name = "HeaderLabelPanel";
            this.HeaderLabelPanel.Padding = new System.Windows.Forms.Padding(40, 15, 40, 15);
            this.HeaderLabelPanel.Size = new System.Drawing.Size(264, 70);
            this.HeaderLabelPanel.TabIndex = 13;
            // 
            // AuthorizationLabel
            // 
            this.AuthorizationLabel.AutoSize = true;
            this.AuthorizationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthorizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.AuthorizationLabel.Location = new System.Drawing.Point(40, 15);
            this.AuthorizationLabel.Name = "AuthorizationLabel";
            this.AuthorizationLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AuthorizationLabel.Size = new System.Drawing.Size(189, 31);
            this.AuthorizationLabel.TabIndex = 1;
            this.AuthorizationLabel.Text = "Авторизация";
            this.AuthorizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthorizationPictureBox
            // 
            this.AuthorizationPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.AuthorizationPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.AuthorizationPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AuthorizationPictureBox.Image")));
            this.AuthorizationPictureBox.Location = new System.Drawing.Point(0, 0);
            this.AuthorizationPictureBox.Name = "AuthorizationPictureBox";
            this.AuthorizationPictureBox.Padding = new System.Windows.Forms.Padding(15);
            this.AuthorizationPictureBox.Size = new System.Drawing.Size(70, 70);
            this.AuthorizationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AuthorizationPictureBox.TabIndex = 11;
            this.AuthorizationPictureBox.TabStop = false;
            // 
            // RegPanel
            // 
            this.RegPanel.Controls.Add(this.RegButtonsPanel);
            this.RegPanel.Controls.Add(this.OrgPanel);
            this.RegPanel.Controls.Add(this.TimeZonePanel);
            this.RegPanel.Controls.Add(this.FullNamePanel);
            this.RegPanel.Controls.Add(this.ProjectsPanel);
            this.RegPanel.Controls.Add(this.RolePanel);
            this.RegPanel.Controls.Add(this.RegPasswordPanel);
            this.RegPanel.Controls.Add(this.RegEmailPanel);
            this.RegPanel.Controls.Add(this.RegLoginPanel);
            this.RegPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegPanel.Location = new System.Drawing.Point(0, 0);
            this.RegPanel.Name = "RegPanel";
            this.RegPanel.Size = new System.Drawing.Size(334, 480);
            this.RegPanel.TabIndex = 13;
            // 
            // RegButtonsPanel
            // 
            this.RegButtonsPanel.Controls.Add(this.RegOfRegPanel);
            this.RegButtonsPanel.Controls.Add(this.RegBackPanel);
            this.RegButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegButtonsPanel.Location = new System.Drawing.Point(0, 375);
            this.RegButtonsPanel.Name = "RegButtonsPanel";
            this.RegButtonsPanel.Size = new System.Drawing.Size(334, 54);
            this.RegButtonsPanel.TabIndex = 14;
            // 
            // RegOfRegPanel
            // 
            this.RegOfRegPanel.Controls.Add(this.RegOfRegButton);
            this.RegOfRegPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RegOfRegPanel.Location = new System.Drawing.Point(167, 0);
            this.RegOfRegPanel.Name = "RegOfRegPanel";
            this.RegOfRegPanel.Padding = new System.Windows.Forms.Padding(15);
            this.RegOfRegPanel.Size = new System.Drawing.Size(167, 54);
            this.RegOfRegPanel.TabIndex = 16;
            // 
            // RegOfRegButton
            // 
            this.RegOfRegButton.BackColor = System.Drawing.Color.Transparent;
            this.RegOfRegButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegOfRegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegOfRegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegOfRegButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.RegOfRegButton.Location = new System.Drawing.Point(15, 15);
            this.RegOfRegButton.Name = "RegOfRegButton";
            this.RegOfRegButton.Size = new System.Drawing.Size(137, 24);
            this.RegOfRegButton.TabIndex = 4;
            this.RegOfRegButton.Text = "Регистрация";
            this.RegOfRegButton.UseVisualStyleBackColor = false;
            this.RegOfRegButton.Click += new System.EventHandler(this.RegPanelButton_Click);
            // 
            // RegBackPanel
            // 
            this.RegBackPanel.Controls.Add(this.RegOfRegBackButton);
            this.RegBackPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RegBackPanel.Location = new System.Drawing.Point(0, 0);
            this.RegBackPanel.Name = "RegBackPanel";
            this.RegBackPanel.Padding = new System.Windows.Forms.Padding(15);
            this.RegBackPanel.Size = new System.Drawing.Size(167, 54);
            this.RegBackPanel.TabIndex = 15;
            // 
            // RegOfRegBackButton
            // 
            this.RegOfRegBackButton.BackColor = System.Drawing.Color.Transparent;
            this.RegOfRegBackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegOfRegBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegOfRegBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegOfRegBackButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.RegOfRegBackButton.Location = new System.Drawing.Point(15, 15);
            this.RegOfRegBackButton.Name = "RegOfRegBackButton";
            this.RegOfRegBackButton.Size = new System.Drawing.Size(137, 24);
            this.RegOfRegBackButton.TabIndex = 4;
            this.RegOfRegBackButton.Text = "Назад";
            this.RegOfRegBackButton.UseVisualStyleBackColor = false;
            this.RegOfRegBackButton.Click += new System.EventHandler(this.RegOfRegButton_Click);
            // 
            // OrgPanel
            // 
            this.OrgPanel.Controls.Add(this.OrgLabel);
            this.OrgPanel.Controls.Add(this.OrgTextBox);
            this.OrgPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrgPanel.Location = new System.Drawing.Point(0, 325);
            this.OrgPanel.Name = "OrgPanel";
            this.OrgPanel.Padding = new System.Windows.Forms.Padding(15);
            this.OrgPanel.Size = new System.Drawing.Size(334, 50);
            this.OrgPanel.TabIndex = 18;
            // 
            // OrgLabel
            // 
            this.OrgLabel.AutoSize = true;
            this.OrgLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.OrgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.OrgLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.OrgLabel.Location = new System.Drawing.Point(15, 15);
            this.OrgLabel.Name = "OrgLabel";
            this.OrgLabel.Size = new System.Drawing.Size(94, 16);
            this.OrgLabel.TabIndex = 4;
            this.OrgLabel.Text = "Организация";
            // 
            // OrgTextBox
            // 
            this.OrgTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.OrgTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrgTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.OrgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrgTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.OrgTextBox.Location = new System.Drawing.Point(125, 15);
            this.OrgTextBox.Name = "OrgTextBox";
            this.OrgTextBox.Size = new System.Drawing.Size(194, 17);
            this.OrgTextBox.TabIndex = 3;
            this.OrgTextBox.TabStop = false;
            this.OrgTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeZonePanel
            // 
            this.TimeZonePanel.Controls.Add(this.TimeZoneCB);
            this.TimeZonePanel.Controls.Add(this.TimeZoneLabel);
            this.TimeZonePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimeZonePanel.Location = new System.Drawing.Point(0, 280);
            this.TimeZonePanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.TimeZonePanel.Name = "TimeZonePanel";
            this.TimeZonePanel.Padding = new System.Windows.Forms.Padding(15);
            this.TimeZonePanel.Size = new System.Drawing.Size(334, 45);
            this.TimeZonePanel.TabIndex = 17;
            // 
            // TimeZoneCB
            // 
            this.TimeZoneCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TimeZoneCB.DropDownHeight = 100;
            this.TimeZoneCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeZoneCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TimeZoneCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeZoneCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TimeZoneCB.FormattingEnabled = true;
            this.TimeZoneCB.IntegralHeight = false;
            this.TimeZoneCB.Items.AddRange(new object[] {
            "(GMT-11:00) Midway Island",
            "(GMT-11:00) Samoa",
            "(GMT-10:00) Hawaii",
            "(GMT-09:00) Alaska",
            "(GMT-08:00) Pacific Time (US &amp; Canada)",
            "(GMT-08:00) Tijuana",
            "(GMT-07:00) Arizona",
            "(GMT-07:00) Mountain Time (US &amp; Canada)",
            "(GMT-07:00) Chihuahua",
            "(GMT-07:00) Mazatlan",
            "(GMT-06:00) Mexico City",
            "(GMT-06:00) Monterrey",
            "(GMT-06:00) Saskatchewan",
            "(GMT-06:00) Central Time (US &amp; Canada)",
            "(GMT-05:00) Eastern Time (US &amp; Canada)",
            "(GMT-05:00) Indiana (East)",
            "(GMT-05:00) Bogota",
            "(GMT-05:00) Lima",
            "(GMT-04:30) Caracas",
            "(GMT-04:00) Atlantic Time (Canada)",
            "(GMT-04:00) La Paz",
            "(GMT-04:00) Santiago",
            "(GMT-03:30) Newfoundland",
            "(GMT-03:00) Buenos Aires",
            "(GMT-03:00) Greenland",
            "(GMT-02:00) Stanley",
            "(GMT-01:00) Azores",
            "(GMT-01:00) Cape Verde Is.",
            "(GMT) Casablanca",
            "(GMT) Dublin",
            "(GMT) Lisbon",
            "(GMT) London",
            "(GMT) Monrovia",
            "(GMT+01:00) Amsterdam",
            "(GMT+01:00) Belgrade",
            "(GMT+01:00) Berlin",
            "(GMT+01:00) Bratislava",
            "(GMT+01:00) Brussels",
            "(GMT+01:00) Budapest",
            "(GMT+01:00) Copenhagen",
            "(GMT+01:00) Ljubljana",
            "(GMT+01:00) Madrid",
            "(GMT+01:00) Paris",
            "(GMT+01:00) Prague",
            "(GMT+01:00) Rome",
            "(GMT+01:00) Sarajevo",
            "(GMT+01:00) Skopje",
            "(GMT+01:00) Stockholm",
            "(GMT+01:00) Vienna",
            "(GMT+01:00) Warsaw",
            "(GMT+01:00) Zagreb",
            "(GMT+02:00) Athens",
            "(GMT+02:00) Bucharest",
            "(GMT+02:00) Cairo",
            "(GMT+02:00) Harare",
            "(GMT+02:00) Helsinki",
            "(GMT+02:00) Istanbul",
            "(GMT+02:00) Jerusalem",
            "(GMT+02:00) Kyiv",
            "(GMT+02:00) Minsk",
            "(GMT+02:00) Riga",
            "(GMT+02:00) Sofia",
            "(GMT+02:00) Tallinn",
            "(GMT+02:00) Vilnius",
            "(GMT+03:00) Baghdad",
            "(GMT+03:00) Kuwait",
            "(GMT+03:00) Nairobi",
            "(GMT+03:00) Riyadh",
            "(GMT+03:00) Moscow",
            "(GMT+03:30) Tehran",
            "(GMT+04:00) Baku",
            "(GMT+04:00) Volgograd",
            "(GMT+04:00) Muscat",
            "(GMT+04:00) Tbilisi",
            "(GMT+04:00) Yerevan",
            "(GMT+04:30) Kabul",
            "(GMT+05:00) Karachi",
            "(GMT+05:00) Tashkent",
            "(GMT+05:30) Kolkata",
            "(GMT+05:45) Kathmandu",
            "(GMT+06:00) Ekaterinburg",
            "(GMT+06:00) Almaty",
            "(GMT+06:00) Dhaka",
            "(GMT+07:00) Novosibirsk",
            "(GMT+07:00) Bangkok",
            "(GMT+07:00) Jakarta",
            "(GMT+08:00) Krasnoyarsk",
            "(GMT+08:00) Chongqing",
            "(GMT+08:00) Hong Kong",
            "(GMT+08:00) Kuala Lumpur",
            "(GMT+08:00) Perth",
            "(GMT+08:00) Singapore",
            "(GMT+08:00) Taipei",
            "(GMT+08:00) Ulaan Bataar",
            "(GMT+08:00) Urumqi",
            "(GMT+09:00) Irkutsk",
            "(GMT+09:00) Seoul",
            "(GMT+09:00) Tokyo",
            "(GMT+09:30) Adelaide",
            "(GMT+09:30) Darwin",
            "(GMT+10:00) Yakutsk",
            "(GMT+10:00) Brisbane",
            "(GMT+10:00) Canberra",
            "(GMT+10:00) Guam",
            "(GMT+10:00) Hobart",
            "(GMT+10:00) Melbourne",
            "(GMT+10:00) Port Moresby",
            "(GMT+10:00) Sydney",
            "(GMT+11:00) Vladivostok",
            "(GMT+12:00) Magadan",
            "(GMT+12:00) Auckland",
            "(GMT+12:00) Fiji"});
            this.TimeZoneCB.Location = new System.Drawing.Point(125, 12);
            this.TimeZoneCB.Name = "TimeZoneCB";
            this.TimeZoneCB.Size = new System.Drawing.Size(194, 24);
            this.TimeZoneCB.TabIndex = 5;
            // 
            // TimeZoneLabel
            // 
            this.TimeZoneLabel.AutoSize = true;
            this.TimeZoneLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TimeZoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TimeZoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TimeZoneLabel.Location = new System.Drawing.Point(15, 15);
            this.TimeZoneLabel.Name = "TimeZoneLabel";
            this.TimeZoneLabel.Size = new System.Drawing.Size(72, 16);
            this.TimeZoneLabel.TabIndex = 4;
            this.TimeZoneLabel.Text = "GMT зона";
            // 
            // FullNamePanel
            // 
            this.FullNamePanel.Controls.Add(this.FullNameLabel);
            this.FullNamePanel.Controls.Add(this.FullNameTextBox);
            this.FullNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FullNamePanel.Location = new System.Drawing.Point(0, 230);
            this.FullNamePanel.Name = "FullNamePanel";
            this.FullNamePanel.Padding = new System.Windows.Forms.Padding(15);
            this.FullNamePanel.Size = new System.Drawing.Size(334, 50);
            this.FullNamePanel.TabIndex = 16;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FullNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.FullNameLabel.Location = new System.Drawing.Point(15, 15);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(38, 16);
            this.FullNameLabel.TabIndex = 4;
            this.FullNameLabel.Text = "ФИО";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.FullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FullNameTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.FullNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.FullNameTextBox.Location = new System.Drawing.Point(125, 15);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(194, 17);
            this.FullNameTextBox.TabIndex = 3;
            this.FullNameTextBox.TabStop = false;
            this.FullNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProjectsPanel
            // 
            this.ProjectsPanel.Controls.Add(this.RegProjectsLabel);
            this.ProjectsPanel.Controls.Add(this.RegProjectsTextBox);
            this.ProjectsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProjectsPanel.Location = new System.Drawing.Point(0, 180);
            this.ProjectsPanel.Name = "ProjectsPanel";
            this.ProjectsPanel.Padding = new System.Windows.Forms.Padding(15);
            this.ProjectsPanel.Size = new System.Drawing.Size(334, 50);
            this.ProjectsPanel.TabIndex = 15;
            // 
            // RegProjectsLabel
            // 
            this.RegProjectsLabel.AutoSize = true;
            this.RegProjectsLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RegProjectsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.RegProjectsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.RegProjectsLabel.Location = new System.Drawing.Point(15, 15);
            this.RegProjectsLabel.Name = "RegProjectsLabel";
            this.RegProjectsLabel.Size = new System.Drawing.Size(64, 16);
            this.RegProjectsLabel.TabIndex = 4;
            this.RegProjectsLabel.Text = "Проекты";
            // 
            // RegProjectsTextBox
            // 
            this.RegProjectsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.RegProjectsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegProjectsTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.RegProjectsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegProjectsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.RegProjectsTextBox.Location = new System.Drawing.Point(125, 15);
            this.RegProjectsTextBox.Name = "RegProjectsTextBox";
            this.RegProjectsTextBox.Size = new System.Drawing.Size(194, 17);
            this.RegProjectsTextBox.TabIndex = 3;
            this.RegProjectsTextBox.TabStop = false;
            this.RegProjectsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RolePanel
            // 
            this.RolePanel.Controls.Add(this.RegRoleComboBox);
            this.RolePanel.Controls.Add(this.RegRoleLabel);
            this.RolePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RolePanel.Location = new System.Drawing.Point(0, 135);
            this.RolePanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.RolePanel.Name = "RolePanel";
            this.RolePanel.Padding = new System.Windows.Forms.Padding(15);
            this.RolePanel.Size = new System.Drawing.Size(334, 45);
            this.RolePanel.TabIndex = 13;
            // 
            // RegRoleComboBox
            // 
            this.RegRoleComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.RegRoleComboBox.DropDownHeight = 100;
            this.RegRoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegRoleComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegRoleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegRoleComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.RegRoleComboBox.FormattingEnabled = true;
            this.RegRoleComboBox.IntegralHeight = false;
            this.RegRoleComboBox.Items.AddRange(new object[] {
            "User",
            "Programmer",
            "Manager",
            "Admin"});
            this.RegRoleComboBox.Location = new System.Drawing.Point(125, 12);
            this.RegRoleComboBox.Name = "RegRoleComboBox";
            this.RegRoleComboBox.Size = new System.Drawing.Size(194, 24);
            this.RegRoleComboBox.TabIndex = 5;
            // 
            // RegRoleLabel
            // 
            this.RegRoleLabel.AutoSize = true;
            this.RegRoleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RegRoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.RegRoleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.RegRoleLabel.Location = new System.Drawing.Point(15, 15);
            this.RegRoleLabel.Name = "RegRoleLabel";
            this.RegRoleLabel.Size = new System.Drawing.Size(39, 16);
            this.RegRoleLabel.TabIndex = 4;
            this.RegRoleLabel.Text = "Роль";
            // 
            // RegPasswordPanel
            // 
            this.RegPasswordPanel.Controls.Add(this.RegPasswordLabel);
            this.RegPasswordPanel.Controls.Add(this.RegPasswordTextBox);
            this.RegPasswordPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegPasswordPanel.Location = new System.Drawing.Point(0, 90);
            this.RegPasswordPanel.Name = "RegPasswordPanel";
            this.RegPasswordPanel.Padding = new System.Windows.Forms.Padding(15);
            this.RegPasswordPanel.Size = new System.Drawing.Size(334, 45);
            this.RegPasswordPanel.TabIndex = 12;
            // 
            // RegPasswordLabel
            // 
            this.RegPasswordLabel.AutoSize = true;
            this.RegPasswordLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RegPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.RegPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.RegPasswordLabel.Location = new System.Drawing.Point(15, 15);
            this.RegPasswordLabel.Name = "RegPasswordLabel";
            this.RegPasswordLabel.Size = new System.Drawing.Size(56, 16);
            this.RegPasswordLabel.TabIndex = 4;
            this.RegPasswordLabel.Text = "Пароль";
            // 
            // RegPasswordTextBox
            // 
            this.RegPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.RegPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.RegPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.RegPasswordTextBox.Location = new System.Drawing.Point(125, 15);
            this.RegPasswordTextBox.Name = "RegPasswordTextBox";
            this.RegPasswordTextBox.Size = new System.Drawing.Size(194, 17);
            this.RegPasswordTextBox.TabIndex = 3;
            this.RegPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegEmailPanel
            // 
            this.RegEmailPanel.Controls.Add(this.RegEmailLabel);
            this.RegEmailPanel.Controls.Add(this.RegEmailTextBox);
            this.RegEmailPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegEmailPanel.Location = new System.Drawing.Point(0, 45);
            this.RegEmailPanel.Name = "RegEmailPanel";
            this.RegEmailPanel.Padding = new System.Windows.Forms.Padding(15);
            this.RegEmailPanel.Size = new System.Drawing.Size(334, 45);
            this.RegEmailPanel.TabIndex = 11;
            // 
            // RegEmailLabel
            // 
            this.RegEmailLabel.AutoSize = true;
            this.RegEmailLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RegEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.RegEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.RegEmailLabel.Location = new System.Drawing.Point(15, 15);
            this.RegEmailLabel.Name = "RegEmailLabel";
            this.RegEmailLabel.Size = new System.Drawing.Size(41, 16);
            this.RegEmailLabel.TabIndex = 4;
            this.RegEmailLabel.Text = "Email";
            // 
            // RegEmailTextBox
            // 
            this.RegEmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.RegEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegEmailTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.RegEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegEmailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.RegEmailTextBox.Location = new System.Drawing.Point(125, 15);
            this.RegEmailTextBox.Name = "RegEmailTextBox";
            this.RegEmailTextBox.Size = new System.Drawing.Size(194, 17);
            this.RegEmailTextBox.TabIndex = 3;
            this.RegEmailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegLoginPanel
            // 
            this.RegLoginPanel.Controls.Add(this.RegLoginLabel);
            this.RegLoginPanel.Controls.Add(this.RegLoginTextBox);
            this.RegLoginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.RegLoginPanel.Name = "RegLoginPanel";
            this.RegLoginPanel.Padding = new System.Windows.Forms.Padding(15);
            this.RegLoginPanel.Size = new System.Drawing.Size(334, 45);
            this.RegLoginPanel.TabIndex = 10;
            // 
            // RegLoginLabel
            // 
            this.RegLoginLabel.AutoSize = true;
            this.RegLoginLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RegLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.RegLoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.RegLoginLabel.Location = new System.Drawing.Point(15, 15);
            this.RegLoginLabel.Name = "RegLoginLabel";
            this.RegLoginLabel.Size = new System.Drawing.Size(46, 16);
            this.RegLoginLabel.TabIndex = 4;
            this.RegLoginLabel.Text = "Логин";
            // 
            // RegLoginTextBox
            // 
            this.RegLoginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.RegLoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegLoginTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.RegLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegLoginTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.RegLoginTextBox.Location = new System.Drawing.Point(125, 15);
            this.RegLoginTextBox.Name = "RegLoginTextBox";
            this.RegLoginTextBox.Size = new System.Drawing.Size(194, 17);
            this.RegLoginTextBox.TabIndex = 3;
            this.RegLoginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(334, 480);
            this.Controls.Add(this.RegPanel);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 265);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.LoginPasswordMailPanel.ResumeLayout(false);
            this.PanelOfTextBoxes.ResumeLayout(false);
            this.PasswordTextBoxPanel.ResumeLayout(false);
            this.PasswordTextBoxPanel.PerformLayout();
            this.LoginTextBoxPanel.ResumeLayout(false);
            this.LoginTextBoxPanel.PerformLayout();
            this.LabelsPanel.ResumeLayout(false);
            this.PasswordLabelPanel.ResumeLayout(false);
            this.PasswordLabelPanel.PerformLayout();
            this.loginLabelPanel.ResumeLayout(false);
            this.loginLabelPanel.PerformLayout();
            this.PanelOfCheckBoxes.ResumeLayout(false);
            this.PanelOfButtons.ResumeLayout(false);
            this.RegButtonPanel.ResumeLayout(false);
            this.LoginPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderLabelPanel.ResumeLayout(false);
            this.HeaderLabelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorizationPictureBox)).EndInit();
            this.RegPanel.ResumeLayout(false);
            this.RegButtonsPanel.ResumeLayout(false);
            this.RegOfRegPanel.ResumeLayout(false);
            this.RegBackPanel.ResumeLayout(false);
            this.OrgPanel.ResumeLayout(false);
            this.OrgPanel.PerformLayout();
            this.TimeZonePanel.ResumeLayout(false);
            this.TimeZonePanel.PerformLayout();
            this.FullNamePanel.ResumeLayout(false);
            this.FullNamePanel.PerformLayout();
            this.ProjectsPanel.ResumeLayout(false);
            this.ProjectsPanel.PerformLayout();
            this.RolePanel.ResumeLayout(false);
            this.RolePanel.PerformLayout();
            this.RegPasswordPanel.ResumeLayout(false);
            this.RegPasswordPanel.PerformLayout();
            this.RegEmailPanel.ResumeLayout(false);
            this.RegEmailPanel.PerformLayout();
            this.RegLoginPanel.ResumeLayout(false);
            this.RegLoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button LoginButton;
        private Button RegistrationButton;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label LoginLabel;
        private Label PassLabel;
        private Panel LoginPasswordMailPanel;
        private Panel PanelOfTextBoxes;
        private Panel LabelsPanel;
        private Panel PanelOfCheckBoxes;
        private Panel PanelOfButtons;
        private Panel RegButtonPanel;
        private Panel LoginPanel;
        private Panel PasswordTextBoxPanel;
        private Panel LoginTextBoxPanel;
        private Panel PasswordLabelPanel;
        private Panel loginLabelPanel;
        private CheckBox checkPass;
        private Panel MainPanel;
        private Panel HeaderPanel;
        private Panel HeaderLabelPanel;
        private Label AuthorizationLabel;
        private PictureBox AuthorizationPictureBox;
        private Panel RegPanel;
        private Panel RolePanel;
        private Label RegRoleLabel;
        private Panel RegPasswordPanel;
        private Label RegPasswordLabel;
        private TextBox RegPasswordTextBox;
        private Panel RegEmailPanel;
        private Label RegEmailLabel;
        private TextBox RegEmailTextBox;
        private Panel RegLoginPanel;
        private Label RegLoginLabel;
        private TextBox RegLoginTextBox;
        private Panel ProjectsPanel;
        private Label RegProjectsLabel;
        private TextBox RegProjectsTextBox;
        private Panel RegButtonsPanel;
        private Button RegOfRegBackButton;
        private ComboBox RegRoleComboBox;
        private Panel RegOfRegPanel;
        private Button RegOfRegButton;
        private Panel RegBackPanel;
        private Panel FullNamePanel;
        private Label FullNameLabel;
        private TextBox FullNameTextBox;
        private Panel TimeZonePanel;
        private ComboBox TimeZoneCB;
        private Label TimeZoneLabel;
        private Panel OrgPanel;
        private Label OrgLabel;
        private TextBox OrgTextBox;
    }
}