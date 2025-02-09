# ProductClientHub

## 📌 Descrição do Projeto
O **ProductClientHub** é uma API desenvolvida em **.NET 8** para gerenciar clientes e produtos. O projeto segue boas práticas de desenvolvimento, utilizando conceitos de **Programação Orientada a Objetos (POO)**, **Entity Framework Core** como ORM para manipulação do banco de dados **MySQL**, além de **FluentValidation** para validação de dados.

### 🏗 Importância das Tecnologias Utilizadas
- **Programação Orientada a Objetos (POO)**: Facilita a reutilização de código, a manutenção e a escalabilidade do sistema.
- **Entity Framework Core (EF Core)**: ORM que simplifica o acesso ao banco de dados, permitindo interações mais seguras e eficientes.
- **FluentValidation**: Ferramenta para validar os dados de entrada de forma clara e desacoplada.

## 🚀 Tecnologias Utilizadas
- **ASP.NET Core 8**
- **Entity Framework Core** (ORM)
- **MySQL** (Banco de Dados)
- **FluentValidation** (Validação de Dados)

## 📋 Pré-requisitos
Antes de começar, você precisará instalar as seguintes ferramentas:
- [.NET 8 ou superior](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [MySQL](https://www.mysql.com/downloads/)

```

## ▶️ Como Executar o Projeto
1. Clone este repositório:
   ```sh
   git clone https://github.com/seu-usuario/ProductClientHub.git
   ```
2. Acesse o diretório do projeto:
   ```sh
   cd ProductClientHub
   ```
3. Configure a string de conexão no **appsettings.json**:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Database=ProductClientHub;User=root;Password=suasenha;"
   }
   ```
4. Restaure as dependências do projeto:
   ```sh
   dotnet restore
   ```
5. Execute as migrações do banco de dados:
   ```sh
   dotnet ef database update
   ```
6. Inicie a aplicação:
   ```sh
   dotnet run --project ProductClientHub.API
   ```

A API estará disponível em: `https://localhost:5199`



## 📜 Licença
Este projeto está sob a licença MIT. Sinta-se à vontade para usá-lo e contribuir!

---
**Desenvolvido por Natã.** 🚀

