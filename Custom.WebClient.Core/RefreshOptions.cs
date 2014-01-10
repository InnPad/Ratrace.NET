// RefreshOptions.cs
//

using System;
using System.Runtime.CompilerServices;

namespace Custom
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class RefreshOptions
    {
        public Size Resize;

        public bool I18n;

        public RefreshOptions()
        {
        }

        public RefreshOptions(params object[] nameValuePairs)
        {
        }
    }
}
