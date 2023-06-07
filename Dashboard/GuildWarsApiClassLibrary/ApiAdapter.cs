namespace GuildWarsApiClassLibrary
{
    internal interface IApiAdapter
    {
        List<string> GetMaterialStorage();
    }

    public class ApiAdapter : IApiAdapter
    {
        private IApiPort _apiPort;

        public List<string> GetMaterialStorage()
        {
            return _apiPort.GetMaterialStorage();
        }
    }
}