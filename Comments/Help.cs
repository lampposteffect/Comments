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
            cbxStartAndClose.Checked = CommentSetting.LogApplicationStartAndStop;
            updateOpacity();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
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

        private void btnTimeReview_Click(object sender, EventArgs e)
        {
            using (var timeReview = new TimeReview())
            {
                timeReview.ShowDialog();
            }
        }

        private void btnLogLocation_Click(object sender, EventArgs e)
        {
            using (var fileBrowser = new FolderBrowserDialog())
            {
                fileBrowser.ShowDialog();
                CommentSetting.CommentLogLocation = fileBrowser.SelectedPath;
            }
        }

        private void btnDontTouch_Click(object sender, EventArgs e)
        {
            var random = new Random(DateTime.Now.Millisecond);
            var red = random.Next(0, 255);
            var blue = random.Next(0, 255);
            var green = random.Next(0, 255);
            btnDontTouch.ForeColor = Color.FromArgb(red, green, blue);
            btnDontTouch.BackColor = Color.FromArgb(blue, red, green);
        }
    }
}