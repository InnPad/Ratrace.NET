// Transition.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    [Imported]
    public class Transition
    {
        public static implicit operator bool(Transition obj)
        {
            return obj;
        }

        /// <summary>
        /// Transition constructor. The transitionTo() Node method returns a reference to the transition object which you can use to stop, resume, or restart the transition
        /// </summary>
        /// <param name="node"></param>
        /// <param name="config"></param>
        public Transition(Node node, TransitionConfig config)
        {
        }

        /// <summary>
        /// Resume transition
        /// </summary>
        public void resume()
        {
        }

        /// <summary>
        /// Start transition
        /// </summary>
        public void start()
        {
        }

        /// <summary>
        /// Stop transition
        /// </summary>
        public void stop()
        {
        }
    }

    /// <summary>
    /// Used to transition node to another state. Any property that can accept a real number can be transitioned, including x, y, rotation, opacity, strokeWidth, radius, scale.x, scale.y, offset.x, offset.y, etc. 
    /// </summary>
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class TransitionConfig
    {
        /// <summary>
        /// Duration that the transition runs in seconds.
        /// </summary>
        public Number duration;

        /// <summary>
        /// Optional. Easing function. can be 'linear', 'ease-in', 'ease-out', 'ease-in-out', 'back-ease-in', 'back-ease-out', 'back-ease-in-out', 'elastic-ease-in', 'elastic-ease-out', 'elastic-ease-in-out', 'bounce-ease-out', 'bounce-ease-in', 'bounce-ease-in-out', 'strong-ease-in', 'strong-ease-out', or 'strong-ease-in-out'. 'linear' is the default.
        /// </summary>
        public string easing;

        /// <summary>
        /// Optional. Callback function to be executed when transition completes.
        /// </summary>
        public Delegate callback;

        public TransitionConfig(params object[] nameValuePairs)
        {
        }
    }
}
