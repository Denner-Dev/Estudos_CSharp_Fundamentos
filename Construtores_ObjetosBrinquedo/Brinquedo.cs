using System;

namespace Construtores_ObjetosBrinquedo
{
    // Representa um brinquedo com nome, preço e quantidade.
    internal class Brinquedo
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        // Construtor padrão.
        public Brinquedo()
        {
            Nome = "Bola";
            Preco = 10;
            Quantidade = 5;
        }

        // Construtor com parâmetros.
        public Brinquedo(string nome, decimal preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Sobrecarga: adiciona quantidade.
        public void AdicionarEstoque(int quantidade)
        {
            Quantidade += quantidade;
            ExibirInfo();
        }

        // Sobrecarga: adiciona quantidade e atualiza preço.
        public void AdicionarEstoque(int quantidade, decimal preco)
        {
            Quantidade += quantidade;
            Preco = preco;
            ExibirInfo();
        }

        // Mostra info do brinquedo.
        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome} - Preço: {Preco:F2} - Quantidade: {Quantidade}");
        }
    }
}
