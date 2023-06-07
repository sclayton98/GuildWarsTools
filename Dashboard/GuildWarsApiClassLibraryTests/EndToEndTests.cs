using FluentAssertions;
using GuildWarsApiClassLibrary;

namespace GuildWarsApiClassLibraryTests
{
    public class EndToEndTests
    {
        [Fact]
        public void ShouldGetContentsOfMaterialStorage()
        {
            //Arrange
            HttpClient httpClient = null;
            IApiPort apiPort = new ApiPort(httpClient);
            IApiAdapter apiAdapter = new ApiAdapter(apiPort);
            IOrchestrator orchestrator = new Orchestrator(apiAdapter);

            //Act
            List<string> materials = orchestrator.GetMaterialStorage();

            //Assert
            materials.Should().NotHaveCount(1);
        }
    }
}
