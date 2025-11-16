using System;

namespace POO_Interfaces_Transportes
{
    internal class Bicicleta : ITransporte
    {
        public void Mover()
        {
            Console.WriteLine("A bicicleta está andando na ciclovia");
        }

        public void Abastecer()
        {
            Console.WriteLine("A bicicleta não abastece");
        }

        public void Status()
        {
            Console.WriteLine("A bicicleta não tem status de abastecimento ou movimento automático.");
        }
    }
}
