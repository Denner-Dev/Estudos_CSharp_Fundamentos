using System;

namespace POO_Heranca_FuncionariosBonus
{
    // Gerente tem bônus maior e departamento.
    internal class Gerente : Funcionario
    {
        public string Departamento { get; set; }

        public Gerente(string nome, string departamento, decimal salario)
            : base(nome, salario)
        {
            Departamento = departamento;
        }

        public override decimal CalcularBonus()
        {
            return Salario * 0.20m;
        }

        public override void ExibirInfo()
        {
            Console.WriteLine("\n=== Gerente ===");
            base.ExibirInfo();
            Console.WriteLine($"Departamento: {Departamento}");
        }
    }
}
