using System;

namespace POO_Heranca_Veiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.marca = "Porsche";
            carro.ano = 2024;
            carro.numeroPortas = 4;
            carro.ExibirInfo();

            Console.WriteLine();

            Moto moto = new Moto();
            moto.marca = "BMW";
            moto.ano = 2025;
            moto.tipoGuidao = "Esportivo";
            moto.ExibirInfo();
        }
    }
}
