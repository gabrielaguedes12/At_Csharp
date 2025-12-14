using System;

class Program
{
    static void Main()
    {
        double primeiroNumero;
        double segundoNumero;

        Console.Write("Digite o primeiro número: ");
        while (!double.TryParse(Console.ReadLine(), out primeiroNumero))
        {
            Console.Write("Digite um número válido: ");
        }

        Console.Write("Digite o segundo número: ");
        while (!double.TryParse(Console.ReadLine(), out segundoNumero))
        {
            Console.Write("Digite um número válido: ");
        }

        Console.WriteLine("Escolha a operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        int escolha;
        Console.Write("Opção: ");
        while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > 4)
        {
            Console.Write("Escolha uma opção válida (1 a 4): ");
        }

        if (escolha == 4 && segundoNumero == 0)
        {
            Console.WriteLine("Não é possível dividir por zero.");
            return;
        }

        double resultado = escolha switch
        {
            1 => primeiroNumero + segundoNumero,
            2 => primeiroNumero - segundoNumero,
            3 => primeiroNumero * segundoNumero,
            4 => primeiroNumero / segundoNumero,
            _ => 0
        };

        Console.WriteLine("Resultado: " + resultado);
    }
}
