# Projeto de Estágio na iData

Este projeto foi desenvolvido como parte do processo seletivo para uma vaga de estágio na iData. O objetivo do projeto é criar uma aplicação para consultar recrutamentos de forma eficiente.

## Descrição

A aplicação permite aos usuários visualizar a lista do banco de dados fornecido pela empresa para a realização da API

## Tecnologias Utilizadas

- **Linguagem de Programação:** C#
- **Banco de Dados:** MySQL
- **Framework Web:** ASP.NET Core
- **Bibliotecas/Ferramentas:** Entity Framework Core, Axios (para requisições HTTP no front-end), Ag-Grid (para a exibição de dados tabulares no front-end)

## Estrutura do Projeto

O projeto é organizado em várias partes:

- **`EstagioiData.Model`**: Contém a definição do modelo de dados para os recrutamentos.
- **`EstagioiData.ViewModel`**: Contém as classes de ViewModel utilizadas para transferir dados entre o back-end e o front-end.
- **`EstagioiData.infraestrutura`**: Responsável por configurar a infraestrutura do projeto, incluindo o contexto de banco de dados e os repositórios.
- **`EstagioiData.Controllers`**: Contém os controladores da API responsáveis por lidar com as requisições HTTP.
- **`EstagioiData.ClientApp`**: Diretório para a aplicação front-end, onde estão localizados os componentes React.

## Autor

Este projeto foi desenvolvido por Vinícius Maurer
