// ngResource.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AngularApi
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface ResourceItem
    {
        [ScriptName("$save")]
        void save(Object parameters, Delegate success, Delegate error);

        [ScriptName("$save"), AlternateSignature]
        void save(Object parameters, Delegate success);

        [ScriptName("$save"), AlternateSignature]
        void save(Object parameters);

        [ScriptName("$save"), AlternateSignature]
        void save();

        [ScriptName("$remove")]
        void remove(Object parameters, Delegate success, Delegate error);

        [ScriptName("$remove")]
        void remove(Object parameters, Delegate success);

        [ScriptName("$remove")]
        void remove(Object parameters);

        [ScriptName("$remove")]
        void remove();

        [ScriptName("$delete")]
        void delete(Object parameters, Delegate success, Delegate error);

        [ScriptName("$delete")]
        void delete(Object parameters, Delegate success);

        [ScriptName("$delete")]
        void delete(Object parameters);
    }
}