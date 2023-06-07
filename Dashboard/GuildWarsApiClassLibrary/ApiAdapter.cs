namespace GuildWarsApiClassLibrary
{
    public interface IApiAdapter
    {
        List<string> GetMaterialStorage();
    }

    public class ApiAdapter : IApiAdapter
    {
        private IApiPort _apiPort;

        public ApiAdapter(IApiPort apiPort)
        {
            _apiPort = apiPort;
        }

        public List<string> GetMaterialStorage()
        {
            return _apiPort.GetMaterialStorage();
        }
    }
}