// CandlestickChart.cs
//

using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;
using Custom;
using jQueryApi;
using Kinetic;

namespace Custom
{
    public delegate void DayQuotationFn(Dictionary<int, DayQuote> quotation, Date start, int count);
    
    public class CandlestickChart : ScriptObject
    {
        public Kinetic.Stage stage;

        public Kinetic.Layer _background;

        /// <summary>
        /// Foreground layer
        /// </summary>
        public Kinetic.Layer _foreground;

        /// <summary>
        /// Highlight background for the area in the range.
        /// </summary>
        public Kinetic.Rect _highlight;

        /// <summary>
        /// Lower bound line delimiting the highlight (to the left)
        /// </summary>
        public Kinetic.Line _leftBound;

        /// <summary>
        /// Higher bound line delimiting the highlight (to the right)
        /// </summary>
        public Kinetic.Line _rightBound;

        public Kinetic.Line _zeroBound;

        public List<Candlestick> sticks;

        private Point _origin;
        private Custom.Vector _scale;
        private Margin _margin;
        private Size _client;
        private Size _view;

        private Range _variation;
        private Range _selection;


        // day range
        private Date _start;
        private int _count;

        public string stickColor;

        public DayQuotationFn quotationFn;
        private Dictionary<int, DayQuote> _quotation;
        
        public CandlestickChart(Stage stage, CandlestickChartOptions options)
        {
            this.stage = stage;
            this.quotationFn = GenerateQuotation;
            this._start = Date.Today;
            this._origin = new Point("x", 0, "y", 0);
            this._view = new Size("width", 0, "height", 0);
            this._margin = new Margin("top", 5, "right", 5, "bottom", 5, "left", 5);
            this._selection = new Range();
            this._variation = new Range();
            this._scale = new Custom.Vector("x", 1, "y", 1);
            this.stickColor = "#0f0";
            this.sticks = new List<Candlestick>();
            
            jQueryObject container = jQuery.FromElement(stage.getContainer());

            this._client = new Size(
                "width", container.GetWidth(),
                "height", container.GetHeight());
            this._view = new Size();

            this.RefreshHorizontalMeasures();
            this.RefreshVerticalMeasures();

            this._background = new Layer(new LayerConfig());

            this._highlight = new Kinetic.Rect(new RectConfig("strokeWidth", 0, "fill", "#555", "opacity", 0.5));
            this._leftBound = new Kinetic.Line(new LineConfig("strokeWidth", 1, "stroke", "#ccc", "opacity", 0.5));
            this._rightBound = new Kinetic.Line(new LineConfig("strokeWidth", 1, "stroke", "#ccc", "opacity", 0.5));
            this._zeroBound = new Kinetic.Line(new LineConfig("strokeWidth", 1, "stroke", "#f00", "opacity", 1));

            this.RefreshBackground();

            this._background.add(this._highlight);
            this._background.add(this._leftBound);
            this._background.add(this._rightBound);
            this._background.add(this._zeroBound);

            this.stage.Add(this._background);
            
            this._foreground = new Layer(new LayerConfig());

            this.stage.Add(this._foreground);

            Update(options);

            this._quotation = new Dictionary<int, DayQuote>();
            this.quotationFn(this._quotation, _start, _count);

            this.RefreshForeground();

            Animation animation = new Animation((Action<Frame>)Animate, this._foreground);

            //animation.start();
        }

        private void Animate(Frame frame)
        {
            if (frame.time % 10 == 1)
            {
                this._background.draw();
            }
        }

        public static void GenerateQuotation(Dictionary<int, DayQuote> quotation, Date start, int count)
        {
            for (int offset = 0; offset < count; offset++)
            {
                Number min = 5 + 10 * Math.Random();
                Number low = min + 20 * Math.Random();
                Number high = low + 50 * Math.Random();
                Number max = high + 20 * Math.Random();

                DayQuote quote;

                if (Math.Random() > 0.5)
                {
                    quote = new DayQuote("close", low, "max", max, "min", min, "open", high);
                }
                else
                {
                    quote = new DayQuote("close", high, "max", max, "min", min, "open", low);
                }

                quotation[offset] = quote;
            }
        }

        public void RenderCandleSticks(Date start, Dictionary<int, DayQuote> quotation)
        {
            _foreground.clear();

            int count = Math.Min(_count, quotation.Count);
            Number scaleX = this._scale.X;
            Number scaleY = this._scale.Y;

            for (int offset = 0; offset < count; offset++)
            {
                Candlestick stick;
                if (this.sticks.Count > offset)
                    stick = this.sticks[offset];
                else
                {
                    stick = new Candlestick();
                    stick.setColor(this.stickColor);
                    this.sticks.Add(stick);
                }

                Date day = new Date();
                day.SetDate(start.GetDay() - offset);
                stick.Update(this._origin.x, this._origin.y, offset, scaleX, scaleY, day, quotation[offset]);
                _foreground.add(stick.shape);
            }
        }

        public Range Range
        {
            [ScriptName("getRange")]
            get { return new Range("high", this._selection.high, "low", this._selection.low); }

            [ScriptName("setRange")]
            set
            {
                jQuery.ExtendObject(this._selection, value);
            }
        }

        public Number High
        {
            [ScriptName("getHigh")]
            get { return this._selection.high; }

            [ScriptName("setHigh")]
            set { this._selection.high = value; }
        }

        public Number Low
        {
            [ScriptName("getLow")]
            get { return this._selection.low; }

            [ScriptName("setLow")]
            set { this._selection.low = value; }
        }

