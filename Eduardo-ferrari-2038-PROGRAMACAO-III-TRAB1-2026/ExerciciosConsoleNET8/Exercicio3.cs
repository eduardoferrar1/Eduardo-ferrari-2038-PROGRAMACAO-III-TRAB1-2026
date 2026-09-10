namespace ExerciciosConsoleNET8;

public static class Exercicio3
{
    public static void Executar()
    {
        Console.WriteLine("=== APENAS AS VOGAIS ===");
        Console.Write("Digite uma string: ");
        string texto = Console.ReadLine() ?? "";

        Console.Write("Vogais: ");

        foreach (char caractere in texto)
        {
            if ("aeiouáéíóúâêôãõàAEIOUÁÉÍÓÚÂÊÔÃÕÀ".Contains(caractere))
                Console.Write(caractere);
        }

        Console.WriteLine();
    }
}
