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
            IOrchestrator orchestrator = new Orchestrator();

            //Act
            List<string> materials = orchestrator.GetMaterialStorage();

            //Assert
            materials.Should().NotHaveCount(1);
        }
    }
}
