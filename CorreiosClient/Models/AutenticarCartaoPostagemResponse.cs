using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CorreiosClient.Models
{
    internal class AutenticarCartaoPostagemResponse
    {
        [JsonProperty("ambiente")]
        internal string Ambiente { get; set; }
        
        [JsonProperty("id")] 
        internal string Id { get; set; }
        
        [JsonProperty("ip")] 
        internal string Ip { get; set; }
        
        [JsonProperty("perfil")] 
        internal string Perfil { get; set; }
        
        [JsonProperty("cnpj")] 
        internal string Cnpj { get; set; }
        
        [JsonProperty("cartaoPostagem")] 
        internal CartaoPostagemAutenticarCartaoPostagemResponse CartaoPostagem { get; set; }
        
        [JsonProperty("emissao")]
        internal DateTime Emissao { get; set; }
        
        [JsonProperty("expiraEm")]
        internal DateTime ExpiraEm { get; set; }
        
        [JsonProperty("zoneOffset")]
        internal string ZoneOffset { get; set; }
        
        [JsonProperty("token")]
        internal string Token { get; set; }

        internal class CartaoPostagemAutenticarCartaoPostagemResponse
        {
            [JsonProperty("numero")]
            internal string Numero { get; set; }

            [JsonProperty("dr")]
            internal int Dr { get; set; }

            [JsonProperty("api")]
            internal List<int> Api { get; set; }
        }
    }
}
