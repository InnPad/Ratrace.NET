// Filters.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    public class Filters
    {
        /// <summary>
        /// Brighten Filter.
        /// </summary>
        /// <param name="imageData"></param>
        /// <param name="config"></param>
        public static void Brighten(object imageData, BrightenConfig config)
        {
        }

        /// <summary>
        /// Grayscale Filter.
        /// </summary>
        /// <param name="imageData"></param>
        /// <param name="config"></param>
        public static void Grayscale(object imageData, object config)
        {
        }

        /// <summary>
        /// Invert Filter.
        /// </summary>
        /// <param name="imageData"></param>
        /// <param name="config"></param>
        public static void Invert(object imageData, object config)
        {
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class BrightenConfig
    {
        /// <summary>
        /// Brightness number from -255 to 255.  Positive values increase the brightness and negative values decrease the brightness, making the image darker.
        /// </summary>
        public int val;
    }
}
