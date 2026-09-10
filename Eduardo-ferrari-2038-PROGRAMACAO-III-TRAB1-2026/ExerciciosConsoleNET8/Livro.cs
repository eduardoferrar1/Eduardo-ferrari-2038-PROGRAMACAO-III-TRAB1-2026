namespace ExerciciosConsoleNET8;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public decimal Valor { get; set; }

    public Livro(string titulo, string autor, decimal valor)
    {
        Titulo = titulo;
        Autor = autor;
        Valor = valor;
    }
}
