// A three dimensional Cartesian coordinate system, with
// origin O and axis lines X, Y and Z
function Cartesian() {
    this.O = new Vector(0, 0, 0);
    this.X = new Vector(1, 0, 0);
    this.Y = new Vector(0, 1, 0);
    this.Z = new Vector(0, 0, 1);
}

function Globe() {
    this.Position = new Cartesian();
}

// A three-dimensional Cartesian system defines a division
// of space into eight regions or octants
// R8 - round octant
function R8(index, color) {
    this.Color = color;
    this.Index = index; // 0 -> 1, 1, 1; 7 => -1, -1, -1
    this.Normal = new Vector(1, 1, 1);
    this.Position = new Cartesian();
    this.System = null;
    this.Type = 'R8';
    this.X = null;
    this.Y = null;
    this.Z = null;

    this.getNormal = function (ctx, center, r, d) {
        var i = 7 - this.Index;
        var v = new Vector(((i << 1) & 2) - 1, (i & 2) - 1, ((i >> 1) & 2) - 1);

        var c = Math.sqrt(2) / 2;

        return v;
    }

    this.isVisible = function () {
        return true;
    }

    this.update = function (cartesian, d, h) {

        var i = 7 - this.Index;
        var v = new Vector(((i << 1) & 2) - 1, (i & 2) - 1, ((i >> 1) & 2) - 1);

        var x = this.Position.X = cartesian.VectorX.plot(v.X);
        var y = this.Position.Y = cartesian.VectorY.plot(v.Y);
        var z = this.Position.Z = cartesian.VectorZ.plot(v.Z);

        var cos = Math.sqrt(2) / 2;
        var sin = cos * v.X * v.Y * v.Z;

        var projection = d / cos;

        var n = this.Normal = x.crossProduct(y).normalize();
        this.Position = n.plot(projection).translate(cartesian.O);

        var ux = x.rotate(y, sin, cos);
        var uy = y.rotate(z, sin, cos);
        var uz = z.rotate(x, sin, cos);

        this.X = ux.plot(projection).translate(x.plot(h));
        this.Y = uy.plot(projection).translate(y.plot(h));
        this.Z = uz.plot(projection).translate(z.plot(h));
    }

    this.zIndex = function () {
        return this.Position.O.Z;
    }
}

// S8 - square octant
function S8(index, cx, cy, cz) {
    this.Type = 'S8';
}

// T8 - R8 ^ S8 octant
function T8(index, cx, cy, cz, color) {
    this.Type = 'T8';
}

// F2 - facet (edge, two faces)
function F2() {
    this.Type = 'F2';
}

// F1 = face (center, one face)
function F1() {
    this.Type = 'F1';
}

function Globik() {
    //   Ik = level
    // 12Ik = number of F2
    //  6Ik = number of F1
    this.Ik = 0;
    this.Canvas = null;
    this.Elements = new Array();
    this.Size = 200;
    this.Primary = new Globe();
    this.Secundary = null;
    this.Pivote = null;
    this.Shift = 0;
    this.Fps = 50;
    this.TimeSpan = 0;
    this.TimeInterval = 0;
    this.transform = null;

    this.init = function (canvas) {
        this.Canvas = canvas;
        this.CanvasContext = this.Canvas.getContext("2d");
    }

    this.start = function () {
        this.TimeInterval = 1000 / this.Fps; // in ms
        var rotateVelocity = 50; // pixels / second
        var rotateDistEachFrame = rotateVelocity * timeInterval / 1000; // ms
        setInterval(updateStage, timeInterval);
    }

    this.paint = function (ctx) {
        var h = Math.sqrt(r * r - d * d);
        var mhu = Math.asin(d / r);

        var elements = this.Elements;
        for (var i = 0; i < elements.length; i++) {
            if (!element.isVisible()) {
                continue;
            }
        }
    }

    this.pause = function () {
    }

    function initStageObjects() {
    }

    function updateStage() {
        this.TimeSpan += timeInterval; // in ms
        clearCanvas();
        updateStageObjects();
        drawStageObjects();
    }

    function updateStageObjects() {
    }

    function drawStageObjects() {
    }

    function clearCanvas() {
        this.CanvasContext.clearRect(0, 0, canvas.width, canvas.height);
    }
}