// AngularModule.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using jQueryApi;

namespace AngularApi
{
    [Imported, IgnoreNamespace]
    public abstract class AngularModule
    {
        public string[] requires;

        public string name;

        public AngularModule provider(string name, Delegate providerType) { return null; }

        [ScriptName("factory")]
        public AngularModule Factory(string name, Delegate providerFunction) { return null; }

        public AngularModule service(string name, Delegate constructor) { return null; }

        public AngularModule value(string name, object obj) { return null; }

        public AngularModule constant(string name, object obj) { return null; }

        public AngularModule filter(string name, Delegate filterFactory) { return null; }

        public AngularModule controller(string name, Delegate constructor) { return null; }

        public AngularModule controller(string name, object[] args) { return null; }

        public AngularModule directive(string name, Delegate directiveFactory) { return null; }

        public AngularModule config(Delegate configFn) { return null; }

        public AngularModule config(object[] args) { return null; }

        public AngularModule run(Delegate initializationFn) { return null; }
    }
}
