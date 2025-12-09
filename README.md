# EnergisaNotes API

> **Versão:** 1.0.0
> **Status:** Em Desenvolvimento

## 1. Visão Geral do Projeto
O **EnergisaNotes** é uma solução corporativa de *Backend as a Service* (BaaS) desenvolvida para orquestrar a gestão de comunicação de incidentes e o diretório de contatos da organização. O sistema atua como a fonte da verdade para templates dinâmicos de texto e dados cadastrais de colaboradores, integrando-se nativamente ao ecossistema Microsoft 365.

O projeto segue os princípios da **Clean Architecture** e utiliza variáveis de ambiente (`.env`) para a gestão segura de credenciais.

## 2. Stack Tecnológica

* **Runtime:** .NET 8 (LTS)
* **Framework:** ASP.NET Core Web API
* **ORM:** Entity Framework Core 8.0.2
* **Database Provider:** Pomelo.EntityFrameworkCore.MySql (MySQL 8.0)
* **Identity Provider:** Microsoft Entra ID (Azure AD).
* **Configuration:** DotNetEnv (Gerenciamento de Segredos).
* **Documentation:** Swashbuckle (OpenAPI 3.0).

---

## 3. Arquitetura da Solução

A solução segue uma estrutura *N-Tier* segregada para impor limites arquiteturais estritos:

### 3.1. EnergisaNotes.Domain (Core)
Camada agnóstica de frameworks externos. Contém:
* **Entidades:** Classes ricas (`Incidente`, `Usuario`) com validações internas e encapsulamento (`private set`).
* **Interfaces:** Contratos de repositório (`IIncidenteRepository`) que definem as operações permitidas.

### 3.2. EnergisaNotes.Infra (Persistence)
Implementação concreta do acesso a dados. Contém:
* **DbContext:** Mapeamento EF Core.
* **Repositories:** Acesso ao MySQL.

### 3.3. EnergisaNotes.API (Presentation)
Ponto de entrada da aplicação. Responsável por:
* **Controllers & DTOs:** Interface HTTP e contratos de dados.
* **Configuração de Ambiente:** Leitura do arquivo `.env`.

### 3.4. Vantagens da Arquitetura Adotada
A escolha pela **Clean Architecture** proporciona benefícios estratégicos para o ciclo de vida do software:

* **Independência de Frameworks:** O núcleo do negócio (`Domain`) não depende de bibliotecas externas ou drivers de banco de dados. Isso protege as regras de negócio contra obsolescência tecnológica.
* **Testabilidade:** A lógica de negócio pode ser testada unitariamente sem a necessidade de um banco de dados real ou servidor web, utilizando *mocks* dos repositórios.
* **Intercambiabilidade de Banco de Dados:** A implementação do MySQL está isolada na camada `Infra`. Migrar para SQL Server ou PostgreSQL exigiria alterações apenas nesta camada, sem impactar a API ou o Domínio.
* **Segurança e Encapsulamento:** O uso de **DTOs** na API impede a exposição acidental de dados sensíveis da entidade (como chaves de particionamento ou dados de auditoria interna) e o uso de **Domínios Ricos** impede que o sistema entre em um estado inválido.

---

## 4. Pré-requisitos de Ambiente

Para executar o projeto localmente:
* **.NET SDK 8.0+** instalado.
* **MySQL Server 8.0+** em execução.
* **Git**.

---

## 5. Configuração (Environment Setup)

O projeto utiliza a biblioteca **DotNetEnv** para carregar variáveis sensíveis. **Não commite credenciais no Git.**

### 5.1. Criar o arquivo `.env`
Na raiz da solução (mesma pasta do arquivo `.sln`), crie um arquivo chamado **`.env`** e preencha com suas credenciais locais:

```ini
# --- Banco de Dados MySQL ---
DB_SERVER=localhost
DB_PORT=3306
DB_DATABASE=EnergisaNotesDb
DB_USER=root
DB_PASSWORD=SUA_SENHA_AQUI

# --- Microsoft Azure AD (Opcional para teste anônimo) ---
AZURE_TENANT_ID=SEU_TENANT_ID
AZURE_CLIENT_ID=SEU_CLIENT_ID
AZURE_DOMAIN=energisa.com.br
```


### 5.2. Configuração do appsettings.json
O arquivo appsettings.json permanece apenas com configurações estruturais e de log, pois as senhas são injetadas via código (Program.cs) lendo o .env.

## 6. Instalação e Execução

### 6.1. Restauração de Dependências
Na raiz da solução, execute:
```bash
dotnet restore
```

### 6.2. Migrations e Database Update
Execute a partir do diretório EnergisaNotes.API. O comando lerá a conexão configurada via .env:
```bash
# Aplica as migrações ao banco de dados MySQL
dotnet ef database update --project ../EnergisaNotes.Infra --startup-project .
```
### 6.3. Executando a API
```bash
dotnet run
```
A aplicação iniciará nas portas padrão (ex: https://localhost:7150).

## 7. Autenticação e Segurança

A API utiliza o esquema Bearer Authentication (JWT) do Microsoft Entra ID.

Testando com Swagger ou Postman

* **Obtenha um Token no Azure AD (via Postman OAuth2 flow).**

* **Adicione o Header: ```Authorization: Bearer <SEU_TOKEN_JWT>```.**

* **As rotas validam a Audience configurada no ```appsettings.json``` ou variáveis de ambiente.**

Nota: Se você não possui credenciais Azure, certifique-se de usar``` [AllowAnonymous] ```nos Controllers para desenvolvimento local.

## 8. Troubleshooting (Problemas Comuns

```Access denied for user``` ou Erro de Conexão
Causa: O sistema não conseguiu ler a senha do banco. Solução:

Verifique se o arquivo ```.env ``` está criado na raiz do projeto API (ou onde o binário é executado).

Verifique se as chaves no ```.env (DB_PASSWORD)``` correspondem ao que o ```Program.cs``` espera.

```ReflectionTypeLoadException```
Causa: Conflito de DLLs ou versões de pacotes. Solução: Apague as pastas``` bin ```e``` obj``` de todos os projetos e recompile ```(dotnet build)```.

## 9. Padrões de Código
Segurança: O arquivo ```.env```está listado no ```.gitignore``` e nunca deve ser enviado ao repositório remoto.

Commits: Seguir a especificação Conventional Commits.
