using System;

namespace POO_Heranca_FuncionariosBonus
{
    // Classe base para funcionários.
    internal class Funcionario
    {
        public string Nome { get; set; }
        public decimal Salario { get; set; }

        public Funcionario(string nome, decimal salario)
        {
            Nome = nome;
            Salario = salario;
        }

        // Calcula bônus padrão (10%).
        public virtual decimal CalcularBonus()
        {
            return Salario * 0.10m;
        }

        // Exibe informações do funcionário incluindo o bônus.
        public virtual void ExibirInfo()
        {
            Console.WriteLine($"\nNome: {Nome}");
            Console.WriteLine($"Salário: {Salario:C}");
            Console.WriteLine($"Bônus: {CalcularBonus():C}");
        }
    }
}
