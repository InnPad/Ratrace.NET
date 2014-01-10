// Circle.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    public class Circle : Shape
    {
        /// <summary>
        /// Circle constructor.
        /// </summary>
        /// <param name="config"></param>
        public Circle(ShapeConfig config)
            : base(config)
        {
        }

        /// <summary>
        /// Get radius.
        /// </summary>
        /// <returns></returns>
        public Number getRadius()
        {
            return null;
        }

        /// <summary>
        /// Set radius.
        /// </summary>
        /// <param name="radius"></param>
        public void setRadius(Number radius)
        {
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class CircleConfig : ShapeConfig
    {
        public Number radius;

        /// <summary>
        /// Optional fill.
        /// </summary>
        public string fill;

        /// <summary>
        /// Fill pattern image.
        /// </summary>
        public Image fillPatternImageOptional;

        public CircleConfig()
        {
        }

        public CircleConfig(params object[] nameValuePairs)
        {
        }
    }
}
