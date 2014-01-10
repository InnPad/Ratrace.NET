
////////////////////////////////////////////////////////////////////////////////
// _bootstrap



Type.registerNamespace('Custom');

////////////////////////////////////////////////////////////////////////////////
// Custom.SymbolPager

Custom.SymbolPager = function Custom_SymbolPager(symbols) {
    /// <param name="symbols" type="Array">
    /// </param>
    /// <field name="_symbols" type="Array">
    /// </field>
    this._symbols = symbols;
}
Custom.SymbolPager.prototype = {
    _symbols: null,
    
    loadMode: function Custom_SymbolPager$loadMode() {
        var ajax = { type: 'GET', url: 'api/symbols', dataType: 'json', success: ss.Delegate.create(this, function(data, textStatus, request) {
            var symbols = data;
            for (var i = 0; i < symbols.length; i++) {
                this._symbols.add(symbols[i]);
            }
        }), error: function(request, textStatus, error) {
            var a = 0;
        } };
        $.ajax(ajax);
    }
}


////////////////////////////////////////////////////////////////////////////////
// Custom.About

Custom.About = function Custom_About() {
}
Custom.About.onPageShow = function Custom_About$onPageShow(e) {
    /// <param name="e" type="jQueryEvent">
    /// </param>
    $('#about-page[data-role=page]').each(function(index, element) {
        var pageEl = $(element);
        var contentEl = pageEl.children('[data-role=content]');
        if (!contentEl.data('Custom.Stage')) {
            require([ 'draw', 'kinetic' ], function() {
                contentEl.atom({ electrons: [ 'Images/tradestation_thumb.jpg', 'Images/angular_thumb.png', 'Images/kinetic_thumb.jpg', 'Images/jquerymobile_thumb.png', 'Images/scriptsharp_thumb.png', 'Images/typescript_thumb.png', 'Images/sencha_thumb.png', 'Images/odata_thumb.png', 'Images/sqlserver_thumb.png', 'Images/servicestack_thumb.png', 'Images/signalr_thumb.jpg', 'Images/titanium_thumb.png', 'Images/twitter_thumb.png', 'Images/jquery_thumb.png', 'Images/dotnet_thumb.png', 'Images/facebook_thumb.png', 'Images/css3_thumb.png', 'Images/html5_thumb.png', 'Images/feed_thumb.png', 'Images/silverlight_thumb.png', 'Images/appcelerator_thumb.png', 'Images/android_thumb.png', 'Images/apple_thumb.png', 'Images/backbone_thumb.png', 'Images/chrome_thumb.png', 'Images/firefox_thumb.png', 'Images/googlemaps_thumb.png', 'Images/ie10_thumb.png', 'Images/java_thumb.png', 'Images/mono_thumb.png', 'Images/phone7_thumb.png', 'Images/phonegap_thumb.png', 'Images/sap_thumb.png', 'Images/windows_thumb.png', 'Images/wpf_thumb.png' ] });
            });
            window.setTimeout(function() {
                Custom.Presentation.refresh({ resize: true });
            }, 100);
        }
        return false;
    });
}


////////////////////////////////////////////////////////////////////////////////
// Custom.Demo

