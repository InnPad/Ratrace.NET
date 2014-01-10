// Sprite.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    /// <summary>
    /// Sprite.
    /// </summary>
    public class Sprite : Shape
    {
        /// <summary>
        /// Sprite constructor.
        /// </summary>
        /// <param name="config"></param>
        public Sprite(SpriteConfig config)
            : base(config)
        {
        }

        /// <summary>
        /// Set after frame event handler.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="func"></param>
        public void afterFrame(Number index, Delegate func)
        {
        }

        /// <summary>
        /// Get animation key.
        /// </summary>
        /// <returns></returns>
        public string getAnimation()
        {
            return null;
        }

        /// <summary>
        /// Get animations object.
        /// </summary>
        /// <returns></returns>
        public Animation getAnimations()
        {
            return null;
        }

        /// <summary>
        /// Get animation frame index.
        /// </summary>
        /// <returns></returns>
        public int getIndex()
        {
            return -1;
        }

        /// <summary>
        /// Set animation key.
        /// </summary>
        /// <param name="anim"></param>
        public void setAnimation(string anim)
        {
        }

        /// <summary>
        /// Set animations object.
        /// </summary>
        /// <param name="animations"></param>
        /// <returns></returns>
        public void setAnimations(Animation animations)
        {
        }

        /// <summary>
        /// Set animation frame index.
        /// </summary>
        /// <param name="index"></param>
        public void setIndex(int index)
        {
        }

        /// <summary>
        /// Start sprite animation.
        /// </summary>
        public void start()
        {
        }

        /// <summary>
        /// Stop sprite animation.
        /// </summary>
        public void stop()
        {
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class SpriteConfig : ShapeConfig
    {
        /// <summary>
        /// Animation key
        /// </summary>
        public string animation;
        
        /// <summary>
        /// Animation map
        /// </summary>
        public Animation animations;

        /// <summary>
        /// Optional. Animation index.
        /// </summary>
        public int index;
    }
}
