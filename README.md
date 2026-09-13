# VideoGameCharacterAPI

API RESTful simples em ASP.NET Core para gerenciar personagens de videogame (CRUD).

Visão geral
---------
Projeto demonstrativo que expõe endpoints para criar, listar, atualizar e remover personagens de videogame. Desenvolvido em .NET 10.

Principais funcionalidades
-------------------------
- Endpoints CRUD para a entidade VideoGameCharacter
- Respostas em JSON
- Uso de DTOs para entrada/saída

Requisitos
----------
- .NET 10 SDK (https://dotnet.microsoft.com)
- Visual Studio 2022/2026 ou VS Code

Como executar
-------------
1. Restaurar dependências:

   dotnet restore

2. Buildar o projeto:

   dotnet build

3. Executar a API:

   dotnet run --project VideoGameCharacterAPI

Após executar, a API normalmente ficará disponível em http://localhost:5000 ou https://localhost:5001 (conforme configuração de launchSettings).

Endpoints (exemplo)
-------------------
- GET    /api/videogamecharacters        -> Lista todos os personagens
- GET    /api/videogamecharacters/{id}   -> Recupera personagem por id
- POST   /api/videogamecharacters        -> Cria novo personagem (body: DTO)
- PUT    /api/videogamecharacters/{id}   -> Atualiza personagem existente
- DELETE /api/videogamecharacters/{id}   -> Remove personagem

Estrutura do projeto
---------------------
- Controllers/          -> Controladores HTTP (VideoGameCharactersController)
- Models/               -> Modelos de domínio
- DTOs/                 -> Objetos de transferência (ex.: GetCharacterResponseDTO)
- Data/                 -> Persistência (in-memory ou EF Core, conforme implementação)

Testes
------
Se houver um projeto de testes incluído, execute:

   dotnet test

Contribuição
------------
Pull requests são bem-vindos. Para mudanças maiores, abra uma issue antes para discutirmos a implementação.

Licença
-------
Defina a licença do projeto conforme sua preferência (ex.: MIT).

Contato
-------
Abra uma issue no repositório para bugs, dúvidas ou sugestões.
