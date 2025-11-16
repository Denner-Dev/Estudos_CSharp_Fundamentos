using System;
using System.ComponentModel;
using System.Drawing;

namespace Excecoes_TratamentoBasico
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
             bool continuar = true;
            /*
             while (continuar)
             {
                 try
                 {
                     Console.Write("Digite o primeiro numero: ");
                     decimal num1 = decimal.Parse(Console.ReadLine());
                     Console.Write("Digite o segundo numero: ");
                     decimal num2 = decimal.Parse(Console.ReadLine());

                     decimal resultado = num1 / num2;

                     Console.WriteLine($"Resultado da divisao: {resultado:F2}");
                     continuar = false;
                 }

                 catch (FormatException)
                 {
                     Console.WriteLine("Valor inválido! Tente novamente.");
                 }

                 catch (DivideByZeroException)
                 {
                     Console.WriteLine("Nao pode dividir por 0!");
                 }

                 finally
                 {

                     Console.WriteLine("Finalizando operação...");

                 }
             }*/

            static decimal LerNumeroValido()
            {

                while (true)
                {
                    try
                    {
                        Console.Write("Digite um numero: ");
                        decimal numero = decimal.Parse(Console.ReadLine());
                        return numero;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Valor inválido! Digite novamente.");

                    }
                }
            }

            decimal n = LerNumeroValido();

            Console.WriteLine("Você digitou: " + n);
        }

    }
}

