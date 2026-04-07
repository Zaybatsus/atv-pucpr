using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Somativa1.src.LoginAPI.AddLogin
{
    public class AddLoginAction : IAddLogin
    {
        public Task<LoginResponse> AddLogin(LoginInput loginInput)
        {
            
           if (loginInput.Username == "admin" && loginInput.Password == "123")
            {
                return Task.FromResult(new LoginResponse
                {
                    Success = true,
                    Message = "Login realizado com sucesso",
                    Token = "fake-jwt-token-123"
                });
            }

            return Task.FromResult(new LoginResponse
            {
                Success = false,
                Message = "Usuário ou senha inválidos",
                Token = null
            });
        }
    }
}