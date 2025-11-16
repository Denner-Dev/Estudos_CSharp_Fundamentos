using System;
using System.Collections.Generic;

namespace POO_Interfaces_Transportes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITransporte carro = new Carro();
            ITransporte bicicleta = new Bicicleta();
            ITransporte aviao = new Aviao();

            List<ITransporte> transportes = new List<ITransporte>
            {
                carro,
                bicicleta,
                aviao
            };

            foreach (ITransporte transporte in transportes)
            {
                transporte.Abastecer();
                transporte.Mover();
                transporte.Status();
                Console.WriteLine();
            }
        }
    }
}
