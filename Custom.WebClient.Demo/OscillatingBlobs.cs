// CanvasOscillatingBlobs.cs
//

using System;
using System.Collections.Generic;
using System.Html;
using AngularApi;
using Kinetic;

namespace Custom
{
    /// <summary>
    /// HTML5 canvas Oscillating Blobs with KineticJS
    /// </summary>
    public class OscillatingBlobs : KineticDemo
    {
        private static AngularModule _controller;

        public override AngularModule GetController(AngularModule module)
        {
            return _controller;
        }

        protected override Layer KineticInitialize(Number stageWidth, Number stageHeight)
        {
            Layer layer = new Layer(new LayerConfig());

            string[] colors = new string [] { "red", "orange", "yellow", "green", "blue", "purple" };
            List<Blob> blobs = new List<Blob>();
            
            // create 6 blobs
            for(int n = 0; n < 6; n++)
            {
                // build array of random points
                List<Point> points = new List<Point>();
                for(int i = 0; i < 5; i++)
                {
                    points.Add(new Point(
                        "x", stageWidth * Math.Random(),
                        "y", stageHeight * Math.Random()));
                }

                Blob blob = new Blob(new SplineConfig(
                    "points", points,
                    "fill", colors[n],
                    "stroke", "black",
                    "strokeWidth", 2,
                    "tension", 0,
                    "opacity", Math.Random(),
                    "draggable", true));

                layer.add(blob);
                blobs.Add(blob);
            }
                        
            Number period = 2000;
            Number centerTension = 0;
            Number amplitude = 1;

            Animation anim = new Animation((Action<Frame>)delegate(Frame frame)
                {
                    for(int n = 0; n < blobs.Count; n++)
                    {
                        blobs[n].setTension(amplitude * Math.Sin(frame.time * 2 * Math.PI / period) + centerTension);
                    }
                }, layer);

            anim.start();

            return layer;
        }
    }
}
