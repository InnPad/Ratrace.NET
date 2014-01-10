// Margin.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Custom
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class OffsetRange : ScriptObject
    {
        [ScriptName("high")]
        public Number high;

        [ScriptName("low")]
        public Number low;

        [ScriptName("max")]
        public Number max;

        [ScriptName("min")]
        public Number min;

        public OffsetRange()
        {
        }

        public OffsetRange(params object[] nameValuePairs)
        {
        }
    }
}
