using System;

class Aluno
{
    public string Nome { get; set; }
    public string Matricula { get; set; }
    public string Curso { get; set; }
    public double Media { get; set; }

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Curso: {Curso}");
        Console.WriteLine($"Média: {Media}");
        Console.WriteLine($"Situação: {VerificarAprovacao()}");
    }

    public string VerificarAprovacao()
    {
        return Media >= 7 ? "Aprovado" : "Reprovado";
    }
}

class Program
{
    static void Main()
    {
        Aluno aluno = new Aluno
        {
            Nome = "Maria Souza",
            Matricula = "20241234",
            Curso = "Análise e Desenvolvimento de Sistemas",
            Media = 8.5
        };

        aluno.ExibirDados();
    }
}
