using System;
using System.IO;

class Program
{
    static void Main()
    {
        string arquivo = "estoque.txt";
        int opcao;

        do
        {
            Console.WriteLine("\n1 - Inserir Produto");
            Console.WriteLine("2 - Listar Produtos");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha: ");
            int.TryParse(Console.ReadLine(), out opcao);

            if (opcao == 1)
            {
                if (File.Exists(arquivo) && File.ReadAllLines(arquivo).Length >= 5)
                {
                    Console.WriteLine("Limite de produtos atingido!");
                    continue;
                }

                Console.Write("Nome do produto: ");
                string nome = Console.ReadLine();

                Console.Write("Quantidade: ");
                int quantidade;
                int.TryParse(Console.ReadLine(), out quantidade);

                Console.Write("Preço: ");
                decimal preco;
                decimal.TryParse(Console.ReadLine(), out preco);

                using (StreamWriter writer = File.AppendText(arquivo))
                {
                    writer.WriteLine($"{nome},{quantidade},{preco:F2}");
                }
            }

            else if (opcao == 2)
            {
                if (!File.Exists(arquivo) || File.ReadAllLines(arquivo).Length == 0)
                {
                    Console.WriteLine("Nenhum produto cadastrado.");
                    continue;
                }

                string[] linhas = File.ReadAllLines(arquivo);

                foreach (string linha in linhas)
                {
                    string[] dados = linha.Split(',');

                    if (dados.Length != 3)
                        continue;

                    Console.WriteLine($"Produto: {dados[0]} | Quantidade: {dados[1]} | Preço: R$ {decimal.Parse(dados[2]):F2}");
                }
            }

        } while (opcao != 3);
    }
}
