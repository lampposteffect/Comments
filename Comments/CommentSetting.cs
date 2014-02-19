using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comments
{
    public static class CommentSetting
    {
        public static string CommentLogLocation
        {
            get { return Properties.Settings.Default.CommentLogLocation; }
            set
            {
                Properties.Settings.Default.CommentLogLocation = value;
                Properties.Settings.Default.Save();
            }
        }
        public static int PositionTop
        {
            get { return Properties.Settings.Default.positionTop; }
            set
            {
                Properties.Settings.Default.positionTop = value;
                Properties.Settings.Default.Save();
            }
        }
        public static int PositionLeft
        {
            get { return Properties.Settings.Default.positionLeft; }
            set
            {
                Properties.Settings.Default.positionLeft = value;
                Properties.Settings.Default.Save();
            }
        }
        public static string TextEditor
        {
            get { return Properties.Settings.Default.textEditor; }
            set
            {
                Properties.Settings.Default.textEditor = value;
                Properties.Settings.Default.Save();
            }
        }
        public static int ReminderIntervalInMinutes
        {
            get { return Properties.Settings.Default.reminderMinutes; }
            set
            {
                Properties.Settings.Default.reminderMinutes = value;
                Properties.Settings.Default.Save();
            }
        }
        public static int ReminderIntervalInMilliseconds
        {
            get { return ReminderIntervalInMinutes * 60 * 1000; }
        }
        public static string ReminderText
        {
            get { return Properties.Settings.Default.reminderText; }
            set
            {
                Properties.Settings.Default.reminderText = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool DisplayPreviousLog
        {
            get { return Properties.Settings.Default.displayPreviousLog; }
            set
            {
                Properties.Settings.Default.displayPreviousLog = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool LogApplicationStartAndStop
        {
            get { return Properties.Settings.Default.logApplicationStartAndStop; }
            set
            {
                Properties.Settings.Default.logApplicationStartAndStop = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool ReminderEnabled
        {
            get { return Properties.Settings.Default.reminderEnabled; }
            set
            {
                Properties.Settings.Default.reminderEnabled = value;
                Properties.Settings.Default.Save();
            }
        }
        public static string Position
        {
            get { return Properties.Settings.Default.Position; }
            set
            {
                Properties.Settings.Default.Position = value;
                Properties.Settings.Default.Save();
            }
        }
        public static int Screen
        {
            get { return Properties.Settings.Default.Screen; }
            set
            {
                Properties.Settings.Default.Screen = value;
                Properties.Settings.Default.Save();
            }
        }
    }
}
