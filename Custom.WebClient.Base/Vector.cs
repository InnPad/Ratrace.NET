// Vector.cs
//

using System;
using System.Runtime.CompilerServices;

namespace Custom
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class Vector : ScriptObject
    {
        public static implicit operator Point(Vector v) { return v; }
        
        /// <summary>
        /// Optional.
        /// </summary>
        [ScriptName("x")]
        public Number X;

        /// <summary>
        /// Optional.
        /// </summary>
        [ScriptName("y")]
        public Number Y;

        /// <summary>
        /// Optional.
        /// </summary>
        [ScriptName("z")]
        public Number Z;

        public Vector()
        {
        }

        public Vector(params object[] nameValuePairs)
        {
        }
    }
}
