// ActionHash.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AngularApi
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class ActionHash
    {
        public ActionHash(params object[] nameValuePairs) { }

        [IntrinsicProperty]
        public extern Action this[string action] { get; set; }
    }
}
