// Wedge.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    /// <summary>
    /// Wedge.
    /// </summary>
    public class Wedge : Shape
    {
        /// <summary>
        /// Wedge constructor.
        /// </summary>
        /// <param name="config"></param>
        public Wedge(ShapeConfig config)
            : base(config)
        {
        }

        /// <summary>
        /// Get angle.
        /// </summary>
        /// <returns></returns>
        public Number getAngle()
        {
            return -1;
        }

        /// <summary>
        /// Get angle in degrees.
        /// </summary>
        /// <returns></returns>
        public Number getAngleDeg()
        {
            return -1;
        }

        /// <summary>
        /// Get clockwise.
        /// </summary>
        /// <returns></returns>
        public bool getClockwise()
        {
            return false;
        }

        /// <summary>
        /// Get radius.
        /// </summary>
        /// <returns></returns>
        public Number getRadius()
        {
            return -1;
        }

        /// <summary>
        /// Set angle.
        /// </summary>
        /// <param name="angle"></param>
        public void setAngle(Number angle)
        {
        }

        /// <summary>
        /// Set angle in degrees.
        /// </summary>
        /// <param name="deg"></param>
        public void setAngleDeg(Number deg)
        {
        }

        /// <summary>
        /// Set clockwise draw direction. If set to true, the wedge will be drawn clockwise If set to false, the wedge will be drawn anti-clockwise. The default is false. 
        /// </summary>
        /// <param name="clockwise"></param>
        public void setClockwise(bool clockwise)
        {
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
    public class WedgeConfig : ShapeConfig
    {
        public Number angle;

        public Number radius;

        /// <summary>
        /// Optional.
        /// </summary>
        public bool clockwise; 
    }
}
