// About.cs
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

namespace Custom
{
    public static class About
    {
        public static void OnPageShow(jQueryEvent e)
        {
            jQuery.Select("#about-page[data-role=page]").Each((ElementInterruptibleIterationCallback)delegate(int index, Element element)
            {
                jQueryObject pageEl = jQuery.FromElement(element);
                jQueryObject contentEl = pageEl.Children("[data-role=content]");

                if (!(bool)contentEl.GetDataValue("Custom.Stage"))
                {
                    RequireGlobal.Require(new string[] { "draw", "kinetic" }, (System.Action)delegate()
                    {
                        contentEl.Plugin<AtomObject>().Atom(new AtomOptions(
                            "electrons", new string[] {
                        "Images/tradestation_thumb.jpg",
                        "Images/angular_thumb.png",
                        "Images/kinetic_thumb.jpg",
                        "Images/jquerymobile_thumb.png",
                        "Images/scriptsharp_thumb.png",
                        "Images/typescript_thumb.png",
                        "Images/sencha_thumb.png",
                        "Images/odata_thumb.png",
                        "Images/sqlserver_thumb.png",
                        "Images/servicestack_thumb.png",
                        "Images/signalr_thumb.jpg",
                        "Images/titanium_thumb.png",
                        "Images/twitter_thumb.png",
                        "Images/jquery_thumb.png",
                        "Images/dotnet_thumb.png",
                        "Images/facebook_thumb.png",
                        "Images/css3_thumb.png",
                        "Images/html5_thumb.png",
                        "Images/feed_thumb.png",
                        "Images/silverlight_thumb.png",
                        "Images/appcelerator_thumb.png",

                        "Images/android_thumb.png",
                        "Images/apple_thumb.png",
                        "Images/backbone_thumb.png",
                        "Images/chrome_thumb.png",
                        "Images/firefox_thumb.png",
                        "Images/googlemaps_thumb.png",
                        "Images/ie10_thumb.png",
                        "Images/java_thumb.png",
                        "Images/mono_thumb.png",
                        "Images/phone7_thumb.png",
                        "Images/phonegap_thumb.png",
                        "Images/sap_thumb.png",
                        "Images/windows_thumb.png",
                        "Images/wpf_thumb.png" }));
                    });

                    Window.SetTimeout(delegate() {
                        Presentation.Refresh(new RefreshOptions("resize", true));
                    }, 100);
                }

                return false;
            });
        }
    }
}
