namespace Comments
{
    partial class TimeReview
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
            this.cbxBeginningTime = new System.Windows.Forms.ComboBox();
            this.lblBeginningTime = new System.Windows.Forms.Label();
            this.lblEndingTime = new System.Windows.Forms.Label();
            this.cbxEndingTime = new System.Windows.Forms.ComboBox();
            this.lblTimeSpent = new System.Windows.Forms.Label();
            this.txtTimeSpent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDate = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxBeginningTime
            // 
            this.cbxBeginningTime.FormattingEnabled = true;
            this.cbxBeginningTime.Location = new System.Drawing.Point(98, 37);
            this.cbxBeginningTime.Name = "cbxBeginningTime";
            this.cbxBeginningTime.Size = new System.Drawing.Size(319, 21);
            this.cbxBeginningTime.TabIndex = 0;
            this.cbxBeginningTime.SelectedIndexChanged += new System.EventHandler(this.EventComboBox_SelectedIndexChanged);
            // 
            // lblBeginningTime
            // 
            this.lblBeginningTime.AutoSize = true;
            this.lblBeginningTime.Location = new System.Drawing.Point(9, 40);
            this.lblBeginningTime.Name = "lblBeginningTime";
            this.lblBeginningTime.Size = new System.Drawing.Size(83, 13);
            this.lblBeginningTime.TabIndex = 1;
            this.lblBeginningTime.Text = "Beginning Time:";
            // 
            // lblEndingTime
            // 
            this.lblEndingTime.AutoSize = true;
            this.lblEndingTime.Location = new System.Drawing.Point(9, 67);
            this.lblEndingTime.Name = "lblEndingTime";
            this.lblEndingTime.Size = new System.Drawing.Size(69, 13);
            this.lblEndingTime.TabIndex = 2;
            this.lblEndingTime.Text = "Ending Time:";
            // 
            // cbxEndingTime
            // 
            this.cbxEndingTime.FormattingEnabled = true;
            this.cbxEndingTime.Location = new System.Drawing.Point(98, 64);
            this.cbxEndingTime.Name = "cbxEndingTime";
            this.cbxEndingTime.Size = new System.Drawing.Size(319, 21);
            this.cbxEndingTime.TabIndex = 3;
            this.cbxEndingTime.SelectedIndexChanged += new System.EventHandler(this.EventComboBox_SelectedIndexChanged);
            // 
            // lblTimeSpent
            // 
            this.lblTimeSpent.AutoSize = true;
            this.lblTimeSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSpent.Location = new System.Drawing.Point(9, 94);
            this.lblTimeSpent.Name = "lblTimeSpent";
            this.lblTimeSpent.Size = new System.Drawing.Size(80, 16);
            this.lblTimeSpent.TabIndex = 4;
            this.lblTimeSpent.Text = "Time Spent:";
            // 
            // txtTimeSpent
            // 
            this.txtTimeSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeSpent.Location = new System.Drawing.Point(98, 91);
            this.txtTimeSpent.Name = "txtTimeSpent";
            this.txtTimeSpent.Size = new System.Drawing.Size(278, 22);
            this.txtTimeSpent.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date:";
            // 
            // cbxDate
            // 
            this.cbxDate.FormattingEnabled = true;
            this.cbxDate.Location = new System.Drawing.Point(270, 10);
            this.cbxDate.Name = "cbxDate";
            this.cbxDate.Size = new System.Drawing.Size(147, 21);
            this.cbxDate.TabIndex = 7;
            this.cbxDate.SelectedIndexChanged += new System.EventHandler(this.cbxDate_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 13);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(35, 13);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year: ";
            // 
            // cbxYear
            // 
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Location = new System.Drawing.Point(98, 10);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(121, 21);
            this.cbxYear.TabIndex = 9;
            this.cbxYear.SelectedIndexChanged += new System.EventHandler(this.cbxYear_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hours";
            // 
            // TimeReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 130);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cbxDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimeSpent);
            this.Controls.Add(this.lblTimeSpent);
            this.Controls.Add(this.cbxEndingTime);
            this.Controls.Add(this.lblEndingTime);
            this.Controls.Add(this.lblBeginningTime);
            this.Controls.Add(this.cbxBeginningTime);
            this.Name = "TimeReview";
            this.Text = "Time Review";
            this.Load += new System.EventHandler(this.TimeReview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxBeginningTime;
        private System.Windows.Forms.Label lblBeginningTime;
        private System.Windows.Forms.Label lblEndingTime;
        private System.Windows.Forms.ComboBox cbxEndingTime;
        private System.Windows.Forms.Label lblTimeSpent;
        private System.Windows.Forms.TextBox txtTimeSpent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDate;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.Label label2;
    }
}