        public Margin Margin
        {
            [ScriptName("getMargin")]
            get { return new Margin("top", this._margin.top, "right", this._margin.right, "bottom", this._margin.bottom, "left", this._margin.left); }

            [ScriptName("setMargin")]
            set { jQuery.ExtendObject(this._margin, value); }
        }

        public void Draw()
        {
            this._background.draw();
            this._foreground.draw();
        }

        public Date GetDate(int offset)
        {
            Date date = new Date();
            date.SetDate(_start.GetDay() - offset);
            return date;
        }

        public Number Max(Dictionary<int, DayQuote> quotation, int first, int last)
        {
            if (quotation.Count == 0)
                return 0;

            Number max = quotation[first].max;
            for (int i = first + 1; i <= last; i++)
            {
                Number value = quotation[i].max;
                if (value > max)
                    max = value;
            }
            return max;
        }

        public Number Min(DayQuote[] quotation, int first, int last)
        {
            if (quotation.Length == 0)
                return 0;

            Number min = quotation[0].min;
            for (int i = first + 1; i <= last; i++)
            {
                Number value = quotation[i].min;
                if (value < min)
                    min = value;
            }
            return min;
        }

        private void RefreshBackground()
        {
            this._rightBound.setPoints(
                new Kinetic.Point[]
                {
                    new Kinetic.Point("x", this._origin.x, "y", this._origin.y - this._view.height), 
                    new Kinetic.Point("x", this._origin.x, "y", this._origin.y)
                });

            this._leftBound.setPoints(
                new Kinetic.Point[]
                {
                    new Kinetic.Point("x", this._origin.x - this._view.width, "y", this._origin.y - this._view.height), 
                    new Kinetic.Point("x", this._origin.x - this._view.width, "y", this._origin.y)
                });

            this._zeroBound.setPoints(
                new Kinetic.Point[]
                {
                    new Kinetic.Point("x", 0, "y", this._origin.y), 
                    new Kinetic.Point("x", this._client.width, "y", this._origin.y)
                });

            this._highlight.setPosition(this._origin.x - this._view.width, this._origin.y - this._view.height);
            this._highlight.setSize(this._view.width, this._view.height - 40);
        }

        public void RefreshForeground()
        {
            // candlestick
            int count = Candlestick.Count(this._view.width);
            if (count > this._count)
            {
                this.quotationFn(this._quotation, _start, count);
            }
            this._count = count;

            // get max and min
            this._variation.high = Max(this._quotation, 0, this._count - 1);
            this._variation.low = Max(this._quotation, 0, this._count - 1);

            // update scales
            this._scale = new Custom.Vector("x", 1, "y", this._view.height / this._variation.high);

            RenderCandleSticks(this._start, this._quotation);
        }

        private void RefreshHorizontalMeasures()
        {
            this._origin.x = Math.Round(this._client.width - this._margin.right * this._client.width / 100);
            this._view.width = Math.Round(this._origin.x - this._margin.left * this._client.width / 100);
        }

        private void RefreshVerticalMeasures()
        {
            this._origin.y = Math.Round(this._client.height - this._margin.bottom * this._client.height / 100);
            this._view.height = Math.Round(this._origin.y - this._margin.left * this._client.height / 100);
        }
        
        public void setScale(Number x, Number y)
        {   
        }

        public void setHeight(Number value)
        {
            this._client.height = value;

            RefreshVerticalMeasures();
            RefreshBackground();
            RefreshForeground();

            this._background.draw();
            this._foreground.draw();
        }

        public void setWidth(Number value)
        {
            this._client.width = value;

            RefreshHorizontalMeasures();
            RefreshBackground();
            RefreshForeground();

            this._background.draw();
            this._foreground.draw();
        }

        public void Update(CandlestickChartOptions options)
        {
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public sealed class CandlestickChartOptions
    {
        public StageOptions stage;

        /// <summary>
        /// The starting day. The date closer to today.
        /// </summary>
        public Date day;

        /// <summary>
        /// The number of days counting to the past.
        /// </summary>
        public int count;

        public CandlestickChartOptions()
        {
        }

        public CandlestickChartOptions(params object[] nameValuePairs)
        {
        }
    }
}

[Mixin("$.fn")]
public static class CandlestickChartPlugin
{
    public static jQueryObject CandlestickChart(CandlestickChartOptions customOptions)
    {
        CandlestickChartOptions defaultOptions =
            new CandlestickChartOptions("day", Date.Today, "count", 20);

        CandlestickChartOptions options =
            jQuery.ExtendObject<CandlestickChartOptions>(new CandlestickChartOptions(), defaultOptions, customOptions);

        return jQuery.Current.Each(delegate(int i, Element element)
        {
            Stage stage = StageMaster.FromElement(element, options.stage);

            jQueryObject container = jQuery.FromElement(stage.getContainer());

            CandlestickChart chart = (CandlestickChart)container.GetDataValue("Custom.CandlestickChart");

            if (!chart)
            {
                chart = new CandlestickChart(stage, options);
                container.Data("Custom.CandlestickChart", chart);
            }
        });
    }
}

#region Script# Support
[Imported]
public sealed class CandlestickChartObject : jQueryObject
{
    public jQueryObject CandlestickChart()
    {
        return null;
    }

    public jQueryObject CandlestickChart(CandlestickChartOptions options)
    {
        return null;
    }
}
#endregion
