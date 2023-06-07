namespace GuildWarsApiClassLibrary
{
    public interface IApiPort
    {
        HttpResponseMessage QueryApi(string endpointUrl);
    }

    public class ApiPort : IApiPort
    {
        private HttpClient _httpClient;

        public ApiPort(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public HttpResponseMessage QueryApi(string endpointUrl)
        {
            return _httpClient.GetAsync(endpointUrl).Result;
        }
    }
}