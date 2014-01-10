// jQueryTransitions.cs
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi
{
    [Imported, NamedValues]
    public enum jQueryTransitions
    {
        [ScriptName("none")]
        None,

        [ScriptName("slide")]
        Slide,

        [ScriptName("slideup")]
        SlideUp,

        [ScriptName("slidedown")]
        SlideDown,

        [ScriptName("pop")]
        Pop,

        [ScriptName("fade")]
        Fade,

        [ScriptName("flip")]
        Flip
    }
}
