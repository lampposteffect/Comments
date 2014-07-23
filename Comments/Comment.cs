using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Comments
{
    public partial class Comments : Form
    {
        private Screen _screen;
        private ScreenPosition _screenPosition;
        Timer reminderTimer = new Timer();
        
        string _todaysLog = Path.Combine(CommentSetting.CommentLogLocation, LogDisplayer.GetCommentLogName(DateTime.Now));

        public Comments()
        {
            InitializeComponent();
            reminderTimer.Interval = CommentSetting.ReminderIntervalInMilliseconds;
            reminderTimer.Enabled = CommentSetting.ReminderEnabled;
            reminderTimer.Tick += reminder_Tick;

            if (CommentSetting.LogApplicationStartAndStop)
                InsertLog("*Application Start*");
        }

        void reminder_Tick(object sender, EventArgs e)
        {
            MessageBox.Show(CommentSetting.ReminderText, "Reminder!");
        }

        private void Comments_Load(object sender, EventArgs e)
        {
            //Position textbox
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            _screenPosition = ScreenPositionHelper.GetFromString(CommentSetting.Position);

            if (Screen.AllScreens.Length == 1)
                _screen = Screen.PrimaryScreen;
            else
                _screen = Screen.AllScreens[CommentSetting.Screen];

            ScreenPositionHelper.UpdateScreenPosition(this, _screen);

            txtComments.Text = default(string);
            this.Opacity = CommentSetting.Opacity;
        }

        private void Comments_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 1.0;
        }

        private void Comments_MouseLeave(object sender, EventArgs e)
        {
            this.Opacity = CommentSetting.Opacity;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtComments.Text))
            {
                var comment = txtComments.Text.Trim();
                Direction direction = DirectionTranslator.TranslateString(comment);

                if (comment == "/exit" || comment == "/e" || comment == "/x")
                    Application.Exit();
                else if (comment == "/review" || comment == "/time" || comment == "/r" || comment == "/tr" || comment == "/timereview")
                    displayTimeReview();
                else if (comment == "/help" || comment == "/h")
                    displayHelpMenu();
                else if (comment == "/reminder" || comment == "/r")
                    displayReminderSettings();
                else if (comment.Contains("/pos") || comment.Contains("/position"))
                    positionForm(comment);
                else if (comment.Contains("/screen"))
                {
                    changeScreen(comment);
                    ScreenPositionHelper.UpdateScreenPosition(this, _screen);
                }
                else if (direction != Direction.Nondirectional)
                    changeFormPosition(direction, comment);
                else
                    InsertLog(comment);

                txtComments.Text = string.Empty;
                txtComments.Focus();
            }
        }

        private void displayTimeReview()
        {
            using (var timeReview = new TimeReview())
            {
                timeReview.ShowDialog();
            }
        }

        private void changeScreen(string comment)
        {
            //Split by a space.
            string[] split = comment.Split((char)32);
            int screenNumber = 0;

            if (split.Length < 2 || int.TryParse(split[1], out screenNumber) == false || screenNumber >= Screen.AllScreens.Length)
                return;

            CommentSetting.Screen = screenNumber;
            _screen = Screen.AllScreens[CommentSetting.Screen];
        }

        private void positionForm(string comment)
        {
            //Split by a space.
            string[] split = comment.Split((char)32);

            if (split.Length < 2) 
                return;
            
            ScreenPosition position = ScreenPositionHelper.GetFromString(split[1]);
            ScreenPositionHelper.DockForm(this, this._screen, position);
            CommentSetting.Position = position.ToString();
        }

        private void displayHelpMenu()
        {
            using (var help = new Help())
            {
                help.ShowDialog();
                reminderTimer.Interval = CommentSetting.ReminderIntervalInMilliseconds;
                this.Opacity = CommentSetting.Opacity;
            }
        }

        private void displayReminderSettings()
        {
            using (var reminderForm = new Reminder())
            {
                reminderForm.ShowDialog();
                reminderTimer.Interval = CommentSetting.ReminderIntervalInMilliseconds;
            }
        }

        private void changeFormPosition(Direction direction, string comment)
        {
            int numberOfPixels = Int32.Parse(Regex.Match(comment, @"\d+$").Value);

            if (direction == Direction.Up)
                CommentSetting.PositionTop -= numberOfPixels;
            else if (direction == Direction.Right)
                CommentSetting.PositionLeft += numberOfPixels;
            else if (direction == Direction.Left)
                CommentSetting.PositionLeft -= numberOfPixels;
            else if (direction == Direction.Down)
                CommentSetting.PositionTop += numberOfPixels;            
            else
                throw new Exception("Wtf are you doing passing a nondirectional direction to this method?");

            ScreenPositionHelper.UpdateScreenPosition(this, _screen);
        }

        public void InsertLog(string comment)
        {
            //Create directory if needed.
            if (!Directory.Exists(CommentSetting.CommentLogLocation))
                Directory.CreateDirectory(CommentSetting.CommentLogLocation);

            //Write comment to file.
            using (StreamWriter datFile = new StreamWriter(_todaysLog, File.Exists(_todaysLog)))
            {
                datFile.WriteLine(DateTime.Now.ToString("HH:mm:ss") + " - " + comment);
                datFile.WriteLine();
            }
        }

        private void Comments_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(reminderTimer.Enabled == true)
                reminderTimer.Stop();

            reminderTimer.Dispose();

#if !DEBUG
            if (CommentSetting.LogApplicationStartAndStop)
                InsertLog("*Application Close*");
#endif
        }
    }
}
