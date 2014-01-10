// ElasticStars.cs
//

using System;
using System.Collections.Generic;
using AngularApi;
using Kinetic;

namespace Custom
{
    /// <summary>
    /// HTML5 canvas Elastic Stars with KineticJS
    /// </summary>
    public class ElasticStars : KineticDemo
    {
        private static AngularModule _controller;

        public override AngularModule GetController(AngularModule module)
        {
            return _controller;
        }

        protected override Layer KineticInitialize(Number stageWidth, Number stageHeight)
        {
            Layer layer = new Layer(new LayerConfig());

            for (int n = 0; n < 10; n++)
            {
                layer.add(AddStar(stageWidth, stageHeight));
            }

            return layer;
        }

        private Star AddStar(Number maxWidth, Number maxHeight)
        {
            Transition trans = null;
            Number scale = Math.Random();

            Star star = new Star(new StarConfig(
                "x", Math.Random() * maxWidth,
                "y", Math.Random() * maxHeight,
                "numPoints", 5,
                "innerRadius", 50,
                "outerRadius", 100,
                "fill", "#1e4705",
                "stroke", "#89b717",
                "opacity", 0.9,
                "strokeWidth", 10,
                "draggable", true,
                "scale", scale,
                "rotationDeg", Math.Random() * 180,
                "shadowColor", "black",
                "shadowBlur", 10,
                "shadowOffset", new Vector("X", 5, "y", 5),
                "shadowOpacity", 0.6,
                "startScale", scale));

            star.on("dragstart", (System.Action)delegate()
            {
                if (trans)
                {
                    trans.stop();
                }

                star.setAttrs(new ShapeConfig(
                    "shadowOffset", new Vector("x", 15, "y", 15),
                  "scale", new Vector(
                      "x", star.attrs.startScale * 1.2,
                      "y", star.attrs.startScale * 1.2)));

                star.on("dragend", (System.Action)delegate()
                {
                    trans = star.transitionTo(new TransitionConfig(
                      "duration", 0.5,
                      "easing", "elastic-ease-out",
                      "scale", new Vector(
                          "x", star.attrs.startScale,
                          "y", star.attrs.startScale),
                      "shadowOffset", new Vector("x", 5, "y", 5)));
                });
            });

            return star;
        }
    }
}