Custom.Demo = function Custom_Demo() {
    /// <field name="_symbols" type="Array" static="true">
    /// </field>
    /// <field name="demo" type="AngularModule" static="true">
    /// </field>
}
Custom.Demo.defineController = function Custom_Demo$defineController(angular, module) {
    /// <param name="angular" type="AngularStatic">
    /// </param>
    /// <param name="module" type="AngularModule">
    /// </param>
    /// <returns type="AngularModule"></returns>
    Custom.DateRangeSlider.init(angular, module);
    return Custom.Demo.demo = module.controller('demo', [ '$scope', '$route', '$routeParams', function(scope, route, routeParams) {
        scope.symbols = (Custom.Demo._symbols || []);
        scope.pager = new Custom.SymbolPager(scope.symbols);
        var today = Date.get_today().getTime();
        var aDay = 86400000;
        var aYear = 365 * aDay;
        var aWeek = 7 * aDay;
        var offset = { min: today - aYear, max: today, low: today - 2 * aWeek, high: today - aWeek };
        scope.slider = new Custom.DateRangeSlider({ offset: offset, date: { low: Custom.DateHelper.date(offset.low), high: Custom.DateHelper.date(offset.high) } });
        var ajax = { type: 'GET', url: 'api/symbols', dataType: 'json', success: function(data, textStatus, request) {
            Custom.Demo._symbols = data;
            for (var i = 0; i < Custom.Demo._symbols.length; i++) {
                scope.symbols.add(Custom.Demo._symbols[i]);
            }
        }, error: function(request, textStatus, error) {
            var a = 0;
        } };
        $.ajax(ajax);
        scope.greeting = 'Hello!';
        scope.searchTheme = 'a';
        scope.toggleSearch = Custom.Demo.toggleSearch;
        scope.$on('$routeChangeSuccess', function(ev) {
            return null;
        });
    } ]);
}
Custom.Demo.onPageShow = function Custom_Demo$onPageShow(e) {
    /// <param name="e" type="jQueryEvent">
    /// </param>
    $('#demo-page[data-role=page]').each(function(index, element) {
        var pageEl = $(element);
        var contentEl = pageEl.children('[data-role=content]');
        if (!contentEl.data('Custom.Stage')) {
            require([ 'trading', 'draw', 'kinetic' ], function() {
                contentEl.candlestickChart({});
            });
            window.setTimeout(function() {
                Custom.Presentation.refresh({ resize: true });
            }, 100);
        }
        return false;
    });
}
Custom.Demo.toggleSearch = function Custom_Demo$toggleSearch(e) {
    /// <param name="e" type="jQueryEvent">
    /// </param>
    var buttonEl = $(e.target).parent('a').first();
    var floatingEl = $('.floating-content');
    if (floatingEl.hasClass('hidden')) {
        floatingEl.removeClass('hidden');
        buttonEl.removeClass('ui-btn-up-a');
        buttonEl.addClass('ui-btn-up-f');
    }
    else {
        floatingEl.addClass('hidden');
        buttonEl.removeClass('ui-btn-up-f');
        buttonEl.addClass('ui-btn-up-a');
    }
}


Custom.SymbolPager.registerClass('Custom.SymbolPager');
Custom.About.registerClass('Custom.About');
Custom.Demo.registerClass('Custom.Demo');
(function () {
    'use strict';
    Custom.Presentation.initialize();
    $('body').bind('pageshow', function(e) {
        Custom.Demo.onPageShow(e);
        Custom.About.onPageShow(e);
    });
    define([ 'angular' ], function(angular) {
        window.mainControllers = angular.module('main.controllers', []);
        window.mainModule = angular.module('main', [ 'main.controllers' ], [ '$provide', function(provide) {
            provide.factory('contact', function(resource) {
                return resource(window.apiRoot + 'api/contact/:id', {}, { update: { method: 'PUT' } });
            });
            provide.factory('circle', function(resource) {
                return resource(window.apiRoot + 'api/circle/:id', {}, { update: { method: 'PUT' } });
            });
            provide.factory('message', function(resource) {
                return resource(window.apiRoot + 'api/message/:id', {}, { update: { method: 'PUT' } });
            });
        } ]);
        window.mainHome = window.mainControllers.controller('main.home', [ '$scope', '$route', '$routeParams', function(scope, route, routeParams) {
            scope.greeting = 'Hello!';
            scope.searchTheme = 'a';
            scope.toggleSearch = Custom.Demo.toggleSearch;
            Custom.Presentation.refresh({ resize: true });
            scope.goHome = function() {
            };
            scope.goDemo = function() {
            };
            scope.goAbout = function() {
            };
            var render = function() {
            };
            scope.$on('$routeChangeSuccess', function(ev) {
                return null;
            });
        } ]);
        Custom.Demo.defineController(angular, window.mainControllers);
        window.mainService = angular.module('Custom.Service', []).value('greeter', { salutation: 'Hello', localize: function(location) {
        } });
        window.mainModule.config([ '$routeProvider', '$locationProvider', function(routeProvider, locationProvider) {
            locationProvider.html5Mode(true);
        } ]);
        window.mainModule.run(function() {
            var a = 0;
        });
    });
})();
Custom.Demo._symbols = null;
Custom.Demo.demo = null;
