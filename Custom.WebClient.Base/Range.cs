// Margin.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Custom
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class Range : ScriptObject
    {
        public static implicit operator bool(Range range) { return range; }

        [ScriptName("high")]
        public Number high;

        [ScriptName("low")]
        public Number low;

        public Range()
        {
        }

        public Range(params object[] nameValuePairs)
        {
        }
    }
}
