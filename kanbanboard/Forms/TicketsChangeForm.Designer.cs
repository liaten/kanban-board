
using System.ComponentModel;
using System.Windows.Forms;

namespace kanbanboard.Forms
{
    partial class TicketsChangeForm
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
            this.ChangingPanel = new System.Windows.Forms.Panel();
            this.ChangingTicketTextBox = new System.Windows.Forms.TextBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.ChangingPeopleLabel = new System.Windows.Forms.Label();
            this.ChangingTicketLabel = new System.Windows.Forms.Label();
            this.ChangingTitleLabel = new System.Windows.Forms.Label();
            this.ChangingPeopleTextBox = new System.Windows.Forms.TextBox();
            this.ChangingTitleTextBox = new System.Windows.Forms.TextBox();
            this.ChangingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangingPanel
            // 
            this.ChangingPanel.AutoScroll = true;
            this.ChangingPanel.Controls.Add(this.SaveChangesButton);
            this.ChangingPanel.Controls.Add(this.ChangingPeopleTextBox);
            this.ChangingPanel.Controls.Add(this.ChangingPeopleLabel);
            this.ChangingPanel.Controls.Add(this.ChangingTicketTextBox);
            this.ChangingPanel.Controls.Add(this.ChangingTicketLabel);
            this.ChangingPanel.Controls.Add(this.ChangingTitleTextBox);
            this.ChangingPanel.Controls.Add(this.ChangingTitleLabel);
            this.ChangingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangingPanel.Location = new System.Drawing.Point(0, 0);
            this.ChangingPanel.Name = "ChangingPanel";
            this.ChangingPanel.Padding = new System.Windows.Forms.Padding(15);
            this.ChangingPanel.Size = new System.Drawing.Size(384, 386);
            this.ChangingPanel.TabIndex = 1;
            // 
            // ChangingTicketTextBox
            // 
            this.ChangingTicketTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangingTicketTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.ChangingTicketTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChangingTicketTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ChangingTicketTextBox.Location = new System.Drawing.Point(84, 122);
            this.ChangingTicketTextBox.Multiline = true;
            this.ChangingTicketTextBox.Name = "ChangingTicketTextBox";
            this.ChangingTicketTextBox.Size = new System.Drawing.Size(236, 135);
            this.ChangingTicketTextBox.TabIndex = 2;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveChangesButton.FlatAppearance.BorderSize = 0;
            this.SaveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChangesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.SaveChangesButton.Location = new System.Drawing.Point(0, 348);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(384, 38);
            this.SaveChangesButton.TabIndex = 6;
            this.SaveChangesButton.Text = "Сохранить";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // ChangingPeopleLabel
            // 
            this.ChangingPeopleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangingPeopleLabel.AutoSize = true;
            this.ChangingPeopleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangingPeopleLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ChangingPeopleLabel.Location = new System.Drawing.Point(104, 260);
            this.ChangingPeopleLabel.Name = "ChangingPeopleLabel";
            this.ChangingPeopleLabel.Size = new System.Drawing.Size(197, 29);
            this.ChangingPeopleLabel.TabIndex = 5;
            this.ChangingPeopleLabel.Text = "Выполняющие";
            this.ChangingPeopleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChangingTicketLabel
            // 
            this.ChangingTicketLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangingTicketLabel.AutoSize = true;
            this.ChangingTicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangingTicketLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ChangingTicketLabel.Location = new System.Drawing.Point(133, 90);
            this.ChangingTicketLabel.Name = "ChangingTicketLabel";
            this.ChangingTicketLabel.Size = new System.Drawing.Size(139, 29);
            this.ChangingTicketLabel.TabIndex = 4;
            this.ChangingTicketLabel.Text = "Описание";
            // 
            // ChangingTitleLabel
            // 
            this.ChangingTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangingTitleLabel.AutoSize = true;
            this.ChangingTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangingTitleLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ChangingTitleLabel.Location = new System.Drawing.Point(131, 21);
            this.ChangingTitleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ChangingTitleLabel.Name = "ChangingTitleLabel";
            this.ChangingTitleLabel.Size = new System.Drawing.Size(143, 29);
            this.ChangingTitleLabel.TabIndex = 3;
            this.ChangingTitleLabel.Text = "Заголовок";
            // 
            // ChangingPeopleTextBox
            // 
            this.ChangingPeopleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangingPeopleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.ChangingPeopleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChangingPeopleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ChangingPeopleTextBox.Location = new System.Drawing.Point(84, 299);
            this.ChangingPeopleTextBox.Name = "ChangingPeopleTextBox";
            this.ChangingPeopleTextBox.Size = new System.Drawing.Size(236, 19);
            this.ChangingPeopleTextBox.TabIndex = 3;
            // 
            // ChangingTitleTextBox
            // 
            this.ChangingTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangingTitleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.ChangingTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChangingTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ChangingTitleTextBox.Location = new System.Drawing.Point(84, 53);
            this.ChangingTitleTextBox.Multiline = true;
            this.ChangingTitleTextBox.Name = "ChangingTitleTextBox";
            this.ChangingTitleTextBox.Size = new System.Drawing.Size(236, 34);
            this.ChangingTitleTextBox.TabIndex = 1;
            // 
            // TicketsChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(384, 386);
            this.Controls.Add(this.ChangingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "TicketsChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить тикет";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TicketsChangeForm_FormClosing);
            this.Load += new System.EventHandler(this.TicketsChangeForm_Load);
            this.ChangingPanel.ResumeLayout(false);
            this.ChangingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ChangingPanel;
        private TextBox ChangingTicketTextBox;
        private Button SaveChangesButton;
        private Label ChangingPeopleLabel;
        private Label ChangingTicketLabel;
        private Label ChangingTitleLabel;
        private TextBox ChangingPeopleTextBox;
        private TextBox ChangingTitleTextBox;
    }
}