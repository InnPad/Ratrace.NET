// Candlestick.cs
//

using System;
using System.Collections.Generic;
using System.Html.Media.Graphics;
using System.Runtime.CompilerServices;
using Kinetic;

namespace Custom
{
    /// <summary>
    /// Candlestick. A charting method, originally from Japan, in which the high and low are plotted as a single line and are referred to as shadows. The price range between the open and the close is plotted as a narrow rectangle and is referred to as the body. If the close is above the open, the body is white. If the close is below the open, the body is black. 
    /// </summary>
    public class Candlestick
    {
        public static Number WickWidth = 1;
        public static Number BlockWidth = 5;
        public static Number MarginWidth = 5;

        public Group shape;
        private Rect _body;
        private Line _head;
        private Line _tail;

        /// <summary>
        /// width 'less or equal than' (n * BlockWidth +  (n - 1) * MarginWidth)
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public static int Count(Number width)
        {
            Number count = (width + MarginWidth) / (Number)(BlockWidth + MarginWidth);
            return Math.Truncate(count);
        }
        
        public Candlestick()
        {
            _body = new Rect(new RectConfig("strokeWidth", 1, "stroke", "#0f0"));

            _head = new Line(new ShapeConfig("strokeWidth", 1, "stroke", "#0f0"));

            _tail = new Line(new ShapeConfig("strokeWidth", 1, "stroke", "#0f0"));

            shape = new Group(new NodeConfig());

            shape.add(_head);
            shape.add(_body);
            shape.add(_tail);
        }

        public void setColor(string color)
        {
            _head.setStroke(color);
            _tail.setStroke(color);
            _body.setStroke(color);
        }

        public void setWickWidth(int value)
        {
            _head.setStrokeWidth(value);
            _tail.setStrokeWidth(value);
        }

        public void Update(Number startX, Number zeroY, int offset, Number scaleX, Number scaleY, Date day, DayQuote quote)
        {
            //shape.setName(day);
            Number high, low;
            string fill;

            if (quote.open > quote.close)
            {
                fill = _body.getStroke();
                high = quote.open;
                low = quote.close;
            }
            else
            {
                fill = null;
                high = quote.close;
                low = quote.open;
            }

            Number x = startX - scaleX * (BlockWidth + MarginWidth) * offset;
            Number width = scaleX * (BlockWidth - WickWidth) / 2;

            _head.setPoints(new Kinetic.Point[] { new Kinetic.Point("x", x, "y", zeroY - scaleY * quote.max), new Kinetic.Point("x", x, "y", zeroY - scaleY *high) });
            _tail.setPoints(new Kinetic.Point[] { new Kinetic.Point("x", x, "y", zeroY - scaleY * low), new Kinetic.Point("x", x, "y", zeroY - scaleY * quote.min) });
            _body.setPosition(x - width, zeroY - scaleY *high);
            _body.setSize(scaleX * BlockWidth, scaleY * (high - low) + 1);
            _body.setFill(fill);
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class CandlestickOptions
    {
        public string color;

        public Number offset;

        public Number close;

        public Number min;

        public Number max;

        public Number open;

        public CandlestickOptions()
        {
        }

        public CandlestickOptions(params object[] nameValuePairs)
        {
        }
    }
}
