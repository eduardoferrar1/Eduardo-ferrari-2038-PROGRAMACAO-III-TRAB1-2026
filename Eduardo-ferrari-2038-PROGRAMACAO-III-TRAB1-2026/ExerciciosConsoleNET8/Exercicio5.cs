namespace ExerciciosConsoleNET8;

public static class Exercicio5
{
    public static void Executar()
    {
        Console.WriteLine("=== FAIXA ETÁRIA ===");
        Console.Write("Digite a idade: ");
        int idade = LerIdade();

        if (idade >= 0 && idade <= 19)
            Console.WriteLine("Faixa etária: Jovem");
        else if (idade <= 59)
            Console.WriteLine("Faixa etária: Adulto");
        else
            Console.WriteLine("Faixa etária: Idoso");
    }

    private static int LerIdade()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int idade) && idade >= 0)
                return idade;

            Console.Write("Idade inválida. Digite novamente: ");
        }
    }
}
