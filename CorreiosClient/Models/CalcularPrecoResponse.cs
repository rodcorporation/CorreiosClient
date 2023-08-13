using Newtonsoft.Json;

namespace CorreiosClient.Models
{
    public class CalcularPrecoResponse
    {
        [JsonProperty("coProduto")]
        public string CodigoProduto { get; set; }
        
        [JsonProperty("pcBase")]
        public string PrecoBase { get; set; }
        
        [JsonProperty("pcBaseGeral")]
        public string PrecoBaseGeral { get; set; }
        
        [JsonProperty("peVariacao")]
        public string PercentualVariacao { get; set; }
        
        [JsonProperty("pcReferencia")]
        public string PrecoReferencia { get; set; }
        
        [JsonProperty("vlBaseCalculoImposto")]
        public string ValorBaseCalculoImposto { get; set; }
        
        [JsonProperty("inPesoCubico")]
        public string IndicadorPesoCubico { get; set; }
        
        [JsonProperty("psCobrado")]
        public string PesoCobrado { get; set; }
        
        [JsonProperty("peAdValorem")]
        public string PercentualAdValorem { get; set; }
        
        [JsonProperty("vlSeguroAutomatico")]
        public string ValorSeguroAutomatico { get; set; }
        
        [JsonProperty("qtAdicional")]
        public string QuantidadeAdicional { get; set; }
        
        [JsonProperty("pcFaixa")]
        public string PrecoFaixa { get; set; }
        
        [JsonProperty("pcFaixaVariacao")]
        public string PrecoFaixaVariacao { get; set; }
        
        [JsonProperty("pcProduto")]
        public string PrecoProduto { get; set; }
        
        [JsonProperty("pcFinal")]
        public string PrecoFinal { get; set; }
    }
}
