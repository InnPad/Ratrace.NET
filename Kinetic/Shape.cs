// Shape.cs
//

using System;
using System.Collections.Generic;
using System.Html;
using System.Html.Media;
using System.Runtime.CompilerServices;

namespace Kinetic
{
    public class Shape : Node
    {
        /// <summary>
        /// Shape constructor.
        /// </summary>
        /// <param name="config"></param>
        public Shape(ShapeConfig config)
            : base(config)
        {
        }

        /// <summary>
        /// Disable dash array
        /// </summary>
        public void disableDashArray()
        {
        }

        /// <summary>
        /// Disable fill
        /// </summary>
        public void disableFill()
        {
        }

        /// <summary>
        /// Disable shadow
        /// </summary>
        public void disableShadow()
        {
        }

        /// <summary>
        /// Disable stroke
        /// </summary>
        public void disableStroke()
        {
        }

        /// <summary>
        /// enable dash array
        /// </summary>
        public void enableDashArray()
        {
        }

        /// <summary>
        /// Enable fill
        /// </summary>
        public void enableFill()
        {
        }

        /// <summary>
        /// Enable shadow
        /// </summary>
        public void enableShadow()
        {
        }

        /// <summary>
        /// Enable stroke
        /// </summary>
        public void enableStroke()
        {
        }

        /// <summary>
        /// Get canvas renderer tied to the layer. Note that this returns a canvas renderer, not a canvas element.
        /// </summary>
        /// <returns>a canvas renderer</returns>
        public Canvas getCanvas()
        {
            return null;
        }

        /// <summary>
        /// Get canvas context tied to the layer
        /// </summary>
        /// <returns></returns>
        public object getContext()
        {
            return null;
        }

        /// <summary>
        /// Get corner radius
        /// </summary>
        /// <returns></returns>
        public Number getCornerRadius()
        {
            return -1;
        }

        /// <summary>
        /// Get dash array
        /// </summary>
        /// <returns></returns>
        public object getDashArray()
        {
            return null;
        }

        /// <summary>
        /// Get draw function
        /// </summary>
        /// <returns></returns>
        public object getDrawFunc()
        {
            return null;
        }

        /// <summary>
        /// Get draw hit function
        /// </summary>
        /// <returns></returns>
        public object getDrawHitFunc()
        {
            return null;
        }

        /// <summary>
        /// Get fill color
        /// </summary>
        /// <returns></returns>
        public object getFill()
        {
            return null;
        }

        /// <summary>
        /// Get fill linear gradient color stops
        /// </summary>
        /// <param name="colorStops"></param>
        /// <returns></returns>
        public object getFillLinearGradientColorStops(object colorStops)
        {
            return null;
        }

        /// <summary>
        /// Get fill linear gradient end point
        /// </summary>
        /// <returns></returns>
        public object getFillLinearGradientEndPoint()
        {
            return null;
        }

        /// <summary>
        /// Get fill linear gradient start point
        /// </summary>
        /// <returns></returns>
        public object getFillLinearGradientStartPoint()
        {
            return null;
        }

        /// <summary>
        /// Get fill pattern image
        /// </summary>
        /// <returns></returns>
        public object getFillPatternImage()
        {
            return null;
        }

        /// <summary>
        /// Get fill pattern offset
        /// </summary>
        /// <returns></returns>
        public object getFillPatternOffset()
        {
            return null;
        }

        /// <summary>
        /// Get fill pattern repeat
        /// </summary>
        /// <returns></returns>
        public object getFillPatternRepeat()
        {
            return null;
        }

        /// <summary>
        /// Get fill pattern rotation in radians
        /// </summary>
        /// <returns></returns>
        public object getFillPatternRotation()
        {
            return null;
        }

        /// <summary>
        /// Get fill pattern rotation in degrees
        /// </summary>
        /// <returns></returns>
        public object getFillPatternRotationDeg()
        {
            return null;
        }

        /// <summary>
        /// Get fill pattern scale
        /// </summary>
        /// <returns></returns>
        public object getFillPatternScale()
        {
            return null;
        }

