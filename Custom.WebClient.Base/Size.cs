// Size.cs
//

using System;
using System.Runtime.CompilerServices;

namespace Custom
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class Size : ScriptObject
    {
        [ScriptName("height")]
        public int height;

        [ScriptName("width")]
        public int width;

        public Size()
        {
        }

        public Size(params object[] nameValuePairs)
        {
        }
    }
}
