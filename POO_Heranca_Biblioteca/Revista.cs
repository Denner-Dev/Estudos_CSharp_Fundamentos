using System;

namespace POO_Heranca_Biblioteca
{
    // Representa uma revista — herda ItemBiblioteca e adiciona edição e periodicidade.
    internal class Revista : ItemBiblioteca
    {
        public string edicao;
        public string periodicidade;

        public override void ExibirInformacoes()
        {
            Console.WriteLine("\n-- Revista --");
            base.ExibirInformacoes();
            Console.WriteLine($"Edição: {edicao} | Periodicidade: {periodicidade}");
        }
    }
}
