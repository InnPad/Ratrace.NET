// DateRange.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Custom
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class DateRange : ScriptObject
    {
        public static implicit operator bool(DateRange range) { return range; }

        [ScriptName("high")]
        public string high;

        [ScriptName("low")]
        public string low;

        [ScriptName("max")]
        public string max;

        [ScriptName("min")]
        public string min;

        public DateRange()
        {
        }

        public DateRange(params object[] nameValuePairs)
        {
        }
    }
}
