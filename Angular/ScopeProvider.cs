// ScopeProvider.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AngularApi
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface ScopeProvider
    {
        void digestTtl(Number limit);
    }
}
