// Greeter.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AngularApi;

namespace Custom
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class Greeter
    {
        public string Saludation;

        public Action<Location> Localize;

        public Func<string, string> Greet;

        public Greeter(params object[] nameValuePairs)
        {
        }
    }
}
