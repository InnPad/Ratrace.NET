// DateRangeSlider.cs
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;
using AngularApi;
using Custom;
using jQueryApi;

namespace Custom
{
    public class DateRangeSlider : DateRangeSliderOptions
    {
        public static void Init(AngularStatic angular, AngularModule module)
        {
            module.directive("dateHigh", (Func<object>)delegate()
            {
                return new Dictionary(
                    "restrict", "A",
                    //"require", "ngModel",
                    "link", (Action<DateRangeScope, jQueryObject, object, DateRangeSliderOptions>)delegate(DateRangeScope scope, jQueryObject element, object attr, DateRangeSliderOptions ngModel)
                    {
                        element.On("change", (jQueryEventHandler)delegate(jQueryEvent ev)
                        {
                            scope.Apply((System.Action)delegate()
                            {
                                string value = element.GetValue();
                                int offset = Date.Parse(value).GetTime();
                                scope.slider.offset.high = offset;
                            });
                        });
                    });
            });

            module.directive("dateLow", (Func<object>)delegate()
            {
                return new Dictionary(
                    "restrict", "A",
                    //"require", "ngModel",
                    "link", (Action<DateRangeScope, jQueryObject, object, DateRangeSliderOptions>)delegate(DateRangeScope scope, jQueryObject element, object attr, DateRangeSliderOptions ngModel)
                    {
                        element.On("change", (jQueryEventHandler)delegate(jQueryEvent ev)
                        {
                            scope.Apply((System.Action)delegate()
                            {
                                string value = element.GetValue();
                                int offset = Date.Parse(value).GetTime();
                                scope.slider.offset.low = offset;
                            });
                        });
                    });
            });

            module.directive("dateRange", (Func<object>)delegate()
            {
                return new Dictionary(
                    "restrict", "A",
                    "link", (Action<DateRangeScope, jQueryObject, object, DateRangeSliderOptions>)delegate(DateRangeScope scope, jQueryObject element, object attr, DateRangeSliderOptions ngModel)
                    {
                        // catch the element
                        scope.slider.el = element;
                        element.Data("Custom.DateRangeSlider", scope.slider);
                    });
            });

            module.directive("rangeTrack", (Func<object>)delegate()
            {
                return new Dictionary(
                    "restrict", "A",
                    "link", (Action<DateRangeScope, jQueryObject, object, DateRangeSliderOptions>)delegate(DateRangeScope scope, jQueryObject element, object attr, DateRangeSliderOptions ngModel)
                    {
                        // catch the element
                        scope.slider.trackEl = element;
                    });
            });

            module.directive("rangeThumb", (Func<object>)delegate()
            {
                return new Dictionary(
                    "restrict", "A",
                    "link", (Action<DateRangeScope, jQueryObject, object, DateRangeSliderOptions>)delegate(DateRangeScope scope, jQueryObject element, object attr, DateRangeSliderOptions ngModel)
                    {
                        // catch the element
                        scope.slider.thumbEl = element;
                    });
            });

            module.directive("rangeHigh", (Func<object>)delegate()
            {
                return new Dictionary(
                    "restrict", "A",
                    //"require", "ngModel",
                    "link", (Action<DateRangeScope, jQueryObject, object, DateRangeSliderOptions>)delegate(DateRangeScope scope, jQueryObject element, object attr, DateRangeSliderOptions ngModel)
                    {
                        // catch the element
                        scope.slider.highEl = element;

                        element.On("create", (jQueryEventHandler)delegate(jQueryEvent ev)
                        {
                            int a = 0;
                        });

                        element.On("slidestart", (jQueryEventHandler)delegate(jQueryEvent ev)
                        {
                            scope.Apply((System.Action)delegate()
                            {
                                int a = 0;
                            });
                        });

                        element.On("change", (jQueryEventHandler)delegate(jQueryEvent ev)
                        {
                            scope.Apply((System.Action)delegate()
                            {
                                string value = element.GetValue();
                                int offset = int.Parse(value);
                                scope.slider.date.high = DateHelper.Date(offset);

                                // update max of the low slider
                                if ((bool)(object)scope.slider.lowEl)
                                {
                                    scope.slider.lowEl.Attribute("max", (string)(object)offset);
                                }
                            });
                        });

                        element.On("slidestop", (jQueryEventHandler)delegate(jQueryEvent ev)
                        {
                            scope.Apply((System.Action)delegate()
                            {
                                // update max of the low slider
                                if ((bool)(object)scope.slider.lowEl)
                                {
                                    //scope.slider.lowEl.Attribute("max", (string)(object)scope.slider.offset.high);
                                    //
                                    scope.slider.lowEl.Plugin<SliderObject>().Slider(new SliderOptions(
                                        "max", scope.slider.offset.high
                                        ));
                                    scope.slider.lowEl.Plugin<SliderObject>().Slider("refresh");
                                }
                            });
                        });
                    });
            });

            module.directive("rangeLow", (Func<object>)delegate()
            {
                return new Dictionary(
                    "restrict", "A",
                    //"require", "ngModel",
                    "link", (Action<DateRangeScope, jQueryObject, object, DateRangeSliderOptions>)delegate(DateRangeScope scope, jQueryObject element, object attr, DateRangeSliderOptions ngModel)
                    {
                        // catch the element
                        scope.slider.lowEl = element;

                        element.On("slidestart", (jQueryEventHandler)delegate(jQueryEvent ev)
                        {
                            scope.Apply((System.Action)delegate()
                            {
                                int a = 0;
                            });
                        });

                        element.On("change", (jQueryEventHandler)delegate(jQueryEvent ev)
                        {
                            scope.Apply((System.Action)delegate()
                            {
                                string value = element.GetValue();
                                int offset = int.Parse(value);
                                scope.slider.date.low = DateHelper.Date(offset);

                                // update min of the high slider
                                if ((bool)(object)scope.slider.highEl)
                                {
                                    scope.slider.highEl.Attribute("min", (string)(object)offset);
                                }
                            });
                        });

                        element.On("slidestop", (jQueryEventHandler)delegate(jQueryEvent ev)
                        {
                            scope.Apply((System.Action)delegate()
                            {
                                // update min of the high slider
                                if ((bool)(object)scope.slider.highEl)
                                {
                                   // scope.slider.highEl.Attribute("min", (string)(object)scope.slider.offset.low);
                                    scope.slider.highEl.Plugin<SliderObject>().Slider(new SliderOptions(
                                        "min", scope.slider.offset.low
                                        ));
                                    scope.slider.highEl.Plugin<SliderObject>().Slider("refresh");
                                }
                            });
                        });
                    });
            });
        }

