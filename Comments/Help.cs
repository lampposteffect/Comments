using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Comments
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            cbxPreviousLogs.Checked = CommentSetting.DisplayPreviousLog;
            cbxStartAndClose.Checked = CommentSetting.LogApplicationStartAndStop;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CommentSetting.DisplayPreviousLog = cbxPreviousLogs.Checked;
            CommentSetting.LogApplicationStartAndStop = cbxStartAndClose.Checked;
            btnCancel_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReminder_Click(object sender, EventArgs e)
        {
            using (var reminder = new Reminder())
            {
                reminder.ShowDialog();
            }
        }
    }
}