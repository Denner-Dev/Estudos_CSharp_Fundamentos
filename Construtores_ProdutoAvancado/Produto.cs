using System;

namespace Construtores_ProdutoAvancado
{
    internal class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        // Construtor padrão.
        public Produto()
        {
            Nome = "Denner";
            Preco = 50m;
            Quantidade = 0;
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

        // Adiciona quantidade simples.
        public void AdicionarEstoque(int qtd)
        {
            Quantidade += qtd;
            Console.WriteLine($"Adicionado {qtd} unidade(s) ao estoque...");
        }

        // Adiciona quantidade e atualiza preço.
        public void AdicionarEstoque(int qtd, decimal novoPreco)
        {
            Quantidade += qtd;
            Preco = novoPreco;
            Console.WriteLine($"Adicionando {qtd} unidade(s) ao estoque. Novo preço: R$ {novoPreco:F2}");
        }

        // Exibe informações do produto.
        public void ExibirInfo()
        {
            Console.WriteLine($"Nome do produto: {Nome} - Preço: R$ {Preco:F2} - Quantidade em estoque: {Quantidade}\n");
        }
    }
}
