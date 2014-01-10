// Text.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    /// <summary>
    /// Text.
    /// </summary>
    public class Text : Shape
    {
        /// <summary>
        /// Text constructor.
        /// </summary>
        /// <param name="config"></param>
        public Text(TextConfig config)
            : base(config)
        {
        }

        /// <summary>
        /// Get horizontal align.
        /// </summary>
        /// <returns>align can be 'left', 'center', or 'right'</returns>
        public string getAlign()
        {
            return null;
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
        /// Get font style. Can be 'normal', 'italic', or 'bold'. 'normal' is the default.
        /// </summary>
        /// <returns>Can be 'normal', 'italic', or 'bold'. 'normal' is the default.</returns>
        public string getFontStyle()
        {
            return null;
        }

        /// <summary>
        /// Get height.
        /// </summary>
        /// <returns></returns>
        public Number getHeight()
        {
            return -1;
        }

        /// <summary>
        /// Get line height. Sefault is 1
        /// </summary>
        /// <returns>Line height. Sefault is 1</returns>
        public Number getLineHeight()
        {
            return -1;
        }

        /// <summary>
        /// Get padding
        /// </summary>
        /// <returns></returns>
        public int getPadding()
        {
            return -1;
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
        /// Get text height.
        /// </summary>
        /// <returns></returns>
        public Number getTextHeight()
        {
            return -1;
        }

        /// <summary>
        /// Get text width.
        /// </summary>
        /// <returns></returns>
        public Number getTextWidth()
        {
            return -1;
        }

        /// <summary>
        /// Get width.
        /// </summary>
        /// <returns></returns>
        public Number getWidth()
        {
            return null;
        }

        /// <summary>
        /// Set horizontal align of text.
        /// </summary>
        /// <param name="align">align can be 'left', 'center', or 'right'</param>
        public void setAlign(string align)
        {
        }

        /// <summary>
        /// Set font family.
        /// </summary>
        /// <param name="fontFamily"></param>
        public void setFontFamily(string fontFamily)
        {
        }

        /// <summary>
        /// Set font size in pixels.
        /// </summary>
        /// <param name="fontSize"></param>
        public void setFontSize(Number fontSize)
        {
        }

        /// <summary>
        /// Set font style. Can be 'normal', 'italic', or 'bold'. 'normal' is the default.
        /// </summary>
        /// <param name="fontStyle">can be 'normal', 'italic', or 'bold'. 'normal' is the default.</param>
        public void setFontStyle(string fontStyle)
        {
        }

        /// <summary>
        /// Set line height.
        /// </summary>
        /// <param name="lineHeight"></param>
        public void setLineHeight(Number lineHeight)
        {
        }

        /// <summary>
        /// Set padding.
        /// </summary>
        /// <param name="padding"></param>
        public void setPadding(int padding)
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
    public class TextConfig : TextPathConfig
    {
        /// <summary>
        /// Optional. Can be left, center, or right.
        /// </summary>
        public string align;

        /// <summary>
        /// Optional.
        /// </summary>
        public Number padding;

        /// <summary>
        /// Optional. Default is auto.
        /// </summary>
        public Number width;

        /// <summary>
        /// Optional. default is auto.
        /// </summary>
        public Number height;

        /// <summary>
        /// Optional. Default is 1.
        /// </summary>
        public Number lineHeight;
    }
}
