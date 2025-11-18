using System;
using System.Collections.Generic;
using System.IO;

namespace Arquivos_TXT_GerenciadorTarefas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = "tarefas.txt";

            Console.Write("Quantas tarefas deseja cadastrar: ");
            int resposta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < resposta; i++)
            {
                Console.Write("\nTarefa:");
                string tarefa = Console.ReadLine();
                File.AppendAllText(caminho, tarefa + "\n");
            }

            Console.WriteLine("\nArquivo TXT criado!");

            Console.WriteLine("\n===== LISTA DE TAREFAS =====");
            string conteudo = File.ReadAllText(caminho);
            Console.WriteLine("\nConteúdo do arquivo:");
            Console.WriteLine(conteudo);
            Console.WriteLine("Tarefas salvas e carregadas com sucesso!\n");
        }
    }
}
