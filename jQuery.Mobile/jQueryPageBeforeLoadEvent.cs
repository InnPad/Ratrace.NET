// jQueryPageBeforeLoadEvent.cs
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi
{
    [Imported]
    public class jQueryPageBeforeLoadEvent : jQueryEvent
    {
        /// <summary>
        /// The absolute or relative URL that was passed into $.mobile.loadPage() by the caller.
        /// </summary>
        [ScriptName("url")]
        public string Url;

        /// <summary>
        /// The absolute version of the url. If url was relative, it is resolved against the url used to load the current active page.
        /// </summary>
        [ScriptName("absUrl")]
        public string AbsoluteUrl;

        /// <summary>
        /// The filtered version of absUrl to be used when identifying the page and updating the browser location when the page is made active.
        /// </summary>
        [ScriptName("dataUrl")]
        public string DataUrl;

        /// <summary>
        /// Callbacks that call preventDefault() on the event, *MUST* call resolve() or reject() on this object so that changePage() requests resume processing. 
        /// </summary>
        [ScriptName("deferred")]
        public jQueryDeferred Deferred;

        /// <summary>
        /// This object contains the options that were passed into $.mobile.loadPage().
        /// </summary>
        [ScriptName("options")]
        public object Options;
    }
}
