using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Comments
{
    public static class LogDisplayer
    {
        public static string GetCommentLogName(DateTime date)
        {
            return date.ToString("yyyyMMdd") + ".txt";
        }

        public static void DisplayPreviousDayLog()
        {
            var yesterday = DateTime.Now.AddDays(-1);
            var yesterdaysLog = Path.Combine(CommentSetting.CommentLogLocation, GetCommentLogName(yesterday));

            if (File.Exists(yesterdaysLog))
                System.Diagnostics.Process.Start(CommentSetting.TextEditor, yesterdaysLog);
        }

        public static void ShowTodaysLog(string logName)
        {
            if (File.Exists(logName))
                System.Diagnostics.Process.Start(CommentSetting.TextEditor, logName);
        }

        public static void ShowAllLogs()
        {
            if (!Directory.Exists(CommentSetting.CommentLogLocation))
                Directory.CreateDirectory(CommentSetting.CommentLogLocation);

            System.Diagnostics.Process.Start("explorer.exe", CommentSetting.CommentLogLocation);
        }
    }
}
