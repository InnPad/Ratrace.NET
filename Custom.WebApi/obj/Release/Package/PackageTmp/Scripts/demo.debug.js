//! demo.debug.js
//

(function($) {

Type.registerNamespace('Custom');

////////////////////////////////////////////////////////////////////////////////
// Custom.Demo

Custom.Demo = function Custom_Demo() {
    /// <field name="_module" type="AngularModule" static="true">
    /// </field>
    /// <field name="cancel" type="Boolean">
    /// </field>
    /// <field name="title" type="String">
    /// </field>
    /// <field name="description" type="String">
    /// </field>
}
Custom.Demo.prototype = {
    cancel: false,
    title: null,
    description: null
}


////////////////////////////////////////////////////////////////////////////////
// Custom.ElasticStars

Custom.ElasticStars = function Custom_ElasticStars() {
    /// <summary>
    /// HTML5 canvas Elastic Stars with KineticJS
    /// </summary>
    /// <field name="_controller$2" type="AngularModule" static="true">
    /// </field>
    Custom.ElasticStars.initializeBase(this);
}
Custom.ElasticStars.prototype = {
    
    getController: function Custom_ElasticStars$getController(module) {
        /// <param name="module" type="AngularModule">
        /// </param>
        /// <returns type="AngularModule"></returns>
        return Custom.ElasticStars._controller$2;
    },
    
    kineticInitialize: function Custom_ElasticStars$kineticInitialize(stageWidth, stageHeight) {
        /// <param name="stageWidth" type="Number">
        /// </param>
        /// <param name="stageHeight" type="Number">
        /// </param>
        /// <returns type="Kinetic.Layer"></returns>
        var layer = new Kinetic.Layer({});
        for (var n = 0; n < 10; n++) {
            layer.add(this._addStar$2(stageWidth, stageHeight));
        }
        return layer;
    },
    
    _addStar$2: function Custom_ElasticStars$_addStar$2(maxWidth, maxHeight) {
        /// <param name="maxWidth" type="Number">
        /// </param>
        /// <param name="maxHeight" type="Number">
        /// </param>
        /// <returns type="Kinetic.Star"></returns>
        var trans = null;
        var scale = Math.random();
        var star = new Kinetic.Star({ x: Math.random() * maxWidth, y: Math.random() * maxHeight, numPoints: 5, innerRadius: 50, outerRadius: 100, fill: '#1e4705', stroke: '#89b717', opacity: 0.9, strokeWidth: 10, draggable: true, scale: scale, rotationDeg: Math.random() * 180, shadowColor: 'black', shadowBlur: 10, shadowOffset: new Custom.Vector('X', 5, 'y', 5), shadowOpacity: 0.6, startScale: scale });
        star.on('dragstart', function() {
            if (trans) {
                trans.stop();
            }
            star.setAttrs({ shadowOffset: new Custom.Vector('x', 15, 'y', 15), scale: new Custom.Vector('x', star.attrs.startScale * 1.2, 'y', star.attrs.startScale * 1.2) });
            star.on('dragend', function() {
                trans = star.transitionTo({ duration: 0.5, easing: 'elastic-ease-out', scale: new Custom.Vector('x', star.attrs.startScale, 'y', star.attrs.startScale), shadowOffset: new Custom.Vector('x', 5, 'y', 5) });
            });
        });
        return star;
    }
}


////////////////////////////////////////////////////////////////////////////////
// Custom.QuantumSquiggle

Custom.QuantumSquiggle = function Custom_QuantumSquiggle() {
    /// <summary>
    /// HTML5 Canvas Quantum Squiggle with KineticJS
    /// </summary>
    /// <field name="_controller$2" type="AngularModule" static="true">
    /// </field>
    Custom.QuantumSquiggle.initializeBase(this);
}
Custom.QuantumSquiggle.prototype = {
    
    getController: function Custom_QuantumSquiggle$getController(module) {
        /// <param name="module" type="AngularModule">
        /// </param>
        /// <returns type="AngularModule"></returns>
        if (Custom.QuantumSquiggle._controller$2 != null) {
            return Custom.QuantumSquiggle._controller$2;
        }
        Custom.QuantumSquiggle._controller$2 = module.controller('QuantumSquiggle', function() {
        });
        return Custom.QuantumSquiggle._controller$2;
    },
    
    kineticInitialize: function Custom_QuantumSquiggle$kineticInitialize(stageWidth, stageHeight) {
        /// <param name="stageWidth" type="Number">
        /// </param>
        /// <param name="stageHeight" type="Number">
        /// </param>
        /// <returns type="Kinetic.Layer"></returns>
        var layer = new Kinetic.Layer({});
        return layer;
    }
}


////////////////////////////////////////////////////////////////////////////////
// Custom.ScatterPlot

Custom.ScatterPlot = function Custom_ScatterPlot() {
    /// <summary>
    /// HTML5 Canvas Scatter Plot with KineticJS
    /// </summary>
    /// <field name="_controller$2" type="AngularModule" static="true">
    /// </field>
    Custom.ScatterPlot.initializeBase(this);
}
Custom.ScatterPlot.prototype = {
    
    getController: function Custom_ScatterPlot$getController(module) {
        /// <param name="module" type="AngularModule">
        /// </param>
        /// <returns type="AngularModule"></returns>
        if (Custom.ScatterPlot._controller$2 != null) {
            return Custom.ScatterPlot._controller$2;
        }
        Custom.ScatterPlot._controller$2 = module.controller('ScatterPlot', function() {
        });
        return Custom.ScatterPlot._controller$2;
    },
    
    kineticInitialize: function Custom_ScatterPlot$kineticInitialize(stageWidth, stageHeight) {
        /// <param name="stageWidth" type="Number">
        /// </param>
        /// <param name="stageHeight" type="Number">
        /// </param>
        /// <returns type="Kinetic.Layer"></returns>
        var layer = new Kinetic.Layer({});
        return layer;
    }
}


////////////////////////////////////////////////////////////////////////////////
// Custom.TextSpiral

Custom.TextSpiral = function Custom_TextSpiral() {
    /// <summary>
    /// HTML5 canvas Text Spiral with KineticJS
    /// </summary>
    /// <field name="_controller$2" type="AngularModule" static="true">
    /// </field>
    Custom.TextSpiral.initializeBase(this);
}
Custom.TextSpiral.prototype = {
    
    getController: function Custom_TextSpiral$getController(module) {
        /// <param name="module" type="AngularModule">
        /// </param>
        /// <returns type="AngularModule"></returns>
        if (Custom.TextSpiral._controller$2 != null) {
            return Custom.TextSpiral._controller$2;
        }
        Custom.TextSpiral._controller$2 = module.controller('TextSpiral', function() {
        });
        return Custom.TextSpiral._controller$2;
    },
    
    kineticInitialize: function Custom_TextSpiral$kineticInitialize(stageWidth, stageHeight) {
        /// <param name="stageWidth" type="Number">
        /// </param>
        /// <param name="stageHeight" type="Number">
        /// </param>
        /// <returns type="Kinetic.Layer"></returns>
        var layer = new Kinetic.Layer({});
        var textpath = new Kinetic.TextPath({ x: stageWidth / 2, y: stageHeight / 2, fill: '#333', fontSize: '6', fontFamily: 'Arial', text: '', data: 'M153 334 C153 334 151 334 151 334 C151 339 153 344 156 344 C164 344 171 339 171 334 C171 322 164 314 156 314 C142 314 131 322 131 334 C131 350 142 364 156 364 C175 364 191 350 191 334 C191 311 175 294 156 294 C131 294 111 311 111 334 C111 361 131 384 156 384 C186 384 211 361 211 334 C211 300 186 274 156 274', scale: 1, offset: new Custom.Vector('x', 153, 'y', 334), opacity: 0.8 });
        layer.add(textpath);
        var text = "All the world's a stage, and all the men and women merely players. They have their exits and their entrances; And one man in his time plays many parts.";
        var n = 0, interval = 0;
        var rotSpeed = 0.1;
        var anim;
        interval = window.setInterval(function() {
            if (n === text.length) {
                window.clearInterval(interval);
            }
            else {
                textpath.setText(text.substring(0, n++));
            }
        }, 1000 / 10);
        anim = new Kinetic.Animation(function(frame) {
            textpath.rotate(2 * Math.PI * rotSpeed * frame.timeDiff / 1000);
        }, layer);
        anim.start();
        textpath.transitionTo({ easing: 'ease-in-out', scale: new Custom.Vector('x', 2, 'y', 2) });
        return layer;
    }
}


////////////////////////////////////////////////////////////////////////////////
// Custom.TextWave

Custom.TextWave = function Custom_TextWave() {
    /// <summary>
    /// HTML5 Canvas Text Wave with KineticJS
    /// </summary>
    /// <field name="_controller$2" type="AngularModule" static="true">
    /// </field>
    Custom.TextWave.initializeBase(this);
}
Custom.TextWave.prototype = {
    
    getController: function Custom_TextWave$getController(module) {
        /// <param name="module" type="AngularModule">
        /// </param>
        /// <returns type="AngularModule"></returns>
        return Custom.TextWave._controller$2;
    },
    
    kineticInitialize: function Custom_TextWave$kineticInitialize(stageWidth, stageHeight) {
        /// <param name="stageWidth" type="Number">
        /// </param>
        /// <param name="stageHeight" type="Number">
        /// </param>
        /// <returns type="Kinetic.Layer"></returns>
        var layer = new Kinetic.Layer({});
        return layer;
    }
}


////////////////////////////////////////////////////////////////////////////////
// Custom.FortuneWheel

Custom.FortuneWheel = function Custom_FortuneWheel() {
    /// <summary>
    /// HTML5 Canvas Wheel of Fortune with KineticJS
    /// </summary>
    /// <field name="_controller$2" type="AngularModule" static="true">
    /// </field>
    Custom.FortuneWheel.initializeBase(this);
}
Custom.FortuneWheel.prototype = {
    
    getController: function Custom_FortuneWheel$getController(module) {
        /// <param name="module" type="AngularModule">
        /// </param>
        /// <returns type="AngularModule"></returns>
        return Custom.FortuneWheel._controller$2;
    },
    
    kineticInitialize: function Custom_FortuneWheel$kineticInitialize(stageWidth, stageHeight) {
        /// <param name="stageWidth" type="Number">
        /// </param>
        /// <param name="stageHeight" type="Number">
        /// </param>
        /// <returns type="Kinetic.Layer"></returns>
        var layer = new Kinetic.Layer({});
        return layer;
    }
}


////////////////////////////////////////////////////////////////////////////////
// Custom.KineticDemo

Custom.KineticDemo = function Custom_KineticDemo() {
    /// <summary>
    /// HTML5 canvas demo with KineticJS
    /// </summary>
    /// <field name="_layer" type="Kinetic.Layer" static="true">
    /// </field>
    /// <field name="_stage$1" type="Kinetic.Stage">
    /// </field>
    /// <field name="_ownsStage$1" type="Boolean">
    /// </field>
    Custom.KineticDemo.initializeBase(this);
}
Custom.KineticDemo.prototype = {
    _stage$1: null,
    _ownsStage$1: false,
    
    initialize: function Custom_KineticDemo$initialize(container) {
        /// <param name="container" type="String">
        /// </param>
        var el = $(document.getElementById(container));
        var stageWidth = el.width();
        var stageHeight = el.height();
        this._stage$1 = new Kinetic.Stage({ container: container, width: stageWidth, height: stageHeight });
        Custom.KineticDemo._layer = new Kinetic.Layer({});
        this._stage$1.add(Custom.KineticDemo._layer);
    },
    
    transitionFrom: function Custom_KineticDemo$transitionFrom(_previous) {
        /// <param name="_previous" type="Custom.KineticDemo">
        /// </param>
        _previous._ownsStage$1 = false;
        this._ownsStage$1 = true;
        Custom.KineticDemo._layer = new Kinetic.Layer({});
        this._stage$1.add(Custom.KineticDemo._layer);
    },
    
    dispose: function Custom_KineticDemo$dispose() {
        if (this._ownsStage$1) {
        }
    }
}


////////////////////////////////////////////////////////////////////////////////
// Custom.OscillatingBlobs

Custom.OscillatingBlobs = function Custom_OscillatingBlobs() {
    /// <summary>
    /// HTML5 canvas Oscillating Blobs with KineticJS
    /// </summary>
    /// <field name="_controller$2" type="AngularModule" static="true">
    /// </field>
    Custom.OscillatingBlobs.initializeBase(this);
}
Custom.OscillatingBlobs.prototype = {
    
    getController: function Custom_OscillatingBlobs$getController(module) {
        /// <param name="module" type="AngularModule">
        /// </param>
        /// <returns type="AngularModule"></returns>
        return Custom.OscillatingBlobs._controller$2;
    },
    
    kineticInitialize: function Custom_OscillatingBlobs$kineticInitialize(stageWidth, stageHeight) {
        /// <param name="stageWidth" type="Number">
        /// </param>
        /// <param name="stageHeight" type="Number">
        /// </param>
        /// <returns type="Kinetic.Layer"></returns>
        var layer = new Kinetic.Layer({});
        var colors = [ 'red', 'orange', 'yellow', 'green', 'blue', 'purple' ];
        var blobs = [];
        for (var n = 0; n < 6; n++) {
            var points = [];
            for (var i = 0; i < 5; i++) {
                points.add({ x: stageWidth * Math.random(), y: stageHeight * Math.random() });
            }
            var blob = new Kinetic.Blob({ points: points, fill: colors[n], stroke: 'black', strokeWidth: 2, tension: 0, opacity: Math.random(), draggable: true });
            layer.add(blob);
            blobs.add(blob);
        }
        var period = 2000;
        var centerTension = 0;
        var amplitude = 1;
        var anim = new Kinetic.Animation(function(frame) {
            for (var n = 0; n < blobs.length; n++) {
                blobs[n].setTension(amplitude * Math.sin(frame.time * 2 * Math.PI / period) + centerTension);
            }
        }, layer);
        anim.start();
        return layer;
    }
}


Custom.Demo.registerClass('Custom.Demo', null, ss.IDisposable);
Custom.KineticDemo.registerClass('Custom.KineticDemo', Custom.Demo);
Custom.ElasticStars.registerClass('Custom.ElasticStars', Custom.KineticDemo);
Custom.QuantumSquiggle.registerClass('Custom.QuantumSquiggle', Custom.KineticDemo);
Custom.ScatterPlot.registerClass('Custom.ScatterPlot', Custom.KineticDemo);
Custom.TextSpiral.registerClass('Custom.TextSpiral', Custom.KineticDemo);
Custom.TextWave.registerClass('Custom.TextWave', Custom.KineticDemo);
Custom.FortuneWheel.registerClass('Custom.FortuneWheel', Custom.KineticDemo);
Custom.OscillatingBlobs.registerClass('Custom.OscillatingBlobs', Custom.KineticDemo);
Custom.Demo._module = null;
(function () {
    Custom.Demo._module = window.angular.module('main', [ 'main.controllers' ], [ '$provide', function(provide) {
    } ]);
})();
Custom.ElasticStars._controller$2 = null;
Custom.QuantumSquiggle._controller$2 = null;
Custom.ScatterPlot._controller$2 = null;
Custom.TextSpiral._controller$2 = null;
Custom.TextWave._controller$2 = null;
Custom.FortuneWheel._controller$2 = null;
Custom.KineticDemo._layer = null;
Custom.OscillatingBlobs._controller$2 = null;
})(jQuery);

//! This script was generated using Script# v0.7.4.0
