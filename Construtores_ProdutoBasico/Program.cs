using System;

namespace Construtores_ProdutoBasico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto("Mouse Gamer", 150m, 10);
            p1.ExibirInfo();

            Console.Write("\nAdicionar ao estoque: ");
            p1.AdicionarEstoque(Convert.ToInt32(Console.ReadLine()));

            Console.Write("\nAdicionar quantidade: ");
            int qtd = Convert.ToInt32(Console.ReadLine());

            Console.Write("Novo preço unitário: ");
            decimal preco = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nAdicionando mais unidades com preço atualizado...");
            p1.AdicionarEstoque(qtd, preco);
        }
    }
}
