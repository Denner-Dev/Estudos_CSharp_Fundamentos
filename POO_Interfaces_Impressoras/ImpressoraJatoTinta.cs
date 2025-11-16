using System;

namespace POO_Interfaces_Impressoras
{
    internal class ImpressoraJatoTinta : IImpressora
    {
        public void Imprimir()
        {
            Console.WriteLine("Impressora Jato Tinta imprimindo documento...");
        }

        public void Scanear()
        {
            Console.WriteLine("Impressora Jato Tinta escaneando documento...");
        }
    }
}
