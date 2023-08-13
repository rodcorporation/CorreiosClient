using Newtonsoft.Json;
using System;

namespace CorreiosClient.Models
{
    public class CalcularPrazoResponse
    {
        [JsonProperty("coProduto")]
        public string CodigoProduto { get; set; }
        
        [JsonProperty("prazoEntrega")]
        public int PrazoEntrega { get; set; }
        
        [JsonProperty("dataMaxima")]
        public DateTime DataMaxima { get; set; }
        
        [JsonProperty("entregaDomiciliar")]
        public string EntregaDomiciliar { get; set; }
        
        [JsonProperty("entregaSabado")]
        public string EntregaSabado { get; set; }
    }
}
