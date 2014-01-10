// Star.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    public class Star : Shape
    {
        public Star(StarConfig config)
            : base(config)
        {
        }

        /// <summary>
        /// Get inner radius.
        /// </summary>
        /// <returns></returns>
        public Number getInnerRadius()
        {
            return -1;
        }

        /// <summary>
        /// Get number of points.
        /// </summary>
        /// <returns></returns>
        public int getNumPoints()
        {
            return -1;
        }

        /// <summary>
        /// Get outer radius.
        /// </summary>
        /// <returns></returns>
        public Number getOuterRadius()
        {
            return -1;
        }

        /// <summary>
        /// Set inner radius
        /// </summary>
        /// <param name="radius"></param>
        public void setInnerRadius(Number radius)
        {
        }
        
        /// <summary>
        /// Set number of points.
        /// </summary>
        /// <param name="points"></param>
        public void setNumPoints(int points) 
        {
        }

        /// <summary>
        /// Set outer radius
        /// </summary>
        /// <param name="radius"></param>
        public void setOuterRadius(Number radius)
        {
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class StarConfig : ShapeConfig
    {
        public int numPoints;

        public Number innerRadius;

        public Number outerRadius;

        public StarConfig(params object[] nameValuePairs)
        {
        }
    }
}
