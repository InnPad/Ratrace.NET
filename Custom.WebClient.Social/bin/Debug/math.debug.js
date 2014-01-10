//! math.debug.js
//

(function($) {

Type.registerNamespace('Custom');

////////////////////////////////////////////////////////////////////////////////
// Custom.Epsilon

Custom.Epsilon = function Custom_Epsilon() {
    /// <field name="value" type="Number" static="true">
    /// </field>
}


////////////////////////////////////////////////////////////////////////////////
// Custom.PI

Custom.PI = function Custom_PI() {
    /// <field name="value" type="Number" static="true">
    /// </field>
    /// <field name="twice" type="Number" static="true">
    /// </field>
    /// <field name="half" type="Number" static="true">
    /// </field>
}


////////////////////////////////////////////////////////////////////////////////
// Custom.GoldenRatio

Custom.GoldenRatio = function Custom_GoldenRatio() {
    /// <field name="value" type="Number" static="true">
    /// </field>
    /// <field name="inverse" type="Number" static="true">
    /// </field>
}


////////////////////////////////////////////////////////////////////////////////
// Custom.Pythagoras

Custom.Pythagoras = function Custom_Pythagoras() {
    /// <summary>
    /// Pitagoras Constant
    /// </summary>
    /// <field name="value" type="Number" static="true">
    /// </field>
    /// <field name="half" type="Number" static="true">
    /// </field>
}


////////////////////////////////////////////////////////////////////////////////
// Custom.Vector

Custom.Vector = function Custom_Vector(x, y, z) {
    /// <param name="x" type="Number">
    /// </param>
    /// <param name="y" type="Number">
    /// </param>
    /// <param name="z" type="Number">
    /// </param>
    /// <field name="x" type="Number">
    /// </field>
    /// <field name="y" type="Number">
    /// </field>
    /// <field name="z" type="Number">
    /// </field>
    this.x = x;
    this.y = y;
    this.z = z;
}
Custom.Vector.angle = function Custom_Vector$angle(center, point) {
    /// <param name="center" type="Custom.Vector">
    /// </param>
    /// <param name="point" type="Custom.Vector">
    /// </param>
    /// <returns type="Number"></returns>
    var x = point.x - center.x;
    var y = point.y - center.y;
    var phi = Math.atan(Math.abs(x / y));
    if (x < 0 && y < 0) {
        phi = Custom.PI.value + phi;
    }
    else if (x < 0) {
        phi = 2 * Custom.PI.value - phi;
    }
    else if (y < 0) {
        phi = Custom.PI.value - phi;
    }
    return phi;
}
Custom.Vector.calcControl = function Custom_Vector$calcControl(context, midA, midB, ending) {
    /// <param name="context" type="Custom.Vector">
    /// </param>
    /// <param name="midA" type="Custom.Vector">
    /// </param>
    /// <param name="midB" type="Custom.Vector">
    /// </param>
    /// <param name="ending" type="Custom.Vector">
    /// </param>
    /// <returns type="Custom.Vector"></returns>
    var xa = (context.x - midA.x);
    var xb = (midB.x - ending.x);
    var ya = (context.y - midA.y);
    var yb = (midB.y - ending.y);
    var d = xa * yb - ya * xb;
    var a = (context.x * midA.y - context.y * midA.x);
    var b = (midB.x * ending.y - midB.y * ending.x);
    var x = (a * xb - xa * b) / d;
    var y = (a * yb - ya * b) / d;
    var z = context.z + (ending.z - context.z) / 2;
    return new Custom.Vector(x, y, z);
}
Custom.Vector.prototype = {
    x: 0,
    y: 0,
    z: 0,
    
    length: function Custom_Vector$length() {
        /// <returns type="Number"></returns>
        return Math.sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
    },
    
    normalize: function Custom_Vector$normalize() {
        var length = this.length();
        this.x = this.x / length;
        this.y = this.y / length;
        this.z = this.z / length;
    },
    
    crossProduct: function Custom_Vector$crossProduct(vector) {
        /// <param name="vector" type="Custom.Vector">
        /// </param>
        /// <returns type="Custom.Vector"></returns>
        return new Custom.Vector(this.y * vector.z - this.z * vector.y, this.z * vector.x - this.x * vector.z, this.x * vector.y - this.y * vector.x);
    },
    
    image: function Custom_Vector$image() {
        /// <returns type="Custom.Vector"></returns>
        return new Custom.Vector(-this.x, -this.y, -this.z);
    },
    
    plot: function Custom_Vector$plot(r) {
        /// <param name="r" type="Number">
        /// </param>
        /// <returns type="Custom.Vector"></returns>
        return new Custom.Vector(this.x * r, this.y * r, this.z * r);
    },
    
    rotate: function Custom_Vector$rotate(vector, sin, cos) {
        /// <param name="vector" type="Custom.Vector">
        /// </param>
        /// <param name="sin" type="Number">
        /// </param>
        /// <param name="cos" type="Number">
        /// </param>
        /// <returns type="Custom.Vector"></returns>
        var icos = 1 - cos;
        var ux = this.x;
        var uy = this.y;
        var uz = this.z;
        var uxx = ux * ux;
        var uyy = uy * uy;
        var uzz = uz * uz;
        var uyz = uy * uz;
        var uzx = uz * ux;
        var uxy = ux * uy;
        var m11 = cos + uxx * icos;
        var m12 = uxy * icos - uz * sin;
        var m13 = uzx * icos + uy * sin;
        var m21 = uxy * icos + uz * sin;
        var m22 = cos + uyy * icos;
        var m23 = uyz * icos - ux * sin;
        var m31 = uzx * icos - uy * sin;
        var m32 = uyz * icos + ux * sin;
        var m33 = cos + uzz * icos;
        var x = m11 * vector.x + m12 * vector.y + m13 * vector.z;
        var y = m21 * vector.x + m22 * vector.y + m23 * vector.z;
        var z = m31 * vector.x + m32 * vector.y + m33 * vector.z;
        return new Custom.Vector(x, y, z);
    },
    
    rotateX: function Custom_Vector$rotateX(cos, sin) {
        /// <param name="cos" type="Number">
        /// </param>
        /// <param name="sin" type="Number">
        /// </param>
        var newY = cos * this.y - sin * this.z;
        var newZ = sin * this.y + cos * this.z;
        this.y = newY;
        this.z = newZ;
        this.normalize();
    },
    
    rotateY: function Custom_Vector$rotateY(cos, sin) {
        /// <param name="cos" type="Number">
        /// </param>
        /// <param name="sin" type="Number">
        /// </param>
        var newX = cos * this.x + sin * this.z;
        var newZ = cos * this.z - sin * this.x;
        this.x = newX;
        this.z = newZ;
        this.normalize();
    },
    
    rotateZ: function Custom_Vector$rotateZ(cos, sin) {
        /// <param name="cos" type="Number">
        /// </param>
        /// <param name="sin" type="Number">
        /// </param>
        var newX = cos * this.x - sin * this.y;
        var newY = sin * this.x + cos * this.y;
        this.x = newX;
        this.y = newY;
        this.normalize();
    },
    
    toString: function Custom_Vector$toString() {
        /// <returns type="String"></returns>
        return '(x: ' + this.x.toString() + '; y: ' + this.y.toString() + '; z: ' + this.z.toString() + ')';
    },
    
    translate: function Custom_Vector$translate(v) {
        /// <param name="v" type="Custom.Vector">
        /// </param>
        /// <returns type="Custom.Vector"></returns>
        return new Custom.Vector(v.x + this.x, v.y + this.y, v.z + this.z);
    },
    
    dotProduct: function Custom_Vector$dotProduct(v) {
        /// <param name="v" type="Custom.Vector">
        /// </param>
        /// <returns type="Custom.Vector"></returns>
        return new Custom.Vector(v.x * this.x, v.y * this.y, v.z * this.z);
    }
}


Custom.Epsilon.registerClass('Custom.Epsilon');
Custom.PI.registerClass('Custom.PI');
Custom.GoldenRatio.registerClass('Custom.GoldenRatio');
Custom.Pythagoras.registerClass('Custom.Pythagoras');
Custom.Vector.registerClass('Custom.Vector');
Custom.Epsilon.value = 1E-10;
Custom.PI.value = Math.PI;
Custom.PI.twice = 2 * Custom.PI.value;
Custom.PI.half = Custom.PI.value / 2;
Custom.GoldenRatio.value = (1 + Math.sqrt(5)) / 2;
Custom.GoldenRatio.inverse = 1 / Custom.GoldenRatio.value;
Custom.Pythagoras.value = Math.sqrt(2);
Custom.Pythagoras.half = Custom.Pythagoras.value / 2;
})(jQuery);

//! This script was generated using Script# v0.7.4.0
