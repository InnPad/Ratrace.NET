using System;
using System.Collections.Generic;

namespace Custom
{
    public static class Epsilon
    {
        public static readonly double Value = 0.0000000001;
    }

    public static class PI
    {
        public static readonly double Value = Math.PI;
        public static readonly double Twice = 2 * Value;
        public static readonly double Half = Value / 2;
    }

    public static class GoldenRatio
    {
        public static readonly double Value = (1 + Math.Sqrt(5)) / 2;
        public static readonly double Inverse = 1 / Value;
    }

    /// <summary>
    /// Pitagoras Constant
    /// </summary>
    public static class Pythagoras
    {
        public static readonly double Value = Math.Sqrt(2);
        public static readonly double Half = Value / 2;
    }
}
