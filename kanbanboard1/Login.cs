using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;




namespace kanbanboard1
{
    public partial class Login : Form
    {
        // FirestoreDb database;

        public Login()
        {
            InitializeComponent();
        }

        public static string Username;


        private void Login_Load(object sender, EventArgs e)
        {
            //string path = AppDomain.CurrentDomain.BaseDirectory + @"kanban-board.json";
            // Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            // database = FirestoreDb.Create("kanban-board-fvdi");
            panel8.Width = this.Size.Width / 2;
            this.MinimumSize = new System.Drawing.Size(350, 360 - EmailLabelPanel.Height);
            this.Size = new System.Drawing.Size(350, 360 - EmailLabelPanel.Height);
            int HeaderPadding = (this.Width - AuthorizationLabel.Width-AuthorizationPictureBox.Width) / 2;
            this.panel11.Padding = new Padding(HeaderPadding, 15, HeaderPadding, 15);
            EmailLabel.Visible = false;
            textBoxEmail.Visible = false;
            CheckBoxRegistration.ForeColor = Color.FromArgb(200, 200, 200);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            loginLabel.ForeColor = Color.FromArgb(114, 119, 139);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            loginLabel.ForeColor = Color.FromArgb(74, 79, 99);
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            passLabel.ForeColor = Color.FromArgb(114, 119, 139);
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            passLabel.ForeColor = Color.FromArgb(74, 79, 99);
        }

        

        private void button1_Click(object sender, EventArgs e) // логин в приложение
        {
            
        LoginButton.Text = "";
        LoginButton.Image = kanbanboard1.Properties.Resources.check;
        this.Hide();
        MainForm main = new MainForm();
        main.Show();            
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (StayLoggedCheckBox.Checked)
            {
                StayLoggedCheckBox.ForeColor = Color.FromArgb(200, 255, 200); 
            }
            else
            {
                StayLoggedCheckBox.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        

        private void textBoxEmail_MouseEnter(object sender, EventArgs e)
        {
            EmailLabel.ForeColor = Color.FromArgb(114, 119, 139);
        }

        private void textBoxEmail_MouseLeave(object sender, EventArgs e)
        {
            EmailLabel.ForeColor = Color.FromArgb(74, 79, 99);
        }

        private void textBoxEmail_Click(object sender, EventArgs e)
        {
            textBoxEmail.Text = "";
        }
        private void Login_Resize(object sender, EventArgs e)
        {
            panel8.Width = this.Size.Width / 2;
            int HeaderPadding = (this.Width - AuthorizationLabel.Width - AuthorizationPictureBox.Width) / 2;
            this.panel11.Padding = new Padding(HeaderPadding, 15, HeaderPadding, 15);
        }

        private void CheckBoxRegistration_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxRegistration.Checked)
            {
                EmailLabel.Visible = true;
                textBoxEmail.Visible = true;
                this.MinimumSize = new System.Drawing.Size(350, 360);
                CheckBoxRegistration.ForeColor = Color.FromArgb(200, 250, 200);
            }
            else
            {
                EmailLabel.Visible = false;
                textBoxEmail.Visible = false;
                this.MinimumSize = new System.Drawing.Size(350, 360-EmailLabelPanel.Height);
                CheckBoxRegistration.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }
    }
}
