namespace CorreiosClient
{
    public class EnvironmentSandbox : IEnvironment
    {
        public string GetUrl() => "https://apihom.correios.com.br";
    }
}
