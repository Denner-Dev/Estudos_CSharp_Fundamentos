using System;

namespace Construtores_ObjetosBrinquedo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade;
            decimal preco;

            // Criando brinquedo via construtor padrão e atualizando.
            Brinquedo brin1 = new Brinquedo();
            brin1.Nome = "Bike";
            brin1.Preco = 100m;
            brin1.Quantidade = 2;
            brin1.ExibirInfo();

            Console.Write("Adicionar a quantidade: ");
            quantidade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ajustar o preco: ");
            preco = Convert.ToDecimal(Console.ReadLine());
            brin1.AdicionarEstoque(quantidade, preco);

            // Criando brinquedo via construtor com parâmetros.
            Brinquedo brin2 = new Brinquedo("Bola", 10m, 10);
            brin2.ExibirInfo();
            Console.Write("Adicionar a quantidade: ");
            quantidade = Convert.ToInt32(Console.ReadLine());
            brin2.AdicionarEstoque(quantidade);
        }
    }
}
