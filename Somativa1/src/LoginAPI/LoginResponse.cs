using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Somativa1.src.LoginAPI
{
    public class LoginResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public string? Token { get; set; }
    }
}