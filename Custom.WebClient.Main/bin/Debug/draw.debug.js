//! draw.debug.js
//

(function($) {

////////////////////////////////////////////////////////////////////////////////
// AtomPlugin

$.fn.atom = function AtomPlugin$atom(customOptions) {
    /// <param name="customOptions" type="Object">
    /// </param>
    /// <returns type="jQueryObject"></returns>
    var defaultOptions = { stage: {} };
    var options = $.extend({}, defaultOptions, customOptions);
    return this.each(function(i, element) {
        var stage = Custom.StageMaster.fromElement(element, options.stage);
        var atom = new Custom.Atom(stage, options);
    });
}


Type.registerNamespace('Custom');

////////////////////////////////////////////////////////////////////////////////
// Custom.Atom

Custom.Atom = function Custom_Atom(stage, options) {
    /// <param name="stage" type="Kinetic.Stage">
    /// </param>
    /// <param name="options" type="Object">
    /// </param>
    /// <field name="_stage" type="Kinetic.Stage">
    /// </field>
    /// <field name="_layer" type="Kinetic.Layer">
    /// </field>
    /// <field name="_animation" type="Kinetic.Animation">
    /// </field>
    /// <field name="nucleus" type="Custom.Nucleus">
    /// </field>
    /// <field name="_electrons" type="Array">
    /// </field>
    /// <field name="_imageUrls" type="Array">
    /// </field>
    /// <field name="_axes" type="Custom.Space3D">
    /// </field>
    this._stage = stage;
    var container = $(stage.getContainer());
    container.data('Custom.Atom', this);
    this._imageUrls = options.electrons;
    this._layer = new Kinetic.Layer({});
    this._axes = new Custom.Space3D();
    this.nucleus = new Custom.Nucleus(this._layer, this._axes);
    this._electrons = [];
    for (var i = 0; i < 20; i++) {
        this._electrons.add(new Custom.Electron(this._layer));
    }
    for (var i = 0; i < Math.min(20, this._imageUrls.length); i++) {
        this._electrons[i].set_image(this._imageUrls[i]);
    }
    var center = this.nucleus.get_center();
    this._animation = new Kinetic.Animation(ss.Delegate.create(this, function(frame) {
        var axis = new Custom.Vector3D(this._axes.axisX.x / 64, this._axes.axisY.y / 32, Custom.PI.value / 256);
        this._axes.rotate(axis.x, axis.y, axis.z);
        this.moveElectrones(this._axes);
    }), this._layer);
    this._animation.start();
    stage.add(this._layer);
}
Custom.Atom.mitter = function Custom_Atom$mitter(x, y, z) {
    /// <param name="x" type="Custom.Vector3D">
    /// </param>
    /// <param name="y" type="Custom.Vector3D">
    /// </param>
    /// <param name="z" type="Custom.Vector3D">
    /// </param>
    /// <returns type="Custom.Vector3D"></returns>
    var c = Custom.Pythagoras.half;
    return x.rotate(y, c, c).rotate(x.rotate(z, c, c), c, c);
}
Custom.Atom.prototype = {
    _stage: null,
    _layer: null,
    _animation: null,
    nucleus: null,
    _electrons: null,
    _imageUrls: null,
    _axes: null,
    
    get_center: function Custom_Atom$get_center() {
        /// <value type="Custom.Vector3D"></value>
        return this.nucleus.get_center();
    },
    set_center: function Custom_Atom$set_center(value) {
        /// <value type="Custom.Vector3D"></value>
        this.nucleus.set_center(value);
        return value;
    },
    
    get_radius: function Custom_Atom$get_radius() {
        /// <value type="Number"></value>
        return this.nucleus.get_radius() * 2;
    },
    set_radius: function Custom_Atom$set_radius(value) {
        /// <value type="Number"></value>
        this.nucleus.set_radius(value / 2);
        return value;
    },
    
    moveElectrones: function Custom_Atom$moveElectrones(g) {
        /// <param name="g" type="Custom.Space3D">
        /// </param>
        var p = new Custom.Vector3D(this.nucleus.circle.getX(), this.nucleus.circle.getY(), 0);
        var r = this.get_radius();
        var x = g.axisX;
        var y = g.axisY;
        var z = g.axisZ;
        var a = x.plot(r);
        var b = y.plot(r);
        var c = z.plot(r);
        this._electrons[0].set_center(p.translate(a));
        this._electrons[1].set_center(p.translate(b));
        this._electrons[2].set_center(p.translate(c));
        var d = a.image();
        var e = b.image();
        var f = c.image();
        this._electrons[3].set_center(p.translate(d));
        this._electrons[4].set_center(p.translate(e));
        this._electrons[5].set_center(p.translate(f));
        this._electrons[6].set_center(p.translate(Custom.Atom.mitter(g.axisX, g.axisY, g.axisZ).plot(r)));
        this._electrons[7].set_center(p.translate(Custom.Atom.mitter(g.axisX.image(), g.axisY, g.axisZ).plot(r)));
        this._electrons[8].set_center(p.translate(Custom.Atom.mitter(g.axisX, g.axisY.image(), g.axisZ).plot(r)));
        this._electrons[9].set_center(p.translate(Custom.Atom.mitter(g.axisX, g.axisY, g.axisZ.image()).plot(r)));
        this._electrons[10].set_center(p.translate(Custom.Atom.mitter(g.axisX.image(), g.axisY.image(), g.axisZ.image()).plot(r)));
        this._electrons[11].set_center(p.translate(Custom.Atom.mitter(g.axisX, g.axisY.image(), g.axisZ.image()).plot(r)));
        this._electrons[12].set_center(p.translate(Custom.Atom.mitter(g.axisX.image(), g.axisY, g.axisZ.image()).plot(r)));
        this._electrons[13].set_center(p.translate(Custom.Atom.mitter(g.axisX.image(), g.axisY.image(), g.axisZ).plot(r)));
        var alpha = Math.atan(-y.z / z.z);
        var betta = Math.atan(-z.z / x.z);
        var gamma = Math.atan(-x.z / y.z);
        var i = Custom.Sphere.plot(alpha, r, y, z);
        var j = Custom.Sphere.plot(betta, r, z, x);
        var k = Custom.Sphere.plot(gamma, r, x, y);
        this._electrons[14].set_center(p.translate(i));
        this._electrons[15].set_center(p.translate(j));
        this._electrons[16].set_center(p.translate(k));
        var l = i.image();
        var m = j.image();
        var n = k.image();
        this._electrons[17].set_center(p.translate(l));
        this._electrons[18].set_center(p.translate(m));
        this._electrons[19].set_center(p.translate(n));
    },
    
    setWidth: function Custom_Atom$setWidth(width) {
        /// <param name="width" type="Number" integer="true">
        /// </param>
        var margin = 34 * width / 100;
        this.nucleus.circle.setX(margin + (width - margin) / 2);
    },
    
    setHeight: function Custom_Atom$setHeight(height) {
        /// <param name="height" type="Number" integer="true">
        /// </param>
        this.nucleus.circle.setY(height / 2);
    }
}


////////////////////////////////////////////////////////////////////////////////
// Custom.Electron

Custom.Electron = function Custom_Electron(layer) {
    /// <param name="layer" type="Kinetic.Layer">
    /// </param>
    /// <field name="_imageObj" type="Object" domElement="true">
    /// </field>
    /// <field name="_image" type="Kinetic.Image">
    /// </field>
    /// <field name="_zIndex" type="Number">
    /// </field>
    this._imageObj = new Image();
    this._image = new Kinetic.Image({ x: -9999, y: -9999, width: 80, height: 80, image: this._imageObj });
    this._zIndex = 0;
    layer.add(this._image);
}
Custom.Electron.prototype = {
    _imageObj: null,
    _image: null,
    _zIndex: null,
    
    get_center: function Custom_Electron$get_center() {
        /// <value type="Custom.Vector3D"></value>
        return new Custom.Vector3D(this._image.getX() + this._image.getWidth() / 2, this._image.getY() + this._image.getHeight() / 2, this._zIndex);
    },
    set_center: function Custom_Electron$set_center(value) {
        /// <value type="Custom.Vector3D"></value>
        this._image.setX(value.x - this._image.getWidth() / 2);
        this._image.setY(value.y - this._image.getHeight() / 2);
        this._zIndex = value.z;
        var roundZIndex = 8 + this._zIndex / 2;
        this._image.setZIndex(parseInt(roundZIndex));
        return value;
    },
    
    get_image: function Custom_Electron$get_image() {
        /// <value type="String"></value>
        return this._imageObj.src;
    },
    set_image: function Custom_Electron$set_image(value) {
        /// <value type="String"></value>
        this._imageObj.src = value;
        return value;
    }
}


////////////////////////////////////////////////////////////////////////////////
// Custom.Nucleus

Custom.Nucleus = function Custom_Nucleus(layer, axes) {
    /// <param name="layer" type="Kinetic.Layer">
    /// </param>
    /// <param name="axes" type="Custom.Space3D">
    /// </param>
    /// <field name="circle" type="Kinetic.Circle">
    /// </field>
    this.circle = new Kinetic.Circle({ x: 100, y: 100, radius: 160, fill: '#ccc', stroke: '#ccc', strokeWidth: 1, drawFunc: ss.Delegate.create(this, function(canvas) {
        this.circle.__proto__.drawFunc.call(this.circle, canvas);
        var ctx = canvas.getContext();
        this.paint(ctx, this.circle.getRadius(), 10, axes);
    }) });
    var zIndex = this.circle.getZIndex();
    layer.add(this.circle);
}
Custom.Nucleus.prototype = {
    circle: null,
    
    get_center: function Custom_Nucleus$get_center() {
        /// <value type="Custom.Vector3D"></value>
        return new Custom.Vector3D(this.circle.getX(), this.circle.getY(), 0);
    },
    set_center: function Custom_Nucleus$set_center(value) {
        /// <value type="Custom.Vector3D"></value>
        this.circle.setX(value.x);
        this.circle.setY(value.y);
        return value;
    },
    
    get_radius: function Custom_Nucleus$get_radius() {
        /// <value type="Number"></value>
        return this.circle.getRadius();
    },
    set_radius: function Custom_Nucleus$set_radius(value) {
        /// <value type="Number"></value>
        this.circle.setRadius(value);
        return value;
    },
    
    paint: function Custom_Nucleus$paint(ctx, r, d, axes) {
        /// <param name="ctx" type="CanvasContext2D">
        /// </param>
        /// <param name="r" type="Number">
        /// </param>
        /// <param name="d" type="Number">
        /// </param>
        /// <param name="axes" type="Custom.Space3D">
        /// </param>
        var h = Math.sqrt(r * r - d * d);
        var mhu = Math.asin(d / r);
        var octants = new Array(8);
        var colors = [ new Custom.Color('#9c6'), new Custom.Color('#693'), new Custom.Color('#369'), new Custom.Color('#69c'), new Custom.Color('#69c'), new Custom.Color('#369'), new Custom.Color('#693'), new Custom.Color('#9c6') ];
        for (var i = 0; i < 8; i++) {
            octants[i] = new Custom.R8(i, colors[i]);
        }
        ctx.lineJoin = 'round';
        for (var i = 0; i < 8; i++) {
            var r8 = octants[i];
            r8.update(axes, d, h);
            if (!Support.get_radialGradient()) {
                ctx.fillStyle = r8.color._value;
            }
            else {
                try {
                    var basecolor = new Custom.Color(r8.color._value);
                    var p0 = this.get_center();
                    var p1 = p0.translate(Custom.Curve.plot(Custom.PI.value / 4, r));
                    var gradient = ctx.createRadialGradient(p0.x, p0.y, r, p1.x, p1.y, r);
                    gradient.addColorStop(0, basecolor.lighter(0.2));
                    gradient.addColorStop(0.5, basecolor._value);
                    gradient.addColorStop(1, basecolor.darker(0.2));
                    ctx.fillStyle = gradient;
                }
                catch (err) {
                    ctx.fillStyle = r8.color.get_value();
                }
            }
            if (r8.traceSurface(ctx, axes, mhu, r, d, h)) {
                ctx.fill();
            }
        }
    }
}


////////////////////////////////////////////////////////////////////////////////
// Custom.R8

Custom.R8 = function Custom_R8(index, color) {
    /// <param name="index" type="Number" integer="true">
    /// </param>
    /// <param name="color" type="Custom.Color">
    /// </param>
    /// <field name="color" type="Custom.Color">
    /// </field>
    /// <field name="index" type="Number" integer="true">
    /// </field>
    /// <field name="vector3D" type="Custom.Vector3D">
    /// </field>
    /// <field name="x" type="Custom.Vector3D">
    /// </field>
    /// <field name="y" type="Custom.Vector3D">
    /// </field>
    /// <field name="z" type="Custom.Vector3D">
    /// </field>
    this.index = index;
    this.color = color;
    this.vector3D = new Custom.Vector3D(1, 1, 1);
    this.x = new Custom.Vector3D(1, 0, 0);
    this.y = new Custom.Vector3D(0, 1, 0);
    this.z = new Custom.Vector3D(0, 0, 1);
}
Custom.R8.prototype = {
    color: null,
    index: 0,
    vector3D: null,
    x: null,
    y: null,
    z: null,
    
    update: function Custom_R8$update(system, d, h) {
        /// <param name="system" type="Custom.Space3D">
        /// </param>
        /// <param name="d" type="Number">
        /// </param>
        /// <param name="h" type="Number">
        /// </param>
        var octant = 7 - this.index;
        var v = this.vector3D = new Custom.Vector3D(((octant << 1) & 2) - 1, (octant & 2) - 1, ((octant >> 1) & 2) - 1);
        var x = system.axisX.plot(v.x);
        var y = system.axisY.plot(v.y);
        var z = system.axisZ.plot(v.z);
        var sin = Custom.Pythagoras.half * v.x * v.y * v.z;
        var cos = Custom.Pythagoras.half;
        var ux = x.rotate(y, sin, cos);
        var uy = y.rotate(z, sin, cos);
        var uz = z.rotate(x, sin, cos);
        this.x = ux.plot(d / cos).translate(x.plot(h));
        this.y = uy.plot(d / cos).translate(y.plot(h));
        this.z = uz.plot(d / cos).translate(z.plot(h));
    },
    
    traceSurface: function Custom_R8$traceSurface(ctx, system, mhu, r, d, h) {
        /// <param name="ctx" type="CanvasContext2D">
        /// </param>
        /// <param name="system" type="Custom.Space3D">
        /// </param>
        /// <param name="mhu" type="Number">
        /// </param>
        /// <param name="r" type="Number">
        /// </param>
        /// <param name="d" type="Number">
        /// </param>
        /// <param name="h" type="Number">
        /// </param>
        /// <returns type="Boolean"></returns>
        var center = system.center;
        var v = this.vector3D;
        var ux = this.x;
        var uy = this.y;
        var uz = this.z;
        if (ux.z < 0 && uy.z < 0 && uz.z < 0) {
            return false;
        }
        var px = center.translate(ux);
        var py = center.translate(uy);
        var pz = center.translate(uz);
        var x = system.axisX.plot(v.x);
        var y = system.axisY.plot(v.y);
        var z = system.axisZ.plot(v.z);
        var cx = center.translate(x.plot(d));
        var cy = center.translate(y.plot(d));
        var cz = center.translate(z.plot(d));
        var phi = new Custom.Vector3D(mhu, mhu, mhu);
        var rho = new Custom.Vector3D(Custom.PI.value / 2 - mhu, Custom.PI.value / 2 - mhu, Custom.PI.value / 2 - mhu);
        if (ux.z > 0 && uy.z > 0 && uz.z > 0) {
            ctx.moveTo(py.x, py.y);
            ctx.beginPath();
            ctx.moveTo(py.x, py.y);
            Custom.Sphere.traceArc(ctx, cx, py, h, phi.x, rho.x, y, z);
            Custom.Sphere.traceArc(ctx, cy, pz, h, phi.y, rho.y, z, x);
            Custom.Sphere.traceArc(ctx, cz, px, h, phi.z, rho.z, x, y);
            ctx.closePath();
        }
        else {
            var axy = 0, axz = 0, ayx = 0, ayz = 0, azx = 0, azy = 0;
            var pxy = px, pxz = px, pyx = py, pyz = py, pzx = pz, pzy = pz;
            if (ux.z < 0) {
                rho.y = Math.atan(-uz.z / ux.z);
                phi.z = Math.atan(-ux.z / uy.z);
                pxy = cy.translate(Custom.Sphere.plot(rho.y, h, z, x));
                pxz = cz.translate(Custom.Sphere.plot(phi.z, h, x, y));
                axz = Custom.Vector3D.angle(center, pxz);
                axy = Custom.Vector3D.angle(center, pxy);
            }
            if (uy.z < 0) {
                phi.x = Math.atan(-uy.z / uz.z);
                rho.z = Math.atan(-ux.z / uy.z);
                pyx = cx.translate(Custom.Sphere.plot(phi.x, h, y, z));
                pyz = cz.translate(Custom.Sphere.plot(rho.z, h, x, y));
                ayx = Custom.Vector3D.angle(center, pyx);
                ayz = Custom.Vector3D.angle(center, pyz);
            }
            if (uz.z < 0) {
                rho.x = Math.atan(-uy.z / uz.z);
                phi.y = Math.atan(-uz.z / ux.z);
                pzx = cx.translate(Custom.Sphere.plot(rho.x, h, y, z));
                pzy = cy.translate(Custom.Sphere.plot(phi.y, h, z, x));
                azx = Custom.Vector3D.angle(center, pzx);
                azy = Custom.Vector3D.angle(center, pzy);
            }
            if (ux.z > 0 && uy.z > 0) {
                ctx.strokeStyle = '#f00';
                ctx.moveTo(pzx.x, pzx.y);
                ctx.beginPath();
                Custom.Sphere.traceArc(ctx, cy, pzy, h, phi.y, rho.y, z, x);
                Custom.Sphere.traceArc(ctx, cz, pxz, h, phi.z, rho.z, x, y);
                Custom.Sphere.traceArc(ctx, cx, pyx, h, phi.x, rho.x, y, z);
                Custom.Curve.smallArc(ctx, center, pzx, r, azx, azy);
            }
            else if (uy.z > 0 && uz.z > 0) {
                ctx.strokeStyle = '#0f0';
                ctx.moveTo(pxz.x, pxz.y);
                ctx.beginPath();
                Custom.Sphere.traceArc(ctx, cz, pxz, h, phi.z, rho.z, x, y);
                Custom.Sphere.traceArc(ctx, cx, pyx, h, phi.x, rho.x, y, z);
                Custom.Sphere.traceArc(ctx, cy, pzx, h, phi.y, rho.y, z, x);
                Custom.Curve.smallArc(ctx, center, pxy, r, axy, axz);
            }
            else if (uz.z > 0 && ux.z > 0) {
                ctx.strokeStyle = '#00f';
                ctx.moveTo(pyx.x, pyx.y);
                ctx.beginPath();
                Custom.Sphere.traceArc(ctx, cx, pyx, h, phi.x, rho.x, y, z);
                Custom.Sphere.traceArc(ctx, cy, pzx, h, phi.y, rho.y, z, x);
                Custom.Sphere.traceArc(ctx, cz, pxz, h, phi.z, rho.z, x, y);
                Custom.Curve.smallArc(ctx, center, pyz, r, ayz, ayx);
            }
            else if (ux.z > 0) {
                ctx.strokeStyle = '#0ff';
                ctx.moveTo(pzy.x, pzy.y);
                ctx.beginPath();
                Custom.Sphere.traceArc(ctx, cy, pzy, h, phi.y, rho.y, z, x);
                Custom.Sphere.traceArc(ctx, cz, pxz, h, phi.z, rho.z, x, y);
                Custom.Curve.smallArc(ctx, center, pyz, r, ayz, azy);
            }
            else if (uy.z > 0) {
                ctx.strokeStyle = '#ff0';
                ctx.moveTo(pxz.x, pxz.y);
                ctx.beginPath();
                Custom.Sphere.traceArc(ctx, cz, pxz, h, phi.z, rho.z, x, y);
                Custom.Sphere.traceArc(ctx, cx, pyx, h, phi.x, rho.x, y, z);
                Custom.Curve.smallArc(ctx, center, pzx, r, azx, axz);
            }
            else if (uz.z > 0) {
                ctx.strokeStyle = '#f0f';
                ctx.moveTo(pyx.x, pyx.y);
                ctx.beginPath();
                Custom.Sphere.traceArc(ctx, cx, pyx, h, phi.x, rho.x, y, z);
                Custom.Sphere.traceArc(ctx, cy, pzy, h, phi.y, rho.y, z, x);
                Custom.Curve.smallArc(ctx, center, pxy, r, axy, ayx);
            }
        }
        return true;
    }
}


////////////////////////////////////////////////////////////////////////////////
// Custom.Curve

Custom.Curve = function Custom_Curve() {
}
Custom.Curve.plot = function Custom_Curve$plot(phi, r) {
    /// <param name="phi" type="Number">
    /// </param>
    /// <param name="r" type="Number">
    /// </param>
    /// <returns type="Custom.Vector3D"></returns>
    return new Custom.Vector3D(Math.sin(phi) * r, Math.cos(phi) * r, 0);
}
Custom.Curve.smallArc = function Custom_Curve$smallArc(ctx, center, context, r, a, b) {
    /// <param name="ctx" type="CanvasContext2D">
    /// </param>
    /// <param name="center" type="Custom.Vector3D">
    /// </param>
    /// <param name="context" type="Custom.Vector3D">
    /// </param>
    /// <param name="r" type="Number">
    /// </param>
    /// <param name="a" type="Number">
    /// </param>
    /// <param name="b" type="Number">
    /// </param>
    /// <returns type="Boolean"></returns>
    if (a === b) {
        return false;
    }
    if (a > b && a - b > Custom.PI.value) {
        a = a - 2 * Custom.PI.value;
    }
    else if (b > a && b - a > Custom.PI.value) {
        b = b - 2 * Custom.PI.value;
    }
    Custom.Curve.traceArc(ctx, center, context, r, a, b);
    return true;
}
Custom.Curve.traceArc = function Custom_Curve$traceArc(ctx, center, context, r, a, b) {
    /// <param name="ctx" type="CanvasContext2D">
    /// </param>
    /// <param name="center" type="Custom.Vector3D">
    /// </param>
    /// <param name="context" type="Custom.Vector3D">
    /// </param>
    /// <param name="r" type="Number">
    /// </param>
    /// <param name="a" type="Number">
    /// </param>
    /// <param name="b" type="Number">
    /// </param>
    /// <returns type="Custom.Vector3D"></returns>
    var angle = b - a;
    var accuracy = Custom.PI.value / 16;
    var steps = Math.abs(Math.ceil(angle / accuracy));
    if (!steps) {
        return context;
    }
    var mhu = angle / steps;
    var phi = a;
    var eps = (mhu < 0) ? -Custom.Epsilon.value : Custom.Epsilon.value;
    for (var i = 0; i < steps; i++) {
        var rho = phi + mhu;
        var ending = center.translate(Custom.Curve.plot(rho, r));
        var control = Custom.Vector3D.calcControl(context, center.translate(Custom.Curve.plot(phi + eps, r)), center.translate(Custom.Curve.plot(rho - eps, r)), ending);
        ctx.quadraticCurveTo(control.x, control.y, ending.x, ending.y);
        phi = rho;
        context = ending;
    }
    return context;
}
Custom.Curve.drawArc = function Custom_Curve$drawArc(ctx, center, context, r, a, b, color) {
    /// <param name="ctx" type="CanvasContext2D">
    /// </param>
    /// <param name="center" type="Custom.Vector3D">
    /// </param>
    /// <param name="context" type="Custom.Vector3D">
    /// </param>
    /// <param name="r" type="Number">
    /// </param>
    /// <param name="a" type="Number">
    /// </param>
    /// <param name="b" type="Number">
    /// </param>
    /// <param name="color" type="Number" integer="true">
    /// </param>
    /// <returns type="Custom.Vector3D"></returns>
    ctx.strokeStyle = color;
    ctx.moveTo(context.x, context.y);
    ctx.beginPath();
    context = Custom.Curve.traceArc(ctx, center, context, r, a, b);
    ctx.stroke();
    return context;
}
Custom.Curve.traceCircle = function Custom_Curve$traceCircle(ctx, center, r) {
    /// <param name="ctx" type="CanvasContext2D">
    /// </param>
    /// <param name="center" type="Custom.Vector3D">
    /// </param>
    /// <param name="r" type="Number">
    /// </param>
    /// <returns type="Custom.Vector3D"></returns>
    return Custom.Curve.traceArc(ctx, center, center.translate(new Custom.Vector3D(r, 0, 0)), r, 0, 2 * Custom.PI.value);
}
Custom.Curve.drawCircle = function Custom_Curve$drawCircle(ctx, center, r, color) {
    /// <param name="ctx" type="CanvasContext2D">
    /// </param>
    /// <param name="center" type="Custom.Vector3D">
    /// </param>
    /// <param name="r" type="Number">
    /// </param>
    /// <param name="color" type="Number" integer="true">
    /// </param>
    /// <returns type="Custom.Vector3D"></returns>
    return Custom.Curve.drawArc(ctx, center, new Custom.Vector3D(r, 0, 0), r, 0, 2 * Custom.PI.value, color);
}
Custom.Curve.traceCircleDeprecated = function Custom_Curve$traceCircleDeprecated(ctx, center, r) {
    /// <param name="ctx" type="CanvasContext2D">
    /// </param>
    /// <param name="center" type="Custom.Vector3D">
    /// </param>
    /// <param name="r" type="Number">
    /// </param>
    var pi4th = Custom.PI.value / 4;
    var pi8th = Custom.PI.value / 8;
    var sin_pi4th = Math.sin(pi4th);
    var tan_pi8th = Math.tan(pi8th);
    var x = center.x;
    var y = center.y;
    ctx.quadraticCurveTo(r + x, -tan_pi8th * r + y, sin_pi4th * r + x, -sin_pi4th * r + y);
    ctx.quadraticCurveTo(tan_pi8th * r + x, -r + y, x, -r + y);
    ctx.quadraticCurveTo(-tan_pi8th * r + x, -r + y, -sin_pi4th * r + x, -sin_pi4th * r + y);
    ctx.quadraticCurveTo(-r + x, -tan_pi8th * r + y, -r + x, y);
    ctx.quadraticCurveTo(-r + x, tan_pi8th * r + y, -sin_pi4th * r + x, sin_pi4th * r + y);
    ctx.quadraticCurveTo(-tan_pi8th * r + x, r + y, x, r + y);
    ctx.quadraticCurveTo(tan_pi8th * r + x, r + y, sin_pi4th * r + x, sin_pi4th * r + y);
    ctx.quadraticCurveTo(r + x, tan_pi8th * r + y, r + x, y);
}
Custom.Curve.drawCircleDeprecated = function Custom_Curve$drawCircleDeprecated(ctx, center, r, color) {
    /// <param name="ctx" type="CanvasContext2D">
    /// </param>
    /// <param name="center" type="Custom.Vector3D">
    /// </param>
    /// <param name="r" type="Number">
    /// </param>
    /// <param name="color" type="String">
    /// </param>
    ctx.beginPath();
    ctx.strokeStyle = color;
    ctx.moveTo(center.x + r, center.y);
    Custom.Curve.traceCircleDeprecated(ctx, center, r);
    ctx.stroke();
}


////////////////////////////////////////////////////////////////////////////////
// Custom.Color

Custom.Color = function Custom_Color(color) {
    /// <param name="color" type="String">
    /// </param>
    /// <field name="_red" type="Number" integer="true">
    /// </field>
    /// <field name="_green" type="Number" integer="true">
    /// </field>
    /// <field name="_blue" type="Number" integer="true">
    /// </field>
    /// <field name="_alpha" type="Number" integer="true">
    /// </field>
    /// <field name="_value" type="String">
    /// </field>
    /// <field name="_rgb" type="Boolean">
    /// </field>
    this._value = color;
    color = color.replace(new RegExp('^\\s*|\\s*$'), '');
    color = color.replace(new RegExp('^#?([a-f0-9])([a-f0-9])([a-f0-9])$'), '#$1$1$2$2$3$3');
    var rgb = color.match(new RegExp('^rgba?\\(\\s*' + '(\\d|[1-9]\\d|1\\d{2}|2[0-4][0-9]|25[0-5])' + '\\s*,\\s*' + '(\\d|[1-9]\\d|1\\d{2}|2[0-4][0-9]|25[0-5])' + '\\s*,\\s*' + '(\\d|[1-9]\\d|1\\d{2}|2[0-4][0-9]|25[0-5])' + '(?:\\s*,\\s*' + '(0|1|0?\\.\\d+))?' + '\\s*\\)$', 'i'));
    if (rgb != null) {
        this._rgb = true;
        this._alpha = (rgb[4] != null) ? parseInt(rgb[4]) : 0;
        this._red = parseInt(rgb[1]);
        this._green = parseInt(rgb[2]);
        this._blue = parseInt(rgb[3]);
    }
    else {
        var web = color.match(new RegExp('^#?([a-f0-9][a-f0-9])([a-f0-9][a-f0-9])([a-f0-9][a-f0-9])'));
        this._rgb = false;
        this._alpha = 0;
        this._red = parseInt(web[1], 16);
        this._green = parseInt(web[2], 16);
        this._blue = parseInt(web[3], 16);
    }
}
Custom.Color.prototype = {
    _red: 0,
    _green: 0,
    _blue: 0,
    _alpha: 0,
    _value: null,
    _rgb: false,
    
    get_value: function Custom_Color$get_value() {
        /// <value type="String"></value>
        return this._value;
    },
    
    lighter: function Custom_Color$lighter(ratio) {
        /// <param name="ratio" type="Number">
        /// </param>
        /// <returns type="String"></returns>
        var difference = Math.round(ratio * 256);
        var red = Math.min(this._red + difference, 255);
        var green = Math.min(this._green + difference, 255);
        var blue = Math.min(this._blue + difference, 255);
        var color = (this._rgb) ? ((!!this._alpha) ? String.format('rgba({0}, {1}, {2}, {3})', red, green, blue, this._alpha) : String.format('rgb({0}, {1}, {2})', red, green, blue)) : String.concat('#', red.toString(16), green.toString(16), blue.toString(16));
        return color;
    },
    
    darker: function Custom_Color$darker(ratio) {
        /// <param name="ratio" type="Number">
        /// </param>
        /// <returns type="String"></returns>
        var difference = -Math.round(ratio * 256);
        var red = Math.max(this._red + difference, 0);
        var green = Math.max(this._green + difference, 0);
        var blue = Math.max(this._blue + difference, 0);
        var color = (this._rgb) ? ((!!this._alpha) ? String.format('rgba({0}, {1}, {2}, {3})', red, green, blue, this._alpha) : String.format('rgb({0}, {1}, {2})', red, green, blue)) : String.format('#{0:x2}{1:x2}{2:x2}', red, green, blue);
        return color;
    }
}


////////////////////////////////////////////////////////////////////////////////
// Custom.Space3D

Custom.Space3D = function Custom_Space3D() {
    /// <field name="axisX" type="Custom.Vector3D">
    /// </field>
    /// <field name="axisY" type="Custom.Vector3D">
    /// </field>
    /// <field name="axisZ" type="Custom.Vector3D">
    /// </field>
    /// <field name="center" type="Custom.Vector3D">
    /// </field>
    this.axisX = new Custom.Vector3D(1, 0, 0);
    this.axisY = new Custom.Vector3D(0, 1, 0);
    this.axisZ = new Custom.Vector3D(0, 0, 1);
    this.center = new Custom.Vector3D(0, 0, 0);
}
Custom.Space3D.prototype = {
    axisX: null,
    axisY: null,
    axisZ: null,
    center: null,
    
    drawVisibleAxes: function Custom_Space3D$drawVisibleAxes(ctx, r, color) {
        /// <param name="ctx" type="CanvasContext2D">
        /// </param>
        /// <param name="r" type="Number">
        /// </param>
        /// <param name="color" type="String">
        /// </param>
        Custom.Sphere.drawVisibleArc(ctx, this.center, r, this.axisY, this.axisZ, color);
        Custom.Sphere.drawVisibleArc(ctx, this.center, r, this.axisZ, this.axisX, color);
        Custom.Sphere.drawVisibleArc(ctx, this.center, r, this.axisX, this.axisY, color);
    },
    
    drawVisibleMesh: function Custom_Space3D$drawVisibleMesh(ctx, r, count, color) {
        /// <param name="ctx" type="CanvasContext2D">
        /// </param>
        /// <param name="r" type="Number">
        /// </param>
        /// <param name="count" type="Number" integer="true">
        /// </param>
        /// <param name="color" type="String">
        /// </param>
        this.drawVisibleAxes(ctx, r, color);
        var step = r / count;
        for (var i = 1; i < count; i++) {
            var d = i * step;
            var h = Math.sqrt(r * r - d * d);
            Custom.Sphere.drawVisibleArc(ctx, this.center.translate(this.axisX.plot(d)), h, this.axisY, this.axisZ, color);
            Custom.Sphere.drawVisibleArc(ctx, this.center.translate(this.axisX.plot(-d)), h, this.axisY, this.axisZ, color);
            Custom.Sphere.drawVisibleArc(ctx, this.center.translate(this.axisY.plot(d)), h, this.axisZ, this.axisX, color);
            Custom.Sphere.drawVisibleArc(ctx, this.center.translate(this.axisY.plot(-d)), h, this.axisZ, this.axisX, color);
            Custom.Sphere.drawVisibleArc(ctx, this.center.translate(this.axisZ.plot(d)), h, this.axisX, this.axisY, color);
            Custom.Sphere.drawVisibleArc(ctx, this.center.translate(this.axisZ.plot(-d)), h, this.axisX, this.axisY, color);
        }
    },
    
    rotate: function Custom_Space3D$rotate(x, y, z) {
        /// <param name="x" type="Number">
        /// </param>
        /// <param name="y" type="Number">
        /// </param>
        /// <param name="z" type="Number">
        /// </param>
        var axis = new Custom.Vector3D(x, y, z);
        if (!!x) {
            var cosX = Math.cos(axis.x);
            var sinX = Math.sin(axis.x);
            this.axisX.rotateX(cosX, sinX);
            this.axisY.rotateX(cosX, sinX);
            this.axisZ.rotateX(cosX, sinX);
        }
        if (!!y) {
            var cosY = Math.cos(axis.y);
            var sinY = Math.sin(axis.y);
            this.axisX.rotateY(cosY, sinY);
            this.axisY.rotateY(cosY, sinY);
            this.axisZ.rotateY(cosY, sinY);
        }
        if (!!z) {
            var cosZ = Math.cos(axis.z);
            var sinZ = Math.sin(axis.z);
            this.axisX.rotateZ(cosZ, sinZ);
            this.axisY.rotateZ(cosZ, sinZ);
            this.axisZ.rotateZ(cosZ, sinZ);
        }
    },
    
    translate: function Custom_Space3D$translate(x, y, z) {
        /// <param name="x" type="Number">
        /// </param>
        /// <param name="y" type="Number">
        /// </param>
        /// <param name="z" type="Number">
        /// </param>
        this.center.x += x;
        this.center.y += y;
        this.center.z += z;
    }
}


////////////////////////////////////////////////////////////////////////////////
// Custom.Sphere

Custom.Sphere = function Custom_Sphere() {
}
Custom.Sphere.traceArc = function Custom_Sphere$traceArc(ctx, center, context, r, a, b, u, v) {
    /// <param name="ctx" type="CanvasContext2D">
    /// </param>
    /// <param name="center" type="Custom.Vector3D">
    /// </param>
    /// <param name="context" type="Custom.Vector3D">
    /// </param>
    /// <param name="r" type="Number">
    /// </param>
    /// <param name="a" type="Number">
    /// </param>
    /// <param name="b" type="Number">
    /// </param>
    /// <param name="u" type="Custom.Vector3D">
    /// </param>
    /// <param name="v" type="Custom.Vector3D">
    /// </param>
    /// <returns type="Custom.Vector3D"></returns>
    var angle = b - a;
    var accuracy = Custom.PI.value / 16;
    var steps = Math.abs(Math.ceil(angle / accuracy));
    steps = 8;
    var mhu = angle / steps;
    var phi = a;
    for (var i = 0; i < steps; i++) {
        var rho = phi + mhu;
        var ending = center.translate(Custom.Sphere.plot(rho, r, u, v));
        var control = Custom.Vector3D.calcControl(context, center.translate(Custom.Sphere.plot(phi + Custom.Epsilon.value, r, u, v)), center.translate(Custom.Sphere.plot(rho - Custom.Epsilon.value, r, u, v)), ending);
        ctx.quadraticCurveTo(control.x, control.y, ending.x, ending.y);
        phi = rho;
        context = ending;
    }
    return context;
}
Custom.Sphere.drawVisibleArc = function Custom_Sphere$drawVisibleArc(ctx, center, r, u, v, color) {
    /// <param name="ctx" type="CanvasContext2D">
    /// </param>
    /// <param name="center" type="Custom.Vector3D">
    /// </param>
    /// <param name="r" type="Number">
    /// </param>
    /// <param name="u" type="Custom.Vector3D">
    /// </param>
    /// <param name="v" type="Custom.Vector3D">
    /// </param>
    /// <param name="color" type="String">
    /// </param>
    /// <returns type="Custom.Vector3D"></returns>
    var phi = 0;
    var rho = 2 * Custom.PI.value;
    if (!!v.z) {
        phi = Math.atan(-u.z / v.z);
        if (v.z < 0) {
            phi = phi + Custom.PI.value;
        }
        if (phi < 0) {
            phi = 2 * Custom.PI.value + phi;
        }
        else if (phi > 2 * Custom.PI.value) {
            phi = phi - 2 * Custom.PI.value;
        }
        rho = phi + Custom.PI.value;
    }
    ctx.beginPath();
    ctx.strokeStyle = color;
    var context = Custom.Sphere.traceArc(ctx, center, null, r, phi, rho, u, v);
    ctx.stroke();
    return context;
}
Custom.Sphere.plot = function Custom_Sphere$plot(rho, r, u, v) {
    /// <param name="rho" type="Number">
    /// </param>
    /// <param name="r" type="Number">
    /// </param>
    /// <param name="u" type="Custom.Vector3D">
    /// </param>
    /// <param name="v" type="Custom.Vector3D">
    /// </param>
    /// <returns type="Custom.Vector3D"></returns>
    var x = r * Math.cos(rho);
    var y = r * Math.sin(rho);
    var Vector3D = new Custom.Vector3D(x * u.x + y * v.x, x * u.y + y * v.y, x * u.z + y * v.z);
    return Vector3D;
}


////////////////////////////////////////////////////////////////////////////////
// Custom.Vector3D

Custom.Vector3D = function Custom_Vector3D(x, y, z) {
    /// <param name="x" type="Number">
    /// </param>
    /// <param name="y" type="Number">
    /// </param>
    /// <param name="z" type="Number">
    /// </param>
    Custom.Vector3D.initializeBase(this);
    this.x = x;
    this.y = y;
    this.z = z;
}
Custom.Vector3D.angle = function Custom_Vector3D$angle(center, point) {
    /// <param name="center" type="Custom.Vector3D">
    /// </param>
    /// <param name="point" type="Custom.Vector3D">
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
Custom.Vector3D.calcControl = function Custom_Vector3D$calcControl(context, midA, midB, ending) {
    /// <param name="context" type="Custom.Vector3D">
    /// </param>
    /// <param name="midA" type="Custom.Vector3D">
    /// </param>
    /// <param name="midB" type="Custom.Vector3D">
    /// </param>
    /// <param name="ending" type="Custom.Vector3D">
    /// </param>
    /// <returns type="Custom.Vector3D"></returns>
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
    return new Custom.Vector3D(x, y, z);
}
Custom.Vector3D.prototype = {
    
    length: function Custom_Vector3D$length() {
        /// <returns type="Number"></returns>
        return Math.sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
    },
    
    normalize: function Custom_Vector3D$normalize() {
        var length = this.length();
        this.x = this.x / length;
        this.y = this.y / length;
        this.z = this.z / length;
    },
    
    crossProduct: function Custom_Vector3D$crossProduct(vector) {
        /// <param name="vector" type="Custom.Vector3D">
        /// </param>
        /// <returns type="Custom.Vector3D"></returns>
        return new Custom.Vector3D(this.y * vector.z - this.z * vector.y, this.z * vector.x - this.x * vector.z, this.x * vector.y - this.y * vector.x);
    },
    
    image: function Custom_Vector3D$image() {
        /// <returns type="Custom.Vector3D"></returns>
        return new Custom.Vector3D(-this.x, -this.y, -this.z);
    },
    
    plot: function Custom_Vector3D$plot(r) {
        /// <param name="r" type="Number">
        /// </param>
        /// <returns type="Custom.Vector3D"></returns>
        return new Custom.Vector3D(this.x * r, this.y * r, this.z * r);
    },
    
    rotate: function Custom_Vector3D$rotate(vector, sin, cos) {
        /// <param name="vector" type="Custom.Vector3D">
        /// </param>
        /// <param name="sin" type="Number">
        /// </param>
        /// <param name="cos" type="Number">
        /// </param>
        /// <returns type="Custom.Vector3D"></returns>
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
        return new Custom.Vector3D(x, y, z);
    },
    
    rotateX: function Custom_Vector3D$rotateX(cos, sin) {
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
    
    rotateY: function Custom_Vector3D$rotateY(cos, sin) {
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
    
    rotateZ: function Custom_Vector3D$rotateZ(cos, sin) {
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
    
    toString: function Custom_Vector3D$toString() {
        /// <returns type="String"></returns>
        return '(x: ' + this.x.toString() + '; y: ' + this.y.toString() + '; z: ' + this.z.toString() + ')';
    },
    
    translate: function Custom_Vector3D$translate(v) {
        /// <param name="v" type="Custom.Vector3D">
        /// </param>
        /// <returns type="Custom.Vector3D"></returns>
        return new Custom.Vector3D(v.x + this.x, v.y + this.y, v.z + this.z);
    },
    
    dotProduct: function Custom_Vector3D$dotProduct(v) {
        /// <param name="v" type="Custom.Vector3D">
        /// </param>
        /// <returns type="Custom.Vector3D"></returns>
        return new Custom.Vector3D(v.x * this.x, v.y * this.y, v.z * this.z);
    }
}


////////////////////////////////////////////////////////////////////////////////
// Custom.StageMaster

Custom.StageMaster = function Custom_StageMaster() {
}
Custom.StageMaster.fromElement = function Custom_StageMaster$fromElement(element, options) {
    /// <param name="element" type="Object" domElement="true">
    /// </param>
    /// <param name="options" type="Object">
    /// </param>
    /// <returns type="Kinetic.Stage"></returns>
    var el = $(element);
    var stage = el.data('Custom.Stage');
    if (stage == null) {
        stage = new Kinetic.Stage({ container: element });
        el.data('Custom.Stage', stage);
    }
    return stage;
}


Custom.Atom.registerClass('Custom.Atom');
Custom.Electron.registerClass('Custom.Electron');
Custom.Nucleus.registerClass('Custom.Nucleus');
Custom.R8.registerClass('Custom.R8');
Custom.Curve.registerClass('Custom.Curve');
Custom.Color.registerClass('Custom.Color');
Custom.Space3D.registerClass('Custom.Space3D');
Custom.Sphere.registerClass('Custom.Sphere');
Custom.Vector3D.registerClass('Custom.Vector3D', Object);
Custom.StageMaster.registerClass('Custom.StageMaster');
})(jQuery);

//! This script was generated using Script# v0.7.4.0
