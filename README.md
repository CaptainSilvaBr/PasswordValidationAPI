# API de Validação de Senha


A API de Validação de Senha é uma aplicação construída em .NET 6.0 que oferece a capacidade de validar senhas de acordo com critérios específicos. Essa API foi desenvolvida com foco em fornecer um serviço simples e eficiente para verificar se uma senha atende aos requisitos de complexidade definidos.

Como Utilizar a API
A API é acessível através de um endpoint HTTP que recebe uma senha como entrada e retorna um booleano indicando se a senha é válida ou não.

Endpoint de Validação de Senha

GET /api/password/validate?password={senha}
Parâmetros:

password (string): A senha a ser validada.
Resposta:

Status 200 OK:
true se a senha for válida.
false se a senha não for válida.
Requisitos de Senha Válida
Uma senha é considerada válida quando atende aos seguintes critérios:

Possui nove ou mais caracteres.
Contém pelo menos um número.
Contém pelo menos uma letra minúscula.
Contém pelo menos uma letra maiúscula.
Contém pelo menos um caractere especial dentre os seguintes: !@#$%^&*()-+
Não possui caracteres repetidos dentro do conjunto.
Exemplos de Uso
Exemplo 1: Senha Válida


GET /api/password/validate?password=AbTp9!fok
Resposta: true

Exemplo 2: Senha Inválida

GET /api/password/validate?password=abc123
Resposta: false

Executando a Aplicação
Para executar a aplicação, siga os passos abaixo:

Certifique-se de ter o .NET 6.0 SDK instalado.
Clone este repositório para sua máquina local.
Abra um terminal na pasta do projeto.
Execute o seguinte comando:

dotnet run
Acesse a documentação da API através do Swagger UI em https://localhost:7079/swagger.
Considerações Finais
Esta API foi desenvolvida seguindo as práticas de Clean Code, SOLID e boas práticas de design de API. Sinta-se à vontade para explorar e estender o código para atender às necessidades específicas do seu projeto. Em caso de dúvidas ou sugestões, não hesite em entrar em contato.

Autor: Kaique Silva
Contato: silva.asset@gmail.com
