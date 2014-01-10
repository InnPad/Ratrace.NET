var sqrt2div2 = Math.sqrt(2) / 2;

function R8(index) {
    this.Index = index;
    this.Color = '#555';
    this.Vector = new Vector(1, 1, 1);
    this.X = new Vector(1, 0, 0);
    this.Y = new Vector(0, 1, 0);
    this.Z = new Vector(0, 0, 1);

    this.update = function (system, d, h) {
        var q = 7 - this.Index;
        var v = this.Vector = new Vector(((q << 1) & 2) - 1, (q & 2) - 1, ((q >> 1) & 2) - 1);

        var x = system.VectorX.plot(v.X);
        var y = system.VectorY.plot(v.Y);
        var z = system.VectorZ.plot(v.Z);

        var sin = sqrt2div2 * v.X * v.Y * v.Z;
        var cos = sqrt2div2;

        var ux = x.rotate(y, sin, cos);
        var uy = y.rotate(z, sin, cos);
        var uz = z.rotate(x, sin, cos);

        this.X = ux.plot(d / cos).translate(x.plot(h));
        this.Y = uy.plot(d / cos).translate(y.plot(h));
        this.Z = uz.plot(d / cos).translate(z.plot(h));

        switch (this.Index) {
            case 0:
                this.Color = '#f90';
                break;
            case 1:
                this.Color = '#30f';
                break;
            case 2:
                this.Color = '#063';
                break;
            case 3:
                this.Color = '#39f';
                break;
            case 4:
                this.Color = '#900';
                break;
            case 5:
                this.Color = '#60c';
                break;
            case 6:
                this.Color = '#fc0';
                break;
            case 7:
                this.Color = '#9f3';
                break;
        }
    }

    this.traceSurface = function (ctx, system, mhu, r, d, h) {
        var v = this.Vector;
        var ux = this.X;
        var uy = this.Y;
        var uz = this.Z;

        if (ux.Z < 0 && uy.Z < 0 && uz.Z < 0) {
            return false;
        }

        var px = center.translate(ux);
        var py = center.translate(uy);
        var pz = center.translate(uz);

        var x = system.VectorX.plot(v.X);
        var y = system.VectorY.plot(v.Y);
        var z = system.VectorZ.plot(v.Z);

        var cx = center.translate(x.plot(d));
        var cy = center.translate(y.plot(d));
        var cz = center.translate(z.plot(d));

        var phi = new Vector(mhu, mhu, mhu);
        var rho = new Vector(pi / 2 - mhu, pi / 2 - mhu, pi / 2 - mhu);

        if (ux.Z > 0 && uy.Z > 0 && uz.Z > 0) {
            ctx.moveTo(py.X, py.Y);
            ctx.beginPath();
            //ctx.moveTo(py.X, py.Y);
            Sphere.traceArc(ctx, cx, py, h, phi.X, rho.X, y, z);
            Sphere.traceArc(ctx, cy, pz, h, phi.Y, rho.Y, z, x);
            Sphere.traceArc(ctx, cz, px, h, phi.Z, rho.Z, x, y);
            ctx.closePath()
        }
        else {
            var axy, axz, ayx, ayz, azx, azy;
            var pxy = px, pxz = px, pyx = py, pyz = py, pzx = pz, pzy = pz;

            if (ux.Z < 0) {
                rho.Y = Math.atan(-uz.Z / ux.Z);
                phi.Z = Math.atan(-ux.Z / uy.Z);

                pxy = cy.translate(Sphere.plot(rho.Y, h, z, x));
                pxz = cz.translate(Sphere.plot(phi.Z, h, x, y));

                axz = Vector.angle(center, pxz);
                axy = Vector.angle(center, pxy);
            }

            if (uy.Z < 0) {
                phi.X = Math.atan(-uy.Z / uz.Z);
                rho.Z = Math.atan(-ux.Z / uy.Z);

                pyx = cx.translate(Sphere.plot(phi.X, h, y, z));
                pyz = cz.translate(Sphere.plot(rho.Z, h, x, y));

                ayx = Vector.angle(center, pyx);
                ayz = Vector.angle(center, pyz);
            }

            if (uz.Z < 0) {
                rho.X = Math.atan(-uy.Z / uz.Z);
                phi.Y = Math.atan(-uz.Z / ux.Z);

                pzx = cx.translate(Sphere.plot(rho.X, h, y, z));
                pzy = cy.translate(Sphere.plot(phi.Y, h, z, x));

                azx = Vector.angle(center, pzx);
                azy = Vector.angle(center, pzy);
            }

            if (ux.Z > 0 && uy.Z > 0) {
                ctx.strokeStyle = '#f00';
                ctx.moveTo(pzx.X, pzx.Y);
                ctx.beginPath();
                //ctx.moveTo(pzx.X, pzx.Y);
                Sphere.traceArc(ctx, cy, pzy, h, phi.Y, rho.Y, z, x);
                Sphere.traceArc(ctx, cz, pxz, h, phi.Z, rho.Z, x, y); //f
                Sphere.traceArc(ctx, cx, pyx, h, phi.X, rho.X, y, z);
                Circle.smallArc(ctx, center, pzx, r, azx, azy);
                ctx.closePath()
            } else if (uy.Z > 0 && uz.Z > 0) {
                ctx.strokeStyle = '#0f0';
                ctx.moveTo(pxz.X, pxz.Y);
                ctx.beginPath();
                //ctx.moveTo(pxz.X, pxz.Y);
                Sphere.traceArc(ctx, cz, pxz, h, phi.Z, rho.Z, x, y);
                Sphere.traceArc(ctx, cx, pyx, h, phi.X, rho.X, y, z); //
                Sphere.traceArc(ctx, cy, pzx, h, phi.Y, rho.Y, z, x);
                Circle.smallArc(ctx, center, pxy, r, axy, axz);
                ctx.closePath()
            } else if (uz.Z > 0 && ux.Z > 0) {
                ctx.strokeStyle = '#00f';
                ctx.moveTo(pyx.X, pyx.Y);
                ctx.beginPath();
                //ctx.moveTo(pyx.X, pyx.Y);
                Sphere.traceArc(ctx, cx, pyx, h, phi.X, rho.X, y, z);
                Sphere.traceArc(ctx, cy, pzx, h, phi.Y, rho.Y, z, x); //
                Sphere.traceArc(ctx, cz, pxz, h, phi.Z, rho.Z, x, y);
                Circle.smallArc(ctx, center, pyz, r, ayz, ayx);
                ctx.closePath()
            } else if (ux.Z > 0) {
                ctx.strokeStyle = '#0ff';
                ctx.moveTo(pzy.X, pzy.Y);
                ctx.beginPath();
                //ctx.moveTo(pzy.X, pzy.Y);
                Sphere.traceArc(ctx, cy, pzy, h, phi.Y, rho.Y, z, x);
                Sphere.traceArc(ctx, cz, pxz, h, phi.Z, rho.Z, x, y);
                Circle.smallArc(ctx, center, pyz, r, ayz, azy);
                ctx.closePath()
            } else if (uy.Z > 0) {
                ctx.strokeStyle = '#ff0';
                ctx.beginPath();
                //ctx.moveTo(pxz.X, pxz.Y);
                Sphere.traceArc(ctx, cz, pxz, h, phi.Z, rho.Z, x, y);
                Sphere.traceArc(ctx, cx, pyx, h, phi.X, rho.X, y, z);
                Circle.smallArc(ctx, center, pzx, r, azx, axz);
                ctx.closePath()
            } else if (uz.Z > 0) {
                ctx.strokeStyle = '#f0f';
                ctx.moveTo(pyx.X, pyx.Y);
                ctx.beginPath();
                //ctx.moveTo(pyx.X, pyx.Y);
                Sphere.traceArc(ctx, cx, pyx, h, phi.X, rho.X, y, z);
                Sphere.traceArc(ctx, cy, pzy, h, phi.Y, rho.Y, z, x);
                Circle.smallArc(ctx, center, pxy, r, axy, ayx);
                ctx.closePath()
            }
        }
        return true;
    }
}

