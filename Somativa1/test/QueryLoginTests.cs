using Xunit;
using Somativa1.GraphQL;
using Somativa1.src.GraphQL;
using FluentAssertions;

public class QueryLoginTests
{
    [Fact]
    public void GetLogin_DeveUsarService()
    {
        var service = new GetLoginQuery();
        var query = new Query();

        var result = query.GetLogin(service);

        result.Should().NotBeNull();
        result.Success.Should().BeTrue();
    }
}