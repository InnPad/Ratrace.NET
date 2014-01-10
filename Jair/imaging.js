// constants
var pi = 3.14159265358979323846;
var epsilon = 1 / 32;

var pad = function (num, totalChars) {
    var pad = '0';
    num = num + '';
    while (num.length < totalChars) {
        num = pad + num;
    }
    return num;
};

function Color(value) {
    this.Value = value;

    // Ratio is between 0 and 1
    this.change = function (ratio, darker) {
        var color = this.Value;

        // Trim trailing/leading whitespace
        color = color.replace(/^\s*|\s*$/, '');

        // Expand three-digit hex
        color = color.replace(
        /^#?([a-f0-9])([a-f0-9])([a-f0-9])$/i,
        '#$1$1$2$2$3$3'
    );

        // Calculate ratio
        var difference = Math.round(ratio * 256) * (darker ? -1 : 1),
        // Determine if input is RGB(A)
        rgb = color.match(new RegExp('^rgba?\\(\\s*' +
            '(\\d|[1-9]\\d|1\\d{2}|2[0-4][0-9]|25[0-5])' +
            '\\s*,\\s*' +
            '(\\d|[1-9]\\d|1\\d{2}|2[0-4][0-9]|25[0-5])' +
            '\\s*,\\s*' +
            '(\\d|[1-9]\\d|1\\d{2}|2[0-4][0-9]|25[0-5])' +
            '(?:\\s*,\\s*' +
            '(0|1|0?\\.\\d+))?' +
            '\\s*\\)$'
        , 'i')),
        alpha = !!rgb && rgb[4] != null ? rgb[4] : null,

        // Convert hex to decimal
        decimal = !!rgb ? [rgb[1], rgb[2], rgb[3]] : color.replace(
            /^#?([a-f0-9][a-f0-9])([a-f0-9][a-f0-9])([a-f0-9][a-f0-9])/i,
            function () {
                return parseInt(arguments[1], 16) + ',' +
                    parseInt(arguments[2], 16) + ',' +
                    parseInt(arguments[3], 16);
            }
        ).split(/,/),
        returnValue;

        // Return RGB(A)
        return !!rgb ?
        'rgb' + (alpha !== null ? 'a' : '') + '(' +
            Math[darker ? 'max' : 'min'](
                parseInt(decimal[0], 10) + difference, darker ? 0 : 255
            ) + ', ' +
            Math[darker ? 'max' : 'min'](
                parseInt(decimal[1], 10) + difference, darker ? 0 : 255
            ) + ', ' +
            Math[darker ? 'max' : 'min'](
                parseInt(decimal[2], 10) + difference, darker ? 0 : 255
            ) +
            (alpha !== null ? ', ' + alpha : '') +
            ')' :
        // Return hex
        [
            '#',
            pad(Math[darker ? 'max' : 'min'](
                parseInt(decimal[0], 10) + difference, darker ? 0 : 255
            ).toString(16), 2),
            pad(Math[darker ? 'max' : 'min'](
                parseInt(decimal[1], 10) + difference, darker ? 0 : 255
            ).toString(16), 2),
            pad(Math[darker ? 'max' : 'min'](
                parseInt(decimal[2], 10) + difference, darker ? 0 : 255
            ).toString(16), 2)
        ].join('');
    }

    this.lighter = function (ratio) {
        return this.change(ratio, false);
    }

    this.darker = function (ratio) {
        return this.change(ratio, true);
    }
}

// Vector
function Vector(x, y, z) {
    this.X = x;
    this.Y = y;
    this.Z = z;

    Vector.angle = function (center, point) {
        var x = point.X - center.X;
        var y = point.Y - center.Y;

        var phi = Math.atan(Math.abs(x / y));

        if (x < 0 && y < 0) {
            phi = pi + phi;
        } else if (x < 0) {
            phi = 2 * pi - phi;
        } else if (y < 0) {
            phi = pi - phi;
        }


        return phi;
    }

    this.draw = function (ctx, color) {
        ctx.fillStyle = color;
        ctx.fillRect(this.X - 3, this.Y - 3, 7, 7);
    }

    // point where lines context-midA and midB-ending intersects
    Vector.calcControl = function (context, midA, midB, ending) {

        var xa = (context.X - midA.X);
        var xb = (midB.X - ending.X);
        var ya = (context.Y - midA.Y);
        var yb = (midB.Y - ending.Y);

        var d = xa * yb - ya * xb;

        var a = (context.X * midA.Y - context.Y * midA.X);
        var b = (midB.X * ending.Y - midB.Y * ending.X);

        var x = (a * xb - xa * b) / d;
        var y = (a * yb - ya * b) / d;
        var z = context.Z + (ending.Z - context.Z) / 2;

        return new Vector(x, y, z);
    }

    this.length = function () {
        return Math.sqrt(this.X * this.X + this.Y * this.Y + this.Z * this.Z);
    }

    // Normalize
    this.normalize = function () {
        var length = this.length();

        this.X = this.X / length;
        this.Y = this.Y / length;
        this.Z = this.Z / length;
    }

    // Cross product
    this.crossProduct = function (vector) {
        return new Vector(
            this.Y * vector.Z - this.Z * vector.Y,
            this.Z * vector.X - this.X * vector.Z,
            this.X * vector.Y - this.Y * vector.X);
    }

    this.image = function () {
        return new Vector(-this.X, -this.Y, -this.Z);
    }

    this.plot = function (r) {
        return new Vector(
            this.X * r,
            this.Y * r,
            this.Z * r);
    }

    this.rotate = function (vector, sin, cos) {
        var icos = 1 - cos;
        var ux = this.X;
        var uy = this.Y;
        var uz = this.Z;
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

        var x = m11 * vector.X + m12 * vector.Y + m13 * vector.Z;
        var y = m21 * vector.X + m22 * vector.Y + m23 * vector.Z;
        var z = m31 * vector.X + m32 * vector.Y + m33 * vector.Z;

        return new Vector(x, y, z);
    }

    // Rotate X
    this.rotateX = function (cos, sin) {
        var newY = cos * this.Y - sin * this.Z;
        var newZ = sin * this.Y + cos * this.Z;

        this.Y = newY;
        this.Z = newZ;

        this.normalize();
    }

    // Rotate Y
    this.rotateY = function (cos, sin) {
        var newX = cos * this.X + sin * this.Z;
        var newZ = cos * this.Z - sin * this.X;

        this.X = newX;
        this.Z = newZ;

        this.normalize();
    }

    // Rotate Z
    this.rotateZ = function (cos, sin) {
        var newX = cos * this.X - sin * this.Y;
        var newY = sin * this.X + cos * this.Y;

        this.X = newX;
        this.Y = newY;

        this.normalize();
    }

    this.toString = function () {
        return "(x: " + this.X.toString() + "; y: " + this.Y.toString() + "; z: " + this.Z.toString() + ")";
    }

    this.translate = function (v) {
        return new Vector(v.X + this.X, v.Y + this.Y, v.Z + this.Z);
    }

    this.dotProduct = function (v) {
        return new Vector(v.X * this.X, v.Y * this.Y, v.Z * this.Z);
    }
};

function Circle() {
}

Circle.plot = function (phi, r) {
    return new Vector(Math.sin(phi) * r, Math.cos(phi) * r, 0);
}

Circle.smallArc = function (ctx, center, context, r, a, b) {
    if (a == b) {
        return false;
    }
    if (a > b && a - b > pi) {
        a = a - 2 * pi;
    } else if (b > a && b - a > pi) {
        b = b - 2 * pi;
    }
    Circle.traceArc(ctx, center, context, r, a, b);
}

Circle.traceArc = function (ctx, center, context, r, a, b) {
    var angle = b - a;
    var accuracy = pi / 16;
    var steps = Math.abs(Math.ceil(angle / accuracy));

    if (steps == 0) {
        return context;
    }

    var mhu = angle / steps;

    var phi = a;

    //ctx.arc(center.X, center.Y, a, b, mhu < 0);

    var eps = mhu < 0 ? -epsilon : epsilon;
    for (var i = 0; i < steps; i++) {

        var rho = phi + mhu;
        var ending = center.translate(Circle.plot(rho, r));



        var control = Vector.calcControl(context,
    center.translate(Circle.plot(phi + eps, r)),
    center.translate(Circle.plot(rho - eps, r)), ending);

        ctx.quadraticCurveTo(control.X, control.Y, ending.X, ending.Y);

        phi = rho;
        context = ending;
    }
    return context;
}

Circle.drawArc = function (ctx, center, context, r, a, b, color) {
    ctx.strokeStyle = color;
    ctx.moveTo(context.X, context.Y);
    ctx.beginPath();
    context = Globe.traceArc(ctx, center, context, r, a, b);
    ctx.stroke();
    return context;
}

Circle.traceCircle = function (ctx, center, r) {
    return Circle.traceArc(ctx, center, center.translate(new Vector(r, 0, 0)), r, 0, 2 * pi);
}

