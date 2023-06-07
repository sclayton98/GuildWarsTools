using GuildWarsApiClassLibrary;
using Moq;

namespace GuildWarsApiClassLibraryTests
{
    public class ApiAdapterTests
    {

        [Fact]
        public void ShouldCallApiPortWhenGettingMaterialStorage()
        {
            //Arrange
            Mock<IApiPort> mockPort = new Mock<IApiPort>();
            IApiAdapter apiAdapter = new ApiAdapter(mockPort.Object);

            //Act
            apiAdapter.GetMaterialStorage();

            //Assert
            mockPort.Verify(x => x.QueryApi(""), Times.Once());
        }
    }
}
