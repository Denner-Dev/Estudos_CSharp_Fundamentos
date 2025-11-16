using System;

namespace POO_Heranca_Eletronicos
{
    internal class Smartphone : ProdutoEletronico
    {
        public string Marca { get; set; }
        public int MemoriaGB { get; set; }

        public Smartphone(string nome, decimal preco, string marca, int memoriaGB)
            : base(nome, preco)
        {
            Marca = marca;
            MemoriaGB = memoriaGB;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Marca: {Marca} - Memória: {MemoriaGB}GB");
        }
    }
}
