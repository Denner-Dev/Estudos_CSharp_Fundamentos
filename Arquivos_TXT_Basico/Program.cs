using System;
using System.IO;

namespace Arquivos_TXT_Basico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "dados.txt";

            // Escreve todo o conteúdo (sobrescreve o arquivo se existir).
            File.WriteAllText(path, "Ola mundo!\nEssa e uma linha.");

            // Anexa uma nova linha ao arquivo existente.
            File.AppendAllText(path, "\nLinha extra adicionada.");

            // Lê todo o conteúdo do arquivo como uma string.
            string conteudo = File.ReadAllText(path);
            Console.WriteLine("Conteudo completo:");
            Console.WriteLine(conteudo);

            // Lê o arquivo linha a linha para um array de strings.
            string[] linhas = File.ReadAllLines(path);
            Console.WriteLine($"\nNumero de linhas: {linhas.Length}");
            foreach (var linha in linhas)
                Console.WriteLine("=> " + linha);
        }
    }
}
