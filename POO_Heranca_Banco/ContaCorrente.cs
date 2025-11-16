using System;

namespace POO_Heranca_Banco
{
    // Conta corrente com limite.
    internal class ContaCorrente : ContaBancaria
    {
        public decimal Limite { get; set; }

        public ContaCorrente(string numeroConta, string titular, decimal saldo, decimal limite)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
            Limite = limite;
        }

        // Rendimento menor para conta corrente.
        public override decimal CalcularRendimento()
        {
            return Saldo * 0.001m;
        }

        // Saque considera saldo + limite.
        public override bool Sacar(decimal valorSacar)
        {
            if (valorSacar <= Saldo)
            {
                Saldo -= valorSacar;
                Console.WriteLine("Saque realizado com sucesso.");
                return true;
            }
            else if (valorSacar <= Saldo + Limite)
            {
                decimal restante = valorSacar - Saldo;
                Saldo = 0;
                Limite -= restante;

                Console.WriteLine("Saldo insuficiente, mas o limite cobriu o saque.");
                return true;
            }

            Console.WriteLine("Saque negado! Saldo + limite insuficientes.");
            return false;
        }

        // Exibe info incluindo o limite.
        public override void ExibirInfo()
        {
            Console.WriteLine("\nConta Corrente");
            base.ExibirInfo();
            Console.WriteLine($"Limite: {Limite:c}");
        }
    }
}
