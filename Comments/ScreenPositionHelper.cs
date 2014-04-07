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
            var leftPoint = 0;
            var topPoint = 0;

            if (((screen.WorkingArea.Left + CommentSetting.PositionLeft) + form.Width) > screen.WorkingArea.Width)
                CommentSetting.PositionLeft = screen.WorkingArea.Width - form.Width;

            if (((screen.WorkingArea.Top + CommentSetting.PositionTop) + form.Height) > screen.WorkingArea.Height)
                CommentSetting.PositionTop = screen.WorkingArea.Height - form.Height;

            if ((screen.WorkingArea.Top + CommentSetting.PositionTop) < screen.WorkingArea.Top)
                CommentSetting.PositionTop = 0;

            if ((screen.WorkingArea.Left + CommentSetting.PositionLeft) < screen.WorkingArea.Left)
                CommentSetting.PositionLeft = 0;

            leftPoint = screen.WorkingArea.Left + CommentSetting.PositionLeft;
            topPoint = screen.WorkingArea.Top + CommentSetting.PositionTop;

            form.Location = new Point(leftPoint, topPoint);
        }

        public static void UpdateScreenPosition(Form form, Screen screen, int top, int left)
        {
            CommentSetting.PositionTop = top;
            CommentSetting.PositionLeft = left;
            UpdateScreenPosition(form, screen);
        }
    }
}
