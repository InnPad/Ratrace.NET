using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;
using jQueryApi;

namespace AngularApi
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface Deregistration
    {
        Action action { get; set; }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface CacheInfo
    {
        string id { get; set; }
        Number size { get; set; }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface Cache
    {
        void put(string key, object value);
        object get(string key);
        void remove(string key);
        void removeAll();
        void destroy();
        CacheInfo info();
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface Provider
    {
        void register(string name, Delegate constructor);
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface HttpConfig
    {
        string method { get; set; }
        string url { get; set; }

        [ScriptName("params")]
        Object @params { get; set; }

        object data { get; set; }
        Object headers { get; set; }
        Action<object/*data*/, Func<Object>/*headersGetter*/> transformRequest { get; set; }
        Action<object/*data*/, Func<Object>/*headersGetter*/> transformResponse { get; set; }
        Cache cache { get; set; }
        Number timeout { get; set; }
        bool withCredentials { get; set; }
        string responseType { get; set; }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface HttpResponse
    {
        object data { get; set; }
        Number status { get; set; }
        Func<string/*name*/, string> headers { get; set; }
        HttpConfig config { get; set; }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface HttpPromise
    {
        void then(Action<HttpResponse /*response*/> success, Action<HttpResponse /*response*/> error);

        [AlternateSignature]
        void then(Action<HttpResponse /*response*/> success);

        void success(Action<HttpResponse /*response*/> callback);
        
        void error(Action<HttpResponse /*response*/> callback);
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface Http
    {
        //HttpPromise (HttpConfig config);
        HttpConfig[] pendingRequests { get; set; }

        HttpPromise get(string url, HttpConfig config);

        [AlternateSignature]
        HttpPromise get(string url);

        HttpPromise delete(string url, HttpConfig config);

        [AlternateSignature]
        HttpPromise delete(string url);

        HttpPromise head(string url, HttpConfig config);

        [AlternateSignature]
        HttpPromise head(string url);

        HttpPromise jsonp(string url, HttpConfig config);

        [AlternateSignature]
        HttpPromise jsonp(string url);

        HttpPromise post(string url, object data, HttpConfig config);

        [AlternateSignature]
        HttpPromise post(string url, object data);

        HttpPromise put(string url, object data, HttpConfig config);

        [AlternateSignature]
        HttpPromise put(string url, object data);

        HttpConfig defaults { get; set; }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface InterpolateProvider
    {
        string startSymbol();
        InterpolateProvider startSymbol(string value);
        string endSymbol();
        InterpolateProvider endSymbol(string value);
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface Interpolate
    {
        //Func<Object /*context*/, string> (string text, bool mustHaveExpression = false);
        string startSymbol();
        string endSymbol();
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface Location
    {
        string absUrl();
        string url();
        Location url(string url);
        string protocol();
        string host();
        Number port();
        string path();
        Location path(string path);
        string search();
        Location search(string search);
        Location search(string search, string paramValue);
        Location search(Object search);
        string hash();
        Location hash(string hash);
        Location replace();
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface LocationProvider
    {
        string hashPrefix();
        LocationProvider hashPrefix(string prefix);
        object html5Mode();
        LocationProvider html5Mode(string mode);
        LocationProvider html5Mode(bool mode);
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface Log
    {
        void log(params object[] args);
        void warn(params object[] args);
        void info(params object[] args);
        void error(params object[] args);
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface Promise
    {
        Promise then(Func<object/*result*/, object> successCallback, Func<object /*result*/, object> errorCallback);

        [AlternateSignature]
        Promise then(Func<object/*result*/, object> successCallback);
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface Deferred
    {
        void resolve(object value);

        void reject(object reason);

        Promise promise { get; set; }
    }
    

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface RouteMap
    {
        Delegate this[string key] { get; set; }
    }

    
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface Timeout
    {
        //Promise (Delegate fn, Number delay = null, bool invokeApply = false);
        bool cancel(Promise promise);

        [AlternateSignature]
        bool cancel();
    }
}
