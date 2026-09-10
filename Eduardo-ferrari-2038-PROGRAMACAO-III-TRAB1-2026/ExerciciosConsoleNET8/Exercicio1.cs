namespace ExerciciosConsoleNET8;

public static class Exercicio1
{
    public static void Executar()
    {
        Console.WriteLine("=== CALCULADORA ===");

        Console.Write("Digite o primeiro número: ");
        double n1 = LerDouble();

        Console.Write("Digite o segundo número: ");
        double n2 = LerDouble();

        Console.WriteLine();
        Console.WriteLine($"Soma: {n1 + n2}");
        Console.WriteLine($"Subtração: {n1 - n2}");
        Console.WriteLine($"Multiplicação: {n1 * n2}");

        if (n2 != 0)
        {
            Console.WriteLine($"Divisão: {n1 / n2}");
            Console.WriteLine($"Resto da divisão: {n1 % n2}");
        }
        else
        {
            Console.WriteLine("Divisão: não é possível dividir por zero.");
            Console.WriteLine("Resto da divisão: não é possível dividir por zero.");
        }
    }

    private static double LerDouble()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double valor))
                return valor;

            Console.Write("Valor inválido. Digite novamente: ");
        }
    }
}
