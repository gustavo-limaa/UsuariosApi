👤 UsuariosApi - Gestão de Autenticação
Esta API é responsável por todo o ecossistema de usuários do sistema de cinemas, utilizando ASP.NET Core Identity para garantir segurança e robustez no armazenamento de credenciais.

🏗️ Arquitetura do Projeto
O projeto segue o padrão de camadas para facilitar a manutenção e escalabilidade:

Controllers: Porta de entrada da API. O UsuarioController gerencia as requisições de cadastro.

Services: Camada de lógica de negócio. A CadastroService isola a comunicação com o Identity.

Data (Context/Dtos): Gerenciamento do banco de dados MySQL via UsuarioDbContext e transferência de dados limpa com DTOs.

Models: Definição da entidade Usuario, que estende as funcionalidades do IdentityUser.

Profiles: Mapeamento inteligente entre Entidades e DTOs usando AutoMapper.

🚀 Funcionalidades Atuais
1. Cadastro de Novos Usuários
O sistema permite a criação de usuários com validações rigorosas de dados.

Endpoint: POST /api/Usuario

Regras de Negócio:

O Username é obrigatório.

Verificação de maioridade ou data de nascimento via DataNascimento.

Segurança: Senha e confirmação de senha (RePassword) devem ser idênticas.

🛠️ Tecnologias Utilizadas
ASP.NET Core 6/7/8

Entity Framework Core: ORM para persistência.

Identity Core: Gestão de autenticação e criptografia de senhas.

MySQL: Banco de dados relacional.

AutoMapper: Para mapeamento de objetos.

📝 Como configurar o ambiente
Banco de Dados: Certifique-se de que a Connection String no appsettings.json aponta para seu servidor MySQL.

Migrations: Como o projeto já possui a migration inicial (Criando Usuario), execute:

Bash

dotnet ef database update
Execução: Rode o projeto e utilize o Swagger ou Postman para testar os endpoints.
