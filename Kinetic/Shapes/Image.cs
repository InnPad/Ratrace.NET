// Image.cs
//

using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    /// <summary>
    /// Image.
    /// </summary>
    public class Image : Shape
    {
        /// <summary>
        /// Image constructor.
        /// </summary>
        /// <param name="config"></param>
        public Image(ImageConfig config)
            : base(config)
        {
        }
        
        /// <summary>
        /// Apply filter.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="filter"></param>
        /// <param name="config2"></param>
        /// <param name="callback"></param>
        public void applyFilter(ImageConfig config, object filter, ShapeConfig config2, Delegate callback)
        {   
        }

        /// <summary>
        /// Clear image hit region.
        /// </summary>
        public void clearImageHitRegion()
        {
        }

        /// <summary>
        /// Create image hit region which enables more accurate hit detection mapping of the image by avoiding event detections for transparent pixels
        /// </summary>
        /// <param name="callback"></param>
        public void createImageHitRegion(Delegate callback)
        {
        }

        /// <summary>
        /// Get crop.
        /// </summary>
        /// <returns></returns>
        public object getCrop() 
        {
            return null;
        }

        /// <summary>
        /// Get image.
        /// </summary>
        /// <returns></returns>
        public ImageElement getImage()
        {
            return null;
        }

        /// <summary>
        /// Set crop.
        /// </summary>
        /// <param name="config"></param>
        public void setCrop(object config)
        {
        }

        /// <summary>
        /// Set image.
        /// </summary>
        /// <param name="image"></param>
        public void setImage(ImageElement image)
        {
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class ImageConfig : ShapeConfig
    {
        public ImageElement image;

        /// <summary>
        /// Optional.
        /// </summary>
        public Object crop;

        public ImageConfig(params object[] nameValuePairs)
        {
        }
    }
}
