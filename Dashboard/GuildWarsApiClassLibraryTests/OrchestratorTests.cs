using GuildWarsApiClassLibrary;
using Moq;

namespace GuildWarsApiClassLibraryTests
{
    public class OrchestratorTests
    {
        [Fact]
        public void ShouldCallApiAdapterWhenGettingMaterialStorage()
        {
            //Arrange
            Mock<IApiAdapter> mockAdapter = new Mock<IApiAdapter>();
            IOrchestrator orchestrator = new Orchestrator(mockAdapter.Object);

            //Act
            orchestrator.GetMaterialStorage();

            //Assert
            mockAdapter.Verify(x => x.GetMaterialStorage(), Times.Once());
        }
    }
}
