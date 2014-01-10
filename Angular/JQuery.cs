// Main.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AngularApi
{
    [Imported, IgnoreNamespace]
    public interface JQuery
    {
        object controller(string name);
        AngularInjector injector();
        Scope scope();
        object inheritedData(string key);
    }

    
}
