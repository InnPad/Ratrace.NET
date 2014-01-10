using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Custom.Models
{
    [DataContract]
    public class Symbol
    {
        [DataMember(Name="id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "market")]
        public string Market { get; set; }

        [DataMember(Name = "value")]
        public double Value { get; set; }

        [DataMember(Name = "summary")]
        public string Summary { get; set; }
    }
}