using System;

namespace POO_Interfaces_Transportes
{
    internal class Aviao : ITransporte
    {
        public void Mover()
        {
            Console.WriteLine("O avião está voando pela cidade");
        }

        public void Abastecer()
        {
            Console.WriteLine("O avião já foi abastecido");
        }

        public void Status()
        {
            Console.WriteLine("Status do avião não implementado.");
        }
    }
}