function Globik() {
    this.VectorX = new Vector(1, 0, 0);
    this.VectorY = new Vector(0, 1, 0);
    this.VectorZ = new Vector(0, 0, 1);

    this.paint = function (ctx, center, r, d) {
        var h = Math.sqrt(r * r - d * d);
        var mhu = Math.asin(d / r);

        var octants = new Array();
        for (var i = 0; i < 8; i++) {
            octants[i] = new R8(i);
        }

        //ctx.lineCap = 'round';
        ctx.lineJoin = 'round';

        var gradient = null;

        try {
            p0 = center;
            p1 = center.translate(Circle.plot(pi / 4, r));
            gradient = ctx.createRadialGradient(p0.X, p0.Y, r, p1.X, p1.Y, r);
        }
        catch (err) {
        }

        for (var i = 0; i < 8; i++) {
            var r8 = octants[i];
            r8.update(this, d, h);
            ctx.fillStyle = r8.Color;
            if (r8.traceSurface(ctx, this, mhu, r, d, h)) {
                ctx.stroke();
            }
        }
    }

    this.drawVisibleAxes = function (ctx, center, r, color) {

        // X
        Sphere.drawVisibleArc(ctx, center, r, this.VectorY, this.VectorZ, color);

        // Y
        Sphere.drawVisibleArc(ctx, center, r, this.VectorZ, this.VectorX, color);

        // Z
        Sphere.drawVisibleArc(ctx, center, r, this.VectorX, this.VectorY, color);
    }

    this.drawVisibleMesh = function (ctx, center, r, count, color) {

        // X
        Sphere.drawVisibleArc(ctx, center, r, this.VectorY, this.VectorZ, color);

        // Y
        Sphere.drawVisibleArc(ctx, center, r, this.VectorZ, this.VectorX, color);

        // Z
        Sphere.drawVisibleArc(ctx, center, r, this.VectorX, this.VectorY, color);


        var step = r / count;

        //var a = Math.atan(-u.Z / v.Z);

        for (var i = 1; i < count; i++) {

            var d = i * step;
            var h = Math.sqrt(r * r - d * d);

            // X
            Sphere.drawVisibleArc(ctx, center.translate(this.VectorX.plot(d)), h, this.VectorY, this.VectorZ, color);
            Sphere.drawVisibleArc(ctx, center.translate(this.VectorX.plot(-d)), h, this.VectorY, this.VectorZ, color);

            // Y
            Sphere.drawVisibleArc(ctx, center.translate(this.VectorY.plot(d)), h, this.VectorZ, this.VectorX, color);
            Sphere.drawVisibleArc(ctx, center.translate(this.VectorY.plot(-d)), h, this.VectorZ, this.VectorX, color);

            // Z
            Sphere.drawVisibleArc(ctx, center.translate(this.VectorZ.plot(d)), h, this.VectorX, this.VectorY, color);
            Sphere.drawVisibleArc(ctx, center.translate(this.VectorZ.plot(-d)), h, this.VectorX, this.VectorY, color);
        }
    }

    

    this.rotate = function (x, y, z) {

        var axis = new Vector(x, y, z);

        //axis.normalize();

        if (x != 0) {
            var cosX = Math.cos(axis.X);
            var sinX = Math.sin(axis.X);
            this.VectorX.rotateX(cosX, sinX);
            this.VectorY.rotateX(cosX, sinX);
            this.VectorZ.rotateX(cosX, sinX);
        }

        if (y != 0) {
            var cosY = Math.cos(axis.Y);
            var sinY = Math.sin(axis.Y);
            this.VectorX.rotateY(cosY, sinY);
            this.VectorY.rotateY(cosY, sinY);
            this.VectorZ.rotateY(cosY, sinY);
        }

        if (z != 0) {
            var cosZ = Math.cos(axis.Z);
            var sinZ = Math.sin(axis.Z);
            this.VectorX.rotateZ(cosZ, sinZ);
            this.VectorY.rotateZ(cosZ, sinZ);
            this.VectorZ.rotateZ(cosZ, sinZ);
        }
    }
}

