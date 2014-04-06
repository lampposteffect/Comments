namespace Comments
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxPreviousLogs = new System.Windows.Forms.CheckBox();
            this.lblCommands = new System.Windows.Forms.Label();
            this.btnReminder = new System.Windows.Forms.Button();
            this.cbxStartAndClose = new System.Windows.Forms.CheckBox();
            this.tkbOpacity = new System.Windows.Forms.TrackBar();
            this.lblOpacity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tkbOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(183, 535);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(146, 31);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "OK";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(10, 535);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 31);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbxPreviousLogs
            // 
            this.cbxPreviousLogs.AutoSize = true;
            this.cbxPreviousLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPreviousLogs.Location = new System.Drawing.Point(12, 360);
            this.cbxPreviousLogs.Name = "cbxPreviousLogs";
            this.cbxPreviousLogs.Size = new System.Drawing.Size(226, 24);
            this.cbxPreviousLogs.TabIndex = 4;
            this.cbxPreviousLogs.Text = "Display Previous Day\'s Log?";
            this.cbxPreviousLogs.UseVisualStyleBackColor = true;
            // 
            // lblCommands
            // 
            this.lblCommands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommands.Location = new System.Drawing.Point(10, 9);
            this.lblCommands.Name = "lblCommands";
            this.lblCommands.Size = new System.Drawing.Size(321, 348);
            this.lblCommands.TabIndex = 5;
            this.lblCommands.Text = resources.GetString("lblCommands.Text");
            // 
            // btnReminder
            // 
            this.btnReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReminder.Location = new System.Drawing.Point(10, 498);
            this.btnReminder.Name = "btnReminder";
            this.btnReminder.Size = new System.Drawing.Size(150, 31);
            this.btnReminder.TabIndex = 6;
            this.btnReminder.Text = "Reminder Settings";
            this.btnReminder.UseVisualStyleBackColor = true;
            this.btnReminder.Click += new System.EventHandler(this.btnReminder_Click);
            // 
            // cbxStartAndClose
            // 
            this.cbxStartAndClose.AutoSize = true;
            this.cbxStartAndClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStartAndClose.Location = new System.Drawing.Point(12, 386);
            this.cbxStartAndClose.Name = "cbxStartAndClose";
            this.cbxStartAndClose.Size = new System.Drawing.Size(278, 24);
            this.cbxStartAndClose.TabIndex = 7;
            this.cbxStartAndClose.Text = "Log Start and Close of Application?";
            this.cbxStartAndClose.UseVisualStyleBackColor = true;
            // 
            // tkbOpacity
            // 
            this.tkbOpacity.Location = new System.Drawing.Point(10, 445);
            this.tkbOpacity.Maximum = 20;
            this.tkbOpacity.Name = "tkbOpacity";
            this.tkbOpacity.Size = new System.Drawing.Size(319, 45);
            this.tkbOpacity.TabIndex = 8;
            this.tkbOpacity.Scroll += new System.EventHandler(this.tkbOpacity_Scroll);
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpacity.Location = new System.Drawing.Point(122, 421);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(92, 20);
            this.lblOpacity.TabIndex = 9;
            this.lblOpacity.Text = "Opacity: 0.0";
            // 
            // Help
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(343, 576);
            this.Controls.Add(this.lblOpacity);
            this.Controls.Add(this.tkbOpacity);
            this.Controls.Add(this.cbxStartAndClose);
            this.Controls.Add(this.btnReminder);
            this.Controls.Add(this.lblCommands);
            this.Controls.Add(this.cbxPreviousLogs);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Help";
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.tkbOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbxPreviousLogs;
        private System.Windows.Forms.Label lblCommands;
        private System.Windows.Forms.Button btnReminder;
        private System.Windows.Forms.CheckBox cbxStartAndClose;
        private System.Windows.Forms.TrackBar tkbOpacity;
        private System.Windows.Forms.Label lblOpacity;
    }
}