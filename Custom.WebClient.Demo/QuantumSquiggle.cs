// QuantumSquiggle.cs
//

using System;
using System.Collections.Generic;
using AngularApi;
using Kinetic;

namespace Custom
{
    /// <summary>
    /// HTML5 Canvas Quantum Squiggle with KineticJS
    /// </summary>
    public class QuantumSquiggle : KineticDemo
    {
        private static AngularModule _controller;

        public override AngularModule GetController(AngularModule module)
        {
            if (_controller != null)
                return _controller;

            _controller = module.controller("QuantumSquiggle", (System.Action)delegate()
            {
            });

            return _controller;
        }

        protected override Layer KineticInitialize(Number stageWidth, Number stageHeight)
        {
            Layer layer = new Layer(new LayerConfig());

            return layer;
        }
    }
}
