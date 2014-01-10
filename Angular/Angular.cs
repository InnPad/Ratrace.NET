// Angular.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AngularApi
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class Action
    {
        [ScriptName("method")]
        public string method;

        [ScriptName("params")]
        public Object Params;

        [ScriptName("isArray")]
        public bool IsArray;

        [ScriptName("headers")]
        public Object Headers;

        public Action(params object[] nameValuePairs) { }
    }
}
