# freight-management

O que é isso?

Este é um exemplo simples que pode fazer operações CRUD em um banco de dados Microsoft SQL Server.
É possível cadastrar usuários, transportadoras além de permitir que um usuário faça a classificação de uma transportadora.

O que é necessário para executar?

Você precisará do Visual Studio 2013 ou superior e uma conexão com o Sql Server.

1º) Você precisa definir sua string de conexão no arquivo freight-management\FreightManagement\FreightManagement\Web.config

2º) Este projeto utiliza Entity Framework Code First e assim sendo você poderá gerar sua base de dados atrás de migrations. 
Para isto, abra seu projeto no Visual Studio e em seguida acesse o menu Ferramentas , clique em Biblioteca Package Manager e, em seguida Package Manager Console.

Na Opção "Default Project" selecione o projeto "Data" e digite add-migration [NOME-SUA-MIGRATION]

Em seguida pressione enter e ao final do processo, digite update-database

Com seu banco de dados criado você poderá rodar o projeto, se cadastrar e conhecer mais.


