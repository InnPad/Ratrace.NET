// Ellipse.cs
//

using System;
using System.Collections.Generic;

namespace Kinetic
{
    /// <summary>
    /// Ellipse.
    /// </summary>
    public class Ellipse : Shape
    {
        /// <summary>
        /// Ellipse constructor.
        /// </summary>
        /// <param name="config"></param>
        public Ellipse(ShapeConfig config)
            : base(config)
        {
        }

        /// <summary>
        /// Get radius.
        /// </summary>
        /// <returns></returns>
        public Custom.Vector getRadius()
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
}
