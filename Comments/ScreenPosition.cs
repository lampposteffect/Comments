using System;
using System.Text.RegularExpressions;

namespace Comments
{
    public enum ScreenPosition
    {
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight
    }

    public static class ScreenPositionHelper
    {
        public static ScreenPosition GetFromString(string position)
        {
            Regex.Replace(position, "_", "");
            switch (position.Trim().ToLower() )
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
                    throw new ArgumentException("Incorrect position given", "position");
            }
        }
    }
}
