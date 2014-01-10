using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Mvc;

namespace Custom.Models
{
    [DataContract]
    public class DayQuote
    {
        [DataMember(Name = "open")]
        public double Open { get; set; }

        [DataMember(Name = "close")]
        public double Close { get; set; }

        [DataMember(Name = "min")]
        public double Minimum { get; set; }

        [DataMember(Name = "max")]
        public double Maximum { get; set; }
    }
}
