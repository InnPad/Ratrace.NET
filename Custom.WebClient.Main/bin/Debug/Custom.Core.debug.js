//! Custom.Core.debug.js
//

(function($) {

Type.registerNamespace('Custom');

////////////////////////////////////////////////////////////////////////////////
// Custom.Presentation

Custom.Presentation = function Custom_Presentation() {
    /// <field name="module" type="AngularModule" static="true">
    /// </field>
}


Custom.Presentation.registerClass('Custom.Presentation');
Custom.Presentation.module = null;
(function () {
    define('angular', function(angular) {
        Custom.Presentation.module = angular.module('Presentation', [], function(provide) {
        });
    });
})();
})(jQuery);

//! This script was generated using Script# v0.7.4.0
