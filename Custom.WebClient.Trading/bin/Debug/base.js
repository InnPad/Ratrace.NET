// base.js
(function($){
Type.registerNamespace('Custom');Custom.DateHelper=function(){}
Custom.DateHelper.getDayOffset=function(from,to){var $0=from.getTime();var $1=to.getTime();var $2=$1-$0;var $3=$2/(24*60*60*1000);return $3;}
Custom.DateHelper.date=function(offset){var $0=new Date(offset);var $1=$0.toISOString();return $1.substr(0,$1.indexOf('T'));}
Support=function(){}
Support.get_browser=function(){return Support.$0;}
Support.get_radialGradient=function(){return Support.$1;}
Support.set_radialGradient=function(value){Support.$1=value;return value;}
Support.reset=function(){var $0=window.navigator.userAgent;var $1=window.navigator.appVersion;var $2=window.navigator.platform;if($0.indexOf('Chrome')>0){Support.$0='Chrome';Support.$1=false;}else if($0.indexOf('MSIE 9.0')>0){Support.$0='IE9';Support.$1=true;}else if($0.indexOf('MSIE 8.0')>0){Support.$0='IE8';Support.$1=false;}else if($0.indexOf('MSIE 7.0')>0){Support.$0='IE7';Support.$1=false;}else if($0.indexOf('MSIE 6.0')>0){Support.$0='IE6';Support.$1=false;}else if($0.indexOf('Firefox')>0){Support.$1=true;}else{Support.$1=false;}}
Custom.DateHelper.registerClass('Custom.DateHelper');Support.registerClass('Support');Support.$0=null;Support.$1=false;})(jQuery);// This script was generated using Script# v0.7.4.0
