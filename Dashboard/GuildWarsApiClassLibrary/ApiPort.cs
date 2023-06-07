namespace GuildWarsApiClassLibrary
{
    public interface IApiPort
    {
        List<string> GetMaterialStorage();
    }

    public class ApiPort : IApiPort
    {
        public List<string> GetMaterialStorage()
        {
            throw new NotImplementedException();
        }
    }
}