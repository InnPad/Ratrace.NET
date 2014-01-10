// RequireConfigOptions.cs
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RequireApi
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class RequireConfigOptions
    {
        /// <summary>
        /// 3rd party script alias names (Easier to type "jquery" than "libs/jquery-1.8.2.min")
        /// </summary>
        public Dictionary paths;

        /// <summary>
        /// Sets the configuration for your third party scripts that are not AMD compatible
        /// </summary>
        public Dictionary shim;

        public RequireConfigOptions()
        {
        }

        public RequireConfigOptions(params object[] nameValuePairs)
        {
        }
    }
}
