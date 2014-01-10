// Stage.cs
//

using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    /// <summary>
    /// Stage.
    /// </summary>
    public class Stage : Container
    {
        /// <summary>
        /// Stage constructor.
        /// </summary>
        public Stage(StageConfig config)
            : base(config)
        {
        }

        /// <summary>
        /// Add layer to stage
        /// </summary>
        /// <param name="layer"></param>
        public void Add(Layer layer)
        {
        }

        /// <summary>
        /// Clear all layers
        /// </summary>
        public void clear()
        {
        }

        /// <summary>
        /// Draw layer scene graphs
        /// </summary>
        public void draw()
        {
        }

        /// <summary>
        /// Draw layer hit graphs
        /// </summary>
        public void drawHit()
        {
        }

        /// <summary>
        /// Get container DOM element
        /// </summary>
        /// <returns></returns>
        public Element getContainer()
        {
            return null;
        }

        /// <summary>
        /// Get stage content div element which has the the class name "kineticjs-content"
        /// </summary>
        /// <returns></returns>
        public object getContent()
        {
            return null;
        }

        /// <summary>
        /// Get drag and drop layer
        /// </summary>
        /// <returns></returns>
        public Layer getDragLayer()
        {
            return null;
        }

        /// <summary>
        /// Get intersection object that contains shape and pixel data
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public object getIntersection(object pos)
        {
            return null;
        }

        /// <summary>
        /// Get mouse position for desktop apps
        /// </summary>
        /// <returns></returns>
        public Point getMousePosition()
        {
            return null;
        }

        /// <summary>
        /// Get touch position for mobile apps
        /// </summary>
        /// <returns></returns>
        public Point getTouchPosition()
        {
            return null;
        }

        /// <summary>
        /// Get user position which can be a touch position or mouse position
        /// </summary>
        /// <returns></returns>
        public Point getUserPosition()
        {
            return null;
        }

        /// <summary>
        /// Reset stage to default state
        /// </summary>
        public void reset()
        {
        }

        /// <summary>
        /// Set container dom element which contains the stage wrapper div element
        /// </summary>
        /// <param name="container"></param>
        public void setContainer(Element container)
        {
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class StageConfig : NodeConfig
    {
        /// <summary>
        /// Container id or DOM element
        /// </summary>
        public Element container;

        public StageConfig(params object[] nameValuePairs)
        {
        }
    }
}