        /// <summary>
        /// Get fill pattern x
        /// </summary>
        /// <returns></returns>
        public object getFillPatternX()
        {
            return null;
        }

        /// <summary>
        /// Get fill pattern y
        /// </summary>
        /// <returns></returns>
        public object getFillPatternY()
        {
            return null;
        }

        /// <summary>
        /// Get fill priority
        /// </summary>
        /// <returns></returns>
        public object getFillPriority()
        {
            return null;
        }

        /// <summary>
        /// Get fill radial gradient color stops
        /// </summary>
        /// <returns></returns>
        public object getFillRadialGradientColorStops()
        {
            return null;
        }

        /// <summary>
        /// Get fill radial gradient end point
        /// </summary>
        /// <returns></returns>
        public object getFillRadialGradientEndPoint()
        {
            return null;
        }

        /// <summary>
        /// Get fill radial gradient end radius
        /// </summary>
        /// <returns></returns>
        public object getFillRadialGradientEndRadius()
        {
            return null;
        }

        /// <summary>
        /// Get fill radial gradient start point
        /// </summary>
        /// <returns></returns>
        public object getFillRadialGradientStartPoint()
        {
            return null;
        }

        /// <summary>
        /// Get fill radial gradient start radius
        /// </summary>
        /// <returns></returns>
        public object getFillRadialGradientStartRadius()
        {
            return null;
        }

        /// <summary>
        /// Get line cap
        /// </summary>
        /// <returns></returns>
        public object getLineCap()
        {
            return null;
        }

        /// <summary>
        /// Get line join
        /// </summary>
        /// <returns></returns>
        public object getLineJoin()
        {
            return null;
        }

        /// <summary>
        /// Get shadow blur
        /// </summary>
        public object getShadowBlur()
        {
            return null;
        }

        /// <summary>
        /// Get shadow color
        /// </summary>
        /// <returns></returns>
        public object getShadowColor()
        {
            return null;
        }

        /// <summary>
        /// get shadow offset
        /// </summary>
        /// <returns></returns>
        public object getShadowOffset()
        {
            return null;
        }

        /// <summary>
        /// Get shadow opacity.
        /// </summary>
        /// <returns>A value between 0 and 1</returns>
        public Number getShadowOpacity()
        {
            return null;
        }

        /// <summary>
        /// Get stroke color
        /// </summary>
        /// <returns></returns>
        public string getStroke()
        {
            return null;
        }

        /// <summary>
        /// Get stroke width
        /// </summary>
        /// <returns></returns>
        public Number getStrokeWidth()
        {
            return null;
        }

        /// <summary>
        /// Returns whether or not a fill will be rendered
        /// </summary>
        /// <returns></returns>
        public bool hasFill()
        {
            return false;
        }

        /// <summary>
        /// Returns whether or not a shadow will be rendered
        /// </summary>
        /// <returns></returns>
        public bool hasShadow()
        {
            return false;
        }

        /// <summary>
        /// Determines if point is in the shape
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool intersects(object point)
        {
            return false;
        }

        /// <summary>
        /// Set corner radius
        /// </summary>
        /// <param name="corner"></param>
        public void setCornerRadius(Number corner)
        {
        }

        /// <summary>
        /// Set dash array.
        /// </summary>
        /// <param name="dashArray"></param>
        public void setDashArray(Array dashArray)
        {
        }

        /// <summary>
        /// Set draw function
        /// </summary>
        /// <param name="drawFunc"></param>
        public void setDrawFunc(Delegate drawFunc)
        {
        }

        /// <summary>
        /// Set draw hit function used for hit detection
        /// </summary>
        /// <param name="drawHitFunc"></param>
        public void setDrawHitFunc(Delegate drawHitFunc)
        {
        }

        /// <summary>
        /// Set fill color
        /// </summary>
        /// <param name="color"></param>
        public void setFill(object color)
        {
        }

        /// <summary>
        /// Set fill linear gradient color stops
        /// </summary>
        /// <param name="colorStops"></param>
        public void setFillLinearGradientColorStops(object colorStops)
        {
        }

