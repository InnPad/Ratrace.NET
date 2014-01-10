// Point.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Custom
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class Point : ScriptObject
    {
        public static implicit operator Vector(Point p) { return p; }
        
        public Number x;

        public Number y;

        public Number z;

        public Point()
        {
        }

        public Point(params object[] nameValuePairs)
        {
        }
    }
}
