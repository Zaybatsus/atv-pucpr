using Somativa1.src.LoginAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Somativa1.src.GraphQL.Mutation
{
    public class Mutation
    {
         public async Task<LoginResponse> AddLogin(
            LoginInput input,
            [Service] IAddLogin service)
        {
            return await service.AddLogin(input);
        }
    }
}