using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Comments
{
    public partial class TimeReview : Form
    {
        public TimeReview()
        {
            InitializeComponent();
        }
        private const string _dateFormat = "MM-dd-yyyy (ddd)";
        private void TimeReview_Load(object sender, EventArgs e)
        {
            const string format = "yyyyMMdd";
            var fileNames = Directory.GetFiles(CommentSetting.CommentLogLocation, "*.txt");
            var commentDates = new List<DateTime>();
            foreach (var file in fileNames)
            {
                DateTime myDateTime;
                if (DateTime.TryParseExact(Path.GetFileNameWithoutExtension(file), format, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal, out myDateTime))
                    commentDates.Add(myDateTime);
            }
            CommentSession.CommentDates = commentDates;
            List<int> commentYears = CommentSession.CommentDates.Select(x => Convert.ToInt32(x.Year)).Distinct().OrderByDescending(x => x).ToList();

            cbxYear.DataSource = commentYears;

            cbxDate.DataSource = CommentSession.CommentDates.Where(x => x.Year == commentYears[0]).ToList();
            cbxDate.FormatString = _dateFormat;
        }

        private void cbxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedYear = Convert.ToInt32(cbxYear.SelectedItem);
            cbxDate.DataSource = CommentSession.CommentDates.Where(x => x.Year == selectedYear).ToList();
        }

        private void cbxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime selectedDate;
            if (DateTime.TryParse(cbxDate.SelectedItem.ToString(), out selectedDate))
            {
                var fullPath = Path.Combine(CommentSetting.CommentLogLocation, selectedDate.ToString("yyyyMMdd") + ".txt");
                var logs = CommentLogParser.GetRawData(fullPath);
                cbxBeginningTime.DataSource = logs;
                cbxEndingTime.DataSource = new List<string>(logs);
            }
        }

        private void EventComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var beginEvent = cbxBeginningTime.SelectedItem.ToString();
            var endEvent = cbxEndingTime.SelectedItem.ToString();

            var beginTime = CommentLogParser.ParseRawLog(beginEvent).Timestamp;
            var endTime = CommentLogParser.ParseRawLog(endEvent).Timestamp;
            var eventDuration = (endTime - beginTime);
            txtTimeSpent.Text = (eventDuration.TotalMinutes / 60.00).ToString("0.##");
        }
    }
}
