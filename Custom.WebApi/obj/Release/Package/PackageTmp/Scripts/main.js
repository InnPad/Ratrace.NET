
Type.registerNamespace('Custom');Custom.SymbolPager=function(symbols){this.$0=symbols;}
Custom.SymbolPager.prototype={$0:null,loadMode:function(){var $0={type:'GET',url:'api/symbols',dataType:'json',success:ss.Delegate.create(this,function($p1_0,$p1_1,$p1_2){
var $1_0=$p1_0;for(var $1_1=0;$1_1<$1_0.length;$1_1++){this.$0.add($1_0[$1_1]);}}),error:function($p1_0,$p1_1,$p1_2){
var $1_0=0;}};$.ajax($0);}}
Custom.About=function(){}
Custom.About.onPageShow=function(e){$('#about-page[data-role=page]').each(function($p1_0,$p1_1){
var $1_0=$($p1_1);var $1_1=$1_0.children('[data-role=content]');if(!$1_1.data('Custom.Stage')){require(['draw','kinetic'],function(){
$1_1.atom({electrons:['Images/tradestation_thumb.jpg','Images/angular_thumb.png','Images/kinetic_thumb.jpg','Images/jquerymobile_thumb.png','Images/scriptsharp_thumb.png','Images/typescript_thumb.png','Images/sencha_thumb.png','Images/odata_thumb.png','Images/sqlserver_thumb.png','Images/servicestack_thumb.png','Images/signalr_thumb.jpg','Images/titanium_thumb.png','Images/twitter_thumb.png','Images/jquery_thumb.png','Images/dotnet_thumb.png','Images/facebook_thumb.png','Images/css3_thumb.png','Images/html5_thumb.png','Images/feed_thumb.png','Images/silverlight_thumb.png','Images/appcelerator_thumb.png','Images/android_thumb.png','Images/apple_thumb.png','Images/backbone_thumb.png','Images/chrome_thumb.png','Images/firefox_thumb.png','Images/googlemaps_thumb.png','Images/ie10_thumb.png','Images/java_thumb.png','Images/mono_thumb.png','Images/phone7_thumb.png','Images/phonegap_thumb.png','Images/sap_thumb.png','Images/windows_thumb.png','Images/wpf_thumb.png']});});window.setTimeout(function(){
Custom.Presentation.refresh({resize:true});},100);}return false;});}
Custom.Demo=function(){}
Custom.Demo.defineController=function(angular,module){Custom.DateRangeSlider.defineDirectives(angular,module);return Custom.Demo.demo=module.controller('demo',['$scope','$route','$routeParams',function($p1_0,$p1_1,$p1_2){
$p1_0.symbols=(Custom.Demo.$0||[]);$p1_0.pager=new Custom.SymbolPager($p1_0.symbols);var $1_0=Date.get_today().getTime();var $1_1=86400000;var $1_2=365*$1_1;var $1_3=7*$1_1;var $1_4={min:$1_0-$1_2,max:$1_0,low:$1_0-2*$1_3,high:$1_0-$1_3};$p1_0.slider={offset:$1_4,date:{low:Custom.DateHelper.date($1_4.low),high:Custom.DateHelper.date($1_4.high)}};var $1_5={type:'GET',url:'api/symbols',dataType:'json',success:function($p2_0,$p2_1,$p2_2){
Custom.Demo.$0=$p2_0;for(var $2_0=0;$2_0<Custom.Demo.$0.length;$2_0++){$p1_0.symbols.add(Custom.Demo.$0[$2_0]);}},error:function($p2_0,$p2_1,$p2_2){
var $2_0=0;}};$.ajax($1_5);$p1_0.greeting='Hello!';$p1_0.searchTheme='a';$p1_0.toggleSearch=Custom.Demo.toggleSearch;$p1_0.$on('$routeChangeSuccess',function($p2_0){
return null;});}]);}
Custom.Demo.onPageShow=function(e){$('#demo-page[data-role=page]').each(function($p1_0,$p1_1){
var $1_0=$($p1_1);var $1_1=$1_0.children('[data-role=content]');if(!$1_1.data('Custom.Stage')){require(['trading','draw','kinetic'],function(){
$1_1.candlestickChart({});});window.setTimeout(function(){
Custom.Presentation.refresh({resize:true});},100);}return false;});}
Custom.Demo.toggleSearch=function(e){var $0=$(e.target).parent('a').first();var $1=$('.floating-content');if($1.hasClass('hidden')){$1.removeClass('hidden');$0.removeClass('ui-btn-up-a');$0.addClass('ui-btn-up-f');}else{$1.addClass('hidden');$0.removeClass('ui-btn-up-f');$0.addClass('ui-btn-up-a');}}
Custom.SymbolPager.registerClass('Custom.SymbolPager');Custom.About.registerClass('Custom.About');Custom.Demo.registerClass('Custom.Demo');(function(){'use strict';Custom.Presentation.initialize();$('body').bind('pageshow',function($p1_0){
Custom.Demo.onPageShow($p1_0);Custom.About.onPageShow($p1_0);});define(['angular'],function($p1_0){
window.mainControllers=$p1_0.module('main.controllers',[]);window.mainModule=$p1_0.module('main',['main.controllers'],['$provide',function($p2_0){
$p2_0.factory('contact',function($p3_0){
return $p3_0(window.apiRoot+'api/contact/:id',{},{update:{method:'PUT'}});});$p2_0.factory('circle',function($p3_0){
return $p3_0(window.apiRoot+'api/circle/:id',{},{update:{method:'PUT'}});});$p2_0.factory('message',function($p3_0){
return $p3_0(window.apiRoot+'api/message/:id',{},{update:{method:'PUT'}});});}]);window.mainHome=window.mainControllers.controller('main.home',['$scope','$route','$routeParams',function($p2_0,$p2_1,$p2_2){
$p2_0.greeting='Hello!';$p2_0.searchTheme='a';$p2_0.toggleSearch=Custom.Demo.toggleSearch;Custom.Presentation.refresh({resize:true});$p2_0.goHome=function(){
};$p2_0.goDemo=function(){
};$p2_0.goAbout=function(){
};var $2_0=function(){
};$p2_0.$on('$routeChangeSuccess',function($p3_0){
return null;});}]);Custom.Demo.defineController($p1_0,window.mainControllers);window.mainService=$p1_0.module('Custom.Service',[]).value('greeter',{salutation:'Hello',localize:function($p2_0){
}});window.mainModule.config(['$routeProvider','$locationProvider',function($p2_0,$p2_1){
$p2_1.html5Mode(true);}]);window.mainModule.run(function(){
var $2_0=0;});});})();
Custom.Demo.$0=null;Custom.Demo.demo=null;