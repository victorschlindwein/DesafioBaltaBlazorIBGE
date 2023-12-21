# Desafio Balta Blazor IBGE

Esse projeto tem como objetivo servir um front-end criado em Blazor 8 para trazer dados do IBGE sobre munic�pios e stados brasileiros.

## Instru��es:
- Para usar as rotas de cria��o, edi��o e dele��o de registros � necess�rio estar autenticado.
- A autentica��o � realizada atrav�s de login e senha e � gerenciada atrav�s do Microsoft Identity.
- As rotas de busca s�o livres de autentica��o.

## Como executar o projeto localmente:
- Realizar o git clone do projeto
- Editar a connection string no ``appsettings.json``.
- Rodar as migrations ``dotnet ef database update``.

## Arquitetura:
- Utilizamos arquitetura Clean Architecture para constru��o do projeto.

<img src=".github/Architecture.png">

# Desenvolvedores:
[@jefersonquaiato](https://github.com/jefersonquaiato), [@teixeiralex](https://github.com/teixeiralex) e [@victorschlindwein](https://github.com/victorschlindwein)