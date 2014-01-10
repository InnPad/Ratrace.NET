// Presentation.cs
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Html;
using AngularApi;
using RequireApi;
using jQueryApi;

namespace Custom
{
    public static class Presentation
    {
        public static readonly Size WindowSize = new Size();
        public static readonly Size PageSize = new Size();
        public static jQueryOrientation Orientation = jQueryOrientation.Landscape;

        public static void ChangeOrientation(jQueryOrientation orientation)
        {
            Orientation = orientation;
        }

        public static void Initialize()
        {
            //MobileGlobal.Mobile.DefaultPageTransition = jQueryTransitions.Slide;

            //MobileGlobal.Mobile.DefaultDialogTransition = jQueryTransitions.Fade;

            //MobileGlobal.Mobile.SelectMenuOptions.NativeMenu = false;

            jQuery.Select("body")

                .Bind("hideOpenMenus", OnHideOpenMenus)

                // Binding to the scrollstart event
                .Bind("scrollstart", OnScrollStart)

                // Binding to the scrollstop event
                .Bind("scrollstop", OnScrollEnd)

                // Binding the orientationchange event to the body element
                .Bind("orientationchange", (jQueryEventHandler)(Delegate)(Action<jQueryOrientationChangeEvent>)OnOrientationChange)

                // Binding to the scrollstart event
                .Bind("pageshow", OnPageRefresh)

                // Triggering the orientationchange event when the document is ready
                .Trigger("orientationchange");

            jQuery.FromObject(Window.Self).Bind("resize", OnWindowResize);

            Refresh(new RefreshOptions("resize", true));
        }

        public static bool IsHeader(jQueryObject el)
        {
            bool isHeader = false;
            el.Each((ElementInterruptibleIterationCallback)delegate(int index, Element element)
            {
                switch (element.TagName)
                {
                    case "H1":
                    case "H2":
                    case "H3":
                    case "H4":
                    case "H5":
                        isHeader = true;
                        return false;
                    default:
                        return true;
                }
            });
            return isHeader;
        }

        public static bool IsInline(jQueryObject el)
        {
            bool isInline = false;
            el.Each((ElementInterruptibleIterationCallback)delegate(int index, Element element)
            {
                switch (element.TagName)
                {
                    case "INPUT":
                        isInline = true;
                        return false;
                    default:
                        return true;
                }
            });
            return isInline;
        }

        public static bool IsFit(Element element)
        {
            switch (element.TagName)
            {
                case "DIV":
                case "CANVAS":
                    return true;
                default:
                    return false;
            }
        }

        private static void OnHideOpenMenus(jQueryEvent e)
        {
            jQuery.Select("ul:jqmData(role='menu')").Find("li > ul").Hide();
        }

        private static void OnOrientationChange(jQueryOrientationChangeEvent e)
        {
            Presentation.ChangeOrientation(e.Orientation);
        }

        private static void OnPageRefresh(jQueryEvent e)
        {   
            Refresh(new RefreshOptions("resize", true));
        }

        private static void OnScrollStart(jQueryEvent e)
        {
            // Add scroll start code here
            Script.Alert("ScrollStart");
        }

        private static void OnScrollEnd(jQueryEvent e)
        {
            // Add scroll stop code here
            Script.Alert("ScrollEnd");
        }

        private static void OnWindowResize(jQueryEvent e)
        {
            Refresh(new RefreshOptions("resize", true));
        }

        public static void Refresh(RefreshOptions options)
        {
            // Always update values
            WindowSize.height = Window.OuterHeight;
            WindowSize.width = Window.OuterWidth;
            PageSize.height = Window.InnerHeight;
            PageSize.width = Window.InnerWidth;

            if ((bool)(object)options.Resize)
            {
                options.Resize = PageSize;
            }

            jQuery.Select("div[data-role=page].ui-page-active").Each((ElementIterationCallback)delegate(int index, Element element)
            {
                jQueryObject pageEl = jQuery.FromElement(element);

                pageEl.CSS("height", PageSize.height + "px");

                jQueryObject contentEl = pageEl.Children(".ui-content");

                if (contentEl.HasClass("wave-height"))
                {
                    int contentHeight = pageEl.GetHeight() - contentEl.Position().Top;

                    jQueryObject headerEl = pageEl.Children(".ui-header");
                    jQueryObject footerEl = pageEl.Children(".ui-footer");

                    if (footerEl.GetAttribute("data-position") == "fixed")
                    {
                        contentHeight -= footerEl.GetOuterHeight(true);
                    }

                    WaveHeight(contentEl, contentHeight);
                }

                if (contentEl.HasClass("wave-width"))
                {
                    WaveWidth(contentEl, PageSize.width);
                }
            });
        }

