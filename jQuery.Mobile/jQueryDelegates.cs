// jQueryDelegates.cs
//

using System;
using System.Collections.Generic;

namespace jQueryApi
{
    public static class jQueryDelegates
    {
        public static void Remove()
        {
            jQuery.This.Remove();
        }

        public static void RemoveOnEvent(jQueryEvent e)
        {
            jQuery.FromElement(e.CurrentTarget).Remove();
        }
    }
}
