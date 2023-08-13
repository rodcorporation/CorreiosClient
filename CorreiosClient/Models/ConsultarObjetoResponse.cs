using Newtonsoft.Json;
using System.Collections.Generic;

namespace CorreiosClient.Models
{
    public class ConsultarObjetoResponse
    {
        [JsonProperty("versao")]
        public string Versao { get; set; }

        [JsonProperty("quantidade")]
        public int quantidade { get; set; }

        [JsonProperty("objetos")]
        public List<ObjetoConsultarObjetoResponse> Objetos { get; set; }

        public class ObjetoConsultarObjetoResponse
        {
            [JsonProperty("codObjeto")]
            public string CodigoObjeto { get; set; }

            [JsonProperty("tipoPostal")]
            public TipoPostalObjetoConsultarObjetoResponse TipoPostal { get; set; }

            [JsonProperty("versao")]
            public List<EventoObjetoConsultarObjetoResponse> Eventos { get; set; }
        }

        public class TipoPostalObjetoConsultarObjetoResponse
        {
            [JsonProperty("sigla")]
            public string Sigla { get; set; }
            
            [JsonProperty("descricao")]
            public string Descricao { get; set; }

            [JsonProperty("categoria")]
            public string Categoria { get; set; }

        }

        public class EventoObjetoConsultarObjetoResponse
        {
            [JsonProperty("codigo")]
            public string Codigo { get; set; }

            [JsonProperty("tipo")]
            public string Tipo { get; set; }

            [JsonProperty("dtHrCriado")]
            public string DataHoraCriado { get; set; }

            [JsonProperty("descricao")]
            public string Descricao { get; set; }

            [JsonProperty("detalhe")]
            public string Detalhe { get; set; }
        }

        public class UnidadeEventoObjetoConsultarObjetoResponse
        {
            [JsonProperty("tipo")]
            public string Tipo { get; set; }

            [JsonProperty("endereco")]
            public EnderecoUnidadeEventoObjetoConsultarObjetoResponse Endereco { get; set; }
        }

        public class EnderecoUnidadeEventoObjetoConsultarObjetoResponse
        {
            [JsonProperty("cidade")]
            public string Cidade { get; set; }

            [JsonProperty("uf")]
            public string Uf { get; set; }
        }

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
