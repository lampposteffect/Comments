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
            updateOpacity();
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

        private void tkbOpacity_Scroll(object sender, EventArgs e)
        {
            if (tkbOpacity.Value == 0)
                CommentSetting.Opacity = 0.0;
            else
                CommentSetting.Opacity = (double)tkbOpacity.Value / (double)20;

            updateOpacity();
        }

        private void updateOpacity()
        {
            tkbOpacity.Value = Convert.ToInt32(CommentSetting.Opacity * (double)20);
            lblOpacity.Text = "Opacity: " + Convert.ToString(CommentSetting.Opacity);
        }
    }
}