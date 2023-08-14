using CorreiosClient.Models;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CorreiosClient
{
    public sealed class Correios
    {
        private readonly Credential _credential;
        private readonly IEnvironment _environment;
        private readonly HttpClient _httpClient;
        private AutenticarCartaoPostagemResponse _autenticarCartaoPostagemResponse;

        public Correios(Credential credential,
                        IEnvironment environment)
        {
            _credential = credential;
            _environment = environment;

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_environment.GetUrl()),
            };
        }

        public void Autenticar()
        {
            var request = new AutenticarCartaoPostagemRequest()
            {
                Numero = _credential.CartaoDePostagem
            };

            var content = new StringContent(JsonConvert.SerializeObject(request));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var client = new HttpClient
            {
                BaseAddress = new Uri(_environment.GetUrl()),
            };

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _credential.AuthorizationBasic);

            var response = client.PostAsync($"/token/v1/autentica/cartaopostagem", content).Result;

            if (!response.IsSuccessStatusCode)
            {
                var message = JsonConvert.DeserializeObject<MessageResponse>(response.Content.ReadAsStringAsync().Result);

                throw new Exception(message.Messages.FirstOrDefault() ?? "Ocorreu um erro");
            }

            _autenticarCartaoPostagemResponse = JsonConvert.DeserializeObject<AutenticarCartaoPostagemResponse>(response.Content.ReadAsStringAsync().Result);

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _autenticarCartaoPostagemResponse.Token);
        }

        public ApiResponse<CalcularPrazoResponse> CalcularPrazo(string codigoServico,
                                                                string cepOrigem,
                                                                string cepDestino)
        {
            var response = _httpClient.GetAsync($"/prazo/v1/nacional/{codigoServico}?cepOrigem={cepOrigem}&cepDestino={cepDestino}").Result;

            if (!response.IsSuccessStatusCode)
                return new ApiResponse<CalcularPrazoResponse>(JsonConvert.DeserializeObject<MessageResponse>(response.Content.ReadAsStringAsync().Result));

            return new ApiResponse<CalcularPrazoResponse>(response.Content.ReadAsStringAsync().Result);
        }

        public ApiResponse<CalcularPrecoResponse> CalcularPreco(string codigoServico,
                                                                string cepOrigem,
                                                                string cepDestino,
                                                                string pesoEmGramas)
        {
            var response = _httpClient.GetAsync($"/preco/v1/nacional/{codigoServico}?cepOrigem={cepOrigem}&cepDestino={cepDestino}&psObjeto={pesoEmGramas}").Result;

            if (!response.IsSuccessStatusCode)
                return new ApiResponse<CalcularPrecoResponse>(JsonConvert.DeserializeObject<MessageResponse>(response.Content.ReadAsStringAsync().Result));

            return new ApiResponse<CalcularPrecoResponse>(JsonConvert.DeserializeObject<CalcularPrecoResponse>(response.Content.ReadAsStringAsync().Result, new JsonSerializerSettings
            {
                Culture = System.Globalization.CultureInfo.GetCultureInfo("pt-BR")
            }));
        }

        public ApiResponse<ConsultarObjetoResponse> ConsultarObjeto(string codigoObjeto)
        {
            var response = _httpClient.GetAsync($"/srorastro/v1/objetos/{codigoObjeto}?resultado=T").Result;

            if (!response.IsSuccessStatusCode)
                return new ApiResponse<ConsultarObjetoResponse>(JsonConvert.DeserializeObject<MessageResponse>(response.Content.ReadAsStringAsync().Result));

            return new ApiResponse<ConsultarObjetoResponse>(response.Content.ReadAsStringAsync().Result);
        }
    }
}
