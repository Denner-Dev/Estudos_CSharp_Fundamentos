using System;

namespace POO_Heranca_Banco
{
    // Conta poupança com rendimento fixo.
    internal class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(string numeroConta, string titular, decimal saldo)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
        }

        // Rendimento da poupança (exemplo 0.5%).
        public override decimal CalcularRendimento()
        {
            return Saldo * 0.005m;
        }

        public override void ExibirInfo()
        {
            Console.WriteLine("\nConta Poupança");
            base.ExibirInfo();
        }
    }
}
