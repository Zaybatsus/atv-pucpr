# atv-pucpr
Atividade Somativa - PUCPR - DevOps

Link: http://localhost:5201/graphql/

    <PackageReference Include="Microsoft.AspNetCore.OpenApi" Version="10.0.5" />

Para testar Query:
query{
   login{
     success
      message
       token
   }
}


Para testar Mutation:
mutation {
  addLogin(input: {
    username: "admin",
    password: "123"
  }) {
    success
    message
    token
  }
}