Circle.drawCircle = function (ctx, center, r, color) {
    return Circle.drawArc(ctx, center, new Vector(r, 0, 0), r, 0, 2 * pi, color);
}

Circle.plot = function (phi, r) {
    return new Vector(Math.sin(phi) * r, Math.cos(phi) * r, 0);
}

Circle.traceCircleDeprecated = function (ctx, center, r) {
    var pi4th = pi / 4;
    var pi8th = pi / 8;
    var sin_pi4th = Math.sin(pi4th);
    var tan_pi8th = Math.tan(pi8th);

    var x = center.X;
    var y = center.Y;

    // start drawing circle CCW at positive x-axis, at distance r from center(x+r)
    // 1st anchor point...x:(x+r), y:y
    ctx.quadraticCurveTo(r + x, -tan_pi8th * r + y, sin_pi4th * r + x, -sin_pi4th * r + y);

    // control point...x:radius+x offset, y:tan(pi/8)*radius+y offset
    // 2nd anchor point...x:cos(pi/4)*radius+x offset, y:sin(pi/4)*radius+y offset
    // becomes 1st anchor point for next curveTo
    ctx.quadraticCurveTo(tan_pi8th * r + x, -r + y, x, -r + y);
    // control point...x:cot(3pi/8)*radius+x offset, y:-radius+ y offset
    // 2nd anchor point...x:x offset,y:-radius+y offset
    // etc...
    ctx.quadraticCurveTo(-tan_pi8th * r + x, -r + y, -sin_pi4th * r + x, -sin_pi4th * r + y);
    ctx.quadraticCurveTo(-r + x, -tan_pi8th * r + y, -r + x, y);
    ctx.quadraticCurveTo(-r + x, tan_pi8th * r + y, -sin_pi4th * r + x, sin_pi4th * r + y);
    ctx.quadraticCurveTo(-tan_pi8th * r + x, r + y, x, r + y);
    ctx.quadraticCurveTo(tan_pi8th * r + x, r + y, sin_pi4th * r + x, sin_pi4th * r + y);
    ctx.quadraticCurveTo(r + x, tan_pi8th * r + y, r + x, y);
}

Circle.drawCircleDeprecated = function (ctx, center, r, color) {
    ctx.beginPath();
    ctx.strokeStyle = color;
    ctx.moveTo(center.X + r, center.Y);
    Circle.traceCircleDeprecated(ctx, center, r);
    ctx.stroke();
}

function Sphere() {
}

Sphere.traceArc = function (ctx, center, context, r, a, b, u, v) {
    var angle = b - a;
    var accuracy = pi / 16;
    var steps = Math.abs(Math.ceil(angle / accuracy));
    steps = 8;
    var mhu = angle / steps;

    var phi = a;

    for (var i = 0; i < steps; i++) {

        var rho = phi + mhu;
        var ending = center.translate(Sphere.plot(rho, r, u, v));

        var control = Vector.calcControl(context,
                center.translate(Sphere.plot(phi + epsilon, r, u, v)),
                center.translate(Sphere.plot(rho - epsilon, r, u, v)), ending);

        ctx.quadraticCurveTo(control.X, control.Y, ending.X, ending.Y);

        phi = rho;
        context = ending;
    }
    return context;
}

Sphere.drawVisibleArc = function (ctx, center, r, u, v, color) {

    var phi = 0;
    var rho = 2 * pi;
    if (v.Z != 0) {
        phi = Math.atan(-u.Z / v.Z);

        if (v.Z < 0) {
            phi = phi + pi;
        }

        if (phi < 0) {
            phi = 2 * pi + phi;
        } else if (phi > 2 * pi) {
            phi = phi - 2 * pi;
        }
        rho = phi + pi;
    }

    ctx.beginPath();
    ctx.strokeStyle = color;
    var context = Sphere.traceArc(ctx, center, r, phi, rho, u, v);
    ctx.stroke();

    return context;
}

// To get a parametric equation follow this procedure.
// 1. Let N be a unit normal vector for the plane.
// 2. Let C be the circle center, and let R be the radius.
// 3. Let U be a unit vector from C toward a point on the circle.
// 4. Let V = N x U.
// 5. Let t be the paramter.
// 6. A point P is on the circle if...
// P = C + R cos(t) U + R sin(t) V
Sphere.plot = function (rho, r, u, v) {
    var x = r * Math.cos(rho);
    var y = r * Math.sin(rho);

    var vector = new Vector(
            x * u.X + y * v.X,
            x * u.Y + y * v.Y,
            x * u.Z + y * v.Z);

    return vector;
}