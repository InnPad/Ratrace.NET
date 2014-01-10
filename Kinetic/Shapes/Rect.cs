// Rect.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    /// <summary>
    /// Rect.
    /// </summary>
    public class Rect : Shape
    {
        /// <summary>
        /// Rect constructor.
        /// </summary>
        /// <param name="config"></param>
        public Rect(RectConfig config)
            : base(config)
        {
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class RectConfig : ShapeConfig
    {
        /// <summary>
        /// Optional.
        /// </summary>
        public Number cornerRadius;

        public RectConfig()
        {
        }

        public RectConfig(params object[] nameValuePairs)
        {
        }
    }
}
