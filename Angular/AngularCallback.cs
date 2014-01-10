// AngularCallback.cs
//

using System;
using System.Collections.Generic;

namespace AngularApi
{
    public delegate void AngularCallback(AngularStatic angular);

    public delegate void Navigate(string path);
}
