namespace ExerciciosConsoleNET8;

public static class Exercicio6
{
    public static void Executar()
    {
        Console.WriteLine("=== CADASTRO DE LIVRO ===");

        Console.Write("Título: ");
        string titulo = Console.ReadLine() ?? "";

        Console.Write("Autor: ");
        string autor = Console.ReadLine() ?? "";

        Console.Write("Valor: R$ ");
        decimal valor = LerDecimal();

        Livro livro = new Livro(titulo, autor, valor);

        Console.WriteLine();
        Console.WriteLine("=== LIVRO CADASTRADO ===");
        Console.WriteLine($"Título: {livro.Titulo}");
        Console.WriteLine($"Autor: {livro.Autor}");
        Console.WriteLine($"Valor: R$ {livro.Valor:F2}");
    }

    private static decimal LerDecimal()
    {
        while (true)
        {
            if (decimal.TryParse(Console.ReadLine(), out decimal valor) && valor >= 0)
                return valor;

            Console.Write("Valor inválido. Digite novamente: R$ ");
        }
    }
}
