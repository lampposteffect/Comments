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
        
    }
}
