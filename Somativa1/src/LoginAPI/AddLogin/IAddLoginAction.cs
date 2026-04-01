using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Somativa1.src.LoginAPI
{
    public interface IAddLogin
    {
        Task<LoginResponse> AddLogin(LoginInput loginInput);
    }
}