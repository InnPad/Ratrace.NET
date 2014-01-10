//! Custom.Main.debug.js
//

(function($) {

Type.registerNamespace('Custom');

////////////////////////////////////////////////////////////////////////////////
// Custom.Application

Custom.Application = function Custom_Application() {
    /// <field name="apiRoot" type="String" static="true">
    /// </field>
    /// <field name="module" type="AngularModule" static="true">
    /// </field>
    /// <field name="controller" type="AngularModule" static="true">
    /// </field>
    /// <field name="service" type="AngularModule" static="true">
    /// </field>
}


Custom.Application.registerClass('Custom.Application');
Custom.Application.apiRoot = 'www.easeaccess.org/';
Custom.Application.module = null;
Custom.Application.controller = null;
Custom.Application.service = null;
(function () {
    define('angular', function(angular) {
        Custom.Application.module = angular.module('Main', [], function(provide) {
            provide.factory('Contact', function(resource) {
                return resource(Custom.Application.apiRoot + 'api/contact/:id', {}, { update: { method: 'PUT' } });
            });
            provide.factory('Circle', function(resource) {
                return resource(Custom.Application.apiRoot + 'api/circle/:id', {}, { update: { method: 'PUT' } });
            });
            provide.factory('Message', function(resource) {
                return resource(Custom.Application.apiRoot + 'api/message/:id', {}, { update: { method: 'PUT' } });
            });
        });
        Custom.Application.controller = Custom.Application.module.controller('Main', function(scope, route, routeParams) {
            scope.greeting = 'Hello!';
            var render = function() {
            };
            scope.$on('$routeChangeSuccess', function(ev) {
                return null;
            });
        });
        Custom.Application.service = angular.module('Custom.Service', []).value('greeter', { salutation: 'Hello', localize: function(location) {
        } });
    });
})();
})(jQuery);

//! This script was generated using Script# v0.7.4.0
