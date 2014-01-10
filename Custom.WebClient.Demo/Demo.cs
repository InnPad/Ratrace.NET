// Demo.cs
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AngularApi;

namespace Custom
{
    public abstract class Demo : IDisposable
    {
        protected static AngularModule _module;

        static Demo()
        {
            _module = AngularGlobal.angular.module("main", new string[] { "main.controllers" }, new object[] { "$provide", (Action<AngularModule>)delegate(AngularModule provide)
            {   
            }});
        }

        public bool cancel;

        public string title;

        public string description;

        public abstract AngularModule GetController(AngularModule module);

        public abstract void Initialize(string container);

        public abstract void Dispose();
    }
}
