// Spline.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    public class Spline : Line
    {
        /// <summary>
        /// Spline constructor. Splines are defined by an array of points and a tension
        /// </summary>
        /// <param name="config"></param>
        public Spline(SplineConfig config)
            : base(config)
        {
        }

        /// <summary>
        /// Get tension
        /// </summary>
        /// <returns></returns>
        public Number getTension()
        {
            return null;
        }

        /// <summary>
        /// Set tension
        /// </summary>
        /// <param name="tension"></param>
        public void setTension(Number tension)
        {
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class SplineConfig : LineConfig
    {
        /// <summary>
        /// Optional, default value is 1. Higher values will result in a more curvy line. A value of 0 will result in no interpolation.
        /// </summary>
        public Number tension;

        public SplineConfig(params object[] nameValuePairs)
        {
        }
    }
}
