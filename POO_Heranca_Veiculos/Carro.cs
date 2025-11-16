using System;

namespace POO_Heranca_Veiculos
{
    // Carro adiciona número de portas.
    internal class Carro : Veiculo
    {
        public int numeroPortas;

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Número de portas: {numeroPortas}");
        }
    }
}
