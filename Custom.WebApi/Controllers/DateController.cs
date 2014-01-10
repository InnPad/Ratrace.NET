using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Custom.Controllers
{
    public class DateController : Controller
    {
        private static readonly string[] JavascriptDateFormats = new []
        {
            "MMM d, y",
        };

        public IEnumerable<string> GetDates(string start, int count)
        {
            var dates = new List<string>();
            foreach (var format in JavascriptDateFormats)
            {
                DateTime from;
                if (DateTime.TryParseExact(start, format, null, System.Globalization.DateTimeStyles.AssumeUniversal, out from))
                {
                    for (int offset = 0; offset < count; offset++)
                    {
                        var date = from - TimeSpan.FromDays(offset);
                        dates.Add(date.ToString(format));
                    }
                }
            }
            return dates;
        }
        
        public string DayOffset(string date, int offset)
        {
            foreach (var format in JavascriptDateFormats)
            {
                DateTime from;
                if (DateTime.TryParseExact(date, format, null, System.Globalization.DateTimeStyles.AssumeUniversal, out from))
                {
                    var result = from - TimeSpan.FromDays(offset);
                    result.ToString(format);
                }
            }
            return null;
        }
    }
}
