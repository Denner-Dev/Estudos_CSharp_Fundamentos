using System;

namespace Construtores_ProdutoBasico
{
    internal class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        // Construtor padrão.
        public Produto()
        {
            Nome = "Caneta";
        }

        // Construtor com nome e preço.
        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        // Construtor completo.
        public Produto(string nome, decimal preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Adiciona apenas quantidade.
        public void AdicionarEstoque(int qtd)
        {
            Quantidade += qtd;
            Console.WriteLine($"Adicionando {qtd} unidades...\n");
            ExibirInfo();
        }

        // Adiciona quantidade e atualiza preço unitário.
        public void AdicionarEstoque(int qtd, decimal precoUnitario)
        {
            Quantidade += qtd;
            Preco = precoUnitario;
            Console.WriteLine($"Adicionando {qtd} unidades com novo preço unitário: {precoUnitario:F2}\n");
            ExibirInfo();
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Produto: {Nome} - Preço: R$ {Preco:F2} - Quantidade: {Quantidade}");
        }
    }
}
