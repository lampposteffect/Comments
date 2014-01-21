namespace Comments
{
    partial class Reminder
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblReminderText = new System.Windows.Forms.Label();
            this.rctReminderText = new System.Windows.Forms.RichTextBox();
            this.lblReminderTime = new System.Windows.Forms.Label();
            this.nudReminderTime = new System.Windows.Forms.NumericUpDown();
            this.cbxReminderEnable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudReminderTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 200);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(260, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "OK";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblReminderText
            // 
            this.lblReminderText.AutoSize = true;
            this.lblReminderText.Location = new System.Drawing.Point(13, 13);
            this.lblReminderText.Name = "lblReminderText";
            this.lblReminderText.Size = new System.Drawing.Size(79, 13);
            this.lblReminderText.TabIndex = 1;
            this.lblReminderText.Text = "Reminder Text:";
            // 
            // rctReminderText
            // 
            this.rctReminderText.Location = new System.Drawing.Point(13, 30);
            this.rctReminderText.Name = "rctReminderText";
            this.rctReminderText.Size = new System.Drawing.Size(259, 96);
            this.rctReminderText.TabIndex = 2;
            this.rctReminderText.Text = "";
            // 
            // lblReminderTime
            // 
            this.lblReminderTime.AutoSize = true;
            this.lblReminderTime.Location = new System.Drawing.Point(13, 133);
            this.lblReminderTime.Name = "lblReminderTime";
            this.lblReminderTime.Size = new System.Drawing.Size(81, 13);
            this.lblReminderTime.TabIndex = 3;
            this.lblReminderTime.Text = "Reminder Time:";
            // 
            // nudReminderTime
            // 
            this.nudReminderTime.Location = new System.Drawing.Point(13, 150);
            this.nudReminderTime.Name = "nudReminderTime";
            this.nudReminderTime.Size = new System.Drawing.Size(259, 20);
            this.nudReminderTime.TabIndex = 4;
            // 
            // cbxReminderEnable
            // 
            this.cbxReminderEnable.AutoSize = true;
            this.cbxReminderEnable.Location = new System.Drawing.Point(13, 177);
            this.cbxReminderEnable.Name = "cbxReminderEnable";
            this.cbxReminderEnable.Size = new System.Drawing.Size(119, 17);
            this.cbxReminderEnable.TabIndex = 5;
            this.cbxReminderEnable.Text = "Reminder Enabled?";
            this.cbxReminderEnable.UseVisualStyleBackColor = true;
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 233);
            this.Controls.Add(this.cbxReminderEnable);
            this.Controls.Add(this.nudReminderTime);
            this.Controls.Add(this.lblReminderTime);
            this.Controls.Add(this.rctReminderText);
            this.Controls.Add(this.lblReminderText);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Reminder";
            this.Text = "Reminder";
            ((System.ComponentModel.ISupportInitialize)(this.nudReminderTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblReminderText;
        private System.Windows.Forms.RichTextBox rctReminderText;
        private System.Windows.Forms.Label lblReminderTime;
        private System.Windows.Forms.NumericUpDown nudReminderTime;
        private System.Windows.Forms.CheckBox cbxReminderEnable;
    }
}