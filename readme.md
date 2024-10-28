# Desafio de Bootcamp - Calculadora com Testes Unitários

Este repositório contém a solução para o desafio de um bootcamp da [Digital Innovation One (DIO)](https://www.dio.me/), que consiste em implementar uma Calculadora simples e os testes unitários para validar suas funcionalidades. O projeto utiliza C# e o framework de testes [xUnit](https://xunit.net/).

## 📋 Descrição do Projeto

O objetivo do projeto é criar uma classe `CalculadoraService` que fornece operações matemáticas básicas, como soma, subtração, multiplicação e divisão, com tratamento de exceção para divisão por zero. Também são implementados testes unitários para cada operação da calculadora, garantindo a precisão e robustez das operações.

### Estrutura do Projeto

A estrutura de pastas segue a organização padrão para soluções de projetos .NET, separando a lógica principal da calculadora dos testes:



## 🛠️ Tecnologias Utilizadas

- **C#**
- **.NET Core**
- **xUnit** - Framework para testes unitários

## 🚀 Funcionalidades

### CalculadoraService
A classe `CalculadoraService` implementa os seguintes métodos:

- `Somar(double num1, double num2)`: Retorna a soma de dois números.
- `Subtrair(double num1, double num2)`: Retorna a subtração do segundo número em relação ao primeiro.
- `Multiplicar(double num1, double num2)`: Retorna a multiplicação de dois números.
- `Dividir(double num1, double num2)`: Retorna a divisão do primeiro número pelo segundo. Lança uma exceção `DivideByZeroException` se o segundo número for zero.

### Testes Unitários
Os testes unitários estão implementados na classe `CalculadoraServiceTests`, que utiliza o framework xUnit para validar as operações da classe `CalculadoraService`. Foram utilizados `[Theory]` e `[InlineData]` para fornecer diferentes conjuntos de dados e tornar os testes mais completos e legíveis.

Cada operação matemática tem um conjunto de testes que valida os cenários principais, incluindo casos de erro, como a divisão por zero.

## 📦 Como Executar o Projeto

### Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/download) 8.0 ou superior

### Executar a Calculadora
1. Navegue até a pasta do projeto:
   ```bash
   cd src/
   ```
2. Execute o projeto:
   ```bash
   dotnet run
   ```

### Executar os Testes
1. Navegue até a pasta raiz do projeto e execute:
   ```bash
   dotnet test
   ```

2. O comando irá compilar e rodar todos os testes da solução, exibindo no terminal o resultado dos testes.
