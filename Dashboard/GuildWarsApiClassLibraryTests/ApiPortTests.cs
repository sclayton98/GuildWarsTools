using FluentAssertions;
using GuildWarsApiClassLibrary;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;

namespace GuildWarsApiClassLibraryTests
{
    public class ApiPortTests : IClassFixture<ApiPortTestFixture>
    {
        private string _apiKey;

        public ApiPortTests(ApiPortTestFixture fixture)
        {
            _apiKey = fixture.ApiKey;
        }

        [Fact]
        public void ShouldGetMaterialStorageForGivenApiKey()
        {
            //Arrange
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apiKey);

            IApiPort apiPort = new ApiPort(httpClient);

            //Act
            HttpResponseMessage response = apiPort.QueryApi("https://api.guildwars2.com/v2/account/materials");

            string responseContent = response.Content.ReadAsStringAsync().Result;

            //Assert
            response.Should().NotBeNull();
        }
    }

    public class ApiPortTestFixture
    {
        public string ApiKey { get; internal set; }

        public ApiPortTestFixture()
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddUserSecrets<ApiPortTests>(optional: true)
                .Build();

            ApiKey = config["apiKeyForTests"];
        }
    }
}
