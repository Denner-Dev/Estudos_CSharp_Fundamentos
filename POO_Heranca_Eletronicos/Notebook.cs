using System;

namespace POO_Heranca_Eletronicos
{
    internal class Notebook : ProdutoEletronico
    {
        public string Marca { get; set; }
        public int TamanhoTela { get; set; }

        public Notebook(string nome, decimal preco, string marca, int tamanhoTela)
            : base(nome, preco)
        {
            Marca = marca;
            TamanhoTela = tamanhoTela;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Marca: {Marca} - Tamanho da tela: {TamanhoTela}");
        }
    }
}
