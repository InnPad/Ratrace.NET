// SelectMenuOptions.cs
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class SelectMenuOptions
    {
        /// <summary>
        /// To use custom menus on a specific select, just add the 
        /// data-native-menu="false" attribute. Alternately, this can also 
        /// programmatically set the select menu's nativeMenu configuration 
        /// option to false in a callback bound to the mobileinit event to 
        /// achieve the same effect. This will globally make all selects use 
        /// the custom menu by default. The following must be included in the 
        /// page after jQuery is loaded but before jQuery Mobile is loaded.
        /// 
        /// $(document).bind('mobileinit',function(){
        ///    $.mobile.selectmenu.prototype.options.nativeMenu = false;
        /// });
        /// </summary>
        public bool NativeMenu;

        /// <summary>
        /// Placeholder options
        /// 
        /// It's common for developers to include a "null" option in their 
        /// select element to force a user to choose an option. If a 
        /// placeholder option is present in your markup, jQuery Mobile 
        /// will hide them in the overlay menu, showing only valid choices 
        /// to the user, and display the placeholder text inside the menu 
        /// as a header. A placeholder option is added when the framework finds:
        /// 
        /// -An option with no value attribute (or an empty value attribute)
        /// -An option with no text node
        /// -An option with a data-placeholder="true" attribute. (This allows 
        /// you to use an option that has a value and a textnode as a placeholder option).
        /// 
        /// You can disable this feature through the selectmenu plugin's 
        /// hidePlaceholderMenuItems option, like this:
        /// $.mobile.selectmenu.prototype.options.hidePlaceholderMenuItems = false;
        /// </summary>
        public bool HidePlaceholderMenuItems;
    }
}
