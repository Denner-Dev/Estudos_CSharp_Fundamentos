using System;

namespace POO_Heranca_Banco
{
    // Classe base abstrata para contas bancárias.
    // Define propriedades comuns e métodos que podem ser sobrescritos.
    internal abstract class ContaBancaria
    {
        public string NumeroConta { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        // Deposita um valor na conta.
        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        // Método virtual para saque — versões específicas podem sobrescrever.
        public virtual bool Sacar(decimal valorSacar)
        {
            if (valorSacar <= Saldo)
            {
                Saldo -= valorSacar;
                return true;
            }

            Console.WriteLine("Saldo insuficiente!");
            return false;
        }

        // Método abstrato para cálculo de rendimento (cada conta implementa).
        public abstract decimal CalcularRendimento();

        // Mostra informações básicas da conta.
        public virtual void ExibirInfo()
        {
            Console.WriteLine($"\nNúmero: {NumeroConta}");
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Saldo: {Saldo:c}");
        }
    }
}
