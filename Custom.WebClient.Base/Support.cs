using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;

namespace Custom
{
    [IgnoreNamespace]
    public static class Support
    {
        private static string _browser;
        private static bool _radialGradient;

        public static string Browser { get { return _browser; } }

        public static bool RadialGradient
        {
            get { return _radialGradient; }
            set { _radialGradient = value; }
        }

        public static void Reset()
        {
            string userAgent = Window.Navigator.UserAgent;
            string appVersion = Window.Navigator.AppVersion;
            string platfomr = Window.Navigator.Platform;

            if (userAgent.IndexOf("Chrome") > 0)
            {
                _browser = "Chrome";
                _radialGradient = false;
            }
            else if (userAgent.IndexOf("MSIE 9.0") > 0)
            {
                _browser = "IE9";
                _radialGradient = true;
            }
            else if (userAgent.IndexOf("MSIE 8.0") > 0)
            {
                _browser = "IE8";
                _radialGradient = false;
            }
            else if (userAgent.IndexOf("MSIE 7.0") > 0)
            {
                _browser = "IE7";
                _radialGradient = false;
            }
            else if (userAgent.IndexOf("MSIE 6.0") > 0)
            {
                _browser = "IE6";
                _radialGradient = false;
            }
            else if (userAgent.IndexOf("Firefox") > 0)
            {
                _radialGradient = true;
            }
            else
            {
                _radialGradient = false;
            }
        }
    }
}
