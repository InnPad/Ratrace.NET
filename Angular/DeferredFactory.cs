// DeferredFactory.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AngularApi
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface DeferredFactory
    {
        Deferred defer();

        Promise reject(object reason);

        Promise when(object value, AsyncCallback success, AsyncCallback error);

        [AlternateSignature]
        Promise when(object value, AsyncCallback success);

        [AlternateSignature]
        Promise when(object value);

        Promise all(Promise[] promises);
    }
}
