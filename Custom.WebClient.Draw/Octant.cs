// Octant.cs
//

using System;
using System.Html.Media.Graphics;
using System.Runtime.CompilerServices;

namespace Custom
{
    // Octahedron
    [ScriptName("R8")]
    public class Octant
    {
        public Color color;
        public readonly int index;
        public Vector3D Vector3D;
        public Vector3D x;
        public Vector3D y;
        public Vector3D z;

        public Octant(int index, Color color)
        {
            this.index = index;
            this.color = color;
            this.Vector3D = new Vector3D(1, 1, 1);
            this.x = new Vector3D(1, 0, 0);
            this.y = new Vector3D(0, 1, 0);
            this.z = new Vector3D(0, 0, 1);
        }

        public void Update(Space3D system, double d, double h)
        {
            int octant = 7 - this.index;
            Vector3D v = this.Vector3D = new Vector3D(((octant << 1) & 2) - 1, (octant & 2) - 1, ((octant >> 1) & 2) - 1);

            Vector3D x = system.AxisX.Plot(v.X);
            Vector3D y = system.AxisY.Plot(v.Y);
            Vector3D z = system.AxisZ.Plot(v.Z);


            double sin = Pythagoras.Half * v.X * v.Y * v.Z;
            double cos = Pythagoras.Half;

            Vector3D ux = x.Rotate(y, sin, cos);
            Vector3D uy = y.Rotate(z, sin, cos);
            Vector3D uz = z.Rotate(x, sin, cos);

            this.x = ux.Plot(d / cos).Translate(x.Plot(h));
            this.y = uy.Plot(d / cos).Translate(y.Plot(h));
            this.z = uz.Plot(d / cos).Translate(z.Plot(h));
        }

        public bool TraceSurface(CanvasContext2D ctx, Space3D system, double mhu, double r, double d, double h)
        {
            Vector3D center = system.Center;
            Vector3D v = this.Vector3D;
            Vector3D ux = this.x;
            Vector3D uy = this.y;
            Vector3D uz = this.z;

            if (ux.Z < 0 && uy.Z < 0 && uz.Z < 0)
            {
                return false;
            }

            Vector3D px = center.Translate(ux);
            Vector3D py = center.Translate(uy);
            Vector3D pz = center.Translate(uz);

            Vector3D x = system.AxisX.Plot(v.X);
            Vector3D y = system.AxisY.Plot(v.Y);
            Vector3D z = system.AxisZ.Plot(v.Z);

            Vector3D cx = center.Translate(x.Plot(d));
            Vector3D cy = center.Translate(y.Plot(d));
            Vector3D cz = center.Translate(z.Plot(d));

            Vector3D phi = new Vector3D(mhu, mhu, mhu);
            Vector3D rho = new Vector3D(PI.Value / 2 - mhu, PI.Value / 2 - mhu, PI.Value / 2 - mhu);

            if (ux.Z > 0 && uy.Z > 0 && uz.Z > 0)
            {
                ctx.MoveTo(py.X, py.Y);
                ctx.BeginPath();
                ctx.MoveTo(py.X, py.Y);
                Sphere.TraceArc(ctx, cx, py, h, phi.X, rho.X, y, z);
                Sphere.TraceArc(ctx, cy, pz, h, phi.Y, rho.Y, z, x);
                Sphere.TraceArc(ctx, cz, px, h, phi.Z, rho.Z, x, y);
                ctx.ClosePath();
            }
            else
            {
                double axy = 0, axz = 0, ayx = 0, ayz = 0, azx = 0, azy = 0;
                Vector3D pxy = px, pxz = px, pyx = py, pyz = py, pzx = pz, pzy = pz;

                if (ux.Z < 0)
                {
                    rho.Y = Math.Atan(-uz.Z / ux.Z);
                    phi.Z = Math.Atan(-ux.Z / uy.Z);

                    pxy = cy.Translate(Sphere.Plot(rho.Y, h, z, x));
                    pxz = cz.Translate(Sphere.Plot(phi.Z, h, x, y));

                    axz = Vector3D.Angle(center, pxz);
                    axy = Vector3D.Angle(center, pxy);
                }

                if (uy.Z < 0)
                {
                    phi.X = Math.Atan(-uy.Z / uz.Z);
                    rho.Z = Math.Atan(-ux.Z / uy.Z);

                    pyx = cx.Translate(Sphere.Plot(phi.X, h, y, z));
                    pyz = cz.Translate(Sphere.Plot(rho.Z, h, x, y));

                    ayx = Vector3D.Angle(center, pyx);
                    ayz = Vector3D.Angle(center, pyz);
                }

                if (uz.Z < 0)
                {
                    rho.X = Math.Atan(-uy.Z / uz.Z);
                    phi.Y = Math.Atan(-uz.Z / ux.Z);

                    pzx = cx.Translate(Sphere.Plot(rho.X, h, y, z));
                    pzy = cy.Translate(Sphere.Plot(phi.Y, h, z, x));

                    azx = Vector3D.Angle(center, pzx);
                    azy = Vector3D.Angle(center, pzy);
                }

                if (ux.Z > 0 && uy.Z > 0)
                {
                    ctx.StrokeStyle = "#f00";
                    ctx.MoveTo(pzx.X, pzx.Y);
                    ctx.BeginPath();
                    Sphere.TraceArc(ctx, cy, pzy, h, phi.Y, rho.Y, z, x);
                    Sphere.TraceArc(ctx, cz, pxz, h, phi.Z, rho.Z, x, y);
                    Sphere.TraceArc(ctx, cx, pyx, h, phi.X, rho.X, y, z);
                    Curve.SmallArc(ctx, center, pzx, r, azx, azy);
                }
                else if (uy.Z > 0 && uz.Z > 0)
                {
                    ctx.StrokeStyle = "#0f0";
                    ctx.MoveTo(pxz.X, pxz.Y);
                    ctx.BeginPath();
                    Sphere.TraceArc(ctx, cz, pxz, h, phi.Z, rho.Z, x, y);
                    Sphere.TraceArc(ctx, cx, pyx, h, phi.X, rho.X, y, z);
                    Sphere.TraceArc(ctx, cy, pzx, h, phi.Y, rho.Y, z, x);
                    Curve.SmallArc(ctx, center, pxy, r, axy, axz);
                }
                else if (uz.Z > 0 && ux.Z > 0)
                {
                    ctx.StrokeStyle = "#00f";
                    ctx.MoveTo(pyx.X, pyx.Y);
                    ctx.BeginPath();
                    Sphere.TraceArc(ctx, cx, pyx, h, phi.X, rho.X, y, z);
                    Sphere.TraceArc(ctx, cy, pzx, h, phi.Y, rho.Y, z, x);
                    Sphere.TraceArc(ctx, cz, pxz, h, phi.Z, rho.Z, x, y);
                    Curve.SmallArc(ctx, center, pyz, r, ayz, ayx);
                }
                else if (ux.Z > 0)
                {
                    ctx.StrokeStyle = "#0ff";
                    ctx.MoveTo(pzy.X, pzy.Y);
                    ctx.BeginPath();
                    Sphere.TraceArc(ctx, cy, pzy, h, phi.Y, rho.Y, z, x);
                    Sphere.TraceArc(ctx, cz, pxz, h, phi.Z, rho.Z, x, y);
                    Curve.SmallArc(ctx, center, pyz, r, ayz, azy);
                }
                else if (uy.Z > 0)
                {
                    ctx.StrokeStyle = "#ff0";
                    ctx.MoveTo(pxz.X, pxz.Y);
                    ctx.BeginPath();
                    Sphere.TraceArc(ctx, cz, pxz, h, phi.Z, rho.Z, x, y);
                    Sphere.TraceArc(ctx, cx, pyx, h, phi.X, rho.X, y, z);
                    Curve.SmallArc(ctx, center, pzx, r, azx, axz);
                }
                else if (uz.Z > 0)
                {
                    ctx.StrokeStyle = "#f0f";
                    ctx.MoveTo(pyx.X, pyx.Y);
                    ctx.BeginPath();
                    Sphere.TraceArc(ctx, cx, pyx, h, phi.X, rho.X, y, z);
                    Sphere.TraceArc(ctx, cy, pzy, h, phi.Y, rho.Y, z, x);
                    Curve.SmallArc(ctx, center, pxy, r, axy, ayx);
                }
            }
            return true;
        }
    }
}