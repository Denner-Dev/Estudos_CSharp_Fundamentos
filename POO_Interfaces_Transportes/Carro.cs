using System;

namespace POO_Interfaces_Transportes
{
    internal class Carro : ITransporte
    {
        public bool emMovimento = true;
        public bool abastecido;

        public void Mover()
        {
            if (abastecido && emMovimento)
            {
                Console.WriteLine("O carro está rodando na estrada");
            }
            else if (!abastecido)
            {
                Console.WriteLine("Abasteça o carro");
            }
        }

        public void Abastecer()
        {
            abastecido = true;
            Console.WriteLine("O carro foi abastecido com gasolina.");
        }

        public void Status()
        {
            Console.WriteLine("O carro está em movimento: " + emMovimento);
            Console.WriteLine("O carro está abastecido: " + abastecido);
        }
    }
}
