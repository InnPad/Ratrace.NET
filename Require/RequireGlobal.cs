// RequireGlobal.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RequireApi
{
    [Imported, GlobalMethods]
    public class RequireGlobal
    {
        public static void Define(string name, Delegate callback)
        {
        }

        public static void Define(string name, string[] dependencies, Delegate callback)
        {
        }

        public static void Define(string[] dependencies, Delegate callback)
        {
        }

        /// <summary>
        /// Using Require.js
        /// </summary>
        /// <param name="scripts"></param>
        public static void Require(string[] scripts)
        {
        }

        /// <summary>
        /// Using Require.js
        /// </summary>
        /// <param name="scripts"></param>
        /// <param name="callback"></param>
        public static void Require(string[] scripts, Delegate callback)
        {
        }
    }
}
