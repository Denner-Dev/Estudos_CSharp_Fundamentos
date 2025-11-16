using System;

namespace POO_Heranca_Biblioteca
{
    // Classe base para itens do acervo da biblioteca.
    internal class ItemBiblioteca
    {
        public string titulo;
        public int anoPublicado;
        public string status;

        // Exibe informações básicas do item.
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {titulo} | Ano: {anoPublicado} | Status: {status}");
        }
    }
}