function FlowContent(id, image) {
    this.Location = null;
    this.Div = document.createElement('div');
    this.Div.setAttribute('class', 'content');
    this.Div.setAttribute('id', id);
    this.Img = document.createElement('img');
    this.Div.appendChild(this.Img);
    this.Img.src = image;
    this.Change = false;
}

function GlobeFlow(globe, container, center, radio) {
    this.Globe = globe;
    this.Center = new Vector(center.X, center.Y, radio + 1);
    this.Radio = radio;
    this.Container = container;
    this.Content = new Array();
    this.Location = new Array();
    this.mIndex = 0;

    this.init = function () {
        for (var i = 0; i < 6; i++) {
            var content = new FlowContent('content' + i, 'http://cdn-5.nflximg.com/en_US/boxshots/large/70142825.jpg');
            this.Content[i] = content;
            this.Container.appendChild(content.Div);
        }
    }

    this.preload = function (source) {
    }

    this.refresh = function () {

        var p = this.Center;
        var g = this.Globe;
        var r = this.Radio;

        var x = g.VectorX;
        var y = g.VectorY;
        var z = g.VectorZ;

        var a = x.plot(r);
        var b = y.plot(r);
        var c = z.plot(r);

        this.Location[0] = p.translate(a);
        this.Location[1] = p.translate(b);
        this.Location[2] = p.translate(c);

        var d = a.image();
        var e = b.image();
        var f = c.image();

        this.Location[3] = p.translate(d);
        this.Location[4] = p.translate(e);
        this.Location[5] = p.translate(f);

        var alpha = Math.atan(-y.Z / z.Z);
        var betta = Math.atan(-z.Z / x.Z);
        var gamma = Math.atan(-x.Z / y.Z);

        var i = Sphere.plot(alpha, r, y, z);
        var j = Sphere.plot(betta, r, z, x);
        var k = Sphere.plot(gamma, r, x, y);

        this.Location[6] = p.translate(i);
        this.Location[7] = p.translate(j);
        this.Location[8] = p.translate(k);

        var l = i.image();
        var m = j.image();
        var n = k.image();

        this.Location[9] = p.translate(l);
        this.Location[10] = p.translate(m);
        this.Location[11] = p.translate(n);
    }

    this.update = function (ctx) {
        for (var i = 0; i < 6; i++) {
            var location = this.Location[i];
            var content = this.Content[i];
            var img = content.Img;
            var style = content.Div.style;

            var z = location.Z - this.Center.Z
            var zIndex = location.Z;
            var width = img.naturalWidth + (img.naturalWidth * z) / (this.Center.Z * 4);
            var height = img.naturalHeight + (img.naturalHeight * z) / (this.Center.Z * 4);
            var left = location.X - (width / 2);
            var top = location.Y - (height / 2);

            if (location.Z + 5 < this.Center.Z) {
                var opacity = (zIndex - 1) / (this.Center.Z * 2);
                style.opacity = opacity.toString();

                if (content.Change == true && z < -(this.Center.Z / 4) && movies != null && movies.length > 0) {
                    if (this.mIndex >= movies.length) {
                        this.mIndex = 0;
                    }
                    var index = this.mIndex;
                    this.mIndex = this.mIndex + 1;
                    img.src = movies[index].BoxArt.LargeUrl;
                    content.Change = false;
                }
            }
            else {
                style.opacity = '1';
                content.Change = true;
            }
            style.left = left.toString() + 'px';
            style.top = top.toString() + 'px';
            style.zIndex = Math.floor(location.Z);
            style.width = width.toString() + 'px';
            style.height = height.toString() + 'px';
            content.Img.width = width;
            content.Img.height = height;
        }
    }
}