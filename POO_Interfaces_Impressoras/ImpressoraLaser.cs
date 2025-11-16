using System;

namespace POO_Interfaces_Impressoras
{
    internal class ImpressoraLaser : IImpressora
    {
        public void Imprimir()
        {
            Console.WriteLine("Impressora a Laser imprimindo documento...");
        }

        public void Scanear()
        {
            Console.WriteLine("Impressora a Laser escaneando documento...");
        }
    }
}
