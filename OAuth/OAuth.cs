// OAuth.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace OAuthApi
{
    [Imported, IgnoreNamespace]
    public class OAuth
    {
        public int timeCorrectionMsec = 0;

        public static void setProperties(object into, object from)
        {
        }

        public string percentEncode(object s)
        {
            return null;
        }

        public string decodePercent(object s)
        {
            return null;
        }

        public Array getParameterList(object[] parameters)
        {
            return null;
        }

        public object getParameterMap(object[] parameters)
        {
            return null;
        }

        public object getParameter(object[] parameters, string name)
        {
            return null;
        }

        public object formEncode(object[] parameters)
        {
            return null;
        }

        public object decodeForm(object form)
        {
            return null;
        }

        public void setParameter(object message, string name, object value)
        {
        }

        public void setParameters(object message, object[] parameters)
        {
        }

        public void completeRequest(object message, object accessor)
        {
        }

        public void setTimestampAndNonce(object message)
        {
        }

        public string addToURL(string url, object parameters)
        {
            return null;
        }

        public string getAuthorizationHeader(object realm, object parameters)
        {
            return null;
        }

        public void correctTimestampFromSrc(string parameterName)
        {
        }

        public void correctTimestamp(object timestamp)
        {
        }

        public Number timestamp()
        {
            return -1;
        }

        public static object declareClass(object parent, string name, Delegate newConstructor)
        {
            return null;
        }
    }
}
