# Exercícios Console .NET 8

Projeto desenvolvido em C# utilizando Console .NET 8.

## Exercícios

1. Calculadora com soma, subtração, multiplicação, divisão e resto.
2. Contagem de vogais em uma string.
3. Impressão somente das vogais.
4. Impressão somente das consoantes.
5. Identificação da faixa etária.
6. Cadastro de livro utilizando classe, título, autor e valor.
7. Cadastro de aluno com notas, frequência, média ponderada e verificação de aprovação.

## Estrutura

- `Program.cs` - menu principal e loop de repetição.
- `Exercicio1.cs` até `Exercicio7.cs` - implementação de cada exercício.
- `Livro.cs` - classe utilizada no exercício 6.
- `Aluno.cs` - classe utilizada no exercício 7.

## Regra do exercício 7

A média é calculada com os pesos:
- Prova: 70%
- Trabalho: 30%

A média mínima é 7,0.

Considerando limite de 40% de faltas em 40 aulas:
- máximo de faltas: 16 aulas;
- frequência mínima: 60%.

O aluno é aprovado somente se atingir média 7,0 ou mais e possuir frequência mínima de 60%.

## Como executar

No terminal, dentro da pasta do projeto:

```bash
dotnet restore
dotnet run
```
