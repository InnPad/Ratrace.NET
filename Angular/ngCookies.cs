// ngCookies.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AngularApi
{
    [Imported, ScriptNamespace("ngCookies")]
    public interface Cookies
    {
        Object this[string name] { get; set; }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface CookieStore
    {
        Object get(string key);
        void put(string key, Object value);
        void remove(string key);
    }
}