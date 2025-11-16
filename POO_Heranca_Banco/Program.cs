using System;
using System.Collections.Generic;

namespace POO_Heranca_Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista de contas (poderia ser usada para múltiplas contas).
            List<ContaBancaria> contas = new List<ContaBancaria>();

            // Cria duas contas de exemplo.
            ContaPoupanca contaP = new ContaPoupanca("432453", "Denner Fernandes", 1000);
            ContaCorrente contaC = new ContaCorrente("4312431", "Denner", 1000, 500);

            contas.Add(contaP);
            contas.Add(contaC);

            bool continuarGeral = true;

            // Loop principal que permite trocar de conta e operações.
            while (continuarGeral)
            {
                Console.WriteLine("\nEscolha a conta:");
                Console.WriteLine("1 - Conta Corrente");
                Console.WriteLine("2 - Conta Poupança");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");

                string input = Console.ReadLine();
                if (input == "0")
                {
                    continuarGeral = false;
                    break;
                }

                ContaBancaria contaSelecionada = input == "1" ? contaC : contaP;

                bool voltarMenuConta = true;
                while (voltarMenuConta)
                {
                    Console.WriteLine("\n=== Banco C# ===");
                    Console.WriteLine("1 - Depositar");
                    Console.WriteLine("2 - Sacar");
                    Console.WriteLine("3 - Exibir Informações");
                    Console.WriteLine("4 - Calcular Rendimento");
                    Console.WriteLine("0 - Trocar de conta");
                    Console.Write("Opção: ");

                    string resposta = Console.ReadLine();

                    switch (resposta)
                    {
                        case "1":
                            Console.Write("Valor do depósito: R$ ");
                            decimal valorDep = Convert.ToDecimal(Console.ReadLine());
                            contaSelecionada.Depositar(valorDep);
                            Console.WriteLine("Depósito realizado!");
                            break;

                        case "2":
                            Console.Write("Valor do saque: R$ ");
                            decimal valorSacar = Convert.ToDecimal(Console.ReadLine());
                            contaSelecionada.Sacar(valorSacar);
                            break;

                        case "3":
                            contaSelecionada.ExibirInfo();
                            break;

                        case "4":
                            decimal rend = contaSelecionada.CalcularRendimento();
                            Console.WriteLine($"Rendimento: {rend:c}");
                            Console.WriteLine($"Saldo + rendimento: {contaSelecionada.Saldo + rend:c}");
                            break;

                        case "0":
                            voltarMenuConta = false;
                            break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                }
            }

            Console.WriteLine("\nSistema encerrado!");
        }
    }
}
