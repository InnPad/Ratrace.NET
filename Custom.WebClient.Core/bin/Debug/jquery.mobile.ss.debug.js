//! jquery.mobile.ss.debug.js
//

(function($) {

Type.registerNamespace('jQueryApi');

////////////////////////////////////////////////////////////////////////////////
// jQueryApi.ChangePageDefaults

jQueryApi.ChangePageDefaults = function jQueryApi_ChangePageDefaults() {
    /// <field name="transition" type="jQueryApi.jQueryTransitions">
    /// </field>
}
jQueryApi.ChangePageDefaults.prototype = {
    transition: null
}


////////////////////////////////////////////////////////////////////////////////
// jQueryApi.jQueryDelegates

jQueryApi.jQueryDelegates = function jQueryApi_jQueryDelegates() {
}
jQueryApi.jQueryDelegates.remove = function jQueryApi_jQueryDelegates$remove() {
    $(this).remove();
}
jQueryApi.jQueryDelegates.removeOnEvent = function jQueryApi_jQueryDelegates$removeOnEvent(e) {
    /// <param name="e" type="jQueryEvent">
    /// </param>
    $(e.currentTarget).remove();
}


jQueryApi.ChangePageDefaults.registerClass('jQueryApi.ChangePageDefaults');
jQueryApi.jQueryDelegates.registerClass('jQueryApi.jQueryDelegates');
})(jQuery);

//! This script was generated using Script# v0.7.4.0
