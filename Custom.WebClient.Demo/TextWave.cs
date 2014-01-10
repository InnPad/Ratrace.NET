// TextWave.cs
//

using System;
using System.Collections.Generic;
using AngularApi;
using Kinetic;

namespace Custom
{
    /// <summary>
    /// HTML5 Canvas Text Wave with KineticJS
    /// </summary>
    public class TextWave : KineticDemo
    {
        private static AngularModule _controller;

        public override AngularModule GetController(AngularModule module)
        {
            return _controller;
        }

        protected override Layer KineticInitialize(Number stageWidth, Number stageHeight)
        {
            Layer layer = new Layer(new LayerConfig());

            return layer;
        }
    }
}
