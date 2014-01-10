// Path.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    /// <summary>
    /// Path.
    /// </summary>
    public class Path : Shape
    {
        /// <summary>
        /// Path constructor.
        /// </summary>
        /// <param name="config"></param>
        public Path(PathConfig config)
            : base(config)
        {
        }

        /// <summary>
        /// Get SVG path data string.
        /// </summary>
        /// <returns></returns>
        public object getData()
        {
            return null;
        }

        /// <summary>
        /// Get parsed data array from the data string.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Path parsePathData(string data)
        {
            return null;
        }

        /// <summary>
        /// Set SVG path data string.
        /// </summary>
        /// <param name="SVG"></param>
        public void setData(string SVG)
        {
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class PathConfig : ShapeConfig
    {
        /// <summary>
        /// SVG data string
        /// </summary>
        public string data;
    }
}
