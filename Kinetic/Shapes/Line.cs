// Line.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    public class Line : Shape
    {
        /// <summary>
        /// Line constructor. Lines are defined by an array of points
        /// </summary>
        /// <param name="config"></param>
        public Line(ShapeConfig config)
            : base(config)
        {
        }

        /// <summary>
        /// Get points array
        /// </summary>
        /// <returns></returns>
        public Point[] getPoints()
        {
            return null;
        }

        /// <summary>
        /// Set points array
        /// </summary>
        /// <param name="points">Can be a flattened array of points, an array of point arrays, or an array of point objects. e.g. [0,1,2,3], [[0,1],[2,3]] and [{x:0,y:1},{x:2,y:3}] are equivalent</param>
        public void setPoints(Point[] points)
        {
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class LineConfig : ShapeConfig
    {
        /// <summary>
        /// Can be a flattened array of points, an array of point arrays, or an array of point objects. e.g. [0,1,2,3], [[0,1],[2,3]] and [{x:0,y:1},{x:2,y:3}] are equivalent
        /// </summary>
        public Point[] points;

        public LineConfig()
        {
        }

        public LineConfig(params object[] nameValuePairs)
        {
        }
    }
}
