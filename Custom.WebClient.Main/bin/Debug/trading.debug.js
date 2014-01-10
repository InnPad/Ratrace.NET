//! trading.debug.js
//

(function($) {

////////////////////////////////////////////////////////////////////////////////
// CandlestickChartPlugin

$.fn.candlestickChart = function CandlestickChartPlugin$candlestickChart(customOptions) {
    /// <param name="customOptions" type="Object">
    /// </param>
    /// <returns type="jQueryObject"></returns>
    var defaultOptions = { day: Date.get_today(), count: 20 };
    var options = $.extend({}, defaultOptions, customOptions);
    return this.each(function(i, element) {
        var stage = Custom.StageMaster.fromElement(element, options.stage);
        var container = $(stage.getContainer());
        var chart = container.data('Custom.CandlestickChart');
        if (!chart) {
            chart = new Custom.CandlestickChart(stage, options);
            container.data('Custom.CandlestickChart', chart);
        }
    });
}


Type.registerNamespace('Custom');

////////////////////////////////////////////////////////////////////////////////
// Custom.StradeStation

Custom.StradeStation = function Custom_StradeStation() {
}
Custom.StradeStation.prototype = {
    
    login: function Custom_StradeStation$login() {
    }
}


////////////////////////////////////////////////////////////////////////////////
// Custom.Symbol

Custom.Symbol = function Custom_Symbol() {
    /// <field name="id" type="String">
    /// </field>
    /// <field name="name" type="String">
    /// </field>
    /// <field name="market" type="String">
    /// </field>
    /// <field name="value" type="Number">
    /// </field>
    /// <field name="summary" type="String">
    /// </field>
}
Custom.Symbol.prototype = {
    id: null,
    name: null,
    market: null,
    value: 0,
    summary: null
}


////////////////////////////////////////////////////////////////////////////////
// Custom.Candlestick

Custom.Candlestick = function Custom_Candlestick() {
    /// <summary>
    /// Candlestick. A charting method, originally from Japan, in which the high and low are plotted as a single line and are referred to as shadows. The price range between the open and the close is plotted as a narrow rectangle and is referred to as the body. If the close is above the open, the body is white. If the close is below the open, the body is black.
    /// </summary>
    /// <field name="wickWidth" type="Number" static="true">
    /// </field>
    /// <field name="blockWidth" type="Number" static="true">
    /// </field>
    /// <field name="marginWidth" type="Number" static="true">
    /// </field>
    /// <field name="shape" type="Kinetic.Group">
    /// </field>
    /// <field name="_body" type="Kinetic.Rect">
    /// </field>
    /// <field name="_head" type="Kinetic.Line">
    /// </field>
    /// <field name="_tail" type="Kinetic.Line">
    /// </field>
    this._body = new Kinetic.Rect({ strokeWidth: 1, stroke: '#0f0' });
    this._head = new Kinetic.Line({ strokeWidth: 1, stroke: '#0f0' });
    this._tail = new Kinetic.Line({ strokeWidth: 1, stroke: '#0f0' });
    this.shape = new Kinetic.Group({});
    this.shape.add(this._head);
    this.shape.add(this._body);
    this.shape.add(this._tail);
}
Custom.Candlestick.count = function Custom_Candlestick$count(width) {
    /// <summary>
    /// width 'less or equal than' (n * BlockWidth +  (n - 1) * MarginWidth)
    /// </summary>
    /// <param name="width" type="Number">
    /// </param>
    /// <returns type="Number" integer="true"></returns>
    var count = (width + Custom.Candlestick.marginWidth) / (Custom.Candlestick.blockWidth + Custom.Candlestick.marginWidth);
    return parseInt(count);
}
Custom.Candlestick.prototype = {
    shape: null,
    _body: null,
    _head: null,
    _tail: null,
    
    setColor: function Custom_Candlestick$setColor(color) {
        /// <param name="color" type="String">
        /// </param>
        this._head.setStroke(color);
        this._tail.setStroke(color);
        this._body.setStroke(color);
    },
    
    setWickWidth: function Custom_Candlestick$setWickWidth(value) {
        /// <param name="value" type="Number" integer="true">
        /// </param>
        this._head.setStrokeWidth(value);
        this._tail.setStrokeWidth(value);
    },
    
    update: function Custom_Candlestick$update(startX, zeroY, offset, scaleX, scaleY, day, quote) {
        /// <param name="startX" type="Number">
        /// </param>
        /// <param name="zeroY" type="Number">
        /// </param>
        /// <param name="offset" type="Number" integer="true">
        /// </param>
        /// <param name="scaleX" type="Number">
        /// </param>
        /// <param name="scaleY" type="Number">
        /// </param>
        /// <param name="day" type="Date">
        /// </param>
        /// <param name="quote" type="Object">
        /// </param>
        var high, low;
        var fill;
        if (quote.open > quote.close) {
            fill = this._body.getStroke();
            high = quote.open;
            low = quote.close;
        }
        else {
            fill = null;
            high = quote.close;
            low = quote.open;
        }
        var x = startX - scaleX * (Custom.Candlestick.blockWidth + Custom.Candlestick.marginWidth) * offset;
        var width = scaleX * (Custom.Candlestick.blockWidth - Custom.Candlestick.wickWidth) / 2;
        this._head.setPoints([ { x: x, y: zeroY - scaleY * quote.max }, { x: x, y: zeroY - scaleY * high } ]);
        this._tail.setPoints([ { x: x, y: zeroY - scaleY * low }, { x: x, y: zeroY - scaleY * quote.min } ]);
        this._body.setPosition(x - width, zeroY - scaleY * high);
        this._body.setSize(scaleX * Custom.Candlestick.blockWidth, scaleY * (high - low) + 1);
        this._body.setFill(fill);
    }
}


////////////////////////////////////////////////////////////////////////////////
// Custom.CandlestickChart

Custom.CandlestickChart = function Custom_CandlestickChart(stage, options) {
    /// <param name="stage" type="Kinetic.Stage">
    /// </param>
    /// <param name="options" type="Object">
    /// </param>
    /// <field name="stage" type="Kinetic.Stage">
    /// </field>
    /// <field name="_background" type="Kinetic.Layer">
    /// </field>
    /// <field name="_foreground" type="Kinetic.Layer">
    /// Foreground layer
    /// </field>
    /// <field name="_highlight" type="Kinetic.Rect">
    /// Highlight background for the area in the range.
    /// </field>
    /// <field name="_leftBound" type="Kinetic.Line">
    /// Lower bound line delimiting the highlight (to the left)
    /// </field>
    /// <field name="_rightBound" type="Kinetic.Line">
    /// Higher bound line delimiting the highlight (to the right)
    /// </field>
    /// <field name="_zeroBound" type="Kinetic.Line">
    /// </field>
    /// <field name="sticks" type="Array">
    /// </field>
    /// <field name="_origin$1" type="Object">
    /// </field>
    /// <field name="_scale$1" type="Object">
    /// </field>
    /// <field name="_margin$1" type="Object">
    /// </field>
    /// <field name="_client$1" type="Object">
    /// </field>
    /// <field name="_view$1" type="Object">
    /// </field>
    /// <field name="_variation$1" type="Object">
    /// </field>
    /// <field name="_selection$1" type="Object">
    /// </field>
    /// <field name="_start$1" type="Date">
    /// </field>
    /// <field name="_count$1" type="Number" integer="true">
    /// </field>
    /// <field name="stickColor" type="String">
    /// </field>
    /// <field name="quotationFn" type="Function">
    /// </field>
    /// <field name="_quotation$1" type="Object">
    /// </field>
    Custom.CandlestickChart.initializeBase(this);
    this.stage = stage;
    this.quotationFn = Custom.CandlestickChart.generateQuotation;
    this._start$1 = Date.get_today();
    this._origin$1 = { x: 0, y: 0 };
    this._view$1 = { width: 0, height: 0 };
    this._margin$1 = { top: 5, right: 5, bottom: 5, left: 5 };
    this._selection$1 = {};
    this._variation$1 = {};
    this._scale$1 = { x: 1, y: 1 };
    this.stickColor = '#0f0';
    this.sticks = [];
    var container = $(stage.getContainer());
    this._client$1 = { width: container.width(), height: container.height() };
    this._view$1 = {};
    this._refreshHorizontalMeasures$1();
    this._refreshVerticalMeasures$1();
    this._background = new Kinetic.Layer({});
    this._highlight = new Kinetic.Rect({ strokeWidth: 0, fill: '#555', opacity: 0.5 });
    this._leftBound = new Kinetic.Line({ strokeWidth: 1, stroke: '#ccc', opacity: 0.5 });
    this._rightBound = new Kinetic.Line({ strokeWidth: 1, stroke: '#ccc', opacity: 0.5 });
    this._zeroBound = new Kinetic.Line({ strokeWidth: 1, stroke: '#f00', opacity: 1 });
    this._refreshBackground$1();
    this._background.add(this._highlight);
    this._background.add(this._leftBound);
    this._background.add(this._rightBound);
    this._background.add(this._zeroBound);
    this.stage.add(this._background);
    this._foreground = new Kinetic.Layer({});
    this.stage.add(this._foreground);
    this.update(options);
    this._quotation$1 = {};
    this.quotationFn(this._quotation$1, this._start$1, this._count$1);
    this.refreshForeground();
    var animation = new Kinetic.Animation(ss.Delegate.create(this, this._animate$1), this._foreground);
}
Custom.CandlestickChart.generateQuotation = function Custom_CandlestickChart$generateQuotation(quotation, start, count) {
    /// <param name="quotation" type="Object">
    /// </param>
    /// <param name="start" type="Date">
    /// </param>
    /// <param name="count" type="Number" integer="true">
    /// </param>
    for (var offset = 0; offset < count; offset++) {
        var min = 5 + 10 * Math.random();
        var low = min + 20 * Math.random();
        var high = low + 50 * Math.random();
        var max = high + 20 * Math.random();
        var quote;
        if (Math.random() > 0.5) {
            quote = { close: low, max: max, min: min, open: high };
        }
        else {
            quote = { close: high, max: max, min: min, open: low };
        }
        quotation[offset] = quote;
    }
}
Custom.CandlestickChart.prototype = {
    stage: null,
    _background: null,
    _foreground: null,
    _highlight: null,
    _leftBound: null,
    _rightBound: null,
    _zeroBound: null,
    sticks: null,
    _origin$1: null,
    _scale$1: null,
    _margin$1: null,
    _client$1: null,
    _view$1: null,
    _variation$1: null,
    _selection$1: null,
    _start$1: null,
    _count$1: 0,
    stickColor: null,
    quotationFn: null,
    _quotation$1: null,
    
    _animate$1: function Custom_CandlestickChart$_animate$1(frame) {
        /// <param name="frame" type="Object">
        /// </param>
        if (frame.time % 10 === 1) {
            this._background.draw();
        }
    },
    
    renderCandleSticks: function Custom_CandlestickChart$renderCandleSticks(start, quotation) {
        /// <param name="start" type="Date">
        /// </param>
        /// <param name="quotation" type="Object">
        /// </param>
        this._foreground.clear();
        var count = Math.min(this._count$1, Object.getKeyCount(quotation));
        var scaleX = this._scale$1.x;
        var scaleY = this._scale$1.y;
        for (var offset = 0; offset < count; offset++) {
            var stick;
            if (this.sticks.length > offset) {
                stick = this.sticks[offset];
            }
            else {
                stick = new Custom.Candlestick();
                stick.setColor(this.stickColor);
                this.sticks.add(stick);
            }
            var day = new Date();
            day.setDate(start.getDay() - offset);
            stick.update(this._origin$1.x, this._origin$1.y, offset, scaleX, scaleY, day, quotation[offset]);
            this._foreground.add(stick.shape);
        }
    },
    
    get_range: function Custom_CandlestickChart$get_range() {
        /// <value type="Object"></value>
        return { high: this._selection$1.high, low: this._selection$1.low };
    },
    set_range: function Custom_CandlestickChart$set_range(value) {
        /// <value type="Object"></value>
        $.extend(this._selection$1, value);
        return value;
    },
    
    get_high: function Custom_CandlestickChart$get_high() {
        /// <value type="Number"></value>
        return this._selection$1.high;
    },
    set_high: function Custom_CandlestickChart$set_high(value) {
        /// <value type="Number"></value>
        this._selection$1.high = value;
        return value;
    },
    
    get_low: function Custom_CandlestickChart$get_low() {
        /// <value type="Number"></value>
        return this._selection$1.low;
    },
    set_low: function Custom_CandlestickChart$set_low(value) {
        /// <value type="Number"></value>
        this._selection$1.low = value;
        return value;
    },
    
    get_margin: function Custom_CandlestickChart$get_margin() {
        /// <value type="Object"></value>
        return { top: this._margin$1.top, right: this._margin$1.right, bottom: this._margin$1.bottom, left: this._margin$1.left };
    },
    set_margin: function Custom_CandlestickChart$set_margin(value) {
        /// <value type="Object"></value>
        $.extend(this._margin$1, value);
        return value;
    },
    
    draw: function Custom_CandlestickChart$draw() {
        this._background.draw();
        this._foreground.draw();
    },
    
    getDate: function Custom_CandlestickChart$getDate(offset) {
        /// <param name="offset" type="Number" integer="true">
        /// </param>
        /// <returns type="Date"></returns>
        var date = new Date();
        date.setDate(this._start$1.getDay() - offset);
        return date;
    },
    
    max: function Custom_CandlestickChart$max(quotation, first, last) {
        /// <param name="quotation" type="Object">
        /// </param>
        /// <param name="first" type="Number" integer="true">
        /// </param>
        /// <param name="last" type="Number" integer="true">
        /// </param>
        /// <returns type="Number"></returns>
        if (!Object.getKeyCount(quotation)) {
            return 0;
        }
        var max = quotation[first].max;
        for (var i = first + 1; i <= last; i++) {
            var value = quotation[i].max;
            if (value > max) {
                max = value;
            }
        }
        return max;
    },
    
    min: function Custom_CandlestickChart$min(quotation, first, last) {
        /// <param name="quotation" type="Array" elementType="Object">
        /// </param>
        /// <param name="first" type="Number" integer="true">
        /// </param>
        /// <param name="last" type="Number" integer="true">
        /// </param>
        /// <returns type="Number"></returns>
        if (!quotation.length) {
            return 0;
        }
        var min = quotation[0].min;
        for (var i = first + 1; i <= last; i++) {
            var value = quotation[i].min;
            if (value < min) {
                min = value;
            }
        }
        return min;
    },
    
    _refreshBackground$1: function Custom_CandlestickChart$_refreshBackground$1() {
        this._rightBound.setPoints([ { x: this._origin$1.x, y: this._origin$1.y - this._view$1.height }, { x: this._origin$1.x, y: this._origin$1.y } ]);
        this._leftBound.setPoints([ { x: this._origin$1.x - this._view$1.width, y: this._origin$1.y - this._view$1.height }, { x: this._origin$1.x - this._view$1.width, y: this._origin$1.y } ]);
        this._zeroBound.setPoints([ { x: 0, y: this._origin$1.y }, { x: this._client$1.width, y: this._origin$1.y } ]);
        this._highlight.setPosition(this._origin$1.x - this._view$1.width, this._origin$1.y - this._view$1.height);
        this._highlight.setSize(this._view$1.width, this._view$1.height - 40);
    },
    
    refreshForeground: function Custom_CandlestickChart$refreshForeground() {
        var count = Custom.Candlestick.count(this._view$1.width);
        if (count > this._count$1) {
            this.quotationFn(this._quotation$1, this._start$1, count);
        }
        this._count$1 = count;
        this._variation$1.high = this.max(this._quotation$1, 0, this._count$1 - 1);
        this._variation$1.low = this.max(this._quotation$1, 0, this._count$1 - 1);
        this._scale$1 = { x: 1, y: this._view$1.height / this._variation$1.high };
        this.renderCandleSticks(this._start$1, this._quotation$1);
    },
    
    _refreshHorizontalMeasures$1: function Custom_CandlestickChart$_refreshHorizontalMeasures$1() {
        this._origin$1.x = Math.round(this._client$1.width - this._margin$1.right * this._client$1.width / 100);
        this._view$1.width = Math.round(this._origin$1.x - this._margin$1.left * this._client$1.width / 100);
    },
    
    _refreshVerticalMeasures$1: function Custom_CandlestickChart$_refreshVerticalMeasures$1() {
        this._origin$1.y = Math.round(this._client$1.height - this._margin$1.bottom * this._client$1.height / 100);
        this._view$1.height = Math.round(this._origin$1.y - this._margin$1.left * this._client$1.height / 100);
    },
    
    setScale: function Custom_CandlestickChart$setScale(x, y) {
        /// <param name="x" type="Number">
        /// </param>
        /// <param name="y" type="Number">
        /// </param>
    },
    
    setHeight: function Custom_CandlestickChart$setHeight(value) {
        /// <param name="value" type="Number">
        /// </param>
        this._client$1.height = value;
        this._refreshVerticalMeasures$1();
        this._refreshBackground$1();
        this.refreshForeground();
        this._background.draw();
        this._foreground.draw();
    },
    
    setWidth: function Custom_CandlestickChart$setWidth(value) {
        /// <param name="value" type="Number">
        /// </param>
        this._client$1.width = value;
        this._refreshHorizontalMeasures$1();
        this._refreshBackground$1();
        this.refreshForeground();
        this._background.draw();
        this._foreground.draw();
    },
    
    update: function Custom_CandlestickChart$update(options) {
        /// <param name="options" type="Object">
        /// </param>
    }
}


Custom.StradeStation.registerClass('Custom.StradeStation');
Custom.Symbol.registerClass('Custom.Symbol');
Custom.Candlestick.registerClass('Custom.Candlestick');
Custom.CandlestickChart.registerClass('Custom.CandlestickChart', Object);
Custom.Candlestick.wickWidth = 1;
Custom.Candlestick.blockWidth = 5;
Custom.Candlestick.marginWidth = 5;
})(jQuery);

//! This script was generated using Script# v0.7.4.0
