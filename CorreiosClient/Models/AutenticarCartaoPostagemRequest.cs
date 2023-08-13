using Newtonsoft.Json;

namespace CorreiosClient.Models
{
    internal class AutenticarCartaoPostagemRequest
    {
        [JsonProperty("numero")]
        internal string Numero { get; set; }
    }
}