        /// <summary>
        /// Set fill linear gradient end point
        /// </summary>
        /// <param name="endPoint"></param>
        public void setFillLinearGradientEndPoint(Point endPoint)
        {
        }

        /// <summary>
        /// Set fill linear gradient start point
        /// </summary>
        /// <param name="startPoint"></param>
        public void setFillLinearGradientStartPoint(object startPoint)
        {
        }

        /// <summary>
        /// Set fill pattern image
        /// </summary>
        /// <param name="image"></param>
        public void setFillPatternImage(Image image)
        {
        }

        /// <summary>
        /// Set fill pattern offset
        /// </summary>
        /// <param name="offset"></param>
        public void setFillPatternOffset(Custom.Vector offset)
        {
        }

        /// <summary>
        /// Set fill pattern repeat
        /// </summary>
        /// <param name="repeat"></param>
        public void setFillPatternRepeat(object repeat)
        {
        }

        /// <summary>
        /// Set fill pattern rotation in radians
        /// </summary>
        /// <param name="rotation"></param>
        public void setFillPatternRotation(Number rotation)
        {
        }

        /// <summary>
        /// Set fill pattern rotation in degrees
        /// </summary>
        /// <param name="rotationDeg"></param>
        public void setFillPatternRotationDeg(Number rotationDeg)
        {
        }

        /// <summary>
        /// Set fill pattern scale
        /// </summary>
        /// <param name="scale"></param>
        public void setFillPatternScale(Number scale)
        {
        }

        /// <summary>
        /// Set fill pattern x
        /// </summary>
        /// <param name="x"></param>
        public void setFillPatternX(Number x)
        {
        }

        /// <summary>
        /// Set fill pattern y
        /// </summary>
        /// <param name="y"></param>
        public void setFillPatternY(Number y)
        {
        }

        /// <summary>
        /// Set fill priority
        /// </summary>
        /// <param name="priority"></param>
        public void setFillPriority(Number priority)
        {
        }

        /// <summary>
        /// Set fill radial gradient color stops
        /// </summary>
        /// <param name="colorStops"></param>
        public void setFillRadialGradientColorStops(object colorStops)
        {
        }

        /// <summary>
        /// Set fill radial gradient end point
        /// </summary>
        /// <param name="endPoint"></param>
        public void setFillRadialGradientEndPoint(Point endPoint)
        {
        }

        /// <summary>
        /// Set fill radial gradient end radius
        /// </summary>
        /// <param name="radius"></param>
        public void setFillRadialGradientEndRadius(Number radius)
        {
        }

        /// <summary>
        /// Set fill radial gradient start point
        /// </summary>
        /// <param name="startPoint"></param>
        public void setFillRadialGradientStartPoint(Point startPoint)
        {
        }

        /// <summary>
        /// Set fill radial gradient start radius
        /// </summary>
        /// <param name="radius"></param>
        public void setFillRadialGradientStartRadius(Number radius)
        {
        }

        /// <summary>
        /// Set line cap.
        /// </summary>
        /// <param name="lineCap"></param>
        public void setLineCap(object lineCap)
        {
        }

        /// <summary>
        /// Set line join
        /// </summary>
        public void setLineJoin()
        {
        }

        /// <summary>
        /// Set shadow blur
        /// </summary>
        /// <param name="blur"></param>
        public void setShadowBlur(object blur)
        {
        }

        /// <summary>
        /// Set shadow color
        /// </summary>
        /// <param name="color"></param>
        public void setShadowColor(object color)
        {
        }

        /// <summary>
        /// Set shadow offset
        /// </summary>
        /// <param name="offset"></param>
        public void setShadowOffset(Custom.Vector offset)
        {
        }
        /// <summary>
        /// Set shadow opacity
        /// </summary>
        /// <param name="opacity">Must be a value between 0 and 1</param>
        public void setShadowOpacity(Number opacity)
        {
        }

        /// <summary>
        /// Set stroke color
        /// </summary>
        /// <param name="stroke"></param>
        public void setStroke(object stroke)
        {
        }

