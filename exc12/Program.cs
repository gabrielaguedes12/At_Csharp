using System;
using System.IO;
using System.Collections.Generic;

class Contato
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
}

abstract class ContatoFormatter
{
    public abstract void ExibirContatos(List<Contato> contatos);
}

class MarkdownFormatter : ContatoFormatter
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        Console.WriteLine("## Lista de Contatos\n");

        foreach (var contato in contatos)
        {
            Console.WriteLine($"- **Nome:** {contato.Nome}");
            Console.WriteLine($"- 📞 Telefone: {contato.Telefone}");
            Console.WriteLine($"- 📧 Email: {contato.Email}\n");
        }
    }
}

class TabelaFormatter : ContatoFormatter
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("| Nome | Telefone | Email |");
        Console.WriteLine("----------------------------------------");

        foreach (var contato in contatos)
        {
            Console.WriteLine($"| {contato.Nome} | {contato.Telefone} | {contato.Email} |");
        }

        Console.WriteLine("----------------------------------------");
    }
}

class RawTextFormatter : ContatoFormatter
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        foreach (var contato in contatos)
        {
            Console.WriteLine($"Nome: {contato.Nome} | Telefone: {contato.Telefone} | Email: {contato.Email}");
        }
    }
}

class Program
{
    static void Main()
    {
        string arquivo = "contatos.txt";
        List<Contato> contatos = new List<Contato>();

        if (File.Exists(arquivo))
        {
            string[] linhas = File.ReadAllLines(arquivo);

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(',');

                if (dados.Length != 3)
                    continue;

                contatos.Add(new Contato
                {
                    Nome = dados[0],
                    Telefone = dados[1],
                    Email = dados[2]
                });
            }
        }

        Console.WriteLine("Escolha o formato de exibição:");
        Console.WriteLine("1 - Markdown");
        Console.WriteLine("2 - Tabela");
        Console.WriteLine("3 - Texto Puro");
        Console.Write("Opção: ");

        int escolha;
        int.TryParse(Console.ReadLine(), out escolha);

        ContatoFormatter formatter = escolha switch
        {
            1 => new MarkdownFormatter(),
            2 => new TabelaFormatter(),
            _ => new RawTextFormatter()
        };

        formatter.ExibirContatos(contatos);
    }
}
