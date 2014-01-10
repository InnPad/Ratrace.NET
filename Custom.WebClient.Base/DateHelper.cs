// DateHelper.cs
//

using System;
using System.Collections.Generic;

namespace Custom
{
    public class DateHelper
    {
        public static int GetDayOffset(Date from, Date to)
        {
            // The getTime() method returns the number of milliseconds between midnight of January 1, 1970 and the specified date.
            int fromMilliseconds = from.GetTime();
            int toMilliseconds = to.GetTime();
            int millisecondsOffset = toMilliseconds - fromMilliseconds;
            Number dayOffset = millisecondsOffset / (24 * 60 * 60 * 1000);
            return dayOffset;
        }

        public static string Date(int offset)
        {
            Date date = new Date(offset);
            string utc = date.ToISOString();
            return utc.Substr(0, utc.IndexOf('T'));
        }
    }
}
