//! core.debug.js
//

(function($) {

////////////////////////////////////////////////////////////////////////////////
// DateRangeSliderPlugin

$.fn.dateRangeSlider = function DateRangeSliderPlugin$dateRangeSlider(customOptions) {
    /// <param name="customOptions" type="Object">
    /// </param>
    /// <returns type="jQueryObject"></returns>
    var defaultOptions = { myOption: 0 };
    var options = $.extend({}, defaultOptions, customOptions);
    return this.each(function(i, element) {
    });
}


////////////////////////////////////////////////////////////////////////////////
// RangeSliderPlugin

$.fn.rangeSlider = function RangeSliderPlugin$rangeSlider(customOptions) {
    /// <param name="customOptions" type="Object">
    /// </param>
    /// <returns type="jQueryObject"></returns>
    var defaultOptions = { myOption: 0 };
    var options = $.extend({}, defaultOptions, customOptions);
    return this.each(function(i, element) {
    });
}


Type.registerNamespace('Custom');

////////////////////////////////////////////////////////////////////////////////
// Custom.Application

Custom.Application = function Custom_Application() {
}


////////////////////////////////////////////////////////////////////////////////
// Custom.DateRangeSlider

Custom.DateRangeSlider = function Custom_DateRangeSlider() {
}
Custom.DateRangeSlider.defineDirectives = function Custom_DateRangeSlider$defineDirectives(angular, module) {
    /// <param name="angular" type="AngularStatic">
    /// </param>
    /// <param name="module" type="AngularModule">
    /// </param>
    module.directive('dateRange', function() {
        return { restrict: 'A', link: function(scope, element, attr, ngModel) {
            scope.slider.el = element;
        } };
    });
    module.directive('dateHigh', function() {
        return { restrict: 'A', link: function(scope, element, attr, ngModel) {
            element.on('change', function(ev) {
                scope.$apply(function() {
                    var value = element.val();
                    var offset = Date.parseDate(value).getTime();
                    scope.slider.offset.high = offset;
                });
            });
        } };
    });
    module.directive('dateLow', function() {
        return { restrict: 'A', link: function(scope, element, attr, ngModel) {
            element.on('change', function(ev) {
                scope.$apply(function() {
                    var value = element.val();
                    var offset = Date.parseDate(value).getTime();
                    scope.slider.offset.low = offset;
                });
            });
        } };
    });
    module.directive('offsetHigh', function() {
        return { restrict: 'A', link: function(scope, element, attr, ngModel) {
            scope.slider.highEl = element;
            element.on('create', function(ev) {
                var a = 0;
            });
            element.on('slidestart', function(ev) {
                scope.$apply(function() {
                    var a = 0;
                });
            });
            element.on('change', function(ev) {
                scope.$apply(function() {
                    var value = element.val();
                    var offset = parseInt(value);
                    scope.slider.date.high = Custom.DateHelper.date(offset);
                    if (scope.slider.lowEl) {
                        scope.slider.lowEl.attr('max', offset);
                    }
                });
            });
            element.on('slidestop', function(ev) {
                scope.$apply(function() {
                    if (scope.slider.lowEl) {
                        scope.slider.lowEl.slider({ max: scope.slider.offset.high });
                        scope.slider.lowEl.slider('refresh');
                    }
                });
            });
        } };
    });
    module.directive('offsetLow', function() {
        return { restrict: 'A', link: function(scope, element, attr, ngModel) {
            scope.slider.lowEl = element;
            element.on('slidestart', function(ev) {
                scope.$apply(function() {
                    var a = 0;
                });
            });
            element.on('change', function(ev) {
                scope.$apply(function() {
                    var value = element.val();
                    var offset = parseInt(value);
                    scope.slider.date.low = Custom.DateHelper.date(offset);
                    if (scope.slider.highEl) {
                        scope.slider.highEl.attr('min', offset);
                    }
                });
            });
            element.on('slidestop', function(ev) {
                scope.$apply(function() {
                    if (scope.slider.highEl) {
                        scope.slider.highEl.slider({ min: scope.slider.offset.low });
                        scope.slider.highEl.slider('refresh');
                    }
                });
            });
        } };
    });
}


////////////////////////////////////////////////////////////////////////////////
// Custom.Presentation

Custom.Presentation = function Custom_Presentation() {
    /// <field name="windowSize" type="Object" static="true">
    /// </field>
    /// <field name="pageSize" type="Object" static="true">
    /// </field>
    /// <field name="orientation" type="jQueryApi.jQueryOrientation" static="true">
    /// </field>
}
Custom.Presentation.changeOrientation = function Custom_Presentation$changeOrientation(orientation) {
    /// <param name="orientation" type="jQueryApi.jQueryOrientation">
    /// </param>
    Custom.Presentation.orientation = orientation;
}
Custom.Presentation.initialize = function Custom_Presentation$initialize() {
    $('body').bind('hideOpenMenus', Custom.Presentation._onHideOpenMenus).bind('scrollstart', Custom.Presentation._onScrollStart).bind('scrollstop', Custom.Presentation._onScrollEnd).bind('orientationchange', Custom.Presentation._onOrientationChange).bind('pageshow', Custom.Presentation._onPageRefresh).trigger('orientationchange');
    $(window.self).bind('resize', Custom.Presentation._onWindowResize);
    Custom.Presentation.refresh({ resize: true });
}
Custom.Presentation.isHeader = function Custom_Presentation$isHeader(el) {
    /// <param name="el" type="jQueryObject">
    /// </param>
    /// <returns type="Boolean"></returns>
    var isHeader = false;
    el.each(function(index, element) {
        switch (element.tagName) {
            case 'H1':
            case 'H2':
            case 'H3':
            case 'H4':
            case 'H5':
                isHeader = true;
                return false;
            default:
                return true;
        }
    });
    return isHeader;
}
Custom.Presentation.isInline = function Custom_Presentation$isInline(el) {
    /// <param name="el" type="jQueryObject">
    /// </param>
    /// <returns type="Boolean"></returns>
    var isInline = false;
    el.each(function(index, element) {
        switch (element.tagName) {
            case 'INPUT':
                isInline = true;
                return false;
            default:
                return true;
        }
    });
    return isInline;
}
Custom.Presentation.isFit = function Custom_Presentation$isFit(element) {
    /// <param name="element" type="Object" domElement="true">
    /// </param>
    /// <returns type="Boolean"></returns>
    switch (element.tagName) {
        case 'DIV':
        case 'CANVAS':
            return true;
        default:
            return false;
    }
}
Custom.Presentation._onHideOpenMenus = function Custom_Presentation$_onHideOpenMenus(e) {
    /// <param name="e" type="jQueryEvent">
    /// </param>
    $("ul:jqmData(role='menu')").find('li > ul').hide();
}
Custom.Presentation._onOrientationChange = function Custom_Presentation$_onOrientationChange(e) {
    /// <param name="e" type="jQueryApi.jQueryOrientationChangeEvent">
    /// </param>
    Custom.Presentation.changeOrientation(e.orientation);
}
Custom.Presentation._onPageRefresh = function Custom_Presentation$_onPageRefresh(e) {
    /// <param name="e" type="jQueryEvent">
    /// </param>
    Custom.Presentation.refresh({ resize: true });
}
Custom.Presentation._onScrollStart = function Custom_Presentation$_onScrollStart(e) {
    /// <param name="e" type="jQueryEvent">
    /// </param>
    alert('ScrollStart');
}
Custom.Presentation._onScrollEnd = function Custom_Presentation$_onScrollEnd(e) {
    /// <param name="e" type="jQueryEvent">
    /// </param>
    alert('ScrollEnd');
}
Custom.Presentation._onWindowResize = function Custom_Presentation$_onWindowResize(e) {
    /// <param name="e" type="jQueryEvent">
    /// </param>
    Custom.Presentation.refresh({ resize: true });
}
Custom.Presentation.refresh = function Custom_Presentation$refresh(options) {
    /// <param name="options" type="Object">
    /// </param>
    Custom.Presentation.windowSize.height = window.outerHeight;
    Custom.Presentation.windowSize.width = window.outerWidth;
    Custom.Presentation.pageSize.height = window.innerHeight;
    Custom.Presentation.pageSize.width = window.innerWidth;
    if (options.resize) {
        options.resize = Custom.Presentation.pageSize;
    }
    $('div[data-role=page].ui-page-active').each(function(index, element) {
        var pageEl = $(element);
        pageEl.css('height', Custom.Presentation.pageSize.height + 'px');
        var contentEl = pageEl.children('.ui-content');
        if (contentEl.hasClass('wave-height')) {
            var contentHeight = pageEl.height() - contentEl.position().top;
            var headerEl = pageEl.children('.ui-header');
            var footerEl = pageEl.children('.ui-footer');
            if (footerEl.attr('data-position') === 'fixed') {
                contentHeight -= footerEl.outerHeight(true);
            }
            Custom.Presentation.waveHeight(contentEl, contentHeight);
        }
        if (contentEl.hasClass('wave-width')) {
            Custom.Presentation.waveWidth(contentEl, Custom.Presentation.pageSize.width);
        }
    });
}
Custom.Presentation.draw = function Custom_Presentation$draw(data) {
    /// <param name="data" type="Object">
    /// </param>
    /// <returns type="Boolean"></returns>
    var draw = data['draw'];
    if (draw != null && typeof(draw) === 'function') {
        draw.call(data);
        return true;
    }
    return false;
}
Custom.Presentation.setHeight = function Custom_Presentation$setHeight(data, height) {
    /// <param name="data" type="Object">
    /// </param>
    /// <param name="height" type="Number" integer="true">
    /// </param>
    /// <returns type="Boolean"></returns>
    var setHeight = data['setHeight'];
    if (setHeight != null && typeof(setHeight) === 'function') {
        setHeight.call(data, height);
        return true;
    }
    return false;
}
Custom.Presentation.setWidth = function Custom_Presentation$setWidth(data, width) {
    /// <param name="data" type="Object">
    /// </param>
    /// <param name="width" type="Number" integer="true">
    /// </param>
    /// <returns type="Boolean"></returns>
    var setWidth = data['setWidth'];
    if (setWidth != null && typeof(setWidth) === 'function') {
        setWidth.call(data, width);
        return true;
    }
    return false;
}
Custom.Presentation.waveHeight = function Custom_Presentation$waveHeight(el, height) {
    /// <param name="el" type="jQueryObject">
    /// </param>
    /// <param name="height" type="Number" integer="true">
    /// </param>
    var offset = el.offset();
    el.css('height', height + 'px');
    if (el.attr('height')) {
        el.removeAttr('height');
    }
    height = el.height();
    var children = el.children();
    var waved = children.filter(function(index) {
        var childEl = $(this);
        if ((Custom.Presentation.isFit(children[index]) && !$(this).hasClass('dont-wave-height') || childEl.hasClass('wave-height'))) {
            return true;
        }
        height -= Math.max(childEl.outerHeight(false), childEl.outerHeight(true), childEl.height());
        return false;
    });
    if (waved.length > 0) {
        var stack = waved.filter(function(index) {
            var position = $(this).css('position');
            switch (position) {
                case 'absolute':
                    return false;
                case 'fixed':
                    return false;
                default:
                    return true;
            }
        });
        stack.each(function(index, element) {
            var childEl = $(element);
            Custom.Presentation.waveHeight(childEl, height / stack.length);
        });
        waved.each(function(index, element) {
            var childEl = $(element);
            var position = childEl.css('position');
            switch (position) {
                case 'absolute':
                    Custom.Presentation.waveHeight(childEl, height);
                    break;
                case 'fixed':
                    el.css('top', offset.top + 'px');
                    Custom.Presentation.waveHeight(childEl, height);
                    break;
            }
        });
    }
    var data = el.data();
    Object.keys(data).forEach(function(value) {
        Custom.Presentation.setHeight(data[value], height);
        Custom.Presentation.draw(data);
    });
}
Custom.Presentation.waveWidth = function Custom_Presentation$waveWidth(el, width) {
    /// <param name="el" type="jQueryObject">
    /// </param>
    /// <param name="width" type="Number" integer="true">
    /// </param>
    el.css('width', width + 'px');
    if (el.attr('width')) {
        el.removeAttr('width');
    }
    el.children().each(function(index, element) {
        var child = $(element);
        if (!child.hasClass('dont-wave-width')) {
            Custom.Presentation.waveWidth(child, width);
        }
    });
    var data = el.data();
    Object.keys(data).forEach(function(value) {
        Custom.Presentation.setWidth(data[value], width);
        Custom.Presentation.draw(data);
    });
}


Custom.Application.registerClass('Custom.Application');
Custom.DateRangeSlider.registerClass('Custom.DateRangeSlider');
Custom.Presentation.registerClass('Custom.Presentation');
Custom.Presentation.windowSize = {};
Custom.Presentation.pageSize = {};
Custom.Presentation.orientation = 'landscape';
})(jQuery);

//! This script was generated using Script# v0.7.4.0
