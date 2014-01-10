// Vector.cs
//

using System;
using System.Runtime.CompilerServices;

namespace Custom
{
    public class Vector3D : Vector
    {   
        public Vector3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static double Angle(Vector3D center, Vector3D point)
        {
            double x = point.X - center.X;
            double y = point.Y - center.Y;

            double phi = Math.Atan(Math.Abs(x / y));

            if (x < 0 && y < 0)
            {
                phi = PI.Value + phi;
            }
            else if (x < 0)
            {
                phi = 2 * PI.Value - phi;
            }
            else if (y < 0)
            {
                phi = PI.Value - phi;
            }

            return phi;
        }

        // point where lines context-midA and midB-ending intersects
        public static Vector3D CalcControl(Vector3D context, Vector3D midA, Vector3D midB, Vector3D ending)
        {
            double xa = (context.X - midA.X);
            double xb = (midB.X - ending.X);
            double ya = (context.Y - midA.Y);
            double yb = (midB.Y - ending.Y);

            double d = xa * yb - ya * xb;

            double a = (context.X * midA.Y - context.Y * midA.X);
            double b = (midB.X * ending.Y - midB.Y * ending.X);

            double x = (a * xb - xa * b) / d;
            double y = (a * yb - ya * b) / d;
            double z = context.Z + (ending.Z - context.Z) / 2;

            return new Vector3D(x, y, z);
        }

        public double Length()
        {
            return Math.Sqrt(this.X * this.X + this.Y * this.Y + this.Z * this.Z);
        }

        // Normalize
        public void Normalize()
        {
            double length = this.Length();

            this.X = this.X / length;
            this.Y = this.Y / length;
            this.Z = this.Z / length;
        }

        // Cross product
        public Vector3D CrossProduct(Vector3D vector)
        {
            return new Vector3D(
                this.Y * vector.Z - this.Z * vector.Y,
                this.Z * vector.X - this.X * vector.Z,
                this.X * vector.Y - this.Y * vector.X);
        }

        public Vector3D Image()
        {
            return new Vector3D(-this.X, -this.Y, -this.Z);
        }

        public Vector3D Plot(double r)
        {
            return new Vector3D(
                this.X * r,
                this.Y * r,
                this.Z * r);
        }

        public Vector3D Rotate(Vector3D vector, double sin, double cos)
        {
            double icos = 1 - cos;
            double ux = this.X;
            double uy = this.Y;
            double uz = this.Z;
            double uxx = ux * ux;
            double uyy = uy * uy;
            double uzz = uz * uz;
            double uyz = uy * uz;
            double uzx = uz * ux;
            double uxy = ux * uy;

            double m11 = cos + uxx * icos;
            double m12 = uxy * icos - uz * sin;
            double m13 = uzx * icos + uy * sin;

            double m21 = uxy * icos + uz * sin;
            double m22 = cos + uyy * icos;
            double m23 = uyz * icos - ux * sin;

            double m31 = uzx * icos - uy * sin;
            double m32 = uyz * icos + ux * sin;
            double m33 = cos + uzz * icos;

            double x = m11 * vector.X + m12 * vector.Y + m13 * vector.Z;
            double y = m21 * vector.X + m22 * vector.Y + m23 * vector.Z;
            double z = m31 * vector.X + m32 * vector.Y + m33 * vector.Z;

            return new Vector3D(x, y, z);
        }

        // Rotate X
        public void RotateX(double cos, double sin)
        {
            double newY = cos * this.Y - sin * this.Z;
            double newZ = sin * this.Y + cos * this.Z;

            this.Y = newY;
            this.Z = newZ;

            this.Normalize();
        }

        // Rotate Y
        public void RotateY(double cos, double sin)
        {
            double newX = cos * this.X + sin * this.Z;
            double newZ = cos * this.Z - sin * this.X;

            this.X = newX;
            this.Z = newZ;

            this.Normalize();
        }

        // Rotate Z
        public void RotateZ(double cos, double sin)
        {
            double newX = cos * this.X - sin * this.Y;
            double newY = sin * this.X + cos * this.Y;

            this.X = newX;
            this.Y = newY;

            this.Normalize();
        }

        public override string ToString()
        {
            return "(x: " + this.X.ToString() + "; y: " + this.Y.ToString() + "; z: " + this.Z.ToString() + ")";
        }

        public Vector3D Translate(Vector3D v)
        {
            return new Vector3D(v.X + this.X, v.Y + this.Y, v.Z + this.Z);
        }

        public Vector3D DotProduct(Vector3D v)
        {
            return new Vector3D(v.X * this.X, v.Y * this.Y, v.Z * this.Z);
        }
    }
}
