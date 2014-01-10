// Margin.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Custom
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class Margin : ScriptObject
    {
        [ScriptName("bottom")]
        public Number bottom;

        [ScriptName("left")]
        public Number left;

        [ScriptName("right")]
        public Number right;

        [ScriptName("top")]
        public Number top;

        public Margin()
        {
        }

        public Margin(params object[] nameValuePairs)
        {
        }
    }
}
