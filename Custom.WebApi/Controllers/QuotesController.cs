using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Custom.Controllers
{
    using Custom.Models;

    public class QuotesController : ApiController
    {
        // GET api/quote
        public IEnumerable<DayQuote> Get(string symbol)
        {
            return Get(DateTime.Today, 1);
        }

        // GET api/quote
        public IEnumerable<DayQuote> Get(string symbol, string day)
        {
            return Get(DateTime.Today, 1);
        }

        // GET api/quote
        public IEnumerable<DayQuote> Get(string symbol, string day, int count)
        {
            return Get(DateTime.Today, count);
        }

        // GET api/quote
        public IEnumerable<DayQuote> Get(string symbol, int count)
        {
            return Get(DateTime.Today, count);
        }

        private IEnumerable<DayQuote> Get(DateTime day, int count)
        {
            List<DayQuote> quotation = new List<DayQuote>();
            var random = new Random();
            for (int i = 0; i < count; i++)
            {
                var min = 5 + 10 * random.NextDouble();
                var low = min + 20 * random.NextDouble();
                var high = low + 50 * random.NextDouble();
                var max = high + 20 * random.NextDouble();

                DayQuote quote;

                if (random.Next() > 0)
                {
                    quote = new DayQuote
                    {
                        Close = low,
                        Maximum = max,
                        Minimum = min,
                        Open = high
                    };
                }
                else
                {
                    quote = new DayQuote
                    {
                        Close = high,
                        Maximum = max,
                        Minimum = min,
                        Open = low
                    };
                }

                quotation.Add(quote);
            }

            return quotation;
        }

        // POST api/quote
        public void Post([FromBody]DayQuote value)
        {
        }

        // PUT api/quote/5
        public void Put(int offset, [FromBody]DayQuote value)
        {
        }

        // DELETE api/quote/5
        public void Delete(int offset)
        {
        }
    }
}
