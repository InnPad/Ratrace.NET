// UrlObject.cs
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class UrlObject
    {
        /// <summary>
        /// The fragment component of the URL, including the leading '#' character.
        /// </summary>
        public string hash;

        /// <summary>
        /// The host and port number of the URL.
        /// </summary>
        public string host;

        /// <summary>
        /// The name of the host within the URL.
        /// </summary>
        public string hostname;

        /// <summary>
        /// The original URL that was parsed.
        /// </summary>
        public string href;

        /// <summary>
        /// The path of the file or directory referenced by the URL.
        /// </summary>
        public string pathname;

        /// <summary>
        /// The port specified within the URL. Most URLs rely on the default port for the protocol used, so this may be an empty string most of the time.
        /// </summary>
        public string port;

        /// <summary>
        /// The protocol for the URL including the trailing ':' character.
        /// </summary>
        public string protocol;

        /// <summary>
        /// The query component of the URL including the leading '?' character.
        /// But it also contains additional properties that provide access to additional components as well as some common forms of the URL developers access:
        /// </summary>
        public string search;

        /// <summary>
        /// The username, password, and host components of the URL
        /// </summary>
        public string authority;

        /// <summary>
        /// The directory component of the pathname, minus any filename.
        /// </summary>
        public string directory;

        /// <summary>
        /// The protocol and authority components of the URL.
        /// </summary>
        public string domain;

        /// <summary>
        /// The filename within the pathname component, minus the directory.
        /// </summary>
        public string filename;

        /// <summary>
        /// The original URL minus the fragment (hash) components.
        /// </summary>
        public string hrefNoHash;

        /// <summary>
        /// The original URL minus the query (search) and fragment (hash) components.
        /// </summary>
        public string hrefNoSearch;

        /// <summary>
        /// The password contained within the authority component.
        /// </summary>
        public string password;

        /// <summary>
        /// The username contained within the authority component.
        /// </summary>
        public string username;
    }
}
