namespace GuildWarsApiClassLibrary
{
    public interface IOrchestrator
    {
        List<string> GetMaterialStorage();
    }

    public class Orchestrator : IOrchestrator
    {
        private IApiAdapter _apiAdapter;

        public Orchestrator(IApiAdapter apiAdapter)
        {
            _apiAdapter = apiAdapter;
        }

        public List<string> GetMaterialStorage()
        {
            return _apiAdapter.GetMaterialStorage();
        }
    }
}