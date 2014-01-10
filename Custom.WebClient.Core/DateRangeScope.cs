// DateRangeScope.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AngularApi;

namespace Custom
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public abstract class DateRangeScope : Scope
    {
        public DateRangeSlider slider;
    }
}
