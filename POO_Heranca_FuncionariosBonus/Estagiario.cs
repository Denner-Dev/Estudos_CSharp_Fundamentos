using System;

namespace POO_Heranca_FuncionariosBonus
{
    // Estagiário com tipo de estágio e bônus reduzido.
    internal class Estagiario : Funcionario
    {
        public string TipoDeEstagio { get; set; }

        public Estagiario(string nome, string tipoDeEstagio, decimal salario)
            : base(nome, salario)
        {
            TipoDeEstagio = tipoDeEstagio;
        }

        public override decimal CalcularBonus()
        {
            return Salario * 0.05m;
        }

        public override void ExibirInfo()
        {
            Console.WriteLine("\n=== Estagiário ===");
            base.ExibirInfo();
            Console.WriteLine($"Tipo de Estágio: {TipoDeEstagio}\n");
        }
    }
}
