// Electron.cs
//

using System;
using System.Collections.Generic;
using System.Html;
using System.Html.Media.Graphics;
using System.Runtime.CompilerServices;
using Kinetic;

namespace Custom
{
    public class Electron
    {
        private ImageElement imageObj;
        private Image image;
        private Number zIndex;

        public Electron(Layer layer)
        {
            imageObj = new ImageElement();
            image = new Image(new ImageConfig(
                "x", -9999,
                "y", -9999,
                "width", 80,
                "height", 80,
                "image", imageObj));
            zIndex = 0;

            layer.add(image);
        }

        public Vector3D Center
        {
            [ScriptName("getCenter")]
            get
            {
                return new Vector3D(
                    image.getX() + image.getWidth() / 2, 
                    image.getY() + image.getHeight() / 2,
                    zIndex);
            }

            [ScriptName("setCenter")]
            set
            {
                image.setX(value.X - image.getWidth() / 2);
                image.setY(value.Y - image.getHeight() / 2);
                zIndex = value.Z;
                Number roundZIndex = 8 + zIndex / 2;
                image.setZIndex(Math.Truncate(roundZIndex));
            }
        }

        public string Image
        {
            [ScriptName("getImage")]
            get { return imageObj.Src; }

            [ScriptName("setImage")]
            set { imageObj.Src = value; }
        }
    }
}
