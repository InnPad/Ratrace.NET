// Layer.cs
//

using System;
using System.Collections.Generic;
using System.Html.Media.Graphics;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    /// <summary>
    /// Layers are tied to their own canvas element and are usedto contain groups or shapes.
    /// </summary>
    public class Layer : Container
    {
        /// <summary>
        /// Layer constructor.
        /// </summary>
        /// <param name="config"></param>
        public Layer(LayerConfig config)
            : base(config)
        {
        }

        /// <summary>
        /// Set after draw handler.
        /// </summary>
        /// <param name="handler"></param>
        public void afterDraw(Delegate handler)
        {
        }

        /// <summary>
        /// Set before draw handler.
        /// </summary>
        /// <param name="handler"></param>
        public void beforeDraw(Delegate handler)
        {
        }

        /// <summary>
        /// Clear canvas tied to the layer
        /// </summary>
        public void clear()
        {
        }

        /// <summary>
        /// Draw children nodes.
        /// </summary>
        public void draw()
        {
        }

        /// <summary>
        /// Draw children nodes on hit.
        /// </summary>
        public void drawHit()
        {
        }

        /// <summary>
        /// Draw children nodes on scene.
        /// </summary>
        /// <param name="canvas"></param>
        public void drawScene(Canvas canvas)
        {
        }

        /// <summary>
        /// Get layer canvas.
        /// </summary>
        /// <returns></returns>
        public Canvas getCanvas()
        {
            return null;
        }

        /// <summary>
        /// Get flag which determines if the layer is cleared or not before drawing
        /// </summary>
        /// <returns></returns>
        public bool getClearBeforeDraw()
        {
            return false;
        }

        /// <summary>
        /// Get layer canvas context.
        /// </summary>
        /// <returns></returns>
        public CanvasContext2D getContext()
        {
            return null;
        }

        /// <summary>
        /// Remove layer from stage.
        /// </summary>
        public void remove()
        {
        }

        /// <summary>
        /// Set flag which determines if the layer is cleared or not before drawing.
        /// </summary>
        /// <param name="clearBeforeDraw"></param>
        public void setClearBeforeDraw(bool clearBeforeDraw)
        {
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class LayerConfig : NodeConfig
    {
        /// <summary>
        /// Optional. Set this property to false if you don't wantto clear the canvas before each layer draw. The default value is true.
        /// </summary>
        public bool clearBeforeDraw;

        public LayerConfig()
        {
        }

        public LayerConfig(params object[] nameValuePairs)
        {
        }
    }
}
