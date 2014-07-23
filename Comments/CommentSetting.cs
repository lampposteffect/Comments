using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comments
{
    /// <summary>
    /// These settings persist in the app.config even after the app closes.
    /// </summary>
    public static class CommentSetting
    {
        /// <summary>
        /// Where comment logs are stored at.
        /// </summary>
        public static string CommentLogLocation
        {
            get { return Properties.Settings.Default.CommentLogLocation; }
            set
            {
                Properties.Settings.Default.CommentLogLocation = value;
                Properties.Settings.Default.Save();
            }
        }
        /// <summary>
        /// Distance from the top edge of the screen
        /// </summary>
        public static int PositionTop
        {
            get { return Properties.Settings.Default.positionTop; }
            set
            {
                Properties.Settings.Default.positionTop = value;
                Properties.Settings.Default.Save();
            }
        }
        /// <summary>
        /// Distance from the left edge of the screen
        /// </summary>
        public static int PositionLeft
        {
            get { return Properties.Settings.Default.positionLeft; }
            set
            {
                Properties.Settings.Default.positionLeft = value;
                Properties.Settings.Default.Save();
            }
        }
        /// <summary>
        /// What text editor you open logs with
        /// </summary>
        public static string TextEditor
        {
            get { return Properties.Settings.Default.textEditor; }
            set
            {
                Properties.Settings.Default.textEditor = value;
                Properties.Settings.Default.Save();
            }
        }
        /// <summary>
        /// Reminder interval in minutes
        /// </summary>
        public static int ReminderIntervalInMinutes
        {
            get { return Properties.Settings.Default.reminderMinutes; }
            set
            {
                Properties.Settings.Default.reminderMinutes = value;
                Properties.Settings.Default.Save();
            }
        }
        /// <summary>
        /// Reminder interval in milliseconds
        /// </summary>
        public static int ReminderIntervalInMilliseconds
        {
            get { return ReminderIntervalInMinutes * 60 * 1000; }
        }
        /// <summary>
        /// Text that pops up when reminder ticks
        /// </summary>
        public static string ReminderText
        {
            get { return Properties.Settings.Default.reminderText; }
            set
            {
                Properties.Settings.Default.reminderText = value;
                Properties.Settings.Default.Save();
            }
        }
        /// <summary>
        /// Display yesterday's log on load?
        /// </summary>
        [Obsolete("Use TimeReview class instead")]
        public static bool DisplayPreviousLog
        {
            get { return Properties.Settings.Default.displayPreviousLog; }
            set
            {
                Properties.Settings.Default.displayPreviousLog = value;
                Properties.Settings.Default.Save();
            }
        }
        /// <summary>
        /// Log when the application starts and stops
        /// </summary>
        public static bool LogApplicationStartAndStop
        {
            get { return Properties.Settings.Default.logApplicationStartAndStop; }
            set
            {
                Properties.Settings.Default.logApplicationStartAndStop = value;
                Properties.Settings.Default.Save();
            }
        }
        /// <summary>
        /// Enabled/disable reminder timer
        /// </summary>
        public static bool ReminderEnabled
        {
            get { return Properties.Settings.Default.reminderEnabled; }
            set
            {
                Properties.Settings.Default.reminderEnabled = value;
                Properties.Settings.Default.Save();
            }
        }
        /// <summary>
        /// User friendly position relative to the active monitor
        /// topleft, topright, bottomleft, bottomright
        /// </summary>
        public static string Position
        {
            get { return Properties.Settings.Default.Position; }
            set
            {
                Properties.Settings.Default.Position = value;
                Properties.Settings.Default.Save();
            }
        }
        /// <summary>
        /// Index in the array of available screens
        /// </summary>
        public static int Screen
        {
            get { return Properties.Settings.Default.Screen; }
            set
            {
                Properties.Settings.Default.Screen = value;
                Properties.Settings.Default.Save();
            }
        }
        /// <summary>
        /// Opacity value of the main Comment form
        /// </summary>
        public static double Opacity
        {
            get { return Properties.Settings.Default.Opacity; }
            set
            {
                Properties.Settings.Default.Opacity = value;
                Properties.Settings.Default.Save();
            }
        }
    }
}
