using Somativa1.GraphQL;
using Somativa1.src.GraphQL;
using Somativa1.src.GraphQL.Mutation;
using Somativa1.src.LoginAPI;
using Somativa1.src.LoginAPI.AddLogin;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAddLogin, AddLoginAction>();
builder.Services.AddScoped<GetLoginQuery>();

// GraphQL
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();

// endpoint GraphQL
app.MapGraphQL();

app.Run();