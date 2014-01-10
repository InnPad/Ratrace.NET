//! kinetic.ss.debug.js
//

(function($) {

Type.registerNamespace('Kinetic');

////////////////////////////////////////////////////////////////////////////////
// Kinetic.Collection

Kinetic.Collection = function Kinetic_Collection() {
    /// <summary>
    /// Collection.
    /// </summary>
}
Kinetic.Collection.prototype = {
    
    apply: function Kinetic_Collection$apply(method, val) {
        /// <summary>
        /// Apply a method to all nodes in the array.
        /// </summary>
        /// <param name="method" type="String">
        /// </param>
        /// <param name="val" type="Object">
        /// </param>
    },
    
    each: function Kinetic_Collection$each(func) {
        /// <summary>
        /// Iterate through node array.
        /// </summary>
        /// <param name="func" type="ss.Delegate">
        /// </param>
    }
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Container

Kinetic.Container = function Kinetic_Container(config) {
    /// <param name="config" type="Object">
    /// </param>
    Kinetic.Container.initializeBase(this, [ config ]);
}
Kinetic.Container.prototype = {
    
    add: function Kinetic_Container$add(child) {
        /// <summary>
        /// Add node to container
        /// </summary>
        /// <param name="child" type="Kinetic.Node">
        /// </param>
    },
    
    clone: function Kinetic_Container$clone(attrs) {
        /// <summary>
        /// Clone node
        /// </summary>
        /// <param name="attrs" type="Object">
        /// </param>
    },
    
    get: function Kinetic_Container$get(selector) {
        /// <summary>
        /// Return an array of nodes that match the selector.
        /// </summary>
        /// <param name="selector" type="String">
        /// </param>
    },
    
    getChildren: function Kinetic_Container$getChildren() {
        /// <summary>
        /// Get children
        /// </summary>
        /// <returns type="Array" elementType="Node"></returns>
        return null;
    },
    
    getIntersections: function Kinetic_Container$getIntersections(point) {
        /// <summary>
        /// get shapes that intersect a point
        /// </summary>
        /// <param name="point" type="Object">
        /// </param>
        /// <returns type="Array" elementType="Shape"></returns>
        return null;
    },
    
    isAncestorOf: function Kinetic_Container$isAncestorOf(node) {
        /// <summary>
        /// Determine if node is an ancestorof descendant
        /// </summary>
        /// <param name="node" type="Kinetic.Node">
        /// </param>
        /// <returns type="Boolean"></returns>
        return false;
    },
    
    removeChildren: function Kinetic_Container$removeChildren() {
        /// <summary>
        /// Remove all children
        /// </summary>
    }
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Filters

Kinetic.Filters = function Kinetic_Filters() {
}
Kinetic.Filters.brighten = function Kinetic_Filters$brighten(imageData, config) {
    /// <summary>
    /// Brighten Filter.
    /// </summary>
    /// <param name="imageData" type="Object">
    /// </param>
    /// <param name="config" type="Object">
    /// </param>
}
Kinetic.Filters.grayscale = function Kinetic_Filters$grayscale(imageData, config) {
    /// <summary>
    /// Grayscale Filter.
    /// </summary>
    /// <param name="imageData" type="Object">
    /// </param>
    /// <param name="config" type="Object">
    /// </param>
}
Kinetic.Filters.invert = function Kinetic_Filters$invert(imageData, config) {
    /// <summary>
    /// Invert Filter.
    /// </summary>
    /// <param name="imageData" type="Object">
    /// </param>
    /// <param name="config" type="Object">
    /// </param>
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.DragAndDrop

Kinetic.DragAndDrop = function Kinetic_DragAndDrop() {
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Global

Kinetic.Global = function Kinetic_Global() {
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Shape

Kinetic.Shape = function Kinetic_Shape(config) {
    /// <param name="config" type="Object">
    /// </param>
    Kinetic.Shape.initializeBase(this, [ config ]);
}
Kinetic.Shape.prototype = {
    
    disableDashArray: function Kinetic_Shape$disableDashArray() {
        /// <summary>
        /// Disable dash array
        /// </summary>
    },
    
    disableFill: function Kinetic_Shape$disableFill() {
        /// <summary>
        /// Disable fill
        /// </summary>
    },
    
    disableShadow: function Kinetic_Shape$disableShadow() {
        /// <summary>
        /// Disable shadow
        /// </summary>
    },
    
    disableStroke: function Kinetic_Shape$disableStroke() {
        /// <summary>
        /// Disable stroke
        /// </summary>
    },
    
    enableDashArray: function Kinetic_Shape$enableDashArray() {
        /// <summary>
        /// enable dash array
        /// </summary>
    },
    
    enableFill: function Kinetic_Shape$enableFill() {
        /// <summary>
        /// Enable fill
        /// </summary>
    },
    
    enableShadow: function Kinetic_Shape$enableShadow() {
        /// <summary>
        /// Enable shadow
        /// </summary>
    },
    
    enableStroke: function Kinetic_Shape$enableStroke() {
        /// <summary>
        /// Enable stroke
        /// </summary>
    },
    
    getCanvas: function Kinetic_Shape$getCanvas() {
        /// <summary>
        /// Get canvas renderer tied to the layer. Note that this returns a canvas renderer, not a canvas element.
        /// </summary>
        /// <returns type="Kinetic.Canvas"></returns>
        return null;
    },
    
    getContext: function Kinetic_Shape$getContext() {
        /// <summary>
        /// Get canvas context tied to the layer
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getCornerRadius: function Kinetic_Shape$getCornerRadius() {
        /// <summary>
        /// Get corner radius
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getDashArray: function Kinetic_Shape$getDashArray() {
        /// <summary>
        /// Get dash array
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getDrawFunc: function Kinetic_Shape$getDrawFunc() {
        /// <summary>
        /// Get draw function
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getDrawHitFunc: function Kinetic_Shape$getDrawHitFunc() {
        /// <summary>
        /// Get draw hit function
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getFill: function Kinetic_Shape$getFill() {
        /// <summary>
        /// Get fill color
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getFillLinearGradientColorStops: function Kinetic_Shape$getFillLinearGradientColorStops(colorStops) {
        /// <summary>
        /// Get fill linear gradient color stops
        /// </summary>
        /// <param name="colorStops" type="Object">
        /// </param>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getFillLinearGradientEndPoint: function Kinetic_Shape$getFillLinearGradientEndPoint() {
        /// <summary>
        /// Get fill linear gradient end point
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getFillLinearGradientStartPoint: function Kinetic_Shape$getFillLinearGradientStartPoint() {
        /// <summary>
        /// Get fill linear gradient start point
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getFillPatternImage: function Kinetic_Shape$getFillPatternImage() {
        /// <summary>
        /// Get fill pattern image
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getFillPatternOffset: function Kinetic_Shape$getFillPatternOffset() {
        /// <summary>
        /// Get fill pattern offset
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getFillPatternRepeat: function Kinetic_Shape$getFillPatternRepeat() {
        /// <summary>
        /// Get fill pattern repeat
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getFillPatternRotation: function Kinetic_Shape$getFillPatternRotation() {
        /// <summary>
        /// Get fill pattern rotation in radians
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getFillPatternRotationDeg: function Kinetic_Shape$getFillPatternRotationDeg() {
        /// <summary>
        /// Get fill pattern rotation in degrees
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getFillPatternScale: function Kinetic_Shape$getFillPatternScale() {
        /// <summary>
        /// Get fill pattern scale
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getFillPatternX: function Kinetic_Shape$getFillPatternX() {
        /// <summary>
        /// Get fill pattern x
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getFillPatternY: function Kinetic_Shape$getFillPatternY() {
        /// <summary>
        /// Get fill pattern y
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getFillPriority: function Kinetic_Shape$getFillPriority() {
        /// <summary>
        /// Get fill priority
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getFillRadialGradientColorStops: function Kinetic_Shape$getFillRadialGradientColorStops() {
        /// <summary>
        /// Get fill radial gradient color stops
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getFillRadialGradientEndPoint: function Kinetic_Shape$getFillRadialGradientEndPoint() {
        /// <summary>
        /// Get fill radial gradient end point
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getFillRadialGradientEndRadius: function Kinetic_Shape$getFillRadialGradientEndRadius() {
        /// <summary>
        /// Get fill radial gradient end radius
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getFillRadialGradientStartPoint: function Kinetic_Shape$getFillRadialGradientStartPoint() {
        /// <summary>
        /// Get fill radial gradient start point
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getFillRadialGradientStartRadius: function Kinetic_Shape$getFillRadialGradientStartRadius() {
        /// <summary>
        /// Get fill radial gradient start radius
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getLineCap: function Kinetic_Shape$getLineCap() {
        /// <summary>
        /// Get line cap
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getLineJoin: function Kinetic_Shape$getLineJoin() {
        /// <summary>
        /// Get line join
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getShadowBlur: function Kinetic_Shape$getShadowBlur() {
        /// <summary>
        /// Get shadow blur
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getShadowColor: function Kinetic_Shape$getShadowColor() {
        /// <summary>
        /// Get shadow color
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getShadowOffset: function Kinetic_Shape$getShadowOffset() {
        /// <summary>
        /// get shadow offset
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getShadowOpacity: function Kinetic_Shape$getShadowOpacity() {
        /// <summary>
        /// Get shadow opacity.
        /// </summary>
        /// <returns type="Number"></returns>
        return null;
    },
    
    getStroke: function Kinetic_Shape$getStroke() {
        /// <summary>
        /// Get stroke color
        /// </summary>
        /// <returns type="String"></returns>
        return null;
    },
    
    getStrokeWidth: function Kinetic_Shape$getStrokeWidth() {
        /// <summary>
        /// Get stroke width
        /// </summary>
        /// <returns type="Number"></returns>
        return null;
    },
    
    hasFill: function Kinetic_Shape$hasFill() {
        /// <summary>
        /// Returns whether or not a fill will be rendered
        /// </summary>
        /// <returns type="Boolean"></returns>
        return false;
    },
    
    hasShadow: function Kinetic_Shape$hasShadow() {
        /// <summary>
        /// Returns whether or not a shadow will be rendered
        /// </summary>
        /// <returns type="Boolean"></returns>
        return false;
    },
    
    intersects: function Kinetic_Shape$intersects(point) {
        /// <summary>
        /// Determines if point is in the shape
        /// </summary>
        /// <param name="point" type="Object">
        /// </param>
        /// <returns type="Boolean"></returns>
        return false;
    },
    
    setCornerRadius: function Kinetic_Shape$setCornerRadius(corner) {
        /// <summary>
        /// Set corner radius
        /// </summary>
        /// <param name="corner" type="Number">
        /// </param>
    },
    
    setDashArray: function Kinetic_Shape$setDashArray(dashArray) {
        /// <summary>
        /// Set dash array.
        /// </summary>
        /// <param name="dashArray" type="Array">
        /// </param>
    },
    
    setDrawFunc: function Kinetic_Shape$setDrawFunc(drawFunc) {
        /// <summary>
        /// Set draw function
        /// </summary>
        /// <param name="drawFunc" type="ss.Delegate">
        /// </param>
    },
    
    setDrawHitFunc: function Kinetic_Shape$setDrawHitFunc(drawHitFunc) {
        /// <summary>
        /// Set draw hit function used for hit detection
        /// </summary>
        /// <param name="drawHitFunc" type="ss.Delegate">
        /// </param>
    },
    
    setFill: function Kinetic_Shape$setFill(color) {
        /// <summary>
        /// Set fill color
        /// </summary>
        /// <param name="color" type="Object">
        /// </param>
    },
    
    setFillLinearGradientColorStops: function Kinetic_Shape$setFillLinearGradientColorStops(colorStops) {
        /// <summary>
        /// Set fill linear gradient color stops
        /// </summary>
        /// <param name="colorStops" type="Object">
        /// </param>
    },
    
    setFillLinearGradientEndPoint: function Kinetic_Shape$setFillLinearGradientEndPoint(endPoint) {
        /// <summary>
        /// Set fill linear gradient end point
        /// </summary>
        /// <param name="endPoint" type="Object">
        /// </param>
    },
    
    setFillLinearGradientStartPoint: function Kinetic_Shape$setFillLinearGradientStartPoint(startPoint) {
        /// <summary>
        /// Set fill linear gradient start point
        /// </summary>
        /// <param name="startPoint" type="Object">
        /// </param>
    },
    
    setFillPatternImage: function Kinetic_Shape$setFillPatternImage(image) {
        /// <summary>
        /// Set fill pattern image
        /// </summary>
        /// <param name="image" type="Kinetic.Image">
        /// </param>
    },
    
    setFillPatternOffset: function Kinetic_Shape$setFillPatternOffset(offset) {
        /// <summary>
        /// Set fill pattern offset
        /// </summary>
        /// <param name="offset" type="Object">
        /// </param>
    },
    
    setFillPatternRepeat: function Kinetic_Shape$setFillPatternRepeat(repeat) {
        /// <summary>
        /// Set fill pattern repeat
        /// </summary>
        /// <param name="repeat" type="Object">
        /// </param>
    },
    
    setFillPatternRotation: function Kinetic_Shape$setFillPatternRotation(rotation) {
        /// <summary>
        /// Set fill pattern rotation in radians
        /// </summary>
        /// <param name="rotation" type="Number">
        /// </param>
    },
    
    setFillPatternRotationDeg: function Kinetic_Shape$setFillPatternRotationDeg(rotationDeg) {
        /// <summary>
        /// Set fill pattern rotation in degrees
        /// </summary>
        /// <param name="rotationDeg" type="Number">
        /// </param>
    },
    
    setFillPatternScale: function Kinetic_Shape$setFillPatternScale(scale) {
        /// <summary>
        /// Set fill pattern scale
        /// </summary>
        /// <param name="scale" type="Number">
        /// </param>
    },
    
    setFillPatternX: function Kinetic_Shape$setFillPatternX(x) {
        /// <summary>
        /// Set fill pattern x
        /// </summary>
        /// <param name="x" type="Number">
        /// </param>
    },
    
    setFillPatternY: function Kinetic_Shape$setFillPatternY(y) {
        /// <summary>
        /// Set fill pattern y
        /// </summary>
        /// <param name="y" type="Number">
        /// </param>
    },
    
    setFillPriority: function Kinetic_Shape$setFillPriority(priority) {
        /// <summary>
        /// Set fill priority
        /// </summary>
        /// <param name="priority" type="Number">
        /// </param>
    },
    
    setFillRadialGradientColorStops: function Kinetic_Shape$setFillRadialGradientColorStops(colorStops) {
        /// <summary>
        /// Set fill radial gradient color stops
        /// </summary>
        /// <param name="colorStops" type="Object">
        /// </param>
    },
    
    setFillRadialGradientEndPoint: function Kinetic_Shape$setFillRadialGradientEndPoint(endPoint) {
        /// <summary>
        /// Set fill radial gradient end point
        /// </summary>
        /// <param name="endPoint" type="Object">
        /// </param>
    },
    
    setFillRadialGradientEndRadius: function Kinetic_Shape$setFillRadialGradientEndRadius(radius) {
        /// <summary>
        /// Set fill radial gradient end radius
        /// </summary>
        /// <param name="radius" type="Number">
        /// </param>
    },
    
    setFillRadialGradientStartPoint: function Kinetic_Shape$setFillRadialGradientStartPoint(startPoint) {
        /// <summary>
        /// Set fill radial gradient start point
        /// </summary>
        /// <param name="startPoint" type="Object">
        /// </param>
    },
    
    setFillRadialGradientStartRadius: function Kinetic_Shape$setFillRadialGradientStartRadius(radius) {
        /// <summary>
        /// Set fill radial gradient start radius
        /// </summary>
        /// <param name="radius" type="Number">
        /// </param>
    },
    
    setLineCap: function Kinetic_Shape$setLineCap(lineCap) {
        /// <summary>
        /// Set line cap.
        /// </summary>
        /// <param name="lineCap" type="Object">
        /// </param>
    },
    
    setLineJoin: function Kinetic_Shape$setLineJoin() {
        /// <summary>
        /// Set line join
        /// </summary>
    },
    
    setShadowBlur: function Kinetic_Shape$setShadowBlur(blur) {
        /// <summary>
        /// Set shadow blur
        /// </summary>
        /// <param name="blur" type="Object">
        /// </param>
    },
    
    setShadowColor: function Kinetic_Shape$setShadowColor(color) {
        /// <summary>
        /// Set shadow color
        /// </summary>
        /// <param name="color" type="Object">
        /// </param>
    },
    
    setShadowOffset: function Kinetic_Shape$setShadowOffset(offset) {
        /// <summary>
        /// Set shadow offset
        /// </summary>
        /// <param name="offset" type="Object">
        /// </param>
    },
    
    setShadowOpacity: function Kinetic_Shape$setShadowOpacity(opacity) {
        /// <summary>
        /// Set shadow opacity
        /// </summary>
        /// <param name="opacity" type="Number">
        /// Must be a value between 0 and 1
        /// </param>
    },
    
    setStroke: function Kinetic_Shape$setStroke(stroke) {
        /// <summary>
        /// Set stroke color
        /// </summary>
        /// <param name="stroke" type="Object">
        /// </param>
    },
    
    setStrokeWidth: function Kinetic_Shape$setStrokeWidth(strokeWidth) {
        /// <summary>
        /// Set stroke width
        /// </summary>
        /// <param name="strokeWidth" type="Number">
        /// </param>
    }
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Blob

Kinetic.Blob = function Kinetic_Blob(config) {
    /// <summary>
    /// Blobs are defined by an array of points and a tension.
    /// </summary>
    /// <param name="config" type="Object">
    /// </param>
    Kinetic.Blob.initializeBase(this, [ config ]);
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Circle

Kinetic.Circle = function Kinetic_Circle(config) {
    /// <param name="config" type="Object">
    /// </param>
    Kinetic.Circle.initializeBase(this, [ config ]);
}
Kinetic.Circle.prototype = {
    
    getRadius: function Kinetic_Circle$getRadius() {
        /// <summary>
        /// Get radius.
        /// </summary>
        /// <returns type="Number"></returns>
        return null;
    },
    
    setRadius: function Kinetic_Circle$setRadius(radius) {
        /// <summary>
        /// Set radius.
        /// </summary>
        /// <param name="radius" type="Number">
        /// </param>
    }
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Ellipse

Kinetic.Ellipse = function Kinetic_Ellipse(config) {
    /// <summary>
    /// Ellipse.
    /// </summary>
    /// <param name="config" type="Object">
    /// </param>
    Kinetic.Ellipse.initializeBase(this, [ config ]);
}
Kinetic.Ellipse.prototype = {
    
    getRadius: function Kinetic_Ellipse$getRadius() {
        /// <summary>
        /// Get radius.
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    setRadius: function Kinetic_Ellipse$setRadius(radius) {
        /// <summary>
        /// Set radius.
        /// </summary>
        /// <param name="radius" type="Number">
        /// </param>
    }
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Image

Kinetic.Image = function Kinetic_Image(config) {
    /// <summary>
    /// Image.
    /// </summary>
    /// <param name="config" type="Object">
    /// </param>
    Kinetic.Image.initializeBase(this, [ config ]);
}
Kinetic.Image.prototype = {
    
    applyFilter: function Kinetic_Image$applyFilter(config, filter, config2, callback) {
        /// <summary>
        /// Apply filter.
        /// </summary>
        /// <param name="config" type="Object">
        /// </param>
        /// <param name="filter" type="Object">
        /// </param>
        /// <param name="config2" type="Object">
        /// </param>
        /// <param name="callback" type="ss.Delegate">
        /// </param>
    },
    
    clearImageHitRegion: function Kinetic_Image$clearImageHitRegion() {
        /// <summary>
        /// Clear image hit region.
        /// </summary>
    },
    
    createImageHitRegion: function Kinetic_Image$createImageHitRegion(callback) {
        /// <summary>
        /// Create image hit region which enables more accurate hit detection mapping of the image by avoiding event detections for transparent pixels
        /// </summary>
        /// <param name="callback" type="ss.Delegate">
        /// </param>
    },
    
    getCrop: function Kinetic_Image$getCrop() {
        /// <summary>
        /// Get crop.
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getImage: function Kinetic_Image$getImage() {
        /// <summary>
        /// Get image.
        /// </summary>
        /// <returns type="Object" domElement="true"></returns>
        return null;
    },
    
    setCrop: function Kinetic_Image$setCrop(config) {
        /// <summary>
        /// Set crop.
        /// </summary>
        /// <param name="config" type="Object">
        /// </param>
    },
    
    setImage: function Kinetic_Image$setImage(image) {
        /// <summary>
        /// Set image.
        /// </summary>
        /// <param name="image" type="Object" domElement="true">
        /// </param>
    }
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Line

Kinetic.Line = function Kinetic_Line(config) {
    /// <param name="config" type="Object">
    /// </param>
    Kinetic.Line.initializeBase(this, [ config ]);
}
Kinetic.Line.prototype = {
    
    getPoints: function Kinetic_Line$getPoints() {
        /// <summary>
        /// Get points array
        /// </summary>
        /// <returns type="Array" elementType="Object"></returns>
        return null;
    },
    
    setPoints: function Kinetic_Line$setPoints(points) {
        /// <summary>
        /// Set points array
        /// </summary>
        /// <param name="points" type="Array" elementType="Object">
        /// Can be a flattened array of points, an array of point arrays, or an array of point objects. e.g. [0,1,2,3], [[0,1],[2,3]] and [{x:0,y:1},{x:2,y:3}] are equivalent
        /// </param>
    }
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Path

Kinetic.Path = function Kinetic_Path(config) {
    /// <summary>
    /// Path.
    /// </summary>
    /// <param name="config" type="Object">
    /// </param>
    Kinetic.Path.initializeBase(this, [ config ]);
}
Kinetic.Path.parsePathData = function Kinetic_Path$parsePathData(data) {
    /// <summary>
    /// Get parsed data array from the data string.
    /// </summary>
    /// <param name="data" type="String">
    /// </param>
    /// <returns type="Kinetic.Path"></returns>
    return null;
}
Kinetic.Path.prototype = {
    
    getData: function Kinetic_Path$getData() {
        /// <summary>
        /// Get SVG path data string.
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    setData: function Kinetic_Path$setData(SVG) {
        /// <summary>
        /// Set SVG path data string.
        /// </summary>
        /// <param name="SVG" type="String">
        /// </param>
    }
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Polygon

Kinetic.Polygon = function Kinetic_Polygon(config) {
    /// <summary>
    /// Polygon.
    /// </summary>
    /// <param name="config" type="Object">
    /// </param>
    Kinetic.Polygon.initializeBase(this, [ config ]);
}
Kinetic.Polygon.prototype = {
    
    getPoints: function Kinetic_Polygon$getPoints() {
        /// <summary>
        /// Get points array
        /// </summary>
        /// <returns type="Array" elementType="Object"></returns>
        return null;
    },
    
    setPoints: function Kinetic_Polygon$setPoints(points) {
        /// <summary>
        /// Set points array
        /// </summary>
        /// <param name="points" type="Array" elementType="Object">
        /// </param>
    }
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Rect

Kinetic.Rect = function Kinetic_Rect(config) {
    /// <summary>
    /// Rect.
    /// </summary>
    /// <param name="config" type="Object">
    /// </param>
    Kinetic.Rect.initializeBase(this, [ config ]);
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.RectangularPolygon

Kinetic.RectangularPolygon = function Kinetic_RectangularPolygon(config) {
    /// <summary>
    /// RegularPolygon.
    /// </summary>
    /// <param name="config" type="Object">
    /// </param>
    Kinetic.RectangularPolygon.initializeBase(this, [ config ]);
}
Kinetic.RectangularPolygon.prototype = {
    
    getRadius: function Kinetic_RectangularPolygon$getRadius() {
        /// <summary>
        /// Get radius
        /// </summary>
        /// <returns type="Number"></returns>
        return null;
    },
    
    getSides: function Kinetic_RectangularPolygon$getSides() {
        /// <summary>
        /// Get number of sides
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    setRadius: function Kinetic_RectangularPolygon$setRadius(radius) {
        /// <summary>
        /// Set radius
        /// </summary>
        /// <param name="radius" type="Number">
        /// </param>
    },
    
    setSides: function Kinetic_RectangularPolygon$setSides(sides) {
        /// <summary>
        /// set number of sides
        /// </summary>
        /// <param name="sides" type="Number">
        /// </param>
    }
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Spline

Kinetic.Spline = function Kinetic_Spline(config) {
    /// <param name="config" type="Object">
    /// </param>
    Kinetic.Spline.initializeBase(this, [ config ]);
}
Kinetic.Spline.prototype = {
    
    getTension: function Kinetic_Spline$getTension() {
        /// <summary>
        /// Get tension
        /// </summary>
        /// <returns type="Number"></returns>
        return null;
    },
    
    setTension: function Kinetic_Spline$setTension(tension) {
        /// <summary>
        /// Set tension
        /// </summary>
        /// <param name="tension" type="Number">
        /// </param>
    }
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Sprite

Kinetic.Sprite = function Kinetic_Sprite(config) {
    /// <summary>
    /// Sprite.
    /// </summary>
    /// <param name="config" type="Object">
    /// </param>
    Kinetic.Sprite.initializeBase(this, [ config ]);
}
Kinetic.Sprite.prototype = {
    
    afterFrame: function Kinetic_Sprite$afterFrame(index, func) {
        /// <summary>
        /// Set after frame event handler.
        /// </summary>
        /// <param name="index" type="Number">
        /// </param>
        /// <param name="func" type="ss.Delegate">
        /// </param>
    },
    
    getAnimation: function Kinetic_Sprite$getAnimation() {
        /// <summary>
        /// Get animation key.
        /// </summary>
        /// <returns type="String"></returns>
        return null;
    },
    
    getAnimations: function Kinetic_Sprite$getAnimations() {
        /// <summary>
        /// Get animations object.
        /// </summary>
        /// <returns type="Kinetic.Animation"></returns>
        return null;
    },
    
    getIndex: function Kinetic_Sprite$getIndex() {
        /// <summary>
        /// Get animation frame index.
        /// </summary>
        /// <returns type="Number" integer="true"></returns>
        return -1;
    },
    
    setAnimation: function Kinetic_Sprite$setAnimation(anim) {
        /// <summary>
        /// Set animation key.
        /// </summary>
        /// <param name="anim" type="String">
        /// </param>
    },
    
    setAnimations: function Kinetic_Sprite$setAnimations(animations) {
        /// <summary>
        /// Set animations object.
        /// </summary>
        /// <param name="animations" type="Kinetic.Animation">
        /// </param>
    },
    
    setIndex: function Kinetic_Sprite$setIndex(index) {
        /// <summary>
        /// Set animation frame index.
        /// </summary>
        /// <param name="index" type="Number" integer="true">
        /// </param>
    },
    
    start: function Kinetic_Sprite$start() {
        /// <summary>
        /// Start sprite animation.
        /// </summary>
    },
    
    stop: function Kinetic_Sprite$stop() {
        /// <summary>
        /// Stop sprite animation.
        /// </summary>
    }
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Star

Kinetic.Star = function Kinetic_Star(config) {
    /// <param name="config" type="Object">
    /// </param>
    Kinetic.Star.initializeBase(this, [ config ]);
}
Kinetic.Star.prototype = {
    
    getInnerRadius: function Kinetic_Star$getInnerRadius() {
        /// <summary>
        /// Get inner radius.
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getNumPoints: function Kinetic_Star$getNumPoints() {
        /// <summary>
        /// Get number of points.
        /// </summary>
        /// <returns type="Number" integer="true"></returns>
        return -1;
    },
    
    getOuterRadius: function Kinetic_Star$getOuterRadius() {
        /// <summary>
        /// Get outer radius.
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    setInnerRadius: function Kinetic_Star$setInnerRadius(radius) {
        /// <summary>
        /// Set inner radius
        /// </summary>
        /// <param name="radius" type="Number">
        /// </param>
    },
    
    setNumPoints: function Kinetic_Star$setNumPoints(points) {
        /// <summary>
        /// Set number of points.
        /// </summary>
        /// <param name="points" type="Number" integer="true">
        /// </param>
    },
    
    setOuterRadius: function Kinetic_Star$setOuterRadius(radius) {
        /// <summary>
        /// Set outer radius
        /// </summary>
        /// <param name="radius" type="Number">
        /// </param>
    }
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Text

Kinetic.Text = function Kinetic_Text(config) {
    /// <summary>
    /// Text.
    /// </summary>
    /// <param name="config" type="Object">
    /// </param>
    Kinetic.Text.initializeBase(this, [ config ]);
}
Kinetic.Text.prototype = {
    
    getAlign: function Kinetic_Text$getAlign() {
        /// <summary>
        /// Get horizontal align.
        /// </summary>
        /// <returns type="String"></returns>
        return null;
    },
    
    getFontFamily: function Kinetic_Text$getFontFamily() {
        /// <summary>
        /// Get font family.
        /// </summary>
        /// <returns type="String"></returns>
        return null;
    },
    
    getFontSize: function Kinetic_Text$getFontSize() {
        /// <summary>
        /// Get font size.
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getFontStyle: function Kinetic_Text$getFontStyle() {
        /// <summary>
        /// Get font style. Can be 'normal', 'italic', or 'bold'. 'normal' is the default.
        /// </summary>
        /// <returns type="String"></returns>
        return null;
    },
    
    getHeight: function Kinetic_Text$getHeight() {
        /// <summary>
        /// Get height.
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getLineHeight: function Kinetic_Text$getLineHeight() {
        /// <summary>
        /// Get line height. Sefault is 1
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getPadding: function Kinetic_Text$getPadding() {
        /// <summary>
        /// Get padding
        /// </summary>
        /// <returns type="Number" integer="true"></returns>
        return -1;
    },
    
    getText: function Kinetic_Text$getText() {
        /// <summary>
        /// Get text.
        /// </summary>
        /// <returns type="String"></returns>
        return null;
    },
    
    getTextHeight: function Kinetic_Text$getTextHeight() {
        /// <summary>
        /// Get text height.
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getTextWidth: function Kinetic_Text$getTextWidth() {
        /// <summary>
        /// Get text width.
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getWidth: function Kinetic_Text$getWidth() {
        /// <summary>
        /// Get width.
        /// </summary>
        /// <returns type="Number"></returns>
        return null;
    },
    
    setAlign: function Kinetic_Text$setAlign(align) {
        /// <summary>
        /// Set horizontal align of text.
        /// </summary>
        /// <param name="align" type="String">
        /// align can be 'left', 'center', or 'right'
        /// </param>
    },
    
    setFontFamily: function Kinetic_Text$setFontFamily(fontFamily) {
        /// <summary>
        /// Set font family.
        /// </summary>
        /// <param name="fontFamily" type="String">
        /// </param>
    },
    
    setFontSize: function Kinetic_Text$setFontSize(fontSize) {
        /// <summary>
        /// Set font size in pixels.
        /// </summary>
        /// <param name="fontSize" type="Number">
        /// </param>
    },
    
    setFontStyle: function Kinetic_Text$setFontStyle(fontStyle) {
        /// <summary>
        /// Set font style. Can be 'normal', 'italic', or 'bold'. 'normal' is the default.
        /// </summary>
        /// <param name="fontStyle" type="String">
        /// can be 'normal', 'italic', or 'bold'. 'normal' is the default.
        /// </param>
    },
    
    setLineHeight: function Kinetic_Text$setLineHeight(lineHeight) {
        /// <summary>
        /// Set line height.
        /// </summary>
        /// <param name="lineHeight" type="Number">
        /// </param>
    },
    
    setPadding: function Kinetic_Text$setPadding(padding) {
        /// <summary>
        /// Set padding.
        /// </summary>
        /// <param name="padding" type="Number" integer="true">
        /// </param>
    },
    
    setText: function Kinetic_Text$setText(text) {
        /// <summary>
        /// Set text.
        /// </summary>
        /// <param name="text" type="String">
        /// </param>
    }
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.TextPath

Kinetic.TextPath = function Kinetic_TextPath(config) {
    /// <summary>
    /// Path.
    /// </summary>
    /// <param name="config" type="Object">
    /// </param>
    Kinetic.TextPath.initializeBase(this, [ config ]);
}
Kinetic.TextPath.prototype = {
    
    getFontFamily: function Kinetic_TextPath$getFontFamily() {
        /// <summary>
        /// Get font family.
        /// </summary>
        /// <returns type="String"></returns>
        return null;
    },
    
    getFontSize: function Kinetic_TextPath$getFontSize() {
        /// <summary>
        /// Get font size.
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getFontStyle: function Kinetic_TextPath$getFontStyle() {
        /// <summary>
        /// Get font style.
        /// </summary>
        /// <returns type="String"></returns>
        return null;
    },
    
    getText: function Kinetic_TextPath$getText() {
        /// <summary>
        /// Get text.
        /// </summary>
        /// <returns type="String"></returns>
        return null;
    },
    
    getTextHeight: function Kinetic_TextPath$getTextHeight() {
        /// <summary>
        /// Get text height in pixels.
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getTextWidth: function Kinetic_TextPath$getTextWidth() {
        /// <summary>
        /// Get text width in pixels.
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    setFontFamily: function Kinetic_TextPath$setFontFamily(fontFamily) {
        /// <summary>
        /// Set font family.
        /// </summary>
        /// <param name="fontFamily" type="String">
        /// </param>
    },
    
    setFontSize: function Kinetic_TextPath$setFontSize(fontSize) {
        /// <summary>
        /// Set font size
        /// </summary>
        /// <param name="fontSize" type="Number">
        /// </param>
    },
    
    setFontStyle: function Kinetic_TextPath$setFontStyle(fontStyle) {
        /// <summary>
        /// Set font style. Can be 'normal', 'italic', or 'bold'. 'normal' is the default.
        /// </summary>
        /// <param name="fontStyle" type="String">
        /// </param>
    },
    
    setText: function Kinetic_TextPath$setText(text) {
        /// <summary>
        /// Set text.
        /// </summary>
        /// <param name="text" type="String">
        /// </param>
    }
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Wedge

Kinetic.Wedge = function Kinetic_Wedge(config) {
    /// <summary>
    /// Wedge.
    /// </summary>
    /// <param name="config" type="Object">
    /// </param>
    Kinetic.Wedge.initializeBase(this, [ config ]);
}
Kinetic.Wedge.prototype = {
    
    getAngle: function Kinetic_Wedge$getAngle() {
        /// <summary>
        /// Get angle.
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getAngleDeg: function Kinetic_Wedge$getAngleDeg() {
        /// <summary>
        /// Get angle in degrees.
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getClockwise: function Kinetic_Wedge$getClockwise() {
        /// <summary>
        /// Get clockwise.
        /// </summary>
        /// <returns type="Boolean"></returns>
        return false;
    },
    
    getRadius: function Kinetic_Wedge$getRadius() {
        /// <summary>
        /// Get radius.
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    setAngle: function Kinetic_Wedge$setAngle(angle) {
        /// <summary>
        /// Set angle.
        /// </summary>
        /// <param name="angle" type="Number">
        /// </param>
    },
    
    setAngleDeg: function Kinetic_Wedge$setAngleDeg(deg) {
        /// <summary>
        /// Set angle in degrees.
        /// </summary>
        /// <param name="deg" type="Number">
        /// </param>
    },
    
    setClockwise: function Kinetic_Wedge$setClockwise(clockwise) {
        /// <summary>
        /// Set clockwise draw direction. If set to true, the wedge will be drawn clockwise If set to false, the wedge will be drawn anti-clockwise. The default is false.
        /// </summary>
        /// <param name="clockwise" type="Boolean">
        /// </param>
    },
    
    setRadius: function Kinetic_Wedge$setRadius(radius) {
        /// <summary>
        /// Set radius.
        /// </summary>
        /// <param name="radius" type="Number">
        /// </param>
    }
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Stage

Kinetic.Stage = function Kinetic_Stage(config) {
    /// <summary>
    /// Stage.
    /// </summary>
    /// <param name="config" type="Object">
    /// </param>
    Kinetic.Stage.initializeBase(this, [ config ]);
}
Kinetic.Stage.prototype = {
    
    add: function Kinetic_Stage$add(layer) {
        /// <summary>
        /// Add layer to stage
        /// </summary>
        /// <param name="layer" type="Kinetic.Layer">
        /// </param>
    },
    
    clear: function Kinetic_Stage$clear() {
        /// <summary>
        /// Clear all layers
        /// </summary>
    },
    
    draw: function Kinetic_Stage$draw() {
        /// <summary>
        /// Draw layer scene graphs
        /// </summary>
    },
    
    drawHit: function Kinetic_Stage$drawHit() {
        /// <summary>
        /// Draw layer hit graphs
        /// </summary>
    },
    
    getContainer: function Kinetic_Stage$getContainer() {
        /// <summary>
        /// Get container DOM element
        /// </summary>
        /// <returns type="Object" domElement="true"></returns>
        return null;
    },
    
    getContent: function Kinetic_Stage$getContent() {
        /// <summary>
        /// Get stage content div element which has the the class name "kineticjs-content"
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getDragLayer: function Kinetic_Stage$getDragLayer() {
        /// <summary>
        /// Get drag and drop layer
        /// </summary>
        /// <returns type="Kinetic.Layer"></returns>
        return null;
    },
    
    getIntersection: function Kinetic_Stage$getIntersection(pos) {
        /// <summary>
        /// Get intersection object that contains shape and pixel data
        /// </summary>
        /// <param name="pos" type="Object">
        /// </param>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getMousePosition: function Kinetic_Stage$getMousePosition() {
        /// <summary>
        /// Get mouse position for desktop apps
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getTouchPosition: function Kinetic_Stage$getTouchPosition() {
        /// <summary>
        /// Get touch position for mobile apps
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getUserPosition: function Kinetic_Stage$getUserPosition() {
        /// <summary>
        /// Get user position which can be a touch position or mouse position
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    reset: function Kinetic_Stage$reset() {
        /// <summary>
        /// Reset stage to default state
        /// </summary>
    },
    
    setContainer: function Kinetic_Stage$setContainer(container) {
        /// <summary>
        /// Set container dom element which contains the stage wrapper div element
        /// </summary>
        /// <param name="container" type="Object" domElement="true">
        /// </param>
    }
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Type

Kinetic.Type = function Kinetic_Type() {
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Canvas

Kinetic.Canvas = function Kinetic_Canvas(width, height, pixelRatio) {
    /// <summary>
    /// Canvas Renderer
    /// </summary>
    /// <param name="width" type="Number">
    /// </param>
    /// <param name="height" type="Number">
    /// </param>
    /// <param name="pixelRatio" type="Object">
    /// </param>
}
Kinetic.Canvas.prototype = {
    
    applyShadow: function Kinetic_Canvas$applyShadow(shape, drawFunc) {
        /// <summary>
        /// Apply shadow
        /// </summary>
        /// <param name="shape" type="Kinetic.Shape">
        /// </param>
        /// <param name="drawFunc" type="ss.Delegate">
        /// </param>
    },
    
    fill: function Kinetic_Canvas$fill(shape) {
        /// <summary>
        /// Fill shape
        /// </summary>
        /// <param name="shape" type="Kinetic.Shape">
        /// </param>
    },
    
    fillStroke: function Kinetic_Canvas$fillStroke(shape) {
        /// <summary>
        /// Fill, stroke, and apply shadows will only be applied to either the fill or stroke.
        /// </summary>
        /// <param name="shape" type="Kinetic.Shape">
        /// </param>
    },
    
    getContext: function Kinetic_Canvas$getContext() {
        /// <summary>
        /// Get canvas context
        /// </summary>
        /// <returns type="CanvasContext2D"></returns>
        return null;
    },
    
    getElement: function Kinetic_Canvas$getElement() {
        /// <summary>
        /// Get canvas element
        /// </summary>
        /// <returns type="Object" domElement="true"></returns>
        return null;
    },
    
    getHeight: function Kinetic_Canvas$getHeight() {
        /// <summary>
        /// Get height
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getWidth: function Kinetic_Canvas$getWidth() {
        /// <summary>
        /// Get width
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    setHeight: function Kinetic_Canvas$setHeight(height) {
        /// <summary>
        /// Set height
        /// </summary>
        /// <param name="height" type="Number">
        /// </param>
    },
    
    setSize: function Kinetic_Canvas$setSize(width, height) {
        /// <summary>
        /// Set size
        /// </summary>
        /// <param name="width" type="Number">
        /// </param>
        /// <param name="height" type="Number">
        /// </param>
    },
    
    setWidth: function Kinetic_Canvas$setWidth(width) {
        /// <summary>
        /// Set width
        /// </summary>
        /// <param name="width" type="Number">
        /// </param>
    },
    
    stroke: function Kinetic_Canvas$stroke(shape) {
        /// <summary>
        /// Stroke shape
        /// </summary>
        /// <param name="shape" type="Kinetic.Shape">
        /// </param>
    },
    
    toDataURL: function Kinetic_Canvas$toDataURL(mimeType, quality) {
        /// <summary>
        /// To data url
        /// </summary>
        /// <param name="mimeType" type="String">
        /// </param>
        /// <param name="quality" type="Number">
        /// </param>
        /// <returns type="String"></returns>
        return null;
    }
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Group

Kinetic.Group = function Kinetic_Group(config) {
    /// <summary>
    /// Group constructor. Groups are used to contain shapes or other groups.
    /// </summary>
    /// <param name="config" type="Object">
    /// </param>
    Kinetic.Group.initializeBase(this, [ config ]);
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Layer

Kinetic.Layer = function Kinetic_Layer(config) {
    /// <summary>
    /// Layers are tied to their own canvas element and are usedto contain groups or shapes.
    /// </summary>
    /// <param name="config" type="Object">
    /// </param>
    Kinetic.Layer.initializeBase(this, [ config ]);
}
Kinetic.Layer.prototype = {
    
    afterDraw: function Kinetic_Layer$afterDraw(handler) {
        /// <summary>
        /// Set after draw handler.
        /// </summary>
        /// <param name="handler" type="ss.Delegate">
        /// </param>
    },
    
    beforeDraw: function Kinetic_Layer$beforeDraw(handler) {
        /// <summary>
        /// Set before draw handler.
        /// </summary>
        /// <param name="handler" type="ss.Delegate">
        /// </param>
    },
    
    clear: function Kinetic_Layer$clear() {
        /// <summary>
        /// Clear canvas tied to the layer
        /// </summary>
    },
    
    draw: function Kinetic_Layer$draw() {
        /// <summary>
        /// Draw children nodes.
        /// </summary>
    },
    
    drawHit: function Kinetic_Layer$drawHit() {
        /// <summary>
        /// Draw children nodes on hit.
        /// </summary>
    },
    
    drawScene: function Kinetic_Layer$drawScene(canvas) {
        /// <summary>
        /// Draw children nodes on scene.
        /// </summary>
        /// <param name="canvas" type="Kinetic.Canvas">
        /// </param>
    },
    
    getCanvas: function Kinetic_Layer$getCanvas() {
        /// <summary>
        /// Get layer canvas.
        /// </summary>
        /// <returns type="Kinetic.Canvas"></returns>
        return null;
    },
    
    getClearBeforeDraw: function Kinetic_Layer$getClearBeforeDraw() {
        /// <summary>
        /// Get flag which determines if the layer is cleared or not before drawing
        /// </summary>
        /// <returns type="Boolean"></returns>
        return false;
    },
    
    getContext: function Kinetic_Layer$getContext() {
        /// <summary>
        /// Get layer canvas context.
        /// </summary>
        /// <returns type="CanvasContext2D"></returns>
        return null;
    },
    
    remove: function Kinetic_Layer$remove() {
        /// <summary>
        /// Remove layer from stage.
        /// </summary>
    },
    
    setClearBeforeDraw: function Kinetic_Layer$setClearBeforeDraw(clearBeforeDraw) {
        /// <summary>
        /// Set flag which determines if the layer is cleared or not before drawing.
        /// </summary>
        /// <param name="clearBeforeDraw" type="Boolean">
        /// </param>
    }
}


////////////////////////////////////////////////////////////////////////////////
// Kinetic.Node

Kinetic.Node = function Kinetic_Node(config) {
    /// <param name="config" type="Object">
    /// </param>
    /// <field name="attrs" type="Object">
    /// </field>
}
Kinetic.Node.create = function Kinetic_Node$create(JSON, container) {
    /// <summary>
    /// Create node with JSON string. De-serializtion does not generate custom shape drawing functions, images, or event handlers (this would make the	serialized object huge). If your app uses custom shapes, images, and event handlers (it probably does), then you need to select the appropriate shapes after loading the stage and set these properties via on(), setDrawFunc(), and setImage() methods
    /// </summary>
    /// <param name="JSON" type="String">
    /// String
    /// </param>
    /// <param name="container" type="Object" domElement="true">
    /// Optional container dom element used only if you're creating a stage node
    /// </param>
    /// <returns type="Kinetic.Node"></returns>
    return null;
}
Kinetic.Node.prototype = {
    attrs: null,
    
    clone: function Kinetic_Node$clone(attrs) {
        /// <summary>
        /// Clone node.
        /// </summary>
        /// <param name="attrs" type="Object">
        /// </param>
    },
    
    destroy: function Kinetic_Node$destroy() {
        /// <summary>
        /// Remove and destroy node
        /// </summary>
    },
    
    fire: function Kinetic_Node$fire(eventType, obj) {
        /// <summary>
        /// Synthetically fire an event.
        /// </summary>
        /// <param name="eventType" type="String">
        /// </param>
        /// <param name="obj" type="Object">
        /// optional object which can be used to pass parameters
        /// </param>
    },
    
    getAbsoluteOpacity: function Kinetic_Node$getAbsoluteOpacity() {
        /// <summary>
        /// Get absolute opacity
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getAbsolutePosition: function Kinetic_Node$getAbsolutePosition() {
        /// <summary>
        /// Get absolute position relative to the top left corner of the stage container div
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getAbsoluteTransform: function Kinetic_Node$getAbsoluteTransform() {
        /// <summary>
        /// Get absolute transform of the node which takes into account its ancestor transforms
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getAbsoluteZIndex: function Kinetic_Node$getAbsoluteZIndex() {
        /// <summary>
        /// Get absolute z-index which takes into account sibling and ancestor indices
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getAttrs: function Kinetic_Node$getAttrs() {
        /// <summary>
        /// Get attrs
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getDragBoundFunc: function Kinetic_Node$getDragBoundFunc() {
        /// <summary>
        /// Get dragBoundFunc
        /// </summary>
        /// <returns type="ss.Delegate"></returns>
        return null;
    },
    
    getDraggable: function Kinetic_Node$getDraggable() {
        /// <summary>
        /// Get draggable
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getDragOnTop: function Kinetic_Node$getDragOnTop() {
        /// <summary>
        /// get flag which enables or disables automatically moving the draggable node to a temporary top layer to improve performance.
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getHeight: function Kinetic_Node$getHeight() {
        /// <summary>
        /// get height
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getId: function Kinetic_Node$getId() {
        /// <summary>
        /// Get id
        /// </summary>
        /// <returns type="String"></returns>
        return null;
    },
    
    getLayer: function Kinetic_Node$getLayer() {
        /// <summary>
        /// Get layer ancestor
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getLevel: function Kinetic_Node$getLevel() {
        /// <summary>
        /// Get node level in node tree. Returns an integer.
        /// e.g. Stage level will always be 0. Layers will always be 1. Groups and Shapes will always be &gt;= 2
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getListening: function Kinetic_Node$getListening() {
        /// <summary>
        /// Determine if node is listening or not.
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getName: function Kinetic_Node$getName() {
        /// <summary>
        /// Get name
        /// </summary>
        /// <returns type="String"></returns>
        return null;
    },
    
    getOffset: function Kinetic_Node$getOffset() {
        /// <summary>
        /// Get offset
        /// </summary>
        /// <returns type="Number"></returns>
        return null;
    },
    
    getOpacity: function Kinetic_Node$getOpacity() {
        /// <summary>
        /// get opacity.
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getParent: function Kinetic_Node$getParent() {
        /// <summary>
        /// Get parent container
        /// </summary>
        /// <returns type="Kinetic.Container"></returns>
        return null;
    },
    
    getPosition: function Kinetic_Node$getPosition() {
        /// <summary>
        /// Get node position relative to parent
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getRotation: function Kinetic_Node$getRotation() {
        /// <summary>
        /// Get rotation in radians
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getRotationDeg: function Kinetic_Node$getRotationDeg() {
        /// <summary>
        /// Get rotation in degrees
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getScale: function Kinetic_Node$getScale() {
        /// <summary>
        /// Gt scale
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getSize: function Kinetic_Node$getSize() {
        /// <summary>
        /// Get size
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    getStage: function Kinetic_Node$getStage() {
        /// <summary>
        /// Get stage ancestor
        /// </summary>
        /// <returns type="Kinetic.Stage"></returns>
        return null;
    },
    
    getTransform: function Kinetic_Node$getTransform() {
        /// <summary>
        /// Get transform of the node
        /// </summary>
        /// <returns type="Kinetic.Transform"></returns>
        return null;
    },
    
    getVisible: function Kinetic_Node$getVisible() {
        /// <summary>
        /// Determine if node is visible or not.
        /// </summary>
        /// <returns type="Boolean"></returns>
        return false;
    },
    
    getWidth: function Kinetic_Node$getWidth() {
        /// <summary>
        /// get width
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getX: function Kinetic_Node$getX() {
        /// <summary>
        /// get x position
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getY: function Kinetic_Node$getY() {
        /// <summary>
        /// get y position
        /// </summary>
        /// <returns type="Number"></returns>
        return -1;
    },
    
    getZIndex: function Kinetic_Node$getZIndex() {
        /// <summary>
        /// Get zIndex relative to the node's siblings who share the same parent
        /// </summary>
        /// <returns type="Number" integer="true"></returns>
        return -1;
    },
    
    hide: function Kinetic_Node$hide() {
        /// <summary>
        /// Hide node.
        /// </summary>
    },
    
    isDraggable: function Kinetic_Node$isDraggable() {
        /// <summary>
        /// Get draggable.
        /// </summary>
        /// <returns type="Boolean"></returns>
        return false;
    },
    
    isDragging: function Kinetic_Node$isDragging() {
        /// <summary>
        /// Determine if node is currently in drag and drop mode
        /// </summary>
        /// <returns type="Boolean"></returns>
        return false;
    },
    
    isListening: function Kinetic_Node$isListening() {
        /// <summary>
        /// Alias of getListening()
        /// </summary>
        /// <returns type="Boolean"></returns>
        return false;
    },
    
    isVisible: function Kinetic_Node$isVisible() {
        /// <summary>
        /// Alias of getVisible()
        /// </summary>
        /// <returns type="Boolean"></returns>
        return false;
    },
    
    move: function Kinetic_Node$move(x, y) {
        /// <summary>
        /// Move node by an amount relative to its current position
        /// </summary>
        /// <param name="x" type="Number">
        /// </param>
        /// <param name="y" type="Number">
        /// </param>
    },
    
    moveDown: function Kinetic_Node$moveDown() {
        /// <summary>
        /// Move node down
        /// </summary>
    },
    
    moveTo: function Kinetic_Node$moveTo(newContainer) {
        /// <summary>
        /// Move node to another container
        /// </summary>
        /// <param name="newContainer" type="Kinetic.Container">
        /// </param>
    },
    
    moveToBottom: function Kinetic_Node$moveToBottom() {
        /// <summary>
        /// Move node to the bottom of its siblings
        /// </summary>
    },
    
    moveToTop: function Kinetic_Node$moveToTop() {
        /// <summary>
        /// Move node to the top of its siblings
        /// </summary>
    },
    
    moveUp: function Kinetic_Node$moveUp() {
        /// <summary>
        /// Move node up
        /// </summary>
    },
    
    off: function Kinetic_Node$off(typesStr) {
        /// <summary>
        /// Remove event bindings from the node.
        /// </summary>
        /// <param name="typesStr" type="String">
        /// </param>
    },
    
    on: function Kinetic_Node$on(typesStr, handler) {
        /// <summary>
        /// Bind events to the node.
        /// </summary>
        /// <param name="typesStr" type="String">
        /// </param>
        /// <param name="handler" type="ss.Delegate">
        /// </param>
    },
    
    remove: function Kinetic_Node$remove() {
        /// <summary>
        /// Remove child from container, but don't destroy it
        /// </summary>
    },
    
    rotate: function Kinetic_Node$rotate(theta) {
        /// <summary>
        /// Rotate node by an amount in radians relative to its current rotation
        /// </summary>
        /// <param name="theta" type="Number">
        /// </param>
    },
    
    rotateDeg: function Kinetic_Node$rotateDeg(deg) {
        /// <summary>
        /// Rotate node by an amount in degrees relative to its current rotation
        /// </summary>
        /// <param name="deg" type="Number">
        /// </param>
    },
    
    setAbsolutePosition: function Kinetic_Node$setAbsolutePosition(x, y) {
        /// <summary>
        /// Set absolute position
        /// </summary>
        /// <param name="x" type="Number">
        /// </param>
        /// <param name="y" type="Number">
        /// </param>
    },
    
    setAttrs: function Kinetic_Node$setAttrs(config) {
        /// <summary>
        /// Set attrs
        /// </summary>
        /// <param name="config" type="Object">
        /// </param>
    },
    
    setDefaultAttrs: function Kinetic_Node$setDefaultAttrs(confic) {
        /// <summary>
        /// Set default attrs.
        /// </summary>
        /// <param name="confic" type="Object">
        /// </param>
    },
    
    setDragBoundFunc: function Kinetic_Node$setDragBoundFunc(dragBoundFunc) {
        /// <summary>
        /// Set drag bound function.
        /// </summary>
        /// <param name="dragBoundFunc" type="ss.Delegate">
        /// </param>
    },
    
    setDraggable: function Kinetic_Node$setDraggable(draggable) {
        /// <summary>
        /// set draggable
        /// </summary>
        /// <param name="draggable" type="Object">
        /// </param>
    },
    
    setDragOnTop: function Kinetic_Node$setDragOnTop(dragOnTop) {
        /// <summary>
        /// set flag which enables or disables automatically moving the draggable node to a temporary top layer to improve performance.
        /// </summary>
        /// <param name="dragOnTop" type="Object">
        /// </param>
    },
    
    setHeight: function Kinetic_Node$setHeight(height) {
        /// <summary>
        /// Set height
        /// </summary>
        /// <param name="height" type="Number">
        /// </param>
    },
    
    setId: function Kinetic_Node$setId(id) {
        /// <summary>
        /// Set id
        /// </summary>
        /// <param name="id" type="String">
        /// </param>
    },
    
    setListening: function Kinetic_Node$setListening(listening) {
        /// <summary>
        /// Listen or don't listen to events
        /// </summary>
        /// <param name="listening" type="Object">
        /// </param>
    },
    
    setName: function Kinetic_Node$setName(name) {
        /// <summary>
        /// Set name
        /// </summary>
        /// <param name="name" type="String">
        /// </param>
    },
    
    setOffset: function Kinetic_Node$setOffset(x, y) {
        /// <summary>
        /// Set offset.
        /// </summary>
        /// <param name="x" type="Number">
        /// </param>
        /// <param name="y" type="Number">
        /// </param>
    },
    
    setOpacity: function Kinetic_Node$setOpacity(opacity) {
        /// <summary>
        /// Set opacity.
        /// </summary>
        /// <param name="opacity" type="Number">
        /// </param>
    },
    
    setPosition: function Kinetic_Node$setPosition(x, y) {
        /// <summary>
        /// Set node position relative to parent
        /// </summary>
        /// <param name="x" type="Number">
        /// </param>
        /// <param name="y" type="Number">
        /// </param>
    },
    
    setRotation: function Kinetic_Node$setRotation(theta) {
        /// <summary>
        /// Set rotation in radians
        /// </summary>
        /// <param name="theta" type="Number">
        /// </param>
    },
    
    setRotationDeg: function Kinetic_Node$setRotationDeg(deg) {
        /// <summary>
        /// Set rotation in degrees
        /// </summary>
        /// <param name="deg" type="Number">
        /// </param>
    },
    
    setScale: function Kinetic_Node$setScale(x, y) {
        /// <summary>
        /// Set scale
        /// </summary>
        /// <param name="x" type="Number">
        /// </param>
        /// <param name="y" type="Number">
        /// </param>
    },
    
    setSize: function Kinetic_Node$setSize(width, height) {
        /// <summary>
        /// Set size
        /// </summary>
        /// <param name="width" type="Number">
        /// </param>
        /// <param name="height" type="Number">
        /// </param>
    },
    
    setVisible: function Kinetic_Node$setVisible(visible) {
        /// <summary>
        /// Set visible
        /// </summary>
        /// <param name="visible" type="Boolean">
        /// </param>
    },
    
    setWidth: function Kinetic_Node$setWidth(width) {
        /// <summary>
        /// Set width
        /// </summary>
        /// <param name="width" type="Number">
        /// </param>
    },
    
    setX: function Kinetic_Node$setX(x) {
        /// <summary>
        /// Set x position
        /// </summary>
        /// <param name="x" type="Number">
        /// </param>
    },
    
    setY: function Kinetic_Node$setY(y) {
        /// <summary>
        /// Set y position
        /// </summary>
        /// <param name="y" type="Number">
        /// </param>
    },
    
    setZIndex: function Kinetic_Node$setZIndex(zIndex) {
        /// <summary>
        /// Set zIndex relative to siblings
        /// </summary>
        /// <param name="zIndex" type="Number" integer="true">
        /// </param>
    },
    
    show: function Kinetic_Node$show() {
        /// <summary>
        /// Show node
        /// </summary>
    },
    
    simulate: function Kinetic_Node$simulate(eventType, evt) {
        /// <summary>
        /// Simulate event with event bubbling
        /// </summary>
        /// <param name="eventType" type="Object">
        /// </param>
        /// <param name="evt" type="ElementEvent">
        /// </param>
    },
    
    toDataURL: function Kinetic_Node$toDataURL(config) {
        /// <summary>
        /// Creates a composite data URL and requires a callback because the composite is generated asynchronously.
        /// </summary>
        /// <param name="config" type="Object">
        /// </param>
        /// <returns type="String"></returns>
        return null;
    },
    
    toImage: function Kinetic_Node$toImage(config) {
        /// <summary>
        /// Converts node into an image.
        /// </summary>
        /// <param name="config" type="Object">
        /// </param>
        /// <returns type="Object"></returns>
        return null;
    },
    
    toJSON: function Kinetic_Node$toJSON() {
        /// <summary>
        /// Convert Node into a JSON string.
        /// </summary>
        /// <returns type="String"></returns>
        return null;
    },
    
    toObject: function Kinetic_Node$toObject() {
        /// <summary>
        /// Convert Node into an object for serialization.
        /// </summary>
        /// <returns type="Object"></returns>
        return null;
    },
    
    transitionTo: function Kinetic_Node$transitionTo(config) {
        /// <summary>
        /// transition node to another state.
        /// </summary>
        /// <param name="config" type="Object">
        /// </param>
        /// <returns type="Kinetic.Transition"></returns>
        return null;
    }
}


Kinetic.Collection.registerClass('Kinetic.Collection');
Kinetic.Node.registerClass('Kinetic.Node');
Kinetic.Container.registerClass('Kinetic.Container', Kinetic.Node);
Kinetic.Filters.registerClass('Kinetic.Filters');
Kinetic.DragAndDrop.registerClass('Kinetic.DragAndDrop');
Kinetic.Global.registerClass('Kinetic.Global');
Kinetic.Shape.registerClass('Kinetic.Shape', Kinetic.Node);
Kinetic.Line.registerClass('Kinetic.Line', Kinetic.Shape);
Kinetic.Spline.registerClass('Kinetic.Spline', Kinetic.Line);
Kinetic.Blob.registerClass('Kinetic.Blob', Kinetic.Spline);
Kinetic.Circle.registerClass('Kinetic.Circle', Kinetic.Shape);
Kinetic.Ellipse.registerClass('Kinetic.Ellipse', Kinetic.Shape);
Kinetic.Image.registerClass('Kinetic.Image', Kinetic.Shape);
Kinetic.Path.registerClass('Kinetic.Path', Kinetic.Shape);
Kinetic.Polygon.registerClass('Kinetic.Polygon', Kinetic.Shape);
Kinetic.Rect.registerClass('Kinetic.Rect', Kinetic.Shape);
Kinetic.RectangularPolygon.registerClass('Kinetic.RectangularPolygon', Kinetic.Shape);
Kinetic.Sprite.registerClass('Kinetic.Sprite', Kinetic.Shape);
Kinetic.Star.registerClass('Kinetic.Star', Kinetic.Shape);
Kinetic.Text.registerClass('Kinetic.Text', Kinetic.Shape);
Kinetic.TextPath.registerClass('Kinetic.TextPath', Kinetic.Shape);
Kinetic.Wedge.registerClass('Kinetic.Wedge', Kinetic.Shape);
Kinetic.Stage.registerClass('Kinetic.Stage', Kinetic.Container);
Kinetic.Type.registerClass('Kinetic.Type');
Kinetic.Canvas.registerClass('Kinetic.Canvas');
Kinetic.Group.registerClass('Kinetic.Group', Kinetic.Container);
Kinetic.Layer.registerClass('Kinetic.Layer', Kinetic.Container);
})(jQuery);

//! This script was generated using Script# v0.7.4.0
