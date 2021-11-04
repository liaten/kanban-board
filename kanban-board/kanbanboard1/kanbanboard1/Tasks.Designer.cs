
namespace kanbanboard1
{
    partial class Tasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.projLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Проект1",
            "Проект2",
            "Проект3"});
            this.comboBox1.Location = new System.Drawing.Point(155, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // btnNewTask
            // 
            this.btnNewTask.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTask.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnNewTask.Location = new System.Drawing.Point(478, 12);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(104, 28);
            this.btnNewTask.TabIndex = 1;
            this.btnNewTask.Text = "Новый";
            this.btnNewTask.UseVisualStyleBackColor = false;
            // 
            // projLabel
            // 
            this.projLabel.AutoSize = true;
            this.projLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(119)))), ((int)(((byte)(139)))));
            this.projLabel.Location = new System.Drawing.Point(3, 18);
            this.projLabel.Name = "projLabel";
            this.projLabel.Size = new System.Drawing.Size(146, 16);
            this.projLabel.TabIndex = 7;
            this.projLabel.Text = "Выберите проект:";
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(584, 336);
            this.Controls.Add(this.projLabel);
            this.Controls.Add(this.btnNewTask);
            this.Controls.Add(this.comboBox1);
            this.Name = "Tasks";
            this.Text = "Tasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnNewTask;
        private System.Windows.Forms.Label projLabel;
    }
}