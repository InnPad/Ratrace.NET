// MobileLoaderOptions.cs
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class MobileLoaderOptions
    {
        /// <summary>
        /// (string, default: "a")
        /// The theme swatch for the message.
        /// </summary>
        public string theme;

        /// <summary>
        /// (string, default: "loading")
        /// The text of the message.
        /// </summary>
        public string text;

        /// <summary>
        /// (boolean, default: false)
        /// If true, the "spinner" image will be hidden when the message is shown.
        /// </summary>
        public bool textonly;

        /// <summary>
        /// (boolean, default: false)
        /// If true, the text value will be used under the spinner.
        /// </summary>
        public bool textVisible;

        /// <summary>
        /// (string, default: "")
        /// If this is set to a non empty string value, it will be used to replace 
        /// the entirety of the loader's inner html.
        /// </summary>
        public string html;

        public MobileLoaderOptions()
        {
        }

        public MobileLoaderOptions(params object[] nameValuePairs)
        {
        }
    }
}
