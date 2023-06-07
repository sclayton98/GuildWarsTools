namespace GuildWarsApiClassLibrary
{
    public interface IOrchestrator
    {
        List<string> GetMaterialStorage();
    }

    public class Orchestrator : IOrchestrator
    {
        private IApiAdapter _apiAdapter;

        public Orchestrator()
        {
        }

        public List<string> GetMaterialStorage()
        {
            return _apiAdapter.GetMaterialStorage();
        }
    }
}