        /// <summary>
        /// Date range control div element
        /// </summary>
        public jQueryObject el;

        /// <summary>
        /// Date range track div element
        /// </summary>
        public jQueryObject trackEl;

        /// <summary>
        /// Date range thumb div element
        /// </summary>
        public jQueryObject thumbEl;

        /// <summary>
        /// Date range high slider input element
        /// </summary>
        public jQueryObject highEl;

        /// <summary>
        /// Date range low slider input element
        /// </summary>
        /// 
        public jQueryObject lowEl;

        public DateRangeSlider(DateRangeSliderOptions options)
        {
            this.date = jQuery.ExtendObject(new DateRange(), options.date);
            this.offset = jQuery.ExtendObject(new OffsetRange(), options.offset);
        }

        public void setHeight(Number value)
        {

        }

        public void setWidth(Number value)
        {
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class DateRangeSliderOptions : ScriptObject
    {
        public DateRange date;

        /// <summary>
        ///  The values are given by the number of milliseconds between midnight of January 1, 1970 and the specified date.
        ///  See Date.getTime and Date.setTime.
        /// </summary>
        public OffsetRange offset;

        public DateRangeSliderOptions()
        {
        }

        public DateRangeSliderOptions(params object[] nameValuePairs)
        {
        }
    }
}

[Mixin("$.fn")]
public static class DateRangeSliderPlugin
{
    public static jQueryObject DateRangeSlider(DateRangeSliderOptions customOptions)
    {
        DateRangeSliderOptions defaultOptions =
            new DateRangeSliderOptions("myOption", 0
            /* name/value pairs corresponding to default options */);

        DateRangeSliderOptions options =
            jQuery.ExtendObject<DateRangeSliderOptions>(new DateRangeSliderOptions(), defaultOptions, customOptions);

        return jQuery.Current.Each(delegate(int i, Element element)
        {
            // TODO: Consume the matched elements
        });
    }
}

#region Script# Support
[Imported]
public sealed class DateRangeSliderObject : jQueryObject
{
    public jQueryObject DateRangeSlider()
    {
        return null;
    }

    public jQueryObject DateRangeSlider(DateRangeSliderOptions options)
    {
        return null;
    }
}
#endregion
