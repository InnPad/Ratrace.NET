// Scope.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using jQueryApi;

namespace AngularApi
{
    [Imported, ScriptNamespace("ng")]
    public abstract class Scope
    {
        [ScriptName("$apply")]
        public abstract void Apply(Delegate fn);

        [ScriptName("$new")]
        public abstract Scope New(bool isolate);

        [ScriptName("$watch")]
        public abstract Deregistration Watch(string watchExpression, string listener, bool objectEquality);

        [ScriptName("$watch"), AlternateSignature]
        public abstract Deregistration Watch(string watchExpression, string listener);

        [ScriptName("$watch"), AlternateSignature]
        public abstract Deregistration Watch(string watchExpression);

        [ScriptName("$watch")]
        public abstract Deregistration Watch(string watchExpression, ValueListenerCallback listener, bool objectEquality);

        [ScriptName("$watch"), AlternateSignature]
        public abstract Deregistration Watch(string watchExpression, ValueListenerCallback listener);

        [ScriptName("$watch")]
        public abstract Deregistration Watch(ScopeCallback watchExpression, string listener, bool objectEquality);

        [ScriptName("$watch"), AlternateSignature]
        public abstract Deregistration Watch(ScopeCallback watchExpression, string listener);

        [ScriptName("$watch")]
        public abstract Deregistration Watch(ScopeCallback watchExpression, ValueListenerCallback listener, bool objectEquality);

        [ScriptName("$watch"), AlternateSignature]
        public abstract Deregistration Watch(ScopeCallback watchExpression, ValueListenerCallback listener);

        [ScriptName("$watch"), AlternateSignature]
        public abstract Deregistration Watch(ScopeCallback watchExpression);

        [ScriptName("$digest")]
        public abstract void Digest();

        [ScriptName("$destroy")]
        public abstract void Destroy();

        [ScriptName("$eval")]
        public abstract object Eval();

        [ScriptName("$eval")]
        public abstract object Eval(string expression);

        [ScriptName("$eval")]
        public abstract object Eval(Func<Scope/*scope*/, object> expression);

        [ScriptName("$eval")]
        public abstract void EvalAsync();

        [ScriptName("$eval")]
        public abstract void EvalAsync(string expression);

        [ScriptName("$eval")]
        public abstract void EvalAsync(Func<Scope/*scope*/, object> expression);

        [ScriptName("$apply")]
        public abstract object Apply();

        [ScriptName("$apply")]
        public abstract object Apply(string expression);

        [ScriptName("$apply")]
        public abstract object Apply(ScopeCallback expression);

        [ScriptName("$on")]
        public abstract Deregistration On(string name, /*EventListenerCallback*/Delegate listener);

        [ScriptName("$emit")]
        public abstract jQueryEvent Emit(string name, params object[] args);

        [ScriptName("$broadcast")]
        public abstract jQueryEvent Broadcast(string name, params object[] args);
    }
}
