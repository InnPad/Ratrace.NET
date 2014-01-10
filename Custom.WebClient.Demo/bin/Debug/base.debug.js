//! base.debug.js
//

(function($) {

Type.registerNamespace('Custom');

////////////////////////////////////////////////////////////////////////////////
// Custom.DateHelper

Custom.DateHelper = function Custom_DateHelper() {
}
Custom.DateHelper.getDayOffset = function Custom_DateHelper$getDayOffset(from, to) {
    /// <param name="from" type="Date">
    /// </param>
    /// <param name="to" type="Date">
    /// </param>
    /// <returns type="Number" integer="true"></returns>
    var fromMilliseconds = from.getTime();
    var toMilliseconds = to.getTime();
    var millisecondsOffset = toMilliseconds - fromMilliseconds;
    var dayOffset = millisecondsOffset / (24 * 60 * 60 * 1000);
    return dayOffset;
}
Custom.DateHelper.date = function Custom_DateHelper$date(offset) {
    /// <param name="offset" type="Number" integer="true">
    /// </param>
    /// <returns type="String"></returns>
    var date = new Date(offset);
    var utc = date.toISOString();
    return utc.substr(0, utc.indexOf('T'));
}


////////////////////////////////////////////////////////////////////////////////
// Support

Support = function Support() {
    /// <field name="_browser" type="String" static="true">
    /// </field>
    /// <field name="_radialGradient" type="Boolean" static="true">
    /// </field>
}
Support.get_browser = function Support$get_browser() {
    /// <value type="String"></value>
    return Support._browser;
}
Support.get_radialGradient = function Support$get_radialGradient() {
    /// <value type="Boolean"></value>
    return Support._radialGradient;
}
Support.set_radialGradient = function Support$set_radialGradient(value) {
    /// <value type="Boolean"></value>
    Support._radialGradient = value;
    return value;
}
Support.reset = function Support$reset() {
    var userAgent = window.navigator.userAgent;
    var appVersion = window.navigator.appVersion;
    var platfomr = window.navigator.platform;
    if (userAgent.indexOf('Chrome') > 0) {
        Support._browser = 'Chrome';
        Support._radialGradient = false;
    }
    else if (userAgent.indexOf('MSIE 9.0') > 0) {
        Support._browser = 'IE9';
        Support._radialGradient = true;
    }
    else if (userAgent.indexOf('MSIE 8.0') > 0) {
        Support._browser = 'IE8';
        Support._radialGradient = false;
    }
    else if (userAgent.indexOf('MSIE 7.0') > 0) {
        Support._browser = 'IE7';
        Support._radialGradient = false;
    }
    else if (userAgent.indexOf('MSIE 6.0') > 0) {
        Support._browser = 'IE6';
        Support._radialGradient = false;
    }
    else if (userAgent.indexOf('Firefox') > 0) {
        Support._radialGradient = true;
    }
    else {
        Support._radialGradient = false;
    }
}


Custom.DateHelper.registerClass('Custom.DateHelper');
Support.registerClass('Support');
Support._browser = null;
Support._radialGradient = false;
})(jQuery);

//! This script was generated using Script# v0.7.4.0
