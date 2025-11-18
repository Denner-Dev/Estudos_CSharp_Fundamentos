using System;
using System.Collections.Generic;
using System.IO;

namespace Arquivos_TXT_GerenciadorAnotacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = "anotacao.txt";

            List<string> anotacoes = new List<string>();

            for (int i = 1; i < 6; i++)
            {
                Console.Write($"Digite a {i} anotação: ");
                string anotacao = Console.ReadLine();
                anotacoes.Add(anotacao);
            }

            File.WriteAllLines(caminho, anotacoes);

            Console.WriteLine("\nArquivo TXT criado!");

            string conteudo = File.ReadAllText("anotacao.txt");
            Console.WriteLine("\nConteúdo do arquivo:");
            Console.WriteLine(conteudo);
            Console.WriteLine("\nFinalize dizendo: Anotações salvas e carregadas com sucesso!");

        }
    }
}
