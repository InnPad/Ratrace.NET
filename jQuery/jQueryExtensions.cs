// jQueryExtensions.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace jQueryApi
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class jQueryExtensions
    {
        [Extern]
        public static jQueryObject Select(this jQueryObject context, string filter)
        {
            return context;
        }
    }
}
