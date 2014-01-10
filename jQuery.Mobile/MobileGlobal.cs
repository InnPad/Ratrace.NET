// MobileGlobal.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using jQueryApi;

[Mixin(""), Imported, GlobalMethods, ScriptName("$")]
public static class MobileGlobal
{
    [ScriptName("mobile")]
    public static Mobile Mobile;
}