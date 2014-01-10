// MobilePath.cs
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi
{
    [Imported, IgnoreNamespace, ScriptName("$.mobile")]
    public class MobilePath
    {
        /// <summary>
        /// Utility method for determining the directory portion of an URL. 
        /// If the URL has no trailing slash, the last component of the URL 
        /// is considered to be a file.
        /// </summary>
        /// <param name="url">
        /// (string, required)
        /// A relative or absolute URL.
        /// </param>
        /// <returns>
        /// This function returns the directory portion of a given URL.
        /// </returns>
        public static string Get(string url)
        {
            return null;
        }

        /// <summary>
        /// Utility method for determining if a URL is absolute.
        /// </summary>
        /// <param name="url">
        /// (string, required)
        /// A relative or absolute URL.
        /// </param>
        /// <returns>
        /// This function returns a boolean true if the URL is absolute, false if not.
        /// </returns>
        public static bool IsAbsoluteUrl(string url)
        {
            return false;
        }

        /// <summary>
        /// Utility method for determining if a URL is a relative variant.
        /// </summary>
        /// <param name="url">
        /// (string, required)
        /// A relative or absolute URL.
        /// </param>
        /// <returns>
        /// This function returns a boolean true if the URL is relative, 
        /// false if it is absolute.
        /// </returns>
        public static bool IsRelativeUrl(string url)
        {
            return false;
        }

        /// <summary>
        /// Utility method for comparing the domain of 2 URLs.
        /// </summary>
        /// <param name="url1">
        /// (string, required)
        /// A relative URL.
        /// </param>
        /// <param name="url2">
        /// (string, required)
        /// An absolute URL to resolve against.
        /// </param>
        /// <returns>
        /// This function returns a boolean true if the domains match, 
        /// false if they don't.
        /// </returns>
        public static bool IsSameDomain(string url1, string url2)
        {
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">
        /// (string, required)
        /// A relative or absolute URL.
        /// </param>
        public static void MakePathAbsolute(string url)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">
        /// (string, required)
        /// A relative or absolute URL.
        /// </param>
        public static void MakeUrlAbsolute(string url)
        {
        }

        /// <summary>
        /// Utility method for parsing a URL and its relative variants into 
        /// an object that makes accessing the components of the URL easy. 
        /// When parsing relative variants, the resulting object will contain 
        /// empty string values for missing components (like protocol, host, etc). 
        /// Also, when parsing URLs that have no authority, such as tel: urls, 
        /// the pathname property of the object will contain the data after the 
        /// protocol/scheme colon.
        /// </summary>
        /// <param name="url">
        /// (string, required)
        /// A relative or absolute URL.
        /// </param>
        /// <returns>
        /// This function returns an object that contains the various components 
        /// of the URL as strings. The properties on the object mimic the browser's 
        /// location object.
        /// </returns>
        public static UrlObject ParseUrl(string url)
        {
            return null;
        }
    }
}
