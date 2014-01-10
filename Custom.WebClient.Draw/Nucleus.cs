// Nucleus.cs
//

using System;
using System.Collections.Generic;
using System.Html;
using System.Html.Media.Graphics;
using System.Runtime.CompilerServices;
using Kinetic;

namespace Custom
{
    public class Nucleus
    {
        public Circle circle;

        public Nucleus(Layer layer, Space3D axes)
        {
            circle = new Circle(new CircleConfig(
                "x", 100,
                "y", 100,
                "radius", 160,
                "fill", "#ccc",
                "stroke", "#ccc",
                "strokeWidth", 1,
                "drawFunc", (Action<Canvas>)delegate(Canvas canvas)
                {
                    Script.Literal("this.circle.__proto__.drawFunc.call(this.circle, canvas)");
                    CanvasContext2D ctx = canvas.getContext();
                    Paint(ctx, circle.getRadius(), 10, axes);
                }));
            
            int zIndex = circle.getZIndex();

            layer.add(circle);
        }

        public Vector3D Center
        {
            [ScriptName("getCenter")]
            get { return new Vector3D(circle.getX(), circle.getY(), 0); }

            [ScriptName("setCenter")]
            set
            {
                circle.setX(value.X);
                circle.setY(value.Y);
            }
        }

        public Number Radius
        {
            [ScriptName("getRadius")]
            get { return circle.getRadius(); }

            [ScriptName("setRadius")]
            set
            {
                circle.setRadius(value);
            }
        }
        public void Paint(CanvasContext2D ctx, double r, double d, Space3D axes)
        {
            double h = Math.Sqrt(r * r - d * d);
            double mhu = Math.Asin(d / r);

            Octant[] octants = new Octant[8];
            Color[] colors = new Color[]
            {
                new Color("#9c6"),
                new Color("#693"),
                new Color("#369"),
                new Color("#69c"),
                //new Color("#963"),
                //new Color("#c96"),
                //new Color("#96c"),
                //new Color("#639")
                new Color("#69c"),
                new Color("#369"),
                new Color("#693"),
                new Color("#9c6")
            };

            for (int i = 0; i < 8; i++)
            {
                octants[i] = new Octant(i, colors[i]);
            }

            //ctx.lineCap = 'round';
            ctx.LineJoin = LineJoin.Round;

            for (int i = 0; i < 8; i++)
            {
                Octant r8 = octants[i];
                r8.Update(axes, d, h);
                if (!Support.RadialGradient)
                    ctx.FillStyle = r8.color._value;
                else
                {
                    try
                    {
                        Color basecolor = new Color(r8.color._value);
                        Vector3D p0 = Center;
                        Vector3D p1 = p0.Translate(Curve.Plot(PI.Value / 4, r));
                        Gradient gradient = ctx.CreateRadialGradient(p0.X, p0.Y, r, p1.X, p1.Y, r);
                        gradient.AddColorStop(0, basecolor.Lighter(0.2));
                        gradient.AddColorStop(0.5, basecolor._value);
                        gradient.AddColorStop(1, basecolor.Darker(0.2));
                        ctx.FillStyle = gradient;
                    }
                    catch (Exception err)
                    {
                        ctx.FillStyle = r8.color.Value;
                    }
                }
                if (r8.TraceSurface(ctx, axes, mhu, r, d, h))
                {
                    ctx.Fill();
                }
            }
        }
    }
}
