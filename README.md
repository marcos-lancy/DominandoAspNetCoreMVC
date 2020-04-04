# Dominando AspNet Core MVC

Projeto criado para desenvolver skills em Asp.Net Core.

## Observação important

Foi forçado no arquivo 'global.json' a versão sdk. Isso 'trava' a aplicação para usar apenas essa versão. Dessa forma, se tem mais controle na versão que o projeto se encontra.
Para baixar o projeto e compilar, sera preciso ter a versão "3.1.201" ou adaptar a versão editando o arquivo para a versão desejada. Lembrando que editando a versão, pode ocorrer erros de compatibilidades, tente ficar em 3.x.

### Libs e links
Fluent API para mapeamentos;
[fluent](https://docs.microsoft.com/pt-br/ef/ef6/modeling/code-first/fluent/types-and-properties)
OBS: Farei uso do complemento Relational em uso no fluent.
[relational](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Relational/2.2.6)

Entity Frameword Core;
[entity](https://docs.microsoft.com/pt-br/ef/core/)

EntityFrameqoekCore.SqlServer;
[SqlServer](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/2.2.6)
OBD: Para gerar o arquivo Sql separado do migration.
PS: Comando para gerar o sql 'Script-Migration -Context MeuDbContext' e 'Script-Migration -Context ApplicationDbContext'

AutoMapper.Extensions.Microsoft.DependencyInjection
[automapper](https://www.nuget.org/packages/AutoMapper.Extensions.Microsoft.DependencyInjection/)

### Arquivo SQL
Caso queria o Sql ao invez do migration, o mesmo esta dentro da em /sql

### Migration
#### Todos os comandos foram executados para ambos os contextos 'MeuDbConext' e 'ApplicationDbContext'.
Para subir o banco de dados, trabalhe com Migrations via console.
OBS: Será necessário gerar migration para ambos os contexts 'MeuDbContext' e ''

1. Add-Migration Initial -Context MeuDbContext
2. Add-Migration Initial -Context ApplicationDbContext

3. Update-Database -Context MeuDbContext
4. Update-Database -Context ApplicationDbContext
