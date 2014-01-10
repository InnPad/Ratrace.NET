// AngularGlobal.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AngularApi;
using jQueryApi;
using Window = System.Html.Window;

[Mixin(""), Imported, GlobalMethods, ScriptName("window")]
public class AngularGlobal
{
    public static AngularStatic angular;

    [ScriptName("$anchorScroll")]
    public static void AnchorScroll() { }

    [ScriptName("$cacheFactory")]
    public Cache CacheFactory(string cacheId, Object options) { return null; }

    [ScriptName("$cacheFactory"), AlternateSignature]
    public Cache CacheFactory(string cacheId) { return null; }

    [ScriptName("$templateCache")]
    public Cache TemplateCache;

    // TODO: $compile
    [ScriptName("$controllerProvider")]
    public Provider ControllerProvider;

    [ScriptName("$controller")]
    public Object Controller(Delegate constructor, Object locals) { return null; }

    [ScriptName("$controller")]
    public Object Controller(string constructor, Object locals) { return null; }

    [ScriptName("$document")]
    public jQueryObject Document;

    [ScriptName("$exceptionHandler")]
    public void ExceptionHandler(Exception exception, string cause) { }

    [ScriptName("$exceptionHandler"), AlternateSignature]
    public void ExceptionHandler(Exception exception) { }

    [ScriptName("$filterProvider")]
    public Provider FilterProvider;

    [ScriptName("$filter")]
    Delegate Filter(string name) { return null; }

    [ScriptName("$http")]
    public Http Http;

    [ScriptName("$interpolateProvider")]
    public InterpolateProvider InterpolateProvider;

    [ScriptName("$interpolate")]
    Interpolate Interpolate;

    [ScriptName("$locale")]
    public string Locale;

    [ScriptName("$location")]
    public Location Location;

    [ScriptName("$locationProvider")]
    LocationProvider LocationProvider;

    [ScriptName("$log")]
    public Log Log;

    [ScriptName("$parse")]
    public Func<Object /*context*/, Object /*locals*/, object> Parse(string expression) { return null; }

    [ScriptName("$q")]
    public DeferredFactory Q;

    [ScriptName("$rootElement")]
    jQueryObject RootElement;

    [ScriptName("$rootScopeProvider")]
    public ScopeProvider RootScopeProvider;

    [ScriptName("$rootScope")]
    public Scope RootScope;

    [ScriptName("$routeProvider")]
    public RouteProvider RouteProvider;

    [ScriptName("$route")]
    public RouteStatic Route;

    [ScriptName("$routeParams")]
    public Object RouteParams;

    [ScriptName("$timeout")]
    public Timeout Timeout;

    [ScriptName("$window")]
    public Window Window;

    [ScriptName("$cookies")]
    public Cookies Cookies;

    [ScriptName("$cookieStore")]
    public CookieStore CookieStore;

    [ScriptName("$resource")]
    public Resource Resource(string url, Object paramDefaults, ActionHash actions) { return null; }

    [AlternateSignature]
    public Resource Resource(string url, Object paramDefaults) { return null; }

    [AlternateSignature]
    public Resource Resource(string url) { return null; }

    [ScriptName("$sanitize")]
    public string Sanitize(string html) { return null; }
}
