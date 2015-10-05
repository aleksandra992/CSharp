using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Processing_JSON_in.NET
{
    public class Video
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("link")]
        public Url Url { get; set; }
    }
}
