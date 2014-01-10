// SymbolPager.cs
//

using System;
using System.Collections.Generic;
using jQueryApi;

namespace Custom
{
    public class SymbolPager
    {
        private List<Symbol> _symbols;

        public SymbolPager(List<Symbol> symbols)
        {
            _symbols = symbols;
        }

        public void LoadMode()
        {
            jQueryAjaxOptions ajax = new jQueryAjaxOptions(
                    "type", "GET",
                    "url", "api/symbols",
                    "dataType", "json",
                    "success", (AjaxRequestCallback)delegate(object data, string textStatus, jQueryXmlHttpRequest request)
                    {
                        Symbol[] symbols = (Symbol[])data;
                        for (int i = 0; i < symbols.Length; i++)
                        {
                            _symbols.Add(symbols[i]);
                        }
                    },
                    "error", (AjaxErrorCallback)delegate(jQueryXmlHttpRequest request, string textStatus, Exception error)
                    {
                        int a = 0;
                    });

            jQuery.AjaxRequest<Symbol[]>(ajax);
        }
    }
}
