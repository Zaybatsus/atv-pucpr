using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Somativa1.src.GraphQL;
using Somativa1.src.LoginAPI;
using Somativa1.src.Models;

namespace Somativa1.GraphQL
{
    public class Query
{
    public LoginResponse GetLogin([Service] GetLoginQuery service)
    {
        return service.GetLogin();
    }

    public List<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book { Id = 1, Title = "Clean Code" },
            new Book { Id = 2, Title = "The Pragmatic Programmer" }
        };
    }
}
}