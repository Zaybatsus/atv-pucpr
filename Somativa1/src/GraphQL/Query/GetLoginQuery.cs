using Somativa1.src.LoginAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Somativa1.src.GraphQL
{
    public class GetLoginQuery
    {
         public LoginResponse GetLogin()
        {
            return new LoginResponse
            {
                Success = true,
                Message = "Usuário já autenticado (mock)",
                Token = "token-existente"
            };
        }
    }
}