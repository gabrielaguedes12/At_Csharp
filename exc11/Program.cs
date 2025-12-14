using System;
using System.IO;

class Program
{
    static void Main()
    {
        string arquivo = "contatos.txt";
        int opcao;

        do
        {
            Console.WriteLine("\n1 - Adicionar novo contato");
            Console.WriteLine("2 - Listar contatos");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha: ");
            int.TryParse(Console.ReadLine(), out opcao);

            if (opcao == 1)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Telefone: ");
                string telefone = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                using (StreamWriter writer = File.AppendText(arquivo))
                {
                    writer.WriteLine($"{nome},{telefone},{email}");
                }

                Console.WriteLine("Contato cadastrado com sucesso!");
            }

            else if (opcao == 2)
            {
                if (!File.Exists(arquivo) || File.ReadAllLines(arquivo).Length == 0)
                {
                    Console.WriteLine("Nenhum contato cadastrado.");
                    continue;
                }

                string[] contatos = File.ReadAllLines(arquivo);

                foreach (string contato in contatos)
                {
                    string[] dados = contato.Split(',');

                    if (dados.Length != 3)
                        continue;

                    Console.WriteLine($"Nome: {dados[0]} | Telefone: {dados[1]} | Email: {dados[2]}");
                }
            }

        } while (opcao != 3);
    }
}
