// AngularStatic.cs
//

using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;
using jQueryApi;

namespace AngularApi
{
    [Imported, IgnoreNamespace]
    public interface AngularStatic
    {
        object bootstrap(Element element, string[] modules);

        object bootstrap(Element element, Delegate[] modules);

        object copy(object source, object destination);

        Array copy(object source, Array destination);

        object extend(Object dest, params Object[] src);

        bool equals(object o1, object o2);

        jQueryObject element(string element);

        jQueryObject element(Element element);

        Array forEach(Array obj, Action<object/*value*/, Number/*index*/> iterator, object context);

        [AlternateSignature]
        Array forEach(Array obj, Action<object/*value*/> iterator, object context);

        object forEach(object obj, Action<object/*value*/, string/*key*/> iterator, object context);

        AngularInjector injector(string[] modules);

        AngularInjector injector(Delegate[] modules);

        AngularModule module(string name, string[] requesires, object[] args);

        AngularModule module(string name, string[] requesires, Delegate configFn);

        AngularModule module(string name, string[] requesires);

        AngularModule module(string name, Delegate configFn);

        void noop();

        Delegate bind(object self, Delegate fn, params object[] args);

        string toJson(object obj, bool pretty);

        object fromJson(string json);

        object identity(object[] any);

        bool isUndefined(object value);

        bool isDefined(object value);

        bool isObject(object value);

        bool isString(object value);

        bool isNumber(object value);

        bool isDate(object value);

        bool isArray(object value);

        bool isFunction(object value);

        bool isElement(object value);

        string lowercase(string str);

        string uppercase(string str);

        //callbacks
        AngularVersion version { get; set; }
    }
}
