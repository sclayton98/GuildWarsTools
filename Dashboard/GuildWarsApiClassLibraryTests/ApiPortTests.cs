using FluentAssertions;
using GuildWarsApiClassLibrary;

namespace GuildWarsApiClassLibraryTests
{
    public class ApiPortTests
    {

        [Fact]
        public void ShouldGetMaterialStorageForGivenApiKey()
        {
            //Arrange
            IApiPort apiPort = new ApiPort();

            //Act
            List<string> response = apiPort.GetMaterialStorage();

            //Assert
            response.Should().HaveCount(1);
        }
    }
}
