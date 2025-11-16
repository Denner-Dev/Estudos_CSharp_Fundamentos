using System;

namespace POO_Heranca_Eletronicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone celular = new Smartphone("14 pro", 2000, "iphone", 256);
            celular.ExibirInformacoes();
        }
    }
}
