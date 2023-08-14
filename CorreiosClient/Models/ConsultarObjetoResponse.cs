using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CorreiosClient.Models
{
    public class ConsultarObjetoResponse
    {
        [JsonProperty("versao")]
        public string Versao { get; set; }

        [JsonProperty("quantidade")]
        public int Quantidade { get; set; }

        [JsonProperty("objetos")]
        public List<ObjetoConsultarObjetoResponse> Objetos { get; set; }

        public class ObjetoConsultarObjetoResponse
        {
            [JsonProperty("codObjeto")]
            public string CodigoObjeto { get; set; }

            [JsonProperty("tipoPostal")]
            public TipoPostalObjetoConsultarObjetoResponse TipoPostal { get; set; }

            [JsonProperty("eventos")]
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
            public DateTime DataHoraCriado { get; set; }

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
    }
}
