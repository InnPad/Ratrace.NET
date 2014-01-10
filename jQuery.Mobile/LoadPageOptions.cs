// LoadPageOptions.cs
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class LoadPageOptions
    {
        /// <summary>
        /// (object or string, default: undefined)
        /// The data to send with an Ajax page request.
        /// </summary>
        public object data;

        /// <summary>
        /// (number (in ms), default: 50)
        /// Forced delay before the loading message is shown. This is meant to allow 
        /// time for a page that has already been visited to be fetched from cache 
        /// without a loading message.
        /// </summary>
        public Number loadMsgDelay;

        /// <summary>
        /// (jQuery collection, default: $.mobile.pageContainer)
        /// Specifies the element that should contain the page after it is loaded.
        /// </summary>
        public jQueryObject pageContainer;

        /// <summary>
        /// (boolean, default: false)
        /// Forces a reload of a page, even if it is already in the DOM of the 
        /// page container.
        /// </summary>
        public bool reloadPage;

        /// <summary>
        /// (string, default: undefined)
        /// The data-role value to be used when displaying the page. By default 
        /// this is undefined which means rely on the value of the @data-role 
        /// attribute defined on the element.
        /// </summary>
        public string role;

        /// <summary>
        /// (boolean, default: false)
        /// Decides whether or not to show the loading message when loading 
        /// external pages.
        /// </summary>
        public bool showLoadMsg;

        /// <summary>
        /// (string, default: "get")
        /// Specifies the method ("get" or "post") to use when making a page request.
        /// </summary>
        public string type;

        public LoadPageOptions()
        {
        }

        public LoadPageOptions(params object[] nameValuePairs)
        {
        }
    }
}
