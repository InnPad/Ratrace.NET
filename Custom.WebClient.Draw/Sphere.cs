// Sphere.cs
//

using System;
using System.Html.Media.Graphics;

namespace Custom
{
    public class Sphere
    {
        public static Vector3D TraceArc(CanvasContext2D ctx, Vector3D center, Vector3D context, double r, double a, double b, Vector3D u, Vector3D v)
        {
            double angle = b - a;
            double accuracy = PI.Value / 16;
            double steps = Math.Abs(Math.Ceil(angle / accuracy));
            steps = 8;
            double mhu = angle / steps;

            double phi = a;

            for (int i = 0; i < steps; i++)
            {

                double rho = phi + mhu;
                Vector3D ending = center.Translate(Sphere.Plot(rho, r, u, v));

                Vector3D control = Vector3D.CalcControl(context,
                        center.Translate(Sphere.Plot(phi + Epsilon.Value, r, u, v)),
                        center.Translate(Sphere.Plot(rho - Epsilon.Value, r, u, v)), ending);

                ctx.QuadraticCurveTo(control.X, control.Y, ending.X, ending.Y);

                phi = rho;
                context = ending;
            }
            return context;
        }

        public static Vector3D DrawVisibleArc(CanvasContext2D ctx, Vector3D center, double r, Vector3D u, Vector3D v, string color)
        {

            double phi = 0;
            double rho = 2 * PI.Value;
            if (v.Z != 0)
            {
                phi = Math.Atan(-u.Z / v.Z);

                if (v.Z < 0)
                {
                    phi = phi + PI.Value;
                }

                if (phi < 0)
                {
                    phi = 2 * PI.Value + phi;
                }
                else if (phi > 2 * PI.Value)
                {
                    phi = phi - 2 * PI.Value;
                }
                rho = phi + PI.Value;
            }

            ctx.BeginPath();
            ctx.StrokeStyle = color;
            Vector3D context = Sphere.TraceArc(ctx, center, null, r, phi, rho, u, v);
            ctx.Stroke();

            return context;
        }

        // To get a parametric equation follow this procedure.
        // 1. Let N be a unit normal Vector3D for the plane.
        // 2. Let C be the circle center, and let R be the radius.
        // 3. Let U be a unit Vector3D from C toward a point on the circle.
        // 4. Let V = N x U.
        // 5. Let t be the paramter.
        // 6. A point P is on the circle if...
        // P = C + R cos(t) U + R sin(t) V
        public static Vector3D Plot(double rho, double r, Vector3D u, Vector3D v)
        {
            double x = r * Math.Cos(rho);
            double y = r * Math.Sin(rho);

            Vector3D Vector3D = new Vector3D(
                    x * u.X + y * v.X,
                    x * u.Y + y * v.Y,
                    x * u.Z + y * v.Z);

            return Vector3D;
        }
    }
}
