// DayQuote.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Custom
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class DayQuote
    {
        public static implicit operator bool(DayQuote quote)
        {
            return quote;
        }

        public int day;

        public Number close;

        public Number min;

        public Number max;

        public Number open;

        public DayQuote()
        {
        }

        public DayQuote(params object[] nameValuePairs)
        {
        }
    }
}
