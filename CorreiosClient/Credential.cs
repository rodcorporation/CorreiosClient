using System;
using System.Text;

namespace CorreiosClient
{
    public class Credential
    {
        public string Usuario { get; internal set; }

        public string CodigoAcessoAPI { get; internal set; }

        public string CartaoDePostagem { get; internal set; }

        public string AuthorizationBasic => Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Usuario}:{CodigoAcessoAPI}"));

        public Credential(string usuario,
                          string codigoAcessoAPI,
                          string cartaoDePostagem)
        {
            Usuario = usuario;
            CodigoAcessoAPI = codigoAcessoAPI;
            CartaoDePostagem = cartaoDePostagem;
        }
    }
}
