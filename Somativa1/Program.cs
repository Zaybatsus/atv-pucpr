using Somativa1.GraphQL;

var builder = WebApplication.CreateBuilder(args);

// GraphQL
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

// endpoint GraphQL
app.MapGraphQL();

app.Run();