using System;

namespace POO_Interfaces_Impressoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IImpressora impressoraSelecionada = null;
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n=== SISTEMA DE IMPRESSORAS ===");
                Console.WriteLine("1 - Impressora Laser");
                Console.WriteLine("2 - Impressora Jato de Tinta");
                Console.WriteLine("0 - Sair");

                Console.Write("Opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        impressoraSelecionada = new ImpressoraLaser();
                        break;
                    case "2":
                        impressoraSelecionada = new ImpressoraJatoTinta();
                        break;
                    case "0":
                        continuar = false;
                        Console.WriteLine("Encerrando o sistema...");
                        continue;
                    default:
                        Console.WriteLine("Opção inválida!");
                        continue;
                }

                Console.WriteLine("\nO que deseja fazer?");
                Console.WriteLine("1 - Imprimir");
                Console.WriteLine("2 - Scanear");
                Console.Write("Opção: ");
                string acao = Console.ReadLine();

                switch (acao)
                {
                    case "1":
                        impressoraSelecionada.Imprimir();
                        break;
                    case "2":
                        impressoraSelecionada.Scanear();
                        break;
                    default:
                        Console.WriteLine("Ação inválida!");
                        break;
                }
            }
        }
    }
}
