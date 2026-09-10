namespace ExerciciosConsoleNET8;

public static class Exercicio7
{
    public static void Executar()
    {
        Console.WriteLine("=== CADASTRO DE ALUNO ===");

        Console.Write("Nome: ");
        string nome = Console.ReadLine() ?? "";

        Console.Write("R.A.: ");
        string ra = Console.ReadLine() ?? "";

        Console.Write("Nota da prova (0 a 10): ");
        double notaProva = LerNota();

        Console.Write("Nota do trabalho (0 a 10): ");
        double notaTrabalho = LerNota();

        Console.Write("Frequência (0 a 100%): ");
        double frequencia = LerFrequencia();

        Aluno aluno = new Aluno(nome, ra, notaProva, notaTrabalho, frequencia);

        double media = aluno.CalcularMedia();
        double faltas = 100 - aluno.Frequencia;

        Console.WriteLine();
        Console.WriteLine("=== DADOS DO ALUNO ===");
        Console.WriteLine($"Nome: {aluno.Nome}");
        Console.WriteLine($"R.A.: {aluno.RA}");
        Console.WriteLine($"Nota da prova: {aluno.NotaProva:F1}");
        Console.WriteLine($"Nota do trabalho: {aluno.NotaTrabalho:F1}");
        Console.WriteLine($"Média ponderada: {media:F2}");
        Console.WriteLine($"Frequência: {aluno.Frequencia:F1}%");
        Console.WriteLine($"Faltas: {faltas:F1}%");

        Console.WriteLine();
        Console.WriteLine(media >= 7
            ? "Situação pela média: Aprovado"
            : "Situação pela média: Reprovado");

        Console.WriteLine(aluno.PassouPorFaltas()
            ? "Situação pelas faltas: Aprovado"
            : "Situação pelas faltas: Reprovado");

        Console.WriteLine(aluno.FoiAprovado()
            ? "RESULTADO FINAL: APROVADO"
            : "RESULTADO FINAL: REPROVADO");
    }

    private static double LerNota()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double nota) &&
                nota >= 0 && nota <= 10)
                return nota;

            Console.Write("Nota inválida. Digite um valor entre 0 e 10: ");
        }
    }

    private static double LerFrequencia()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double frequencia) &&
                frequencia >= 0 && frequencia <= 100)
                return frequencia;

            Console.Write("Frequência inválida. Digite um valor entre 0 e 100: ");
        }
    }
}
