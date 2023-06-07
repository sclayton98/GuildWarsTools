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
            IApiPort apiPort = new ApiPort();
            IApiAdapter apiAdapter = new ApiAdapter(apiPort);
            IOrchestrator orchestrator = new Orchestrator(apiAdapter);

            //Act
            List<string> materials = orchestrator.GetMaterialStorage();

            //Assert
            materials.Should().NotHaveCount(1);
        }
    }
}
