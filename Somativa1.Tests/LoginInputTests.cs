using Xunit;
using Somativa1.src.LoginAPI;
using FluentAssertions;

public class LoginInputTests
{
    [Fact]
    public void LoginInput_DeveArmazenarDados()
    {
        var input = new LoginInput
        {
            Username = "user",
            Password = "pass"
        };

        input.Username.Should().Be("user");
        input.Password.Should().Be("pass");
    }
}