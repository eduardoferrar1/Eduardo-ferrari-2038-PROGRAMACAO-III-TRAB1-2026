namespace ExerciciosConsoleNET8;

public static class Exercicio2
{
    public static void Executar()
    {
        Console.WriteLine("=== QUANTIDADE DE VOGAIS ===");
        Console.Write("Digite uma string: ");
        string texto = Console.ReadLine() ?? "";

        int quantidade = 0;

        foreach (char caractere in texto.ToLower())
        {
            if ("aeiouáéíóúâêôãõà".Contains(caractere))
                quantidade++;
        }

        Console.WriteLine($"Quantidade de vogais: {quantidade}");
    }
}
