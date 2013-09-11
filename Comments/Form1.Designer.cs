namespace Comments
{
    partial class Comments
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
            this.txtComments = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(1, 0);
            this.txtComments.Margin = new System.Windows.Forms.Padding(0);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(293, 20);
            this.txtComments.TabIndex = 0;
            this.txtComments.TextAlignChanged += new System.EventHandler(this.Comments_MouseEnter);
            this.txtComments.TextChanged += new System.EventHandler(this.Comments_MouseEnter);
            this.txtComments.MouseEnter += new System.EventHandler(this.Comments_MouseEnter);
            this.txtComments.MouseLeave += new System.EventHandler(this.Comments_MouseLeave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(290, 16);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(1, 1);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Comments
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 20);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtComments);
            this.MaximizeBox = false;
            this.Name = "Comments";
            this.Opacity = 0.15D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Comments";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Comments_FormClosing);
            this.Load += new System.EventHandler(this.Comments_Load);
            this.MouseEnter += new System.EventHandler(this.Comments_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Comments_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Button btnSubmit;
    }
}

