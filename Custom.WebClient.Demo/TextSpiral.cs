// TextSpiral.cs
//

using System;
using System.Collections.Generic;
using System.Html;
using AngularApi;
using Kinetic;

namespace Custom
{
    /// <summary>
    /// HTML5 canvas Text Spiral with KineticJS
    /// </summary>
    public class TextSpiral : KineticDemo
    {
        private static AngularModule _controller;

        public override AngularModule GetController(AngularModule module)
        {
            if (_controller != null)
                return _controller;

            _controller = module.controller("TextSpiral", (System.Action)delegate()
            {
            });

            return _controller;
        }

        protected override Layer KineticInitialize(Number stageWidth, Number stageHeight)
        {
            Layer layer = new Layer(new LayerConfig());

            TextPath textpath = new TextPath(new TextPathConfig(
                "x", stageWidth / 2,
                "y", stageHeight / 2,
                "fill", "#333",
                "fontSize", "6",
                "fontFamily", "Arial",
                "text", "",
                "data", "M153 334 C153 334 151 334 151 334 C151 339 153 344 156 344 C164 344 171 339 171 334 C171 322 164 314 156 314 C142 314 131 322 131 334 C131 350 142 364 156 364 C175 364 191 350 191 334 C191 311 175 294 156 294 C131 294 111 311 111 334 C111 361 131 384 156 384 C186 384 211 361 211 334 C211 300 186 274 156 274",
                "scale", 1,
                "offset", new Vector("x", 153, "y", 334),
                "opacity", 0.8));

            layer.add(textpath);

            string text = "All the world\'s a stage, and all the men and women merely players. They have their exits and their entrances; And one man in his time plays many parts.";

            // interval
            int n = 0, interval = 0;
            Number rotSpeed = 0.1;
            Animation anim;
            interval = Window.SetInterval(delegate()
            {
                if (n == text.Length)
                {
                    Window.ClearInterval(interval);
                }
                else
                {   
                    textpath.setText(text.Substring(0, n++));
                }
            }, 1000 / 10);

            // animation
            anim = new Animation((Action<Frame>)delegate(Frame frame)
            {
                textpath.rotate(2 * Math.PI * rotSpeed * frame.timeDiff / 1000);
            }, layer);

            anim.start();

            // transition
            textpath.transitionTo(new TransitionConfig(
                "easing", "ease-in-out",
                "scale", new Vector(
                    "x", 2,
                    "y", 2)));

            return layer;
        }
    }
}
