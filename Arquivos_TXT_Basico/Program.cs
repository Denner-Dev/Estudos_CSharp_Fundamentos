using System;
using System.IO;

namespace Arquivos_TXT_Basico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = "exemplo.txt";
            string texto = "Linha 1\nLinha 2\nLinha 3";

            // Escreve todo o conteúdo (sobrescreve o arquivo se existir).
            File.WriteAllText(caminho, texto);

            Console.WriteLine("Arquivo TXT criado!");

            // Lê todo o conteúdo do arquivo como uma string.
            string conteudo = File.ReadAllText("exemplo.txt");
            Console.WriteLine("Conteúdo do arquivo:");
            Console.WriteLine(conteudo);
        }
    }
}
