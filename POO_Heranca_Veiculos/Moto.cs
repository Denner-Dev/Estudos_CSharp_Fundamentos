using System;

namespace POO_Heranca_Veiculos
{
    // Moto adiciona tipo de guidão.
    internal class Moto : Veiculo
    {
        public string tipoGuidao;

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Tipo de guidão: {tipoGuidao}");
        }
    }
}
