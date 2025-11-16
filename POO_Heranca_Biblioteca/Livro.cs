using System;

namespace POO_Heranca_Biblioteca
{
    // Representa um livro — herda ItemBiblioteca e adiciona autor e páginas.
    internal class Livro : ItemBiblioteca
    {
        public string autor;
        public int numeroPaginas;

        // Exibe as informações do livro e do item base.
        public override void ExibirInformacoes()
        {
            Console.WriteLine("\n-- Livro --");
            base.ExibirInformacoes();
            Console.WriteLine($"Autor: {autor} | Páginas: {numeroPaginas}");
        }
    }
}
