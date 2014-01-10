// AngularVersion.cs
//

using System;
using System.Runtime.CompilerServices;

namespace AngularApi
{
    [Imported, IgnoreNamespace]
    public interface AngularVersion
    {
        String full { get; set; }
        Number major { get; set; }
        Number minor { get; set; }
        Number dot { get; set; }
        string codeName { get; set; }
    }
}