        public static bool Draw(Dictionary data)
        {
            Function draw = (Function)data["draw"];
            if (draw != null && Type.GetScriptType(draw) == "function")
            {
                draw.Call(data);
                return true;
            }
            return false;
        }

        public static bool SetHeight(Dictionary data, int height)
        {
            Function setHeight = (Function)data["setHeight"];
            if (setHeight != null && Type.GetScriptType(setHeight) == "function")
            {
                setHeight.Call(data, height);
                return true;
            }
            return false;
        }

        public static bool SetWidth(Dictionary data, int width)
        {
            Function setWidth = (Function)data["setWidth"];
            if (setWidth != null && Type.GetScriptType(setWidth) == "function")
            {
                setWidth.Call(data, width);
                return true;
            }
            return false;
        }

        public static void WaveHeight(jQueryObject el, int height)
        {
            jQueryPosition offset = el.GetOffset();

            el.CSS("height", height + "px");

            if ((bool)(object)el.GetAttribute("height"))
            {
                el.RemoveAttr("height");//, height + "px");
            }

            height = el.GetHeight();
            jQueryObject children = el.Children();
            jQueryObject waved = children.Filter((ElementFilterCallback)delegate(int index)
            {
                jQueryObject childEl = jQuery.This;
                if ((IsFit(children[index]) && !(jQuery.This.HasClass("dont-wave-height")) || childEl.HasClass("wave-height")))
                    return true;
                height -= Math.Max(childEl.GetOuterHeight(false), childEl.GetOuterHeight(true), childEl.GetHeight());
                return false;
            });
            if (waved.Length > 0)
            {
                jQueryObject stack = waved.Filter((ElementFilterCallback)delegate(int index)
                {
                    string position = jQuery.This.GetCSS("position");
                    switch (position)
                    {
                        case "absolute":
                            return false;
                        case "fixed":
                            return false;
                        default:
                            return true;
                    }
                });

                stack.Each((ElementIterationCallback)delegate(int index, Element element)
                {
                    jQueryObject childEl = jQuery.FromElement(element);
                    WaveHeight(childEl, height / stack.Length);
                });

                waved.Each((ElementIterationCallback)delegate(int index, Element element)
                {
                    jQueryObject childEl = jQuery.FromElement(element);
                    string position = childEl.GetCSS("position");
                    switch(position)
                    {
                        case "absolute":
                            WaveHeight(childEl, height);
                            break;
                        case "fixed":
                            el.CSS("top", offset.Top + "px");
                            WaveHeight(childEl, height);
                            break;
                    }
                });
            }

            Dictionary data = el.GetData();
            data.Keys.ForEach((ArrayItemCallback)delegate(object value)
            {
                SetHeight((Dictionary)data[(string)value], height);
                Draw(data);
            });
        }

        public static void WaveWidth(jQueryObject el, int width)
        {
            el.CSS("width", width + "px");

            if ((bool)(object)el.GetAttribute("width"))
            {
                el.RemoveAttr("width");//, width + "px");
            }
            
            el.Children().Each((ElementIterationCallback)delegate(int index, Element element)
            {
                jQueryObject child = jQuery.FromElement(element);

                if (!child.HasClass("dont-wave-width"))
                {
                    WaveWidth(child, width);
                }
            });

            Dictionary data = el.GetData();
            data.Keys.ForEach((ArrayItemCallback)delegate(object value)
            {
                SetWidth((Dictionary)data[(string)value], width);
                Draw(data);
            });
        }
    }
}
