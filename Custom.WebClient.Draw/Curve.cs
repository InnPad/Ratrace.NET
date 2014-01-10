// Circle.cs
//

using System;
using System.Collections.Generic;
using System.Html.Media.Graphics;

namespace Custom
{
    public class Curve
    {
        public static Vector3D Plot(double phi, double r)
        {
            return new Vector3D(Math.Sin(phi) * r, Math.Cos(phi) * r, 0);
        }

        public static bool SmallArc(CanvasContext2D ctx, Vector3D center, Vector3D context, double r, double a, double b)
        {
            if (a == b)
            {
                return false;
            }
            if (a > b && a - b > PI.Value)
            {
                a = a - 2 * PI.Value;
            }
            else if (b > a && b - a > PI.Value)
            {
                b = b - 2 * PI.Value;
            }
            Curve.TraceArc(ctx, center, context, r, a, b);

            return true;
        }

        public static Vector3D TraceArc(CanvasContext2D ctx, Vector3D center, Vector3D context, double r, double a, double b)
        {
            double angle = b - a;
            double accuracy = PI.Value / 16;
            double steps = Math.Abs(Math.Ceil(angle / accuracy));

            if (steps == 0)
            {
                return context;
            }

            double mhu = angle / steps;

            double phi = a;

            //ctx.arc(center.X, center.Y, a, b, mhu < 0);

            double eps = mhu < 0 ? -Epsilon.Value : Epsilon.Value;
            for (int i = 0; i < steps; i++)
            {

                double rho = phi + mhu;
                Vector3D ending = center.Translate(Curve.Plot(rho, r));



                Vector3D control = Vector3D.CalcControl(context,
                    center.Translate(Curve.Plot(phi + eps, r)),
                    center.Translate(Curve.Plot(rho - eps, r)), ending);

                ctx.QuadraticCurveTo(control.X, control.Y, ending.X, ending.Y);

                phi = rho;
                context = ending;
            }
            return context;
        }

        public static Vector3D DrawArc(CanvasContext2D ctx, Vector3D center, Vector3D context, double r, double a, double b, long color)
        {
            ctx.StrokeStyle = color;
            ctx.MoveTo(context.X, context.Y);
            ctx.BeginPath();
            context = Curve.TraceArc(ctx, center, context, r, a, b);
            ctx.Stroke();
            return context;
        }

        public static Vector3D TraceCircle(CanvasContext2D ctx, Vector3D center, double r)
        {
            return Curve.TraceArc(ctx, center, center.Translate(new Vector3D(r, 0, 0)), r, 0, 2 * PI.Value);
        }

        public static Vector3D DrawCircle(CanvasContext2D ctx, Vector3D center, double r, long color)
        {
            return Curve.DrawArc(ctx, center, new Vector3D(r, 0, 0), r, 0, 2 * PI.Value, color);
        }

        public static void TraceCircleDeprecated(CanvasContext2D ctx, Vector3D center, double r)
        {
            double pi4th = PI.Value / 4;
            double pi8th = PI.Value / 8;
            double sin_pi4th = Math.Sin(pi4th);
            double tan_pi8th = Math.Tan(pi8th);

            double x = center.X;
            double y = center.Y;

            // start drawing circle CCW at positive x-axis, at distance r from center(x+r)
            // 1st anchor point...x:(x+r), y:y
            ctx.QuadraticCurveTo(r + x, -tan_pi8th * r + y, sin_pi4th * r + x, -sin_pi4th * r + y);

            // control point...x:radius+x offset, y:tan(pi/8)*radius+y offset
            // 2nd anchor point...x:cos(pi/4)*radius+x offset, y:sin(pi/4)*radius+y offset
            // becomes 1st anchor point for next curveTo
            ctx.QuadraticCurveTo(tan_pi8th * r + x, -r + y, x, -r + y);
            // control point...x:cot(3pi/8)*radius+x offset, y:-radius+ y offset
            // 2nd anchor point...x:x offset,y:-radius+y offset
            // etc...
            ctx.QuadraticCurveTo(-tan_pi8th * r + x, -r + y, -sin_pi4th * r + x, -sin_pi4th * r + y);
            ctx.QuadraticCurveTo(-r + x, -tan_pi8th * r + y, -r + x, y);
            ctx.QuadraticCurveTo(-r + x, tan_pi8th * r + y, -sin_pi4th * r + x, sin_pi4th * r + y);
            ctx.QuadraticCurveTo(-tan_pi8th * r + x, r + y, x, r + y);
            ctx.QuadraticCurveTo(tan_pi8th * r + x, r + y, sin_pi4th * r + x, sin_pi4th * r + y);
            ctx.QuadraticCurveTo(r + x, tan_pi8th * r + y, r + x, y);
        }

        public static void DrawCircleDeprecated(CanvasContext2D ctx, Vector3D center, double r, string color)
        {
            ctx.BeginPath();
            ctx.StrokeStyle = color;
            ctx.MoveTo(center.X + r, center.Y);
            Curve.TraceCircleDeprecated(ctx, center, r);
            ctx.Stroke();
        }
    }
}
