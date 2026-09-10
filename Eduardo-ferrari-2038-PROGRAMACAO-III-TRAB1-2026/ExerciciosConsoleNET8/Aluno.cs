namespace ExerciciosConsoleNET8;

public class Aluno
{
    public string Nome { get; set; }
    public string RA { get; set; }
    public double NotaProva { get; set; }
    public double NotaTrabalho { get; set; }
    public double Frequencia { get; set; }

    public Aluno(string nome, string ra, double notaProva, double notaTrabalho, double frequencia)
    {
        Nome = nome;
        RA = ra;
        NotaProva = notaProva;
        NotaTrabalho = notaTrabalho;
        Frequencia = frequencia;
    }

    public double CalcularMedia()
    {
        return (NotaProva * 0.7) + (NotaTrabalho * 0.3);
    }

    public bool PassouPorFaltas()
    {
        return Frequencia >= 60;
    }

    public bool FoiAprovado()
    {
        return CalcularMedia() >= 7 && PassouPorFaltas();
    }
}
