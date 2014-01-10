// KineticDemo.cs
//

using System;
using System.Collections.Generic;
using System.Html;
using jQueryApi;
using Kinetic;

namespace Custom
{
    /// <summary>
    /// HTML5 canvas demo with KineticJS
    /// </summary>
    public abstract class KineticDemo : Demo
    {
        protected static Layer _layer;
        private Stage _stage;
        private bool _ownsStage;

        public override void Initialize(string container)
        {
            jQueryObject el = jQuery.FromElement(Document.GetElementById(container));

            Number stageWidth = el.GetWidth();
            Number stageHeight = el.GetHeight();

            _stage = new Stage(new StageConfig(
                "container", container,
                "width", stageWidth,
                "height", stageHeight));

            _layer = new Layer(new LayerConfig());

            _stage.add(_layer);
        }

        public void TransitionFrom(KineticDemo _previous)
        {
            _previous._ownsStage = false;
            _ownsStage = true;

            _layer = new Layer(new LayerConfig());

            _stage.add(_layer);
        }

        public override void Dispose()
        {
            if (_ownsStage)
            {
            }
        }

        protected abstract Layer KineticInitialize(Number stageWidth, Number stageHeight);
    }
}
