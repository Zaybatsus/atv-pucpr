using Xunit;
using Moq;
using Somativa1.src.GraphQL.Mutation;
using Somativa1.src.LoginAPI;
using FluentAssertions;

public class MutationTests
{
    [Fact]
    public async Task AddLogin_DeveRetornarSucesso()
    {
        var mockService = new Mock<IAddLogin>();

        mockService.Setup(s => s.AddLogin(It.IsAny<LoginInput>()))
            .ReturnsAsync(new LoginResponse
            {
                Success = true,
                Token = "fake-token"
            });

        var mutation = new Mutation();

        var result = await mutation.AddLogin(
            new LoginInput { Username = "test", Password = "123" },
            mockService.Object
        );

        result.Success.Should().BeTrue();
        result.Token.Should().Be("fake-token");
    }
}