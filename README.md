# CalculaFipeApi - CSharp 🚀 🔄 🌐


Códificação de Aplicação em C# que se chama `CalculaFipeApi` é uma API RESTful desenvolvida para calcular juros com base em valores fornecidos. 
A aplicação foi projetada para simular cálculos com o formato do Real Digital, uma proposta de moeda digital do Banco Central do Brasil.
A aplicação está integrada com Swagger.

### Funcionalidades

- **Cálculo de Juros**: A API aceita um valor base, uma taxa de juros e um período em dias para calcular o valor final após a aplicação dos juros compostos.

### Arquitetura e Design Patterns

A aplicação segue o padrão arquitetural **MVC (Model-View-Controller)**:

- **Model**: Representa os dados e a estrutura dos objetos.
- **View**: Em aplicações web completas, seria a representação visual dos dados. Neste caso, estamos retornando dados em formato JSON, então não temos uma "view" tradicional.
- **Controller**: Gerencia as requisições do usuário e retorna a resposta apropriada.

### Princípios SOLID identificados:

- **Single Responsibility Principle (SRP)**: Cada classe tem uma responsabilidade única. Por exemplo, o `CalculoFipeService` é responsável apenas pelos cálculos relacionados aos juros.
- **Dependency Inversion Principle (DIP)**: O `CalculoFipeController` depende de uma abstração (`ICalculoFipeService`) e não de uma implementação concreta.

### Como executar

```
# Clone o repositório
```

git clone [URL_DO_REPOSITÓRIO]

# Navegue até o diretório do projeto
```
cd CalculaFipeApi
```

### Execute a aplicação (assumindo que você está usando o dotnet CLI)
dotnet run

### Endpoints
POST /CalculoFipe: Recebe um JSON com ValorBase, Dias e TaxaJuros e retorna o valor final após a aplicação dos juros.
Exemplo de Requisição:

```
{

    "ValorBase": "18000.00",
    
    "Dias": 30,
    
    "TaxaJuros": "1.00 RD"
}
```


### Autor:
Emerson Amorim
