using ExerciciosConsoleNET8;

while (true)
{
    Console.Clear();
    Console.WriteLine("====================================");
    Console.WriteLine("       MENU DE EXERCÍCIOS .NET 8");
    Console.WriteLine("====================================");
    Console.WriteLine("1 - Calculadora");
    Console.WriteLine("2 - Quantidade de vogais");
    Console.WriteLine("3 - Imprimir apenas as vogais");
    Console.WriteLine("4 - Imprimir apenas as consoantes");
    Console.WriteLine("5 - Faixa etária");
    Console.WriteLine("6 - Cadastro de livro");
    Console.WriteLine("7 - Cadastro de aluno");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("====================================");
    Console.Write("Escolha uma opção: ");

    string? opcao = Console.ReadLine();

    Console.Clear();

    switch (opcao)
    {
        case "1":
            Exercicio1.Executar();
            break;
        case "2":
            Exercicio2.Executar();
            break;
        case "3":
            Exercicio3.Executar();
            break;
        case "4":
            Exercicio4.Executar();
            break;
        case "5":
            Exercicio5.Executar();
            break;
        case "6":
            Exercicio6.Executar();
            break;
        case "7":
            Exercicio7.Executar();
            break;
        case "0":
            Console.WriteLine("Programa encerrado.");
            return;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    Console.WriteLine();
    Console.WriteLine("Pressione ENTER para voltar ao menu...");
    Console.ReadLine();
}
