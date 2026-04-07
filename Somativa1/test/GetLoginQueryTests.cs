using Xunit;
using Somativa1.src.GraphQL;
using FluentAssertions;

public class GetLoginQueryTests
{
    [Fact]
    public void GetLogin_DeveRetornarSucesso()
    {
        var service = new GetLoginQuery();

        var result = service.GetLogin();

        result.Success.Should().BeTrue();
        result.Token.Should().Be("token-existente");
    }
}