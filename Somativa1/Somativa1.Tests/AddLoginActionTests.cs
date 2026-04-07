using Xunit;
using Somativa1.src.LoginAPI.AddLogin;
using Somativa1.src.LoginAPI;
using FluentAssertions;
using System.Threading.Tasks;

public class AddLoginActionTests
{
    [Fact]
    public async Task AddLogin_DeveRetornarSucesso_QuandoCredenciaisValidas()
    {
        var service = new AddLoginAction();

        var input = new LoginInput
        {
            Username = "admin",
            Password = "123"
        };

        var result = await service.AddLogin(input);

        result.Success.Should().BeTrue();
        result.Token.Should().Be("fake-jwt-token-123");
        result.Message.Should().Be("Login realizado com sucesso");
    }

    [Fact]
    public async Task AddLogin_DeveRetornarErro_QuandoCredenciaisInvalidas()
    {
        var service = new AddLoginAction();

        var input = new LoginInput
        {
            Username = "user",
            Password = "errado"
        };

        var result = await service.AddLogin(input);

        result.Success.Should().BeFalse();
        result.Token.Should().BeNull();
        result.Message.Should().Be("Usuário ou senha inválidos");
    }
}