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
            
        btnLogin.Text = "";
        btnLogin.Image = kanbanboard1.Properties.Resources.check;
        this.Hide();
        Form1 main = new Form1();
        main.Show();            
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStayLogged.Checked)
            {
                checkBoxStayLogged.ForeColor = Color.FromArgb(200, 255, 200); 
            }
            else
            {
                checkBoxStayLogged.ForeColor = Color.FromArgb(200, 200, 200);
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
    }
}
