using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CorreiosClient.Models
{
    public class MessageResponse
    {
        [JsonProperty("msgs")]
        public List<string> Messages { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("causa")]
        public string Causa { get; set; }

        [JsonProperty("stackTrace")]
        public string StackTrace { get; set; }
    }
}
