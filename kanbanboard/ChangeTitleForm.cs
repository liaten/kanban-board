﻿using System;
using System.Windows.Forms;

namespace kanbanboard
{
    public partial class ChangeTitleForm : Form
    {
        public new MainForm Owner { get; }
        private readonly TitlePanel _titlePanel;
        public ChangeTitleForm(MainForm owner, TitlePanel titlePanel)
        {
            Owner = owner;
            _titlePanel = titlePanel;
            InitializeComponent();

            KeyDown += (s, a) => {
                if (a.KeyValue == (int)Keys.Enter || a.KeyValue == (int)Keys.Escape) Close();
            };
        }

        // Сохранение
        private void ChangeTitleForm_FormClosing(object sender, FormClosingEventArgs e) => _titlePanel.TitleColumnLabel.Text = TitleTextBox.Text;

        private void ChangeTitleForm_Load(object sender, EventArgs e)
        {
            TitleTextBox.Text = _titlePanel.TitleColumnLabel.Text;
            TitleTextBox.Focus();
        }
    }
}
