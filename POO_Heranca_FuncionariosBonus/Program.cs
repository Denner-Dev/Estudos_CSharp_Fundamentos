using System;

namespace POO_Heranca_FuncionariosBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n=== Comparação de Bônus de Funcionários ===\n");

            Gerente gen1 = new Gerente("Denner", "TI", 10000);
            Estagiario esta1 = new Estagiario("Denner", "Remunerado", 5000);

            gen1.ExibirInfo();
            decimal bonusGen = gen1.CalcularBonus();

            esta1.ExibirInfo();
            decimal bonusEsta = esta1.CalcularBonus();

            Console.WriteLine("\n=== Resultado ===");

            if (bonusGen > bonusEsta)
            {
                Console.WriteLine($"Gerente tem o maior bônus ({bonusGen:C}).");
                Console.WriteLine($"Diferença: {bonusGen - bonusEsta:C}");
            }
            else if (bonusEsta > bonusGen)
            {
                Console.WriteLine($"Estagiário tem o maior bônus ({bonusEsta:C}).");
                Console.WriteLine($"Diferença: {bonusEsta - bonusGen:C}");
            }
            else
            {
                Console.WriteLine("Ambos possuem o mesmo valor de bônus.");
            }
        }
    }
}
