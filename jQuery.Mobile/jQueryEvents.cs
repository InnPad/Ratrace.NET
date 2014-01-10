// jQueryEvents.cs
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi
{
    [Imported, NamedValues]
    public enum jQueryEvents
    {
        /// <summary>
        /// jQuery Mobile exposes the animationComplete plugin, which you can 
        /// utilize after adding or removing a class that applies a CSS transition. 
        /// It can be used with page transition events.
        /// jQueryMobile
        /// </summary>
        [ScriptName("animationcomplete")]
        AnimationComplete,

        /// <summary>
        /// 
        /// </summary>
        [ScriptName("blur")]
        Blur,

        /// <summary>
        /// 
        /// </summary>
        [ScriptName("change")]
        Change,

        /// <summary>
        /// 
        /// </summary>
        [ScriptName("click")]
        Click,

        /// <summary>
        /// 
        /// </summary>
        [ScriptName("dblclick")]
        DoubleClick,

        /// <summary>
        /// 
        /// </summary>
        [ScriptName("error")]
        Error,

        /// <summary>
        /// 
        /// </summary>
        [ScriptName("focus")]
        Focus,

        /// <summary>
        /// 
        /// </summary>
        [ScriptName("focusin")]
        FocusIn,

        /// <summary>
        /// 
        /// </summary>
        [ScriptName("focusout")]
        FocusOut,

        /// <summary>
        /// 
        /// </summary>
        [ScriptName("keypress")]
        KeyPress,

        /// <summary>
        /// 
        /// </summary>
        [ScriptName("keydown")]
        KeyDown,

        /// <summary>
        /// 
        /// </summary>
        [ScriptName("keyup")]
        KeyUp,

        /// <summary>
        /// 
        /// </summary>
        [ScriptName("hover")]
        Hover,

        [ScriptName("mobileinit")]
        MobileInit,

        /// <summary>
        /// 
        /// </summary>
        [ScriptName("mousedown")]
        MouseDown,

        /// <summary>
        /// 
        /// </summary>
        [ScriptName("mouseenter")]
        MouseEnter,

        /// <summary>
        /// 
        /// </summary>
        [ScriptName("mouseleave")]
        MouseLeave,

        /// <summary>
        /// 
        /// </summary>
        [ScriptName("mousemove")]
        MouseMove,

        /// <summary>
        /// 
        /// </summary>
        [ScriptName("mouseout")]
        MouseOut,

        /// <summary>
        /// 
        /// </summary>
        [ScriptName("mouseover")]
        MouseOver,

        /// <summary>
        /// 
        /// </summary>
        [ScriptName("mouseup")]
        MouseUp,

        /// <summary>
        /// jQueryMobile
        /// </summary>
        [ScriptName("pagebeforeload")]
        PageBeforeLoad,

        /// <summary>
        /// jQueryMobile
        /// </summary>
        [ScriptName("pageload")]
        PageLoad,

        /// <summary>
        /// jQueryMobile
        /// </summary>
        [ScriptName("pageloadfailed")]
        PageLoadFailed,

        /// <summary>
        /// jQueryMobile
        /// </summary>
        [ScriptName("pagebeforechange")]
        PageBeforeChange,

        /// <summary>
        /// jQueryMobile
        /// </summary>
        [ScriptName("pagechange")]
        PageChange,

        /// <summary>
        /// jQueryMobile
        /// </summary>
        [ScriptName("pagechangefailed")]
        PageChangeFailed,

        /// <summary>
        /// jQueryMobile
        /// </summary>
        [ScriptName("pagebeforeshow")]
        PageBeforeShow,

        /// <summary>
        /// jQueryMobile
        /// </summary>
        [ScriptName("pagebeforehide")]
        PageBeforeHide,

        /// <summary>
        /// Triggered on the "toPage" after the transition animation has completed. 
        /// Callbacks for this event will receive a data object as their 2nd arg.
        /// param prevPage (object):
        /// A jQuery collection object that contains the page DOM element that we 
        /// just transitioned away from. Note that this collection is empty when the 
        /// first page is transitioned in during application startup.
        /// jQueryMobile
        /// </summary>
        [ScriptName("pageshow")]
        PageShow,

        /// <summary>
        /// Triggered on the "fromPage" after the transition animation has completed. 
        /// Callbacks for this event will receive a data object as their 2nd arg.
        /// jQueryMobile
        /// param: nextPage (object)
        /// A jQuery collection object that contains the page DOM element that we just 
        /// transitioned to.
        /// </summary>
        [ScriptName("pagehide")]
        PageHide,

        /// <summary>
        /// Triggered on the page being initialized, before most plugin 
        /// auto-initialization occurs.
        /// jQueryMobile
        /// </summary>
        [ScriptName("pagebeforecreate")]
        PageBeforeCreate,


        /// <summary>
        /// Triggered when the page has been created in the DOM (via ajax or other) 
        /// but before all widgets have had an opportunity to enhance the contained 
        /// markup. This event is most useful for user's wishing to create their 
        /// own custom widgets for child markup enhancement as the jquery mobile 
        /// widgets do.
        /// $( '#aboutPage' ).live( 'pagecreate',function(event){
        ///    ( ":jqmData(role='sweet-plugin')" ).sweetPlugin();
        /// });
        /// jQueryMobile
        /// </summary>
        [ScriptName("pagecreate")]
        PageCreate,


        /// <summary>
        /// Triggered on the page being initialized, after initialization occurs. We 
        /// recommend binding to this event instead of DOM ready() because this will 
        /// work regardless of whether the page is loaded directly or if the content 
        /// is pulled into another page as part of the Ajax navigation system.
        /// $( '#aboutPage' ).live( 'pageinit',function(event) {
        ///    alert( 'This page was just enhanced by jQuery Mobile!' );
        /// });
        /// jQueryMobile
        /// </summary>
        [ScriptName("pageinit")]
        PageInit,

        /// <summary>
        /// By default, the framework removes any non active dynamically loaded 
        /// external pages from the DOM as soon as the user navigates away to a 
        /// different page. The pageremove event is dispatched just before the 
        /// framework attempts to remove the page from the DOM.
        /// Event callbacks can call preventDefault on the event object to 
        /// prevent the page from being removed. 
        /// jQueryMobile
        /// </summary>
        [ScriptName("pageremove")]
        PageRemove,

        #region - layout events -

        // Some components within the framework, such as collapsible and 
        // listview search, dynamically hide and show content based on user 
        // events. This hiding/showing of content affects the size of the 
        // page and may result in the browser adjusting/scrolling the 
        // viewport to accommodate the new page size. Since this has the 
        // potential to affect other components such as fixed headers and 
        // footers, components like collapsible and listview trigger a custom 
        // updatelayout event to notify other components that they may need 
        // to adjust their layouts in response to their content changes. 
        // Developers who are building dynamic applications that inject, 
        // hide, or remove content from the page, or manipulate it in any way
        // that affects the dimensions of the page, can also manually trigger 
        // this updatelayout event to ensure components on the page update in 
        // response to the changes.

        /// <summary>
        /// This event is triggered by components within the framework that 
        /// dynamically show/hide content, and is meant as a generic mechanism 
        /// to notify other components that they may need to update their size 
        /// or position. Within the framework, this event is fired on the 
        /// component element whose content was shown/hidden, and bubbles all 
        /// the way up to the document element.
        /// $( '#foo' ).hide().trigger( 'updatelayout' );
        /// jQueryMobile
        /// </summary>
        [ScriptName("updatelayout")]
        UpdateLayout,

        #endregion - layout events -

        /// <summary>
        /// Triggers after a quick, complete touch event.
        /// jQueryMobile
        /// </summary>
        [ScriptName("tap")]
        Tap,

        /// <summary>
        /// Triggers after a held complete touch event.
        /// $.event.special.tap.tapholdThreshold (default: 750ms) – This value 
        /// dictates how long the user must hold their tap before the taphold 
        /// event is fired on the target element.
        /// jQueryMobile
        /// </summary>
        [ScriptName("taphold")]
        Taphold,

        /// <summary>
        /// Triggers when a horizontal drag of 30px or more (and less than 75px 
        /// vertically) occurs within 1 second duration but these can be configured:
        /// $.event.special.swipe.scrollSupressionThreshold (default: 10px) – More 
        /// than this horizontal displacement, and we will suppress scrolling.
        /// $.event.special.swipe.durationThreshold (default: 1000ms) – More time 
        /// than this, and it isn't a swipe.
        /// $.event.special.swipe.horizontalDistanceThreshold (default: 30px) – Swipe 
        /// horizontal displacement must be more than this.
        /// $.event.special.swipe.verticalDistanceThreshold (default: 75px) – Swipe 
        /// vertical displacement must be less than this.
        /// jQueryMobile
        /// </summary>
        [ScriptName("swipe")]
        Swipe,

        /// <summary>
        /// Triggers when a swipe event occurred moving in the left direction.
        /// jQueryMobile
        /// </summary>
        [ScriptName("swipeleft")]
        SwipeLeft,

        /// <summary>
        /// Triggers when a swipe event occurred moving in the right direction.
        /// jQueryMobile
        /// </summary>
        [ScriptName("swiperight")]
        SwipeRight,

        /// <summary>
        /// Triggers when a device orientation changes (by turning it vertically 
        /// or horizontally). When bound to this event, the callback function has 
        /// one argument, the event object. The event object contains an orientation 
        /// property equal to either "portrait" or "landscape". 
        /// Note that we currently bind to the resize event when orientationchange 
        /// is not natively supported, or when $.mobile.orientationChangeEnabled 
        /// is set to false.
        /// jQueryMobile
        /// </summary>
        [ScriptName("orientationchange")]
        OrientationChange,

        /// <summary>
        /// Triggers when a scroll begins. Note that iOS devices freeze DOM manipulation 
        /// during scroll, queuing them to apply when the scroll finishes. We're currently 
        /// investigating ways to allow DOM manipulations to apply before a scroll starts.
        /// jQueryMobile
        /// </summary>
        [ScriptName("scrollstart")]
        ScrollStart,

        /// <summary>
        /// Triggers when a scroll finishes.
        /// jQueryMobile
        /// </summary>
        [ScriptName("scrollstop")]
        ScrollStop,

        #region - virtual mouse events -

        // jQueryMobile provides a set of "virtual" mouse events that attempt to 
        // abstract away mouse and touch events. This allows the developer to 
        // register listeners for the basic mouse events, such as mousedown, 
        // mousemove, mouseup, and click, and the plugin will take care of 
        // registering the correct listeners behind the scenes to invoke the 
        // listener at the fastest possible time for that device. In touch 
        // environments, the plugin retains the order of event firing that is 
        // seen in traditional mouse environments, so for example, vmouseup is 
        // always dispatched before vmousedown, and vmousedown before vclick, etc. 
        // The virtual mouse events also normalize how coordinate information is 
        // extracted from the event, so in touch based environments, coordinates 
        // are available from the pageX, pageY, screenX, screenY, clientX, and 
        // clientY properties, directly on the event object.

        /// <summary>
        /// Normalized event for handling touchend or mouse click events. 
        /// On touch devices, this event is dispatched *AFTER* vmouseup.
        /// </summary>
        [ScriptName("vclick")]
        VClick,

        /// <summary>
        /// Normalized event for handling touch or mouse mousecancel events
        /// </summary>
        [ScriptName("vmousecancel")]
        VMouseCancel,

        /// <summary>
        /// Normalized event for handling touchstart or mousedown events
        /// </summary>
        [ScriptName("vmousedown")]
        VMouseDown,

        /// <summary>
        /// Normalized event for handling touchmove or mousemove events
        /// </summary>
        [ScriptName("vmousemove")]
        VMuseMove,

        /// <summary>
        /// Normalized event for handling touch or mouseout events
        /// </summary>
        [ScriptName("vmouseout")]
        VMouseOut,

        /// <summary>
        /// Normalized event for handling touch or mouseover events
        /// </summary>
        [ScriptName("vmouseover")]
        VMouseOver,

        /// <summary>
        /// Normalized event for handling touchend or mouseup events
        /// </summary>
        [ScriptName("vmouseup")]
        VMouseUp,

        #endregion - virtual mouse events -

    }
}
