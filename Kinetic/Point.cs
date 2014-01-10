// Point.cs
//

using System;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class Point
    {
        /// <summary>
        /// Optional.
        /// </summary>
        public Number x;

        /// <summary>
        /// Optional.
        /// </summary>
        public Number y;

        public Point(params object[] nameValuePairs)
        {
        }
    }
}
