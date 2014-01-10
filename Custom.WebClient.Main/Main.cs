// MainGlobal.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AngularApi;

namespace Custom
{
    [Imported, IgnoreNamespace, ScriptName("window")]
    public static class Main
    {
        public static readonly string ApiRoot = "";

        [ScriptName("mainModule")]
        public static AngularModule Application;
         
        [ScriptName("mainControllers")]
        public static AngularModule Controllers;

        [ScriptName("mainHome")]
        public static AngularModule Home;

        [ScriptName("mainService")]
        public static AngularModule Service;
    }
}
