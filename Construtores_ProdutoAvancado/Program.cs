using System;

namespace Construtores_ProdutoAvancado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(); // Construtor padrão
            Produto p2 = new Produto("Teclado", 150m, 5); // Construtor com parâmetros

            p1.AdicionarEstoque(10);
            p2.AdicionarEstoque(5, 200m);

            p1.ExibirInfo();
            p2.ExibirInfo();
        }
    }
}
