using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CorreiosClient.Models
{
    internal class AutenticarCartaoPostagemResponse
    {
        [JsonProperty("ambiente")]
        internal string Ambiente { get; set; }
        
        [JsonProperty("ambiente")] 
        internal string Id { get; set; }
        
        [JsonProperty("ambiente")] 
        internal string Ip { get; set; }
        
        [JsonProperty("ambiente")] 
        internal string Perfil { get; set; }
        
        [JsonProperty("ambiente")] 
        internal string Cnpj { get; set; }
        
        [JsonProperty("ambiente")] 
        internal CartaoPostagemAutenticarCartaoPostagemResponse CartaoPostagem { get; set; }
        
        [JsonProperty("emissao")]
        internal DateTime Emissao { get; set; }
        
        [JsonProperty("expiraEm")]
        internal DateTime ExpiraEm { get; set; }
        
        [JsonProperty("offset")]
        internal string Offset { get; set; }
        
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