        /// <summary>
        /// Set stroke width
        /// </summary>
        /// <param name="strokeWidth"></param>
        public void setStrokeWidth(Number strokeWidth)
        {
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class ShapeConfig : NodeConfig
    {
        /// <summary>
        /// Optional, fill color
        /// </summary>
        public string fill;

        /// <summary>
        /// Optional, fill pattern image
        /// </summary>
        public Image fillPatternImage;

        /// <summary>
        /// Optional
        /// </summary>
        public Number fillPatternX;

        /// <summary>
        /// Optional
        /// </summary>
        public Number fillPatternY;

        /// <summary>
        /// Optional, array with two elements or object with x and y component
        /// </summary>
        public Custom.Vector fillPatternOffset;

        /// <summary>
        /// Optional, array with two elements or object with x and y component
        /// </summary>
        public Custom.Vector fillPatternScale;

        /// <summary>
        /// Optional
        /// </summary>
        public Number fillPatternRotation;

        /// <summary>
        /// Optional, can be 'repeat', 'repeat-x', 'repeat-y', or 'no-repeat'. The default is 'no-repeat'
        /// </summary>
        public string fillPatternRepeat;

        /// <summary>
        /// Optional, array with two elements or object with x and y component
        /// </summary>
        public Custom.Vector fillLinearGradientStartPoint;

        /// <summary>
        /// Optional, array with two elements or object with x and y component
        /// </summary>
        public Custom.Vector fillLinearGradientEndPoint;

        /// <summary>
        /// Optional, array of color stops
        /// </summary>
        public Array fillLinearGradientColorStops;

        /// <summary>
        /// Optional, array with two elements or object with x and y component
        /// </summary>
        public Custom.Vector fillRadialGradientStartPoint;

        /// <summary>
        /// Optional, array with two elements or object with x and y component
        /// </summary>
        public Custom.Vector fillRadialGradientEndPoint;

        /// <summary>
        /// Optional
        /// </summary>
        public Number fillRadialGradientStartRadius;

        /// <summary>
        /// Optional
        /// </summary>
        public Number fillRadialGradientEndRadius;

        /// <summary>
        /// Optional, array of color stops
        /// </summary>
        public Array fillRadialGradientColorStops;

        /// <summary>
        /// Optional, flag which enables or disables the fill. The default value is true
        /// </summary>
        public bool fillEnabled;

        /// <summary>
        /// Optional, can be color, linear-gradient, radial-graident, or pattern. The default value is color. The fillPriority property makes it really easy to toggle between different fill types. For example, if you want to toggle between a fill color style and a fill pattern style, simply set the fill property and the fillPattern properties, and then use setFillPriority('color') to render the shape with a color fill, or use setFillPriority('pattern') to render the shape with the pattern fill configuration
        /// </summary>
        public string fillPriority;

        /// <summary>
        /// Optional, stroke color
        /// </summary>
        public string stroke;

        /// <summary>
        /// Optional, stroke width
        /// </summary>
        public Number strokeWidth;

        /// <summary>
        /// Optional, flag which enables or disables the stroke. The default value is true
        /// </summary>
        public bool strokeEnabled;

        /// <summary>
        /// Optional, can be miter, round, or bevel. The default is miter
        /// </summary>
        public string lineJoin;

        /// <summary>
        /// Optional, can be butt, round, or sqare. The default is butt
        /// </summary>
        public string lineCap;

        /// <summary>
        /// Optional
        /// </summary>
        public string shadowColor;

        /// <summary>
        /// Optional
        /// </summary>
        public Number shadowBlur;

        /// <summary>
        /// Optional
        /// </summary>
        public Custom.Vector shadowOffset;

        /// <summary>
        /// Optional, shadow opacity. Can be any real number between 0 and 1
        /// </summary>
        public Number shadowOpacity;

        /// <summary>
        /// Optional, flag which enables or disables the shadow. The default value is true
        /// </summary>
        public bool shadowEnabled;

        /// <summary>
        /// Optional
        /// </summary>
        public Array dashArray;

        /// <summary>
        /// Optional, flag which enables or disables the dashArray. The default value is true
        /// </summary>
        public bool dashArrayEnabled;

        public ShapeConfig(params object[] nameValuePairs)
        {
        }
    }
}
