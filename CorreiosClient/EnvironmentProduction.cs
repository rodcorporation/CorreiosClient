namespace CorreiosClient
{
    public class EnvironmentProduction : IEnvironment
    {
        public string GetUrl() => "https://api.correios.com.br";
    }
}
