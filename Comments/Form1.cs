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
        string _todaysLog = Path.Combine(CommentSetting.CommentLogLocation, getCommentLogName(DateTime.Now));
        static bool _isFirstRun = true;
        static string _messageText = @"/exit, /e, or /x to Exit Application. \n" +
                                      "/todayslog or /t for Today's Log. \n" + 
                                      "/logs or /l for Log Directory. \n" +
                                      "/yolo or /y for Yesterday's Log. \n" + 
                                      "/help or /h to Display This Again. \n" + 
                                      "Repositioning: \n" + 
                                      "  right #\n" +
                                      "  left #\n" + 
                                      "  up #\n" +
                                      "  down #\n"; 

        public Comments()
        {
            InitializeComponent();
        }

        private void Comments_Load(object sender, EventArgs e)
        {
            //Position textbox
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Top = CommentSetting.PositionTop;
            this.Left = CommentSetting.PositionLeft;

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
                System.Diagnostics.Process.Start(CommentSetting.TextEditor, _todaysLog);
        }

        private void ShowAllLogs()
        {
            if (!Directory.Exists(CommentSetting.CommentLogLocation))
                Directory.CreateDirectory(CommentSetting.CommentLogLocation);

            System.Diagnostics.Process.Start("explorer.exe", CommentSetting.CommentLogLocation);
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
                    MessageBox.Show(_messageText, "Help Menu");
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
                CommentSetting.PositionTop = this.Top - numberOfPixels;
            else if (direction == Direction.Right)
                CommentSetting.PositionLeft = this.Left + numberOfPixels;
            else if (direction == Direction.Left)
                CommentSetting.PositionLeft = this.Left - numberOfPixels;
            else if (direction == Direction.Down)
                CommentSetting.PositionTop = this.Top + numberOfPixels;            
            else
                throw new Exception("Wtf are you doing passing a nondirectional direction to this method?");

            this.Top = CommentSetting.PositionTop;
            this.Left = CommentSetting.PositionLeft;
        }

        private Direction directionTranslator(string checkText)
        {
            if (Regex.Match(checkText, @"^up \d+$").Success)
                return Direction.Up;
            else if (Regex.Match(checkText, @"^left \d+$").Success)
                return Direction.Left;
            else if (Regex.Match(checkText, @"^right \d+$").Success)
                return Direction.Right;
            else if (Regex.Match(checkText, @"^down \d+$").Success)
                return Direction.Down;
            else
                return Direction.Nondirectional;
        }

        private void displayPreviousDayLog()
        {
            var yesterday = DateTime.Now.AddDays(-1);
            var yesterdaysLog = Path.Combine(CommentSetting.CommentLogLocation, getCommentLogName(yesterday));

            if(File.Exists(yesterdaysLog))
                System.Diagnostics.Process.Start(CommentSetting.TextEditor, yesterdaysLog);           
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
            InsertLog("*Application Close*");
        }
    }
}
