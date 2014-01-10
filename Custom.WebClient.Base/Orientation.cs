// Orientation.cs
//

using System;
using System.Runtime.CompilerServices;

namespace Custom
{
    [Imported, NamedValues]
    public enum Orientation : ScriptObject
    {
        [ScriptName("landscape")]
        Landscape,

        [ScriptName("portrait")]
        Portrait
    }
}
