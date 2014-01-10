// Demo.cs
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;
using AngularApi;
using jQueryApi;
using RequireApi;

namespace Custom
{
    public static class Demo
    {
        private static List<Symbol> _symbols;

        [ScriptName("demo")]
        public static AngularModule Controller;

        public static AngularModule DefineController(AngularStatic angular, AngularModule module)
        {
            DateRangeSlider.Init(angular, module);

            return Demo.Controller = module.controller("demo", new object[] { "$scope", /*"$provide",*/ "$route", "$routeParams", (Action<DemoScope, /*AngularModule,*/ RouteStatic, RouteMap>)delegate(DemoScope scope, /*AngularModule provide,*/ RouteStatic route, RouteMap routeParams)
            {
                scope.symbols = Script.Value(_symbols, new List<Symbol>());
                scope.pager = new SymbolPager(scope.symbols);

                /*jQuery.Select(".ui-range-slider").Plugin<SliderObject>().Slider(new SliderOptions(
                    "orientation", "horizontal",
                    "range", true,
                    "min", 0,
                    "max", 100,
                    "values", new long[] { 17, 67 },
                    "slide", (Action<jQueryEvent, object>)delegate(jQueryEvent ev, object ui) {
                    }));*/

                int today = Date.Today.GetTime();
                long aDay = 86400000;
                long aYear = 365 * aDay;
                long aWeek = 7 * aDay;
                OffsetRange offset = new OffsetRange("min", today - aYear, "max", today, "low", today - 2 * aWeek, "high", today - aWeek);
                scope.slider = new DateRangeSlider(new DateRangeSliderOptions(
                    "offset", offset,
                    "date", new DateRange(
                        "low", DateHelper.Date(offset.low),
                        "high", DateHelper.Date(offset.high))));

                jQueryAjaxOptions ajax = new jQueryAjaxOptions(
                    "type", "GET",
                    "url", "api/symbols",
                    "dataType", "json",
                    "success", (AjaxRequestCallback)delegate(object data, string textStatus, jQueryXmlHttpRequest request)
                    {
                        _symbols = (List<Symbol>)data;
                        for (int i = 0; i < _symbols.Count; i++)
                        {
                            scope.symbols.Add(_symbols[i]);
                        }
                        //scope.symbols.AddRange(_symbols);
                    },
                    "error", (AjaxErrorCallback)delegate(jQueryXmlHttpRequest request, string textStatus, Exception error)
                    {
                        int a = 0;
                    });

                jQuery.AjaxRequest<Symbol[]>(ajax);

                scope.greeting = "Hello!";
                scope.searchTheme = "a";
                scope.toggleSearch = (Action<jQueryEvent>)Demo.ToggleSearch;

                /*provide.Factory("symbol", (Delegate)(Func<Func<string, Object, ActionHash, Resource>, Resource>)delegate(Func<string, Object, ActionHash, Resource> resource)
                {
                    return resource(Main.ApiRoot + "api/symbols", new Dictionary(), new ActionHash());
                });

                provide.Factory("quote", (Delegate)(Func<Func<string, Object, ActionHash, Resource>, Resource>)delegate(Func<string, Object, ActionHash, Resource> resource)
                {
                    return resource(Main.ApiRoot + "api/quotes/:symbol", new Dictionary(), new ActionHash());
                });*/

                scope.On("$routeChangeSuccess", (EventListenerCallback)delegate(jQueryEvent ev)
                {
                    return null;
                });
            }});
        }

        public static void OnPageShow(jQueryEvent e)
        {
            jQuery.Select("#demo-page[data-role=page]").Each((ElementInterruptibleIterationCallback)delegate(int index, Element element)
            {
                jQueryObject pageEl = jQuery.FromElement(element);
                jQueryObject contentEl = pageEl.Children("[data-role=content]");

                if (!(bool)contentEl.GetDataValue("Custom.Stage"))
                {
                    RequireGlobal.Require(new string[] { "trading", "draw", "kinetic" }, (System.Action)delegate()
                    {
                        contentEl.Plugin<CandlestickChartObject>().CandlestickChart(new CandlestickChartOptions());
                    });

                    Window.SetTimeout(delegate()
                    {
                        Presentation.Refresh(new RefreshOptions("resize", true));
                    }, 100);
                }

                return false;
            });
        }

        public static void ToggleSearch(jQueryEvent e)
        {
            jQueryObject buttonEl = jQuery.FromElement(e.Target).Parent("a").First();

            jQueryObject floatingEl = jQuery.Select(".floating-content");

            if (floatingEl.HasClass("hidden"))
            {
                floatingEl.RemoveClass("hidden");
                buttonEl.RemoveClass("ui-btn-up-a");
                buttonEl.AddClass("ui-btn-up-f");
            }
            else
            {
                floatingEl.AddClass("hidden");
                buttonEl.RemoveClass("ui-btn-up-f");
                buttonEl.AddClass("ui-btn-up-a");
            }
        }
    }
}
