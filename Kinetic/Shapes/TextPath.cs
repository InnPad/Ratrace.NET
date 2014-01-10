// TextPath.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    /// <summary>
    /// Path.
    /// </summary>
    public class TextPath : Shape
    {
        /// <summary>
        /// Path constructor.
        /// </summary>
        /// <param name="config"></param>
        public TextPath(TextPathConfig config)
            : base(config)
        {
        }

        /// <summary>
        /// Get font family.
        /// </summary>
        /// <returns></returns>
        public string getFontFamily()
        {
            return null;
        }

        /// <summary>
        /// Get font size.
        /// </summary>
        /// <returns></returns>
        public Number getFontSize()
        {
            return -1;
        }

        /// <summary>
        /// Get font style.
        /// </summary>
        /// <returns></returns>
        public string getFontStyle()
        {
            return null;
        }

        /// <summary>
        /// Get text.
        /// </summary>
        /// <returns></returns>
        public string getText()
        {
            return null;
        }

        /// <summary>
        /// Get text height in pixels.
        /// </summary>
        /// <returns></returns>
        public Number getTextHeight()
        {
            return -1;
        }

        /// <summary>
        /// Get text width in pixels.
        /// </summary>
        /// <returns></returns>
        public Number getTextWidth()
        {
            return -1;
        }

        /// <summary>
        /// Set font family.
        /// </summary>
        /// <param name="fontFamily"></param>
        public void setFontFamily(string fontFamily)
        {
        }

        /// <summary>
        /// Set font size
        /// </summary>
        /// <param name="fontSize"></param>
        public void setFontSize(Number fontSize)
        {
        }

        /// <summary>
        /// Set font style. Can be 'normal', 'italic', or 'bold'. 'normal' is the default. 
        /// </summary>
        /// <param name="fontStyle"></param>
        public void setFontStyle(string fontStyle)
        {
        }

        /// <summary>
        /// Set text.
        /// </summary>
        /// <param name="text"></param>
        public void setText(string text)
        {
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class TextPathConfig : ShapeConfig
    {
        /// <summary>
        /// Optional. Default is Calibri
        /// </summary>
        public string fontFamily;

        /// <summary>
        /// Optional. Default is 12
        /// </summary>
        public Number fontSize;

        /// <summary>
        /// Optional. Can be normal, bold, or italic. Default is normal.
        /// </summary>
        public string fontStyle;

        /// <summary>
        /// Text
        /// </summary>
        public string text;

        public TextPathConfig(params object[] nameValuePairs)
        {
        }
    }
}
