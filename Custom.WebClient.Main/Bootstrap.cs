// Bootstrap.cs
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;
using AngularApi;
using RequireApi;
using jQueryApi;
using Custom;

[Mixin(null), GlobalMethods]
static class Bootstrap
{
    static Bootstrap()
    {
        Script.Literal("'use strict'");

        // Patch for jquery mobile to transparently lookup non existing embedded pages
        // as external pages with the suffix .html.
        /*RequireGlobal.Define(new string [] { "jquery.mobile", "jquery.mobile-adapter", }, (System.Action)delegate() {
             MobileGlobal.Mobile.OriginalLoadPage = MobileGlobal.Mobile.LoadPage;
             MobileGlobal.Mobile.LoadPage = (Func<string, LoadPageOptions, object>)delegate(string url, LoadPageOptions options)
             {
                 string[] match = url.Match(new RegularExpression(@"/#(\w+)/"));
                 if ((bool)(object)match) {
                     string pageId = match[1];
                     Element page = Document.GetElementById(pageId);
                     if (!(bool)(object)page || jQuery.FromObject(page).Is(":jqmData(external-page='true')")) {
                         url = pageId + ".html";
                     }
                 }
                 return MobileGlobal.Mobile.OriginalLoadPage(url, options);
             };
        });*/

        Presentation.Initialize();

        jQuery.Select("body")
            .Bind("pageshow", delegate(jQueryEvent e)
            {
                Demo.OnPageShow(e);
                About.OnPageShow(e);
            });

        RequireGlobal.Define(new string[] { "angular" }, (Action<AngularStatic>)delegate(AngularStatic angular)
        {
            Main.Controllers = angular.module("main.controllers", new string[] { });

            Main.Application = angular.module("main", new string[] { "main.controllers" }, new object[] { "$provide", (Action<AngularModule>)delegate(AngularModule provide)
            {
                provide.Factory("contact", (Delegate)(Func<Func<string, Object, ActionHash, Resource>, Resource>)delegate(Func<string, Object, ActionHash, Resource> resource)
                {
                    return resource(Main.ApiRoot + "api/contact/:id", new Dictionary(), new ActionHash(
                        "update", new AngularApi.Action("method", "PUT")
                        ));
                });

                provide.Factory("circle", (Delegate)(Func<Func<string, Object, ActionHash, Resource>, Resource>)delegate(Func<string, Object, ActionHash, Resource> resource)
                {
                    return resource(Main.ApiRoot + "api/circle/:id", new Dictionary(), new ActionHash(
                        "update", new AngularApi.Action("method", "PUT")
                        ));
                });

                provide.Factory("message", (Delegate)(Func<Func<string, Object, ActionHash, Resource>, Resource>)delegate(Func<string, Object, ActionHash, Resource> resource)
                {
                    return resource(Main.ApiRoot + "api/message/:id", new Dictionary(), new ActionHash(
                        "update", new AngularApi.Action("method", "PUT")
                        ));
                });
            }});

            Main.Home = Main.Controllers.controller("main.home", new object[] { "$scope", "$route", "$routeParams", (Action<MainScope, RouteStatic, RouteMap>)delegate(MainScope scope, RouteStatic route, RouteMap routeParams)
            {
                scope.greeting = "Hello!";
                scope.searchTheme = "a";
                scope.toggleSearch = (Action<jQueryEvent>)Demo.ToggleSearch;

                Presentation.Refresh(new RefreshOptions("resize", true));

                scope.goHome = (System.Action)delegate()
                {
                };

                scope.goDemo = (System.Action)delegate()
                {
                };

                scope.goAbout = (System.Action)delegate()
                {
                };

                System.Action render = delegate()
                {
                    //string renderAction = Script.Value(route.current.action, "");
                };

                scope.On("$routeChangeSuccess", (EventListenerCallback)delegate(jQueryEvent ev)
                {
                    return null;
                });
            }});

            Demo.DefineController(angular, Main.Controllers);

            //Main.Home.Inject = new string[] { "$scope", "$route", "$routeParams" };

            Main.Service = angular.module("Custom.Service", new string[] { }).value("greeter", new Greeter(
                "salutation", "Hello",
                "localize", (Action<AngularApi.Location>)delegate(AngularApi.Location location)
                {
                }/*,
                    "greet", delegate(string name)
                        {
                            return this.
                        }*/
                ));

            Main.Application.config(new object[] { "$routeProvider", "$locationProvider", (Action<RouteProvider, LocationProvider>)delegate (RouteProvider routeProvider, LocationProvider locationProvider) {

                // Typically when defining routes, you will map the route to a template to be rendered;
                // however, with nested navigation, you will probably need something something more complex.
                // In this case, we are mapping routes to render actions rather than a template.
                /*routeProvider
                    .when("/", new Route("templateUrl", "Home/Partial", "jqmOptions", new Dictionary("transition", "flip")))
                    .when("/Demo", new Route("templateUrl", "Demo/Partial", "jqmOptions", new Dictionary("transition", "flip")))
                    .when("/Remote", new Route("templateUrl", "Remote/Partial", "jqmOptions", new Dictionary("transition", "flip")))
                    .when("/About", new Route("templateUrl", "About/Partial", "jqmOptions", new Dictionary("transition", "flip")))
                    .otherwise(new Route("redirectTo", "/"));*/

                /*routeProvider.onChange(function () {
                    self.params = $scope.current.params;
                });

                routeProvider.parent(this);*/

                locationProvider.html5Mode(true);
            }});

            Main.Application.run((System.Action)delegate()
            {
                int a = 0;
            });
        });
    }
}
