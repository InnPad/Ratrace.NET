// RouteStatic.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AngularApi
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface RouteStatic
    {
        Route current { get; set; }
        Route[] routes { get; set; }
        void reload();
    }
}
