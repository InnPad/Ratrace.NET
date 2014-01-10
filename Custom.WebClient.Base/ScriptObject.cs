// ScriptObject.cs
//

using System;
using System.Runtime.CompilerServices;

namespace Custom
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class ScriptObject
    {
        public static implicit operator bool(ScriptObject obj) { return obj; }
    }
}
