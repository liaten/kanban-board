﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kanbanboard1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.panel3.Controls.Clear();
            Profile ProfileTab = new Profile() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ProfileTab.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(ProfileTab);
            ProfileTab.Show();
            UsernameLabel.Text = Login.Username;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Задачи";
            this.panel3.Controls.Clear();
            Tasks TaskTab = new Tasks() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            TaskTab.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(TaskTab);
            TaskTab.Show();
            panel4.Location = button2.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Профиль";
            this.panel3.Controls.Clear();
            Profile ProfileTab = new Profile() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ProfileTab.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(ProfileTab);
            ProfileTab.Show();
            panel4.Location = button1.Location;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "Мессенджер";
            this.panel3.Controls.Clear();
            Msgr MsgrTab = new Msgr() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            MsgrTab.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(MsgrTab);
            MsgrTab.Show();
            panel4.Location = button3.Location;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "Календарь";
            this.panel3.Controls.Clear();
            Calender CalenderTab = new Calender() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CalenderTab.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(CalenderTab);
            CalenderTab.Show();
            panel4.Location = button4.Location;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(14, 20, 44);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Login LoginForm = new Login();
            LoginForm.Show();
        }
    }
}
