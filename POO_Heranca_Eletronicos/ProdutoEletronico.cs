using System;

namespace POO_Heranca_Eletronicos
{
    // Classe base para produtos eletrônicos.
    internal class ProdutoEletronico
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public ProdutoEletronico(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome} - Preço: R$ {Preco:F2}.");
        }
    }
}
