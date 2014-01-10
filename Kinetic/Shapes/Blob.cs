// Blob.cs
//

using System;
using System.Collections.Generic;

namespace Kinetic
{
    /// <summary>
    /// Blobs are defined by an array of points and a tension.
    /// </summary>
    public class Blob : Spline
    {
        /// <summary>
        /// Blob constructor.  Blobs are defined by an array of points and a tension 
        /// </summary>
        /// <param name="config"></param>
        public Blob(SplineConfig config)
            : base(config)
        {
        }
    }
}
