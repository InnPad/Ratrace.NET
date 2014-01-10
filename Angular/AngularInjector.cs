// AngularInjector.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using jQueryApi;

namespace AngularApi
{
    [Imported, IgnoreNamespace]
    public interface AngularInjector
    {
        object get(string name);

        object invoke(Function fn, object self, object locals);

        [AlternateSignature]
        object invoke(Function fn, object self);

        [AlternateSignature]
        object invoke(Function fn);

        object instantiate(object constructor, object locals);

        [AlternateSignature]
        object instantiate(object constructor);

        string[] annotate(Function fn);

        string[] annotate(string[] fns);

        string[] annotate(Delegate[] fns);
    }
}
