using Newtonsoft.Json;
using System;

namespace CorreiosClient.Models
{
    public class CalcularPrecoResponse
    {
        [JsonProperty("coProduto")]
        public string CodigoProduto { get; set; }
        
        [JsonProperty("pcBase")]
        public Decimal PrecoBase { get; set; }
        
        [JsonProperty("pcBaseGeral")]
        public Decimal PrecoBaseGeral { get; set; }
        
        [JsonProperty("peVariacao")]
        public Decimal PercentualVariacao { get; set; }
        
        [JsonProperty("pcReferencia")]
        public Decimal PrecoReferencia { get; set; }
        
        [JsonProperty("vlBaseCalculoImposto")]
        public Decimal ValorBaseCalculoImposto { get; set; }
        
        [JsonProperty("inPesoCubico")]
        public string IndicadorPesoCubico { get; set; }
        
        [JsonProperty("psCobrado")]
        public double PesoCobrado { get; set; }
        
        [JsonProperty("peAdValorem")]
        public Decimal PercentualAdValorem { get; set; }
        
        [JsonProperty("vlSeguroAutomatico")]
        public Decimal ValorSeguroAutomatico { get; set; }
        
        [JsonProperty("qtAdicional")]
        public int QuantidadeAdicional { get; set; }
        
        [JsonProperty("pcFaixa")]
        public Decimal PrecoFaixa { get; set; }
        
        [JsonProperty("pcFaixaVariacao")]
        public Decimal PrecoFaixaVariacao { get; set; }
        
        [JsonProperty("pcProduto")]
        public Decimal PrecoProduto { get; set; }
        
        [JsonProperty("pcFinal")]
        public Decimal PrecoFinal { get; set; }
    }
}
