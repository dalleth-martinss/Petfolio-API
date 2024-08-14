
# Exercicio CRUD Petfolio🐾 API 👩🏻‍💻📚
O Petfolio é um projeto de exercício que visa minha familiarização com os conceitos dos métodos HTTP e operações CRUD (Create, Read, Update, Delete). Ele permite o gerenciamento de informações relacionadas a animais de estimação. Aqui estão os principais pontos sobre o Petfolio:

- **Objetivo**:
O objetivo principal do Petfolio é fornecer uma interface para cadastrar, visualizar, atualizar e excluir informações sobre pets.🐾

## Ferramentas Utilizadas🛠️👩🏻‍💻

- **Visual Studio**: Ambiente de desenvolvimento integrado (IDE) utilizado para desenvolver o projeto.
- **Swagger**: Ferramenta para documentação e teste de APIs.
- **C#**: Linguagem de programação utilizada para desenvolver a API.

## Funcionalidades ⚙️ 👩🏻‍💻

- **Buscar todos os pets**: Recupera uma lista de todos os pets cadastrados.
- **Buscar pet por ID**: Recupera as informações de um pet específico pelo seu ID.
- **Atualizar dados do pet**: Atualiza as informações de um pet existente.
- **Deletar pet por ID**: Remove um pet específico do sistema pelo seu ID.

## Estrutura do Projeto 📚👩🏻‍💻

- **Petfolio.API**: Contém os arquivos principais da API.
  - `README.md`: Documentação do projeto.
  - `UseCases`: Contém os casos de uso para as operações CRUD.
    - `GetAll.cs`: Lógica para buscar todos os pets.
    - `GetById.cs`: Lógica para buscar um pet por ID.
    - `Register.cs`: Lógica para registrar um novo pet.
    - `Update.cs`: Lógica para atualizar um pet existente.
    - `Delete.cs`: Lógica para deletar um pet por ID.

- **Petfolio.Application**: Contém a lógica de aplicação.
  - `Pet`: Subpasta com arquivos relacionados às operações de pets.
  - `Enums`: Contém enums utilizados no projeto.

- **Petfolio.Communication**: Contém as classes de comunicação.
  - `Requests`: Contém as classes de requisição.
  - `Responses`: Contém as classes de resposta.

## Como Executar❤️👩🏻‍💻

1. Clone o repositório.
2. Abra o projeto no Visual Studio.
3. Compile e execute o projeto.
4. Acesse o Swagger para testar os endpoints da API.

## Contribuição 🔗👩🏻‍💻

Sinta-se à vontade para contribuir com o projeto. Caso queira, basta seguir os passos abaixo:

1. Faça um fork do repositório.
2. Crie uma nova branch (`git checkout -b feature/nova-funcionalidade`).
3. Faça commit das suas alterações (`git commit -am 'Adiciona nova funcionalidade'`).
4. Faça push para a branch (`git push origin feature/nova-funcionalidade`).
5. Abra um Pull Request.

## Licença📌

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](https://opensource.org/license/MIT) para mais informações.

---

Desenvolvido por [Dálleth Martins](https://github.com/dalleth-martinss)