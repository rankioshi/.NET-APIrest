
# .NET-APIrest

API RESTful desenvolvida em .NET para gerenciamento de pessoas, utilizando Entity Framework e SQLite.

---

## Funcionalidades

- CRUD completo de pessoas (Create, Read, Update, Delete)
- Integração com banco de dados SQLite
- Documentação automática via Swagger

---

## Como rodar o projeto

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/rankioshi/.NET-APIrest.git
   ```
2. **Acesse a pasta do projeto:**
   ```bash
   cd .NET-APIrest
   ```
3. **Restaure os pacotes e rode a aplicação:**
   ```bash
   dotnet restore
   dotnet run
   ```
4. **Acesse o Swagger:**
   Normalmente disponível em `http://localhost:5000/swagger` ou conforme configurado no projeto.

---

## Estrutura do Projeto

- **Data/**: Contexto do banco de dados e configurações do Entity Framework
- **Migrations/**: Migrações do banco de dados
- **Models/**: Modelos de dados (ex: Person)
- **Routes/**: Rotas/endpoints da API

---

## Exemplos de Uso

### 1. Listagem de Pessoas

```
GET /api/person
```

### 2. Cadastro de Pessoa

```
POST /api/person
Body: {
  "name": "Exemplo",
  "age": 30
}
```

---

## Imagens do Projeto

**Swagger UI**

<img src="https://cdn.discordapp.com/attachments/1229834827721605152/1370111532045959329/image.png?ex=681e4f4c&is=681cfdcc&hm=9f9e1c117e706ceec3ef1bab398db8b0b969c81c717b444334e050fd6e1befd6&"  />

**Exemplo de Requisição no Swagger**
>
> <img src="https://cdn.discordapp.com/attachments/1229834827721605152/1370113122618179595/image.png?ex=681e50c7&is=681cff47&hm=131151f8330bcfde35b4a07bec251fbfae0421f4f35643a433745014fec8e6e1&"  />

<img src="https://cdn.discordapp.com/attachments/1229834827721605152/1370113157007409222/image.png?ex=681e50d0&is=681cff50&hm=1252f565ff508f0680e8962dd70f9bcac8ae2df2f503d5b5ca1fac755b340bd5&"  />

**Confirmação no Get**

<img src="https://media.discordapp.net/attachments/1229834827721605152/1370113287441875045/image.png?ex=681e50ef&is=681cff6f&hm=ebddb6b3996d143d7afdb05bdcb8d63eb54d0a3f3aa2d65a33939084ff7479bc&=&format=webp&quality=lossless&width=1554&height=864&"  />
---

## Observações

- Certifique-se de que o arquivo `appsettings.json` está configurado corretamente para o ambiente local.
- O banco de dados SQLite já está incluído no repositório, mas pode ser recriado via migrations se necessário.
- Requisições como PUT e DELETE necessitam do ID

---

## Contribuição

Sinta-se à vontade para abrir issues ou pull requests!

---

## Licença

Este projeto está sob a licença MIT.
