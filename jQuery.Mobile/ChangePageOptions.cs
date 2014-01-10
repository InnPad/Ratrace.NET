// ChangePageOptions.cs
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class ChangePageOptions
    {
        /// <summary>
        /// (boolean, default: false)
        /// By default, changePage() ignores requests to change to the current 
        /// active page. Setting this option to true, allows the request to 
        /// execute. Developers should note that some of the page transitions 
        /// assume that the fromPage and toPage of a changePage request are 
        /// different, so they may not animate as expected. Developers are 
        /// responsible for either providing a proper transition, or turning it 
        /// off for this specific case.
        /// </summary>
        public bool allowSamePageTransition;

        /// <summary>
        /// (boolean, default: true)
        /// Decides if the hash in the location bar should be updated.
        /// </summary>
        public bool changeHash;

        /// <summary>
        /// (object or string, default: undefined)
        /// The data to send with an Ajax page request.
        /// - Used only when the 'to' argument of changePage() is a URL.
        /// </summary>
        public object data;

        /// <summary>
        /// (string, default: undefined)
        /// The URL to use when updating the browser location upon changePage 
        /// completion. If not specified, the value of the data-url attribute 
        /// of the page element is used.
        /// </summary>
        public string dataUrl;

        /// <summary>
        /// (jQuery collection, default: $.mobile.pageContainer)
        /// Specifies the element that should contain the page.
        /// </summary>
        public jQueryObject pageContainer;

        /// <summary>
        /// (boolean, default: false)
        /// Forces a reload of a page, even if it is already in the DOM of 
        /// the page container.
        /// - Used only when the 'to' argument of changePage() is a URL.
        /// </summary>
        public bool reloadPage;

        /// <summary>
        /// (boolean, default: false)
        /// Decides what direction the transition will run when showing the 
        /// page.
        /// </summary>
        public bool reverse;

        /// <summary>
        /// (string, default: undefined)
        /// The data-role value to be used when displaying the page. By 
        /// default this is undefined which means rely on the value of 
        /// the @data-role attribute defined on the element.
        /// </summary>
        public string role;

        /// <summary>
        /// (boolean, default: true)
        /// Decides whether or not to show the loading message when 
        /// loading external pages.
        /// </summary>
        public bool showLoadMsg;

        /// <summary>
        /// (string, default: $.mobile.defaultPageTransition)
        /// The transition to use when showing the page.
        /// </summary>
        public jQueryTransitions transition;

        /// <summary>
        /// (string, default: "get")
        /// Specifies the method ("get" or "post") to use when making a page
        /// request.
        /// - Used only when the 'to' argument of changePage() is a URL.
        /// </summary>
        public string type;

        public ChangePageOptions()
        {
        }

        public ChangePageOptions(params object[] nameValuePairs)
        {
        }
    }
}
