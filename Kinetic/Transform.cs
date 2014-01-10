// Transform.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    /// <summary>
    /// Transform
    /// </summary>
    [Imported]
    public class Transform
    {
        public static implicit operator bool(Transform obj)
        {
            return obj;
        }

        /// <summary>
        /// Transform constructor.
        /// </summary>
        public Transform()
        {
        }

        /// <summary>
        /// Return matrix.
        /// </summary>
        /// <returns></returns>
        public object getMatrix()
        {
            return null;
        }

        /// <summary>
        /// Returns the translation.
        /// </summary>
        /// <returns></returns>
        public Point getTranslation()
        {
            return null;
        }

        /// <summary>
        /// Invert the matrix.
        /// </summary>
        public void invert()
        {
        }

        /// <summary>
        /// Transform multiplication.
        /// </summary>
        /// <param name="matrix"></param>
        public void multiply(object matrix)
        {
        }

        /// <summary>
        /// Apply rotation.
        /// </summary>
        /// <param name="rad"></param>
        public void rotate(Number rad)
        {
        }

        /// <summary>
        /// Apply scale.
        /// </summary>
        /// <param name="sx"></param>
        /// <param name="sy"></param>
        public void scale(Number sx, Number sy)
        {
        }

        /// <summary>
        /// Apply translation.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void translate(Number x, Number y)
        {
        }
    }
}
