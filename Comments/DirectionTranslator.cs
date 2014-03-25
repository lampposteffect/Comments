using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Comments
{
    public class DirectionTranslator
    {
        public static Direction TranslateString(string direction)
        {
            if (Regex.Match(direction, @"^/up \d+$").Success)
                return Direction.Up;
            else if (Regex.Match(direction, @"^/left \d+$").Success)
                return Direction.Left;
            else if (Regex.Match(direction, @"^/right \d+$").Success)
                return Direction.Right;
            else if (Regex.Match(direction, @"^/down \d+$").Success)
                return Direction.Down;
            else
                return Direction.Nondirectional;
        }
    }
}
