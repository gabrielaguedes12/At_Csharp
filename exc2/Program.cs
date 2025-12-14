using System;
namespace exc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome completo: ");
            string nome = Console.ReadLine();

            char[] caracteres = nome.ToCharArray();

            for (int i = 0; i< caracteres.Length; i++)
            {
                char c = caracteres[i];

                if (c >= 'A' && c<= 'Z')
                {
                    caracteres[i] = (char)(((c - 'A' + 2)% 26)+'A');
                }
                else if (c >= 'a' && c<= 'z')
                {
                    caracteres[i] = (char)(((c - 'a' + 2) % 26) + 'a');
                }
            }
            string resultado = new string(caracteres);
            Console.WriteLine("Nome cifrado: " + resultado);
        }
    }
