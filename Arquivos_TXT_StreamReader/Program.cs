using System;
using System.IO;

namespace Arquivos_TXT_StreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Substitua pelo caminho real do arquivo, por exemplo "dados.txt" ou um caminho absoluto.
            string path = "dados.txt";

            // StreamReader é indicado para arquivos grandes ou leitura controlada linha a linha.
            using (var sr = new StreamReader(path))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            } // StreamReader é fechado automaticamente ao sair do bloco using.
        }
    }
}
