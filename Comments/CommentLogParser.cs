using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
namespace Comments
{
    class CommentLogParser
    {
        public static List<CommentLog> GetLogsByPath(string path)
        {
            var logs = new List<CommentLog>();
            Regex match = new Regex(@"^\d{2}:\d{2}:\d{2} - .*$");
            string[] lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                if (match.IsMatch(line))
                {
                    var splitIndex = line.IndexOf('-');
                    var dateTimeString = line.Substring(0, splitIndex).Trim();
                    var eventText = line.Substring(splitIndex, line.Length - splitIndex).Trim();

                    var dateTime = DateTime.ParseExact(dateTimeString, "HH:mm:ss", CultureInfo.InvariantCulture);
                    logs.Add(new CommentLog(dateTime, eventText, line));
                }
            }
            return logs;
        }

        public static CommentLog ParseRawLog(string rawLog)
        {
            var splitIndex = rawLog.IndexOf('-');
            var dateTimeString = rawLog.Substring(0, splitIndex).Trim();
            var eventText = rawLog.Substring(splitIndex, rawLog.Length - splitIndex).Trim();

            var dateTime = DateTime.ParseExact(dateTimeString, "HH:mm:ss", CultureInfo.InvariantCulture);
            return new CommentLog(dateTime, eventText, rawLog);
        }

        public static List<string> GetRawData(string path)
        {
            var logs = new List<string>();
            Regex match = new Regex(@"^\d{2}:\d{2}:\d{2} - .*$");
            string[] lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                if (match.IsMatch(line))
                {
                    logs.Add(line.Trim());
                }
            }
            return logs;
        }
    }
}
