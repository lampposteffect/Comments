using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Comments
{
    public static class ScreenPositionHelper
    {
        public static ScreenPosition GetFromString(string position)
        {
            Regex.Replace(position, "_", "");
            Regex.Replace(position, "-", "");
            switch (position.Trim().ToLower())
            {
                case "topleft":
                    return ScreenPosition.TopLeft;
                case "topright":
                    return ScreenPosition.TopRight;
                case "bottomleft":
                    return ScreenPosition.BottomLeft;
                case "bottomright":
                    return ScreenPosition.BottomRight;
                default:
                    return ScreenPosition.None;
            }
        }

        public static void DockForm(Form form, Screen screen, ScreenPosition position)
        {
            switch (position)
            {
                case ScreenPosition.BottomRight:
                    CommentSetting.PositionTop = screen.WorkingArea.Height - form.Size.Height;
                    CommentSetting.PositionLeft = screen.WorkingArea.Width - form.Size.Width;
                    break;
                case ScreenPosition.BottomLeft:
                    CommentSetting.PositionTop = screen.WorkingArea.Height - form.Size.Height;
                    CommentSetting.PositionLeft = 0;
                    break;
                case ScreenPosition.TopRight:
                    CommentSetting.PositionTop = 0;
                    CommentSetting.PositionLeft = screen.WorkingArea.Width - form.Size.Width;
                    break;
                case ScreenPosition.TopLeft:
                    CommentSetting.PositionTop = 0;
                    CommentSetting.PositionLeft = 0;
                    break;
                default:
                    CommentSetting.PositionTop = 0;
                    CommentSetting.PositionLeft = 0;
                    break;
            }

            UpdateScreenPosition(form, screen);
        }

        public static void UpdateScreenPosition(Form form, Screen screen)
        {
            Console.WriteLine("Setting Left: {0}", CommentSetting.PositionLeft);
            Console.WriteLine("Setting Top: {0}", CommentSetting.PositionTop);
            form.Location = new Point(screen.WorkingArea.Left + CommentSetting.PositionLeft, screen.WorkingArea.Top + CommentSetting.PositionTop);
        }

        public static void UpdateScreenPosition(Form form, Screen screen, int top, int left)
        {
            CommentSetting.PositionTop = top;
            CommentSetting.PositionLeft = left;
            UpdateScreenPosition(form, screen);
        }
    }
}
