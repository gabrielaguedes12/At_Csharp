using System;

class Program
{
    static void Main()
    {
        DateTime dataFormatura = new DateTime(2026, 12, 15);

        Console.Write("Digite a data atual (dd/MM/yyyy): ");
        DateTime dataAtual;

        if (!DateTime.TryParse(Console.ReadLine(), out dataAtual))
        {
            Console.WriteLine("Data inválida.");
            return;
        }

        if (dataAtual > DateTime.Today)
        {
            Console.WriteLine("Erro: A data informada não pode ser no futuro!");
            return;
        }

        if (dataAtual > dataFormatura)
        {
            Console.WriteLine("Parabéns! Você já deveria estar formado!");
            return;
        }

        int anos = dataFormatura.Year - dataAtual.Year;
        int meses = dataFormatura.Month - dataAtual.Month;
        int dias = dataFormatura.Day - dataAtual.Day;

        if (dias < 0)
        {
            meses--;
            dias += DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month);
        }

        if (meses < 0)
        {
            anos--;
            meses += 12;
        }

        if (anos > 0)
        {
            Console.WriteLine($"Faltam {anos} anos, {meses} meses e {dias} dias para sua formatura!");
        }
        else
        {
            Console.WriteLine($"Faltam {meses} meses e {dias} dias para sua formatura!");
        }

        if (anos == 0 && meses < 6)
        {
            Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
        }
    }
}
