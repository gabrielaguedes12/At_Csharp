using System;

class Program
{
    static void Main()
    {
        Random sorteio = new Random();
        int numeroSecreto = sorteio.Next(1, 51);
        int tentativas = 5;

        while (tentativas > 0)
        {
            Console.Write("Digite um número entre 1 e 50: ");
            int palpite;

            if (!int.TryParse(Console.ReadLine(), out palpite))
            {
                Console.WriteLine("Entrada inválida.");
                continue;
            }

            if (palpite < 1 || palpite > 50)
            {
                Console.WriteLine("Número fora do intervalo.");
                continue;
            }

            tentativas--;

            if (palpite == numeroSecreto)
            {
                Console.WriteLine("Parabéns! Você acertou!");
                return;
            }

            Console.WriteLine("Número errado.");
            Console.WriteLine($"Tentativas restantes: {tentativas}");
        }

        Console.WriteLine($"Fim de jogo! O número era {numeroSecreto}");
    }
}
