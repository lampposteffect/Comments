using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comments
{
    class CommentLog
    {
        public CommentLog(DateTime timestamp, string log)
        {
            this.Timestamp = timestamp;
            this.Log = log;
        }

        public CommentLog(DateTime timestamp, string log, string rawData)
        {
            this.Timestamp = timestamp;
            this.Log = log;
            this.RawData = rawData;
        }
        public DateTime Timestamp { get; set; }
        public string Log { get; set; }
        public string RawData { get; set; }
    }
}
