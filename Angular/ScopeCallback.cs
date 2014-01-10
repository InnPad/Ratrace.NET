// ScopeCallback.cs
//

using System;
using System.Collections.Generic;
using jQueryApi;

namespace AngularApi
{
    public delegate object AsyncCallback(object result);

    public delegate object ScopeCallback(Scope scope);

    public delegate object ValueListenerCallback(object newValue, object oldValue, Scope scope);

    public delegate object EventListenerCallback(jQueryEvent ev);
}
