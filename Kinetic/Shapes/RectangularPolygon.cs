// RectangularPolygon.cs
//

using System;
using System.Collections.Generic;

namespace Kinetic
{
    /// <summary>
    /// RegularPolygon.
    /// </summary>
    public class RectangularPolygon : Shape
    {
        /// <summary>
        /// RegularPolygon constructor.
        /// </summary>
        /// <param name="config"></param>
        public RectangularPolygon(ShapeConfig config)
            : base(config)
        {
        }

        /// <summary>
        /// Get radius
        /// </summary>
        /// <returns></returns>
        public Number getRadius()
        {
            return null;
        }

        /// <summary>
        /// Get number of sides
        /// </summary>
        /// <returns></returns>
        public Number getSides()
        {
            return -1;
        }

        /// <summary>
        /// Set radius
        /// </summary>
        /// <param name="radius"></param>
        public void setRadius(Number radius)
        {
        }
        
        /// <summary>
        /// set number of sides
        /// </summary>
        /// <param name="sides"></param>
        public void setSides(Number sides)
        {
        }
    }
}
