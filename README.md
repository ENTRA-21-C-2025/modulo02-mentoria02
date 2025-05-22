# modulo02-mentoria02
## Tipos Primitivos, Tratamento de Exceções e Operadores

Este projeto demonstra o uso de tipos primitivos, tratamento de exceções e operadores em C# através de exemplos práticos e interativos.

### Visão Geral do Projeto

O projeto é uma aplicação console que apresenta um menu interativo com diferentes exemplos de programação em C#. Cada exemplo foi desenvolvido para demonstrar conceitos específicos da linguagem, com foco em:

- Tratamento de erros e exceções
- Manipulação de diferentes tipos de dados
- Uso de operadores e expressões
- Boas práticas de programação
- Documentação de código

### Estrutura do Projeto

```
console.mentoria2/
├── Program.cs (Menu principal)
├── ExemploError.cs
├── ExemploInteiro.cs
├── ExemploDecimal.cs
├── ExemploBoleano.cs
└── ExemploString.cs
```

### Como Executar

1. Clone o repositório
2. Aba o projeto no Visual Studio ou VS Code
3. Execute o projeto
4. Use o menu interativo para selecionar os diferentes exemplos

### Tecnologias Utilizadas

- C#
- .NET
- Console Application

## Exemplos Detalhados

### 1. Tratamento de Exceções (ExemploError)

Este exemplo demonstra o tratamento de erros em C# através de diferentes cenários:

#### Funcionalidades
- Tratamento de erros de formato ao converter strings para números
- Tratamento de divisão por zero
- Uso de blocos try-catch-finally
- Demonstração de diferentes tipos de exceções

#### Conceitos Demonstrados
- Try-catch blocks
- Exception handling
- Finally block
- Specific exception types (FormatException, DivideByZeroException)
- Error messages personalizados

### 2. Operações com Números Inteiros (ExemploInteiro)

Exemplo focado em operações matemáticas com números inteiros:

#### Funcionalidades
- Solicita dois números inteiros ao usuário
- Demonstra operações com operadores de atribuição composta
- Realiza as quatro operações básicas da matemática
- Mostra o uso do operador de módulo (resto da divisão)

#### Conceitos Demonstrados
- Operadores de atribuição composta (+=, -=, *=, /=, %=)
- Conversão de string para inteiro usando int.Parse()
- Operações matemáticas básicas
- Manipulação de variáveis inteiras
- Interação com o usuário via console
- Formatação de saída com string interpolation

### 3. Operações com Números Decimais (ExemploDecimal)

Demonstração de operações com números decimais e arredondamento:

#### Funcionalidades
- Operações com números decimais
- Funções de arredondamento
- Precisão decimal

#### Conceitos Demonstrados
- Tipo decimal
- Math.Ceiling()
- Math.Floor()
- Math.Round()
- Precisão em cálculos

### 4. Operações com Booleanos (ExemploBoleano)

Exemplo prático de uso de operadores lógicos e booleanos:

#### Funcionalidades
- Operadores lógicos
- Comparações booleanas
- Verificação de idade

#### Conceitos Demonstrados
- Operadores lógicos (&&, ||, !)
- Expressões booleanas
- Comparações
- Tomada de decisão baseada em condições

### 5. Manipulação de Strings (ExemploString)

Demonstração de diferentes operações com strings:

#### Funcionalidades
- Concatenação de strings
- Manipulação de case
- Acesso a caracteres
- Substituição e extração

#### Conceitos Demonstrados
- String interpolation
- Métodos de string (ToUpper, ToLower, Replace)
- Acesso a caracteres por índice
- Ranges e substrings
- Propriedade Length

### Observações Finais

- Todos os exemplos são interativos e solicitam entrada do usuário
- O código inclui documentação XML para melhor compreensão
- Os exemplos utilizam recursos modernos do C#
- O menu principal permite fácil navegação entre os exemplos
