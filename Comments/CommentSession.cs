using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comments
{
    /// <summary>
    /// Wrapper class for static variables. Acts as a windows form 'Sesssion'
    /// </summary>
    public static class CommentSession
    {
        /// <summary>
        /// List of DateTimes the correlate with comment files found on the user's system.
        /// </summary>
        public static List<DateTime> CommentDates { get; set; }
    }
}
