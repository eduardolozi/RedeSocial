# Projeto de Rede Social - Instagram Clone

Olá, bem-vindo ao meu projeto de rede social, uma aplicação inspirada no Instagram, desenvolvida em .NET. Neste projeto, estou focando em seguir as melhores práticas de desenvolvimento, utilizando Clean Architecture, Injeção de Dependência, Padrão Repository com RavenDB Cloud, autenticação com Token JWT e construindo uma API Rest robusta.

## Sobre o Projeto

Este projeto tem como objetivo criar uma plataforma de rede social onde os usuários podem compartilhar fotos, seguir outros usuários, comentar em postagens e interagir de maneira semelhante ao Instagram. A estrutura e o design do sistema foram cuidadosamente planejados para promover a modularidade, escalabilidade e manutenibilidade.

## Tecnologias Utilizadas

### Clean Architecture

A aplicação segue os princípios da [Clean Architecture](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html), dividindo o sistema em camadas bem definidas - Aplicação, Domínio e Infraestrutura. Essa abordagem visa manter uma separação clara de responsabilidades e facilitar a substituição de componentes sem afetar a lógica central da aplicação.

### Injeção de Dependência

A [Injeção de Dependência](https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection) é fundamental para garantir a flexibilidade e a testabilidade do código. Utilizo a Injeção de Dependência nativa do .NET para gerenciar as dependências entre os componentes do sistema.

### Padrão Repository com RavenDB Cloud

A persistência de dados é implementada seguindo o [Padrão Repository](https://docs.microsoft.com/en-us/ef/core/repatterns/repository) proporcionando uma camada de abstração entre a lógica de negócios e o banco de dados. Estou utilizando o [RavenDB Cloud](https://cloud.ravendb.net/) como o sistema de gerenciamento de banco de dados NoSQL, garantindo desempenho e escalabilidade.

### Autenticação com Token JWT

A autenticação é realizada através de Token JWT (JSON Web Token), proporcionando uma maneira segura e eficiente de autenticar usuários na aplicação. Essa abordagem é essencial para proteger as rotas da API e garantir o acesso controlado aos recursos.

### API Rest

A aplicação é construída como uma API Rest, permitindo a interação fácil e eficiente com diferentes clientes, como aplicativos web e móveis. Os endpoints da API seguem padrões RESTful para uma comunicação clara e consistente.

