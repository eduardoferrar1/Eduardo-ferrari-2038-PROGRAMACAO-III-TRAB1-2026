namespace ExerciciosConsoleNET8;

public static class Exercicio4
{
    public static void Executar()
    {
        Console.WriteLine("=== APENAS AS CONSOANTES ===");
        Console.Write("Digite uma string: ");
        string texto = Console.ReadLine() ?? "";

        Console.Write("Consoantes: ");

        foreach (char caractere in texto)
        {
            if (char.IsLetter(caractere) &&
                !"aeiouáéíóúâêôãõàAEIOUÁÉÍÓÚÂÊÔÃÕÀ".Contains(caractere))
            {
                Console.Write(caractere);
            }
        }

        Console.WriteLine();
    }
}
