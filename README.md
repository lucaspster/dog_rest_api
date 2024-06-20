Aqui está um exemplo de arquivo README para um projeto ASP.NET Core com duas soluções:

# Nome do Projeto

Este projeto contém duas soluções: **WebApiDog** e **AspNetCore**. Ambas as soluções estão desenvolvidas em ASP.NET Core.

## Estrutura do Projeto

- **WebApiDog**: Solução principal que contém a API Web para gerenciamento de Dog.
- **AspNetCore**: Interface Web para acessar a Api

## Requisitos

- .NET 6 SDK ou superior
- Visual Studio 2022 ou superior

## Instalação

1. Clone o repositório:
   ```bash
   git clone https://github.com/lucaspster/dog_rest_api
   cd seu-repositorio
   ```

2. Restaure os pacotes NuGet:
   ```bash
   dotnet restore
   ```

## Executando a Aplicação

1. Navegue até o diretório da solução desejada:
   ```bash
   cd WebApiDog
   ```

2. Execute o projeto:
   ```bash
   dotnet run
   ```

3. Acesse a aplicação no navegador:
   ```bash
   http://localhost:5000
   ```

## Uso

### Endpoints da Web API

- **GET /api/Dog**: Retorna a lista de raças de cães.

## Contribuindo

1. Faça um fork do repositório.
2. Crie uma branch para sua feature ou correção:
   ```bash
   git checkout -b minha-feature
   ```
3. Commit suas mudanças:
   ```bash
   git commit -m "Minha nova feature"
   ```
4. Envie para o seu repositório:
   ```bash
   git push origin minha-feature
   ```
5. Abra um Pull Request.



