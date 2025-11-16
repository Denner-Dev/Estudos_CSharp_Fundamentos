using System;

namespace POO_Heranca_Veiculos
{
    // Classe base para veículos com marca e ano.
    internal class Veiculo
    {
        public string marca;
        public int ano;

        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Marca: {marca} - Ano: {ano}");
        }
    }
}
