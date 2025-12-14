using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua data de nascimento (dd/MM/yyyy): ");
        DateTime dataNascimento;

        while (!DateTime.TryParse(Console.ReadLine(), out dataNascimento))
        {
            Console.Write("Digite uma data válida (dd/MM/yyyy): ");
        }

        DateTime hoje = DateTime.Today;

        DateTime proximoAniversario = new DateTime(
            hoje.Year,
            dataNascimento.Month,
            dataNascimento.Day
        );

        if (proximoAniversario < hoje)
        {
            proximoAniversario = proximoAniversario.AddYears(1);
        }

        int diasRestantes = (proximoAniversario - hoje).Days;

        Console.WriteLine($"Faltam {diasRestantes} dias para o seu próximo aniversário.");

        if (diasRestantes < 7)
        {
            Console.WriteLine("Seu aniversário está chegando!");
        }
    }
}
