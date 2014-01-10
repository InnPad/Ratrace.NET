// Atom.cs
//

using System;
using System.Collections.Generic;
using System.Html;
using System.Html.Media.Graphics;
using System.Runtime.CompilerServices;
using jQueryApi;
using Custom;
using Kinetic;

namespace Custom
{
    public class Atom
    {
        private Stage stage;
        private Layer layer;
        
        private Animation animation;
        public Nucleus nucleus;
        private List<Electron> electrons;
        private List<string> imageUrls;
        
        private readonly Space3D axes;

        public Atom(Stage stage, AtomOptions options)
        {
            this.stage = stage;

            jQueryObject container = jQuery.FromElement(stage.getContainer());

            container.Data("Custom.Atom", this);

            imageUrls = options.electrons;

            layer = new Layer(new LayerConfig());

            axes = new Space3D();
            
            nucleus = new Nucleus(layer, axes);

            electrons = new List<Electron>();

            for (int i = 0; i < 20; i++)
            {
                electrons.Add(new Electron(layer));
            }

            for (int i = 0; i < Math.Min(20, imageUrls.Count); i++)
            {
                electrons[i].Image = imageUrls[i];
            }

            Vector3D center = nucleus.Center;

            animation = new Animation((Action<Frame>)delegate(Frame frame)
            {
                //double ran = (Math.Random() - 0.5)/64;
                Vector3D axis = new Vector3D(axes.AxisX.X / 64, axes.AxisY.Y / 32, PI.Value / 256);
                //axis.normalize();
                axes.Rotate(axis.X, axis.Y, axis.Z);

                MoveElectrones(axes);

            }, layer);

            animation.start();

            stage.Add(layer);
        }

        public Vector3D Center
        {
            [ScriptName("getCenter")]
            get { return nucleus.Center; }

            [ScriptName("setCenter")]
            set { nucleus.Center = value; }
        }

        public Number Radius
        {
            get { return nucleus.Radius * 2; }
            set
            {
                nucleus.Radius = value / 2;
            }
        }

        public static Vector3D Mitter(Vector3D x, Vector3D y, Vector3D z)
        {
            double c = Pythagoras.Half;
            return x.Rotate(y, c, c).Rotate(x.Rotate(z, c, c), c, c);
        }

        public void MoveElectrones(Space3D g)
        {
            Vector3D p = new Vector3D(nucleus.circle.getX(), nucleus.circle.getY(), 0);
            double r = Radius;// nucleus.circle.getRadius();

            Vector3D x = g.AxisX;
            Vector3D y = g.AxisY;
            Vector3D z = g.AxisZ;

            Vector3D a = x.Plot(r);
            Vector3D b = y.Plot(r);
            Vector3D c = z.Plot(r);

            electrons[0].Center = p.Translate(a);
            electrons[1].Center = p.Translate(b);
            electrons[2].Center = p.Translate(c);

            Vector3D d = a.Image();
            Vector3D e = b.Image();
            Vector3D f = c.Image();

            electrons[3].Center = p.Translate(d);
            electrons[4].Center = p.Translate(e);
            electrons[5].Center = p.Translate(f);

            electrons[6].Center = p.Translate(Mitter(g.AxisX, g.AxisY, g.AxisZ).Plot(r));
            electrons[7].Center = p.Translate(Mitter(g.AxisX.Image(), g.AxisY, g.AxisZ).Plot(r));
            electrons[8].Center = p.Translate(Mitter(g.AxisX, g.AxisY.Image(), g.AxisZ).Plot(r));
            electrons[9].Center = p.Translate(Mitter(g.AxisX, g.AxisY, g.AxisZ.Image()).Plot(r));
            electrons[10].Center = p.Translate(Mitter(g.AxisX.Image(), g.AxisY.Image(), g.AxisZ.Image()).Plot(r));
            electrons[11].Center = p.Translate(Mitter(g.AxisX, g.AxisY.Image(), g.AxisZ.Image()).Plot(r));
            electrons[12].Center = p.Translate(Mitter(g.AxisX.Image(), g.AxisY, g.AxisZ.Image()).Plot(r));
            electrons[13].Center = p.Translate(Mitter(g.AxisX.Image(), g.AxisY.Image(), g.AxisZ).Plot(r));

            Number alpha = Math.Atan(-y.Z / z.Z);
            Number betta = Math.Atan(-z.Z / x.Z);
            Number gamma = Math.Atan(-x.Z / y.Z);

            Vector3D i = Sphere.Plot(alpha, r, y, z);
            Vector3D j = Sphere.Plot(betta, r, z, x);
            Vector3D k = Sphere.Plot(gamma, r, x, y);

            electrons[14].Center = p.Translate(i);
            electrons[15].Center = p.Translate(j);
            electrons[16].Center = p.Translate(k);

            Vector3D l = i.Image();
            Vector3D m = j.Image();
            Vector3D n = k.Image();

            electrons[17].Center = p.Translate(l);
            electrons[18].Center = p.Translate(m);
            electrons[19].Center = p.Translate(n);
        }

        public void setWidth(int width)
        {
            int margin = 34 * width / 100;
            this.nucleus.circle.setX(margin + (width - margin) / 2);
        }

        public void setHeight(int height)
        {
            this.nucleus.circle.setY(height / 2);
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public sealed class AtomOptions
    {
        public StageOptions stage;

        public List<string> electrons;

        public AtomOptions()
        {
        }

        public AtomOptions(params object[] nameValuePairs)
        {
        }
    }
}

[Mixin("$.fn")]
public static class AtomPlugin
{
    public static jQueryObject Atom(AtomOptions customOptions)
    {
        AtomOptions defaultOptions = new AtomOptions("stage", new StageOptions());

        AtomOptions options = jQuery.ExtendObject<AtomOptions>(new AtomOptions(), defaultOptions, customOptions);

        return jQuery.Current.Each(delegate(int i, Element element)
        {
            Stage stage = StageMaster.FromElement(element, options.stage);
            Atom atom = new Atom(stage, options);
        });
    }
}

#region Script# Support
[Imported]
public sealed class AtomObject : jQueryObject
{
    public jQueryObject Atom()
    {
        return null;
    }

    public jQueryObject Atom(AtomOptions options)
    {
        return null;
    }
}
#endregion
