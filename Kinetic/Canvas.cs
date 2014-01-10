// Canvas.cs
//

using System;
using System.Collections.Generic;
using System.Html;
using System.Html.Media;
using System.Html.Media.Graphics;

namespace Kinetic
{
    /// <summary>
    /// Canvas Renderer
    /// </summary>
    public class Canvas
    {
        /// <summary>
        /// Canvas Renderer constructor
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="pixelRatio"></param>
        public Canvas(Number width, Number height, object pixelRatio)
        {
        }

        /// <summary>
        /// Apply shadow
        /// </summary>
        /// <param name="shape"></param>
        /// <param name="drawFunc"></param>
        public void applyShadow(Shape shape, Delegate drawFunc)
        {
        }

        /// <summary>
        /// Fill shape
        /// </summary>
        /// <param name="shape"></param>
        public void Fill(Shape shape)
        {
        }

        /// <summary>
        /// Fill, stroke, and apply shadows will only be applied to either the fill or stroke.
        /// </summary>
        /// <param name="shape"></param>
        public void fillStroke(Shape shape)
        {
        }

        /// <summary>
        /// Get canvas context
        /// </summary>
        public CanvasContext2D getContext()
        {
            return null;
        }

        /// <summary>
        /// Get canvas element
        /// </summary>
        /// <returns></returns>
        public Element getElement()
        {
            return null;
        }

        /// <summary>
        /// Get height
        /// </summary>
        /// <returns></returns>
        public Number getHeight()
        {
            return -1;
        }

        /// <summary>
        /// Get width
        /// </summary>
        /// <returns></returns>
        public Number getWidth()
        {
            return -1;
        }

        /// <summary>
        /// Set height
        /// </summary>
        /// <param name="height"></param>
        public void setHeight(Number height)
        {
        }

        /// <summary>
        /// Set size
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void setSize(Number width, Number height)
        {
        }

        /// <summary>
        /// Set width
        /// </summary>
        /// <param name="width"></param>
        public void setWidth(Number width)
        {
        }

        /// <summary>
        /// Stroke shape
        /// </summary>
        /// <param name="shape"></param>
        public void stroke(Shape shape)
        {
        }

        /// <summary>
        /// To data url
        /// </summary>
        /// <param name="mimeType"></param>
        /// <param name="quality"></param>
        /// <returns></returns>
        public string toDataURL(string mimeType, Number quality)
        {
            return null;
        }
    }
}
