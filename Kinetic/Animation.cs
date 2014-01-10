// Animation.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    /// <summary>
    /// A stage is used to contain multiple layers and handleanimations.
    /// </summary>
    [Imported]
    public class Animation
    {
        public static implicit operator bool(Animation obj)
        {
            return obj;
        }

        /// <summary>
        /// Stage constructor. A stage is used to contain multiple layers and handleanimations .
        /// </summary>
        /// <param name="func">Function executed on each animation frame</param>
        /// <param name="node">Optional. Node to be redrawn.  Can be a layer or the stage. Not specifying a node will result in no redraw.</param>
        public Animation(Delegate func, Node node)
        {
        }

        /// <summary>
        /// Determine if animation is running or not.
        /// </summary>
        /// <returns></returns>
        public bool isRunning() { return false; }

        /// <summary>
        /// Start animation
        /// </summary>
        public void start() { }

        /// <summary>
        /// Stop animation
        /// </summary>
        public void stop() { }
    }
}
