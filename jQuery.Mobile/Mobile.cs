// Mobile.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace jQueryApi
{
    /// <summary>
    /// jQueryMobile $.mobile
    /// </summary>
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class Mobile
    {
        // $.mobile.selectmenu.prototype.options.nativeMenu = false;
        [ScriptName("selectmenu.prototype.options")]
        public SelectMenuOptions SelectMenuOptions;

        /// <summary>
        /// (string, default: "ui-btn-active")
        /// The CSS class used for "active" button state.
        /// </summary>
        public string activeBtnClass;

        /// <summary>
        /// Reference to the page currently in view.
        /// </summary>
        public readonly string activePage;

        /// <summary>
        /// (string, default: "ui-page-active")
        /// The CSS class used for the page currently in 
        /// view or in a transition.
        /// </summary>
        public string activePageClass;

        /// <summary>
        /// (boolean, default: true)
        /// jQuery Mobile will automatically handle link clicks and 
        /// form submissions through Ajax, when possible. If false, 
        /// URL hash listening will be disabled as well, and URLs 
        /// will load as ordinary HTTP requests.
        /// </summary>
        public bool AjaxEnabled;

        /// <summary>
        /// (boolean, default: false)
        /// When jQuery Mobile attempts to load an external page, the request 
        /// runs through $.mobile.loadPage(). This will only allow cross-domain 
        /// requests if $.mobile.allowCrossDomainPages is set to true. Because 
        /// the jQuery Mobile framework tracks what page is being viewed within 
        /// the browser's location hash, it is possible for a cross-site scripting 
        /// (XSS) attack to occur if the XSS code in question can manipulate the 
        /// hash and set it to a cross-domain URL of its choice. This is the main
        /// reason that the default setting for $.mobile.allowCrossDomainPages is 
        /// set to false. In PhoneGap apps that must "phone home" by loading assets 
        /// off a remote server, both the $.support.cors AND $.mobile.allowCrossDomainPages 
        /// must be set to true.
        /// </summary>
        public bool allowCrossDomainPages;

        /// <summary>
        /// (boolean, default: true)
        /// When the DOM is ready, the framework should automatically call $.mobile.initializePage. 
        /// If false, the page will not initialize and will be visually hidden 
        /// until $.mobile.initializePage is manually called.
        /// </summary>
        public bool autoInitializePage;

        #region - $.mobile.buttonMarkup -

        /// <summary>
        /// (integer, default: 200)
        /// Set the delay for touch devices to add the hover and down classes 
        /// on touch interactions for buttons throughout the framework. Reducing 
        /// the delay here results in a more responsive feeling ui, but will 
        /// often result in the downstate being applied during page scrolling.
        /// </summary>
        [ScriptName("buttonMarkup.hoverDelay")]
        public int HoverDelay;

        #endregion - $.mobile.buttonMarkup -

        #region - $.mobile.changePage.defaults -

        /// <summary>
        /// 
        /// </summary>
        [ScriptName("changePage.defaults")]
        public readonly ChangePageDefaults ChangePageDefaults;

        #endregion - $.mobile.changePage.defaults -

        /// <summary>
        /// (string, default: 'pop')
        /// Set the default transition for dialog changes that use Ajax.
        /// Set to 'none' for no transitions.
        /// </summary>
        public jQueryTransitions DefaultDialogTransition;

        /// <summary>
        /// (string, default: 'fade')
        /// Set the default transition for page changes that use Ajax. 
        /// Note: default changed from 'slide' to 'fade' in 1.1. 
        /// Set to 'none' for no transitions.
        /// </summary>
        public jQueryTransitions DefaultPageTransition;

        /// <summary>
        /// (integer, default: 3)
        /// Set a scroll position breakpoint for transitions. If the scroll 
        /// position is greater than the window height multiplied by the 
        /// value that has been set, transition "none" will be used.
        /// </summary>
        public int getMaxScrollForTransition;

        /// <summary>
        /// Function that returns a boolean, default: a function returning 
        /// the value of $.support.mediaquery
        /// Any support conditions that must be met in order to proceed.
        /// </summary>
        public Func<string, bool> gradeA;

        /// <summary>
        /// (boolean, default: true)
        /// jQuery Mobile will automatically listen and handle changes to
        /// the location.hash. Disabling this will prevent jQuery Mobile 
        /// from handling hash changes, which allows you to handle them 
        /// yourself or use simple deep-links within a document that 
        /// scroll to a particular id.
        /// </summary>
        public bool HashListeningEnabled;

        /// <summary>
        /// (boolean, default: false)
        /// Warning: Setting this property to true will cause performance 
        /// degradation on enhancement. Once set, all automatic enhancements 
        /// made by the framework to each enhanceable element of the user's 
        /// markup will first check for a data-enhance=false parent node. 
        /// If one is found the markup will be ignored. This setting and the 
        /// accompanying data attribute provide a mechanism through which 
        /// users can prevent enhancement over large sections of markup.
        /// </summary>
        public bool ignoreContentEnabled;

        /// <summary>
        /// (boolean, default: true)
        /// jQuery Mobile will automatically bind the clicks on anchor tags 
        /// in your document. Setting this option to false will prevent all 
        /// anchor click handling including the addition of active button 
        /// state and alternate link bluring. This should only be used when 
        /// attempting to delegate the click management to another library 
        /// or custom code (such as Backbone.js, in order to use the router 
        /// exclusively to handle all hashchange events. The jQuery Mobile 
        /// $.mobile.changePage() method could be used to programatically 
        /// change the page)
        /// </summary>
        public bool LinkBindingEnabled;

        #region - $.mobile.loader.prototype.options -

        /// <summary>
        /// Loader prototype options
        /// ($.mobile.loader.prototype.options)
        /// </summary>
        [ScriptName("loader.prototype.options")]
        public MobileLoaderOptions LoaderOptions;

        #endregion - $.mobile.loader.prototype.options -

        /// <summary>
        /// (integer, boolean, default: false)
        /// Set a max width for transitions. The option accepts any number 
        /// representing a pixel width and its default value false. If a number 
        /// value is set, transition "none" will be used if the window is wider 
        /// than the specified value.
        /// </summary>
        public object maxTransitionWidth;

        /// <summary>
        /// (integer, default: 250)
        /// Minimum scroll distance that will be remembered when returning to a page.
        /// </summary>
        public int minScrollBack;

        /// <summary>
        /// (string, default: "")
        /// The namespace used in data attributes (e.g., data-role). Can be set to 
        /// any string, including a blank string which is the default. When using, 
        /// it's clearest if you include a trailing dash, such as "mynamespace-" which 
        /// maps to data-mynamespace-foo="...".
        /// If you use data- namespacing, you will need to update/override one selector 
        /// in the theme CSS. The following data selectors should incorporate the 
        /// namespace you're using:
        /// .ui-mobile [data-mynamespace-role=page], .ui-mobile [data-mynamespace-role=dialog], .ui-page { ...
        /// </summary>
        public string ns;

        #region - $.mobile.path -

        /// <summary>
        /// Url utilities.
        /// </summary>
        public readonly MobilePath path;

        #endregion - $.mobile.path -

        /// <summary>
        /// (string, default: "Error Loading Page")
        /// Set the text that appears when a page fails to load through Ajax.
        /// </summary>
        public string pageLoadErrorMessage;

        /// <summary>
        /// (string, default: "e")
        /// Set the theme that the error message box uses.
        /// </summary>
        public string pageLoadErrorMessageTheme;

        /// <summary>
        /// (boolean, default: false)
        /// Replace calls to window.history.back with PhoneGap's navigation 
        /// helper where it is available. This addresses navigation issues 
        /// on page refresh in Android PhoneGap applications using jQuery Mobile.
        /// </summary>
        public bool phonegapNavigationEnabled;

        /// <summary>
        /// (boolean, default: true)
        /// Enhancement to use history.replaceState in supported browsers, 
        /// to convert the hash-based Ajax URL into the full document path. 
        /// Note that we recommend disabling this feature if Ajax is disabled 
        /// or if external links are used extensively.
        /// </summary>
        public bool PushStateEnabled;

        /// <summary>
        /// (string, default: "ui-page")
        /// The url parameter used for referencing widget-generated sub-pages 
        /// (such as those generated by nested listviews). Translates to 
        /// example.html&amp;ui-page=subpageIdentifier. 
        /// The hash segment before &amp;ui-page= is used by the framework for 
        /// making an Ajax request to the URL where the sub-page exists.
        /// </summary>
        public string subPageUrlKey;

        /// <summary>
        /// ([transition] string, default: "fade")
        /// Set the fallback transition for browsers that don't support 
        /// 3D transforms for a specific transition type.
        /// </summary>
        public string transitionFallbacks;

        /// <summary>
        /// Programmatically change from one page to another. This method 
        /// is used internally for the page loading and transitioning that 
        /// occurs as a result of clicking a link or submitting a form, 
        /// when those features are enabled.
        /// </summary>
        /// <param name="to">
        /// (string or object, required)
        /// String: Absolute or relative URL. ("about/us.html")
        /// Object: jQuery collection object. ($("#about"))
        /// </param>
        public void ChangePage(object to) { }

        /// <summary>
        /// Programmatically change from one page to another. This method 
        /// is used internally for the page loading and transitioning that 
        /// occurs as a result of clicking a link or submitting a form, 
        /// when those features are enabled.
        /// </summary>
        /// <param name="to">
        /// (string or object, required)
        /// String: Absolute or relative URL. ("about/us.html")
        /// Object: jQuery collection object. ($("#about"))
        /// </param>
        /// <param name="options">
        /// (optional)
        /// </param>
        public void ChangePage(object to, ChangePageOptions options)
        {
        }

        /// <summary>
        /// Show or hide the page loading message, which is configurable via 
        /// $.mobile.loader prototype options as described in the widget docs 
        /// or can be controlled via a params object.
        /// </summary>
        /// <param name="show">'show'</param>
        public void Loading(string show)
        {
        }

        /// <summary>
        /// Show or hide the page loading message, which is configurable via 
        /// $.mobile.loader prototype options as described in the widget docs 
        /// or can be controlled via a params object.
        /// </summary>
        /// <param name="show">'show'</param>
        /// <param name="options">
        /// (optional)
        /// </param>
        public void Loading(string show, MobileLoaderOptions options)
        {
        }

        /// <summary>
        /// Load an external page, enhance its content, and insert it into 
        /// the DOM. This method is called internally by the changePage() 
        /// function when its first argument is a URL. This function does 
        /// not affect the current active page so it can be used to load 
        /// pages in the background. The function returns a deferred promise 
        /// object that gets resolved after the page has been enhanced and 
        /// inserted into the document.
        /// </summary>
        /// <param name="url">
        /// (string or object, required)
        /// A relative or absolute URL.
        /// </param>
        public void LoadPage(string url)
        {
        }

        /// <summary>
        /// Load an external page, enhance its content, and insert it into 
        /// the DOM. This method is called internally by the changePage() 
        /// function when its first argument is a URL. This function does 
        /// not affect the current active page so it can be used to load 
        /// pages in the background. The function returns a deferred promise 
        /// object that gets resolved after the page has been enhanced and 
        /// inserted into the document.
        /// </summary>
        /// <param name="url">
        /// (string or object, required)
        /// A relative or absolute URL.
        /// </param>
        /// <param name="options">
        /// (optional) 
        /// </param>
        public void LoadPage(string url, LoadPageOptions options)
        {
        }

        /// <summary>
        /// Scroll to a particular Y position without triggering scroll event listeners.
        /// </summary>
        /// <param name="yPos">
        /// (number, defaults to 0).
        /// Pass any number to scroll to that Y location.
        /// </param>
        public void SilentScroll(int yPos)
        {
        }
    }
}
