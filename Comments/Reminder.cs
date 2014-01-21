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
    public partial class Reminder : Form
    {
        public Reminder()
        {
            InitializeComponent();
            rctReminderText.Text = CommentSetting.ReminderText;
            nudReminderTime.Value = CommentSetting.ReminderIntervalInMinutes;
            cbxReminderEnable.Checked = CommentSetting.ReminderEnabled;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CommentSetting.ReminderText = rctReminderText.Text;
            CommentSetting.ReminderIntervalInMinutes = Convert.ToInt32(nudReminderTime.Value);
            CommentSetting.ReminderEnabled = cbxReminderEnable.Checked;
            this.Close();
        }
    }
}
