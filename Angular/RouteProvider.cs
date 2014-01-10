// RouteProvider.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AngularApi
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface RouteProvider
    {
        RouteProvider when(string path, Route route);
        RouteProvider otherwise(Route route);
    }
}
