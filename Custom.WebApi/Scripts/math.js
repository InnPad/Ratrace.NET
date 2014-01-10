// math.js
(function($){
Type.registerNamespace('Custom');Custom.Epsilon=function(){}
Custom.PI=function(){}
Custom.GoldenRatio=function(){}
Custom.Pythagoras=function(){}
Custom.Epsilon.registerClass('Custom.Epsilon');Custom.PI.registerClass('Custom.PI');Custom.GoldenRatio.registerClass('Custom.GoldenRatio');Custom.Pythagoras.registerClass('Custom.Pythagoras');Custom.Epsilon.value=1E-10;Custom.PI.value=Math.PI;Custom.PI.twice=2*Custom.PI.value;Custom.PI.half=Custom.PI.value/2;Custom.GoldenRatio.value=(1+Math.sqrt(5))/2;Custom.GoldenRatio.inverse=1/Custom.GoldenRatio.value;Custom.Pythagoras.value=Math.sqrt(2);Custom.Pythagoras.half=Custom.Pythagoras.value/2;})(jQuery);// This script was generated using Script# v0.7.4.0
