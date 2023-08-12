namespace CorreiosClient
{
    public class EnvironmentProduction : IEnvironment
    {
        public string GetUrl() => "https://api.mandae.com.br/v2";
    }
}
