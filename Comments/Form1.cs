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
        enum Direction { Up, Down, Left, Right, Nondirectional };
        string _todaysLog = Path.Combine(Properties.Settings.Default.CommentLogLocation, getCommentLogName(DateTime.Now));
        static bool _isFirstRun = true;

        public Comments()
        {
            InitializeComponent();
        }

        private void Comments_Load(object sender, EventArgs e)
        {
            //Position textbox
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width/2 - this.Width) + 400;

            //If current file doesn't exist this is probably the first start up of the day.
            if (!File.Exists(_todaysLog))
                displayPreviousDayLog();

            if (_isFirstRun)
            {
                InsertLog("*Application Start*");
                _isFirstRun = false;
            }

            txtComments.Text = default(string);
        }

        private static string getCommentLogName(DateTime date)
        {
            return date.ToString("yyyyMMdd") + ".txt";
        }

        private void ShowTodaysLog()
        {
            if (!File.Exists(_todaysLog))
                txtComments.Text = "No log for today.";
            else
                System.Diagnostics.Process.Start("notepad++.exe", _todaysLog);
        }

        private void ShowAllLogs()
        {
            if (!Directory.Exists(Properties.Settings.Default.CommentLogLocation))
                Directory.CreateDirectory(Properties.Settings.Default.CommentLogLocation);

            System.Diagnostics.Process.Start("explorer.exe", Properties.Settings.Default.CommentLogLocation);
        }

        private void Comments_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 1.0;
        }

        private void Comments_MouseLeave(object sender, EventArgs e)
        {
            this.Opacity = 0.15;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string messageText = string.Format(@"/exit, /e, or /x to Exit Application. {0}/todayslog or /t for Today's Log. {0}/logs or /l for Log Directory. {0}/yolo or /y for Yesterday's Log. {0}/help or /h to Display This Again.", Environment.NewLine);
            if (!String.IsNullOrWhiteSpace(txtComments.Text))
            {
                var comment = txtComments.Text.Trim();
                Direction direction = directionTranslator(comment);

                if (comment == "/exit" || comment == "/e" || comment == "/x")
                    Application.Exit();
                else if (comment == "/todayslog" || comment == "/t")
                    ShowTodaysLog();
                else if (comment == "/logs" || comment == "/l")
                    ShowAllLogs();
                else if (comment == "/help" || comment == "/h")
                    MessageBox.Show(messageText, "Help Menu");
                else if (comment == "/yolo" || comment == "/y" || comment == "/yesterday")
                    displayPreviousDayLog();
                else if (direction != Direction.Nondirectional)
                    changeFormPosition(direction, comment);
                else
                    InsertLog(comment);

                txtComments.Text = string.Empty;
                txtComments.Focus();
            }
        }

        private void changeFormPosition(Direction direction, string comment)
        {
            int numberOfPixels = Int32.Parse(Regex.Match(comment, @"\d+$").Value);

            if (direction == Direction.Up)
                this.Top = this.Top - numberOfPixels;
            else if (direction == Direction.Right)
                this.Left = this.Left + numberOfPixels;
            else if (direction == Direction.Left)
                this.Left = this.Left - numberOfPixels;
            else if (direction == Direction.Down)
                this.Top = this.Top + numberOfPixels;
            else
                throw new Exception("Wtf are you doing passing a nondirectional direction to this method?");
        }

        private Direction directionTranslator(string checkText)
        {
            if (Regex.Match(checkText, "^up.*[0-9]+$").Success)
                return Direction.Up;
            else if (Regex.Match(checkText, "^left.*[0-9]+$").Success)
                return Direction.Left;
            else if (Regex.Match(checkText, "^right.*[0-9]+$").Success)
                return Direction.Right;
            else if (Regex.Match(checkText, "^down.*[0-9]+$").Success)
                return Direction.Down;
            else
                return Direction.Nondirectional;
        }

        private void displayPreviousDayLog()
        {
            var yesterday = DateTime.Now.AddDays(-1);
            var yesterdaysLog = Path.Combine(Properties.Settings.Default.CommentLogLocation, getCommentLogName(yesterday));

            if(File.Exists(yesterdaysLog))
                System.Diagnostics.Process.Start("notepad++.exe", yesterdaysLog);            
        }

        public void InsertLog(string comment)
        {
            //Create directory if needed.
            if (!Directory.Exists(Properties.Settings.Default.CommentLogLocation))
                Directory.CreateDirectory(Properties.Settings.Default.CommentLogLocation);

            //Write comment to file.
            using (StreamWriter datFile = new StreamWriter(_todaysLog, File.Exists(_todaysLog)))
            {
                datFile.WriteLine(DateTime.Now.ToString("HH:mm:ss") + " - " + comment);
                datFile.WriteLine();
            }
        }

        private void Comments_FormClosing(object sender, FormClosingEventArgs e)
        {
            InsertLog("*Application Close*");
        }
    }
}
