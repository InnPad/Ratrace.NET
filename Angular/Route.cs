// Route.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AngularApi
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class Route
    {
        public object controller;
        public string template;
        public string templateUrl;
        public RouteMap resolve;
        public string key;
        public object factory;
        public object redirectTo;

        public Route(params object[] nameValuePairs) { }
    }
}
