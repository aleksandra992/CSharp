using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Processing_JSON_in.NET
{
    public class Url
    {
        [JsonProperty("@rel")]
        public string Rel { get; set; }

        [JsonProperty("@href")]
        public string Href { get; set; }

    }
}
