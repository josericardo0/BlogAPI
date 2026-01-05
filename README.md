# Blog API - ASP.NET Core

API RESTful simples para gerenciamento de posts de blog e comentários.

## Tecnologias
- .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- Swagger

## Como executar o projeto

### 1. Clonar o repositório
```bash
git clone https://github.com/seu-usuario/blog-api.git
```
### 2. Abra a pasta do projeto na sua IDE ou no seu editor de texto/código. De preferência, use o Visual Studio Code e abra a pasta do projeto .NET ou execute via terminal o seguinte comando:
```bash
cd Blog-Api
```
### 3. Instale e adicione os pacotes e ferramentas utilizados no projeto (preferencialmente, um comando por vez):
```bash
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Swashbuckle.AspNetCore
```
### 4. Restaure as dependências e compile o projeto
```bash
dotnet restore
dotnet build
```
### 5. Crie o banco de dados com migrations:
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```
### 6. Execute o projeto .NET:
```bash
dotnet run
```
### 7. Acesse a URL do Swagger para visualizar cada endpoint e testar a aplicação:
```bash
http://localhost:5157/swagger
```

## Considerações finais
- Se eu tivesse mais tempo para o desenvolvimento do projeto, eu desenvolveria um front end básico para a aplicação, deixando o projeto numa vertente mais fullstack. Porém gostei muito de explorar o framework .NET e a linguagem C#, embora eu tenha maior experiência com Java, Spring e etc, gostei demais de fazer esse projeto e pretendo me aprofundar nessa stack.





