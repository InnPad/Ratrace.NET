// Space3D.cs
//

using System;
using System.Html.Media.Graphics;

namespace Custom
{
    public class Space3D
    {
        public readonly Vector3D AxisX;
        public readonly Vector3D AxisY;
        public readonly Vector3D AxisZ;
        public readonly Vector3D Center;

        public Space3D()
        {
            AxisX = new Vector3D(1, 0, 0);
            AxisY = new Vector3D(0, 1, 0);
            AxisZ = new Vector3D(0, 0, 1);
            Center = new Vector3D(0, 0, 0);
        }

        public void DrawVisibleAxes(CanvasContext2D ctx, double r, string color)
        {
            // X
            Sphere.DrawVisibleArc(ctx, Center, r, AxisY, AxisZ, color);

            // Y
            Sphere.DrawVisibleArc(ctx, Center, r, AxisZ, AxisX, color);

            // Z
            Sphere.DrawVisibleArc(ctx, Center, r, AxisX, AxisY, color);
        }

        public void DrawVisibleMesh(CanvasContext2D ctx, double r, int count, string color)
        {
            DrawVisibleAxes(ctx, r, color);

            double step = r / count;

            //var a = Math.atan(-u.Z / v.Z);

            for (int i = 1; i < count; i++)
            {

                double d = i * step;
                double h = Math.Sqrt(r * r - d * d);

                // X
                Sphere.DrawVisibleArc(ctx, Center.Translate(AxisX.Plot(d)), h, AxisY, AxisZ, color);
                Sphere.DrawVisibleArc(ctx, Center.Translate(AxisX.Plot(-d)), h, AxisY, AxisZ, color);

                // Y
                Sphere.DrawVisibleArc(ctx, Center.Translate(AxisY.Plot(d)), h, AxisZ, AxisX, color);
                Sphere.DrawVisibleArc(ctx, Center.Translate(AxisY.Plot(-d)), h, AxisZ, AxisX, color);

                // Z
                Sphere.DrawVisibleArc(ctx, Center.Translate(AxisZ.Plot(d)), h, AxisX, AxisY, color);
                Sphere.DrawVisibleArc(ctx, Center.Translate(AxisZ.Plot(-d)), h, AxisX, AxisY, color);
            }
        }

        public void Rotate(double x, double y, double z)
        {
            Vector3D axis = new Vector3D(x, y, z);

            //axis.normalize();

            if (x != 0)
            {
                double cosX = Math.Cos(axis.X);
                double sinX = Math.Sin(axis.X);
                AxisX.RotateX(cosX, sinX);
                AxisY.RotateX(cosX, sinX);
                AxisZ.RotateX(cosX, sinX);
            }

            if (y != 0)
            {
                double cosY = Math.Cos(axis.Y);
                double sinY = Math.Sin(axis.Y);
                AxisX.RotateY(cosY, sinY);
                AxisY.RotateY(cosY, sinY);
                AxisZ.RotateY(cosY, sinY);
            }

            if (z != 0)
            {
                double cosZ = Math.Cos(axis.Z);
                double sinZ = Math.Sin(axis.Z);
                AxisX.RotateZ(cosZ, sinZ);
                AxisY.RotateZ(cosZ, sinZ);
                AxisZ.RotateZ(cosZ, sinZ);
            }
        }

        public void Translate(double x, double y, double z)
        {
            Center.X += x;
            Center.Y += y;
            Center.Z += z;
        }
    }
}
