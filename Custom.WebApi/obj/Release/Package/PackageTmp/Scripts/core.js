// core.js
(function($){
$.fn.dateRangeSlider=function(customOptions){var $0={myOption:0};var $1=$.extend({},$0,customOptions);return this.each(function($p1_0,$p1_1){
});}
$.fn.rangeSlider=function(customOptions){var $0={myOption:0};var $1=$.extend({},$0,customOptions);return this.each(function($p1_0,$p1_1){
});}
Type.registerNamespace('Custom');Custom.Application=function(){}
Custom.DateRangeSlider=function(){}
Custom.DateRangeSlider.defineDirectives=function(angular,module){module.directive('dateRange',function(){
return {restrict:'A',link:function($p2_0,$p2_1,$p2_2,$p2_3){
$p2_0.slider.el=$p2_1;}};});module.directive('dateHigh',function(){
return {restrict:'A',link:function($p2_0,$p2_1,$p2_2,$p2_3){
$p2_1.on('change',function($p3_0){
$p2_0.$apply(function(){
var $4_0=$p2_1.val();var $4_1=Date.parseDate($4_0).getTime();$p2_0.slider.offset.high=$4_1;});});}};});module.directive('dateLow',function(){
return {restrict:'A',link:function($p2_0,$p2_1,$p2_2,$p2_3){
$p2_1.on('change',function($p3_0){
$p2_0.$apply(function(){
var $4_0=$p2_1.val();var $4_1=Date.parseDate($4_0).getTime();$p2_0.slider.offset.low=$4_1;});});}};});module.directive('offsetHigh',function(){
return {restrict:'A',link:function($p2_0,$p2_1,$p2_2,$p2_3){
$p2_0.slider.highEl=$p2_1;$p2_1.on('create',function($p3_0){
var $3_0=0;});$p2_1.on('slidestart',function($p3_0){
$p2_0.$apply(function(){
var $4_0=0;});});$p2_1.on('change',function($p3_0){
$p2_0.$apply(function(){
var $4_0=$p2_1.val();var $4_1=parseInt($4_0);$p2_0.slider.date.high=Custom.DateHelper.date($4_1);if($p2_0.slider.lowEl){$p2_0.slider.lowEl.attr('max',$4_1);}});});$p2_1.on('slidestop',function($p3_0){
$p2_0.$apply(function(){
if($p2_0.slider.lowEl){$p2_0.slider.lowEl.slider({max:$p2_0.slider.offset.high});$p2_0.slider.lowEl.slider('refresh');}});});}};});module.directive('offsetLow',function(){
return {restrict:'A',link:function($p2_0,$p2_1,$p2_2,$p2_3){
$p2_0.slider.lowEl=$p2_1;$p2_1.on('slidestart',function($p3_0){
$p2_0.$apply(function(){
var $4_0=0;});});$p2_1.on('change',function($p3_0){
$p2_0.$apply(function(){
var $4_0=$p2_1.val();var $4_1=parseInt($4_0);$p2_0.slider.date.low=Custom.DateHelper.date($4_1);if($p2_0.slider.highEl){$p2_0.slider.highEl.attr('min',$4_1);}});});$p2_1.on('slidestop',function($p3_0){
$p2_0.$apply(function(){
if($p2_0.slider.highEl){$p2_0.slider.highEl.slider({min:$p2_0.slider.offset.low});$p2_0.slider.highEl.slider('refresh');}});});}};});}
Custom.Presentation=function(){}
Custom.Presentation.changeOrientation=function(orientation){Custom.Presentation.orientation=orientation;}
Custom.Presentation.initialize=function(){$('body').bind('hideOpenMenus',Custom.Presentation.$0).bind('scrollstart',Custom.Presentation.$3).bind('scrollstop',Custom.Presentation.$4).bind('orientationchange',Custom.Presentation.$1).bind('pageshow',Custom.Presentation.$2).trigger('orientationchange');$(window.self).bind('resize',Custom.Presentation.$5);Custom.Presentation.refresh({resize:true});}
Custom.Presentation.isHeader=function(el){var $0=false;el.each(function($p1_0,$p1_1){
switch($p1_1.tagName){case 'H1':case 'H2':case 'H3':case 'H4':case 'H5':$0=true;return false;default:return true;}});return $0;}
Custom.Presentation.isInline=function(el){var $0=false;el.each(function($p1_0,$p1_1){
switch($p1_1.tagName){case 'INPUT':$0=true;return false;default:return true;}});return $0;}
Custom.Presentation.isFit=function(element){switch(element.tagName){case 'DIV':case 'CANVAS':return true;default:return false;}}
Custom.Presentation.$0=function($p0){$("ul:jqmData(role='menu')").find('li > ul').hide();}
Custom.Presentation.$1=function($p0){Custom.Presentation.changeOrientation($p0.orientation);}
Custom.Presentation.$2=function($p0){Custom.Presentation.refresh({resize:true});}
Custom.Presentation.$3=function($p0){alert('ScrollStart');}
Custom.Presentation.$4=function($p0){alert('ScrollEnd');}
Custom.Presentation.$5=function($p0){Custom.Presentation.refresh({resize:true});}
Custom.Presentation.refresh=function(options){Custom.Presentation.windowSize.height=window.outerHeight;Custom.Presentation.windowSize.width=window.outerWidth;Custom.Presentation.pageSize.height=window.innerHeight;Custom.Presentation.pageSize.width=window.innerWidth;if(options.resize){options.resize=Custom.Presentation.pageSize;}$('div[data-role=page].ui-page-active').each(function($p1_0,$p1_1){
var $1_0=$($p1_1);$1_0.css('height',Custom.Presentation.pageSize.height+'px');var $1_1=$1_0.children('.ui-content');if($1_1.hasClass('wave-height')){var $1_2=$1_0.height()-$1_1.position().top;var $1_3=$1_0.children('.ui-header');var $1_4=$1_0.children('.ui-footer');if($1_4.attr('data-position')==='fixed'){$1_2-=$1_4.outerHeight(true);}Custom.Presentation.waveHeight($1_1,$1_2);}if($1_1.hasClass('wave-width')){Custom.Presentation.waveWidth($1_1,Custom.Presentation.pageSize.width);}});}
Custom.Presentation.draw=function(data){var $0=data['draw'];if($0!=null&&typeof($0)==='function'){$0.call(data);return true;}return false;}
Custom.Presentation.setHeight=function(data,height){var $0=data['setHeight'];if($0!=null&&typeof($0)==='function'){$0.call(data,height);return true;}return false;}
Custom.Presentation.setWidth=function(data,width){var $0=data['setWidth'];if($0!=null&&typeof($0)==='function'){$0.call(data,width);return true;}return false;}
Custom.Presentation.waveHeight=function(el,height){var $0=el.offset();el.css('height',height+'px');if(el.attr('height')){el.removeAttr('height');}height=el.height();var $1=el.children();var $2=$1.filter(function($p1_0){
var $1_0=$(this);if((Custom.Presentation.isFit($1[$p1_0])&&!$(this).hasClass('dont-wave-height')||$1_0.hasClass('wave-height'))){return true;}height-=Math.max($1_0.outerHeight(false),$1_0.outerHeight(true),$1_0.height());return false;});if($2.length>0){var $4=$2.filter(function($p1_0){
var $1_0=$(this).css('position');switch($1_0){case 'absolute':return false;case 'fixed':return false;default:return true;}});$4.each(function($p1_0,$p1_1){
var $1_0=$($p1_1);Custom.Presentation.waveHeight($1_0,height/$4.length);});$2.each(function($p1_0,$p1_1){
var $1_0=$($p1_1);var $1_1=$1_0.css('position');switch($1_1){case 'absolute':Custom.Presentation.waveHeight($1_0,height);break;case 'fixed':el.css('top',$0.top+'px');Custom.Presentation.waveHeight($1_0,height);break;}});}var $3=el.data();Object.keys($3).forEach(function($p1_0){
Custom.Presentation.setHeight($3[$p1_0],height);Custom.Presentation.draw($3);});}
Custom.Presentation.waveWidth=function(el,width){el.css('width',width+'px');if(el.attr('width')){el.removeAttr('width');}el.children().each(function($p1_0,$p1_1){
var $1_0=$($p1_1);if(!$1_0.hasClass('dont-wave-width')){Custom.Presentation.waveWidth($1_0,width);}});var $0=el.data();Object.keys($0).forEach(function($p1_0){
Custom.Presentation.setWidth($0[$p1_0],width);Custom.Presentation.draw($0);});}
Custom.Application.registerClass('Custom.Application');Custom.DateRangeSlider.registerClass('Custom.DateRangeSlider');Custom.Presentation.registerClass('Custom.Presentation');Custom.Presentation.windowSize={};Custom.Presentation.pageSize={};Custom.Presentation.orientation='landscape';})(jQuery);// This script was generated using Script# v0.7.4.0
