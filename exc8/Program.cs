using System;

class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public decimal SalarioBase { get; set; }

    public virtual decimal CalcularSalario()
    {
        return SalarioBase;
    }
}

class Gerente : Funcionario
{
    public override decimal CalcularSalario()
    {
        return SalarioBase * 1.2m;
    }
}

class Program
{
    static void Main()
    {
        Funcionario funcionario = new Funcionario
        {
            Nome = "Ana Lima",
            Cargo = "Analista",
            SalarioBase = 3000
        };

        Gerente gerente = new Gerente
        {
            Nome = "Carlos Rocha",
            Cargo = "Gerente",
            SalarioBase = 5000
        };

        Console.WriteLine($"{funcionario.Nome} - Salário: R$ {funcionario.CalcularSalario():F2}");
        Console.WriteLine($"{gerente.Nome} - Salário: R$ {gerente.CalcularSalario():F2}");
    }
}
