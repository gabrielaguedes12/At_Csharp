using System;

class ContaBancaria
{
    public string Titular { get; set; }
    private decimal saldo;

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("O valor do depósito deve ser positivo!");
            return;
        }

        saldo += valor;
        Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
    }

    public void Sacar(decimal valor)
    {
        if (valor > saldo)
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque!");
            return;
        }

        saldo -= valor;
        Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual: R$ {saldo:F2}");
    }
}

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria();
        conta.Titular = "João Silva";

        Console.WriteLine($"Titular: {conta.Titular}");

        conta.Depositar(500);
        conta.ExibirSaldo();

        Console.WriteLine("Tentativa de saque: R$ 700,00");
        conta.Sacar(700);

        conta.Sacar(200);
        conta.ExibirSaldo();
    }
}
