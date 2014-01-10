// DemoScope.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AngularApi;

namespace Custom
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public abstract class DemoScope : Scope
    {
        public Symbol currentSymbol;

        public List<Symbol> symbols;

        public SymbolPager pager;

        public DateRangeSlider slider;

        public string greeting;

        public string searchTheme;

        public string successMessage;

        public string errorMessage;

        public Delegate clearMessages;

        public Delegate goHome;

        public Delegate goDemo;

        public Delegate goAbout;

        public Delegate toggleSearch;
    }
}
