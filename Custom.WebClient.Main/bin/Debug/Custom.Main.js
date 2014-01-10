// Custom.Main.js
(function($){
Type.registerNamespace('Custom');Custom.Application=function(){}
Custom.Application.registerClass('Custom.Application');Custom.Application.apiRoot='www.easeaccess.org/';Custom.Application.module=null;Custom.Application.controller=null;Custom.Application.service=null;(function(){define('angular',function($p1_0){
Custom.Application.module=$p1_0.module('Main',[],function($p2_0){
$p2_0.factory('Contact',function($p3_0){
return $p3_0(Custom.Application.apiRoot+'api/contact/:id',{},{update:{method:'PUT'}});});$p2_0.factory('Circle',function($p3_0){
return $p3_0(Custom.Application.apiRoot+'api/circle/:id',{},{update:{method:'PUT'}});});$p2_0.factory('Message',function($p3_0){
return $p3_0(Custom.Application.apiRoot+'api/message/:id',{},{update:{method:'PUT'}});});});Custom.Application.controller=Custom.Application.module.controller('Main',function($p2_0,$p2_1,$p2_2){
$p2_0.greeting='Hello!';var $2_0=function(){
};$p2_0.$on('$routeChangeSuccess',function($p3_0){
return null;});});Custom.Application.service=$p1_0.module('Custom.Service',[]).value('greeter',{salutation:'Hello',localize:function($p2_0){
}});});})();
})(jQuery);// This script was generated using Script# v0.7.4.0
