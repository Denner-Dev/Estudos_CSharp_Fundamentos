using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Arquivos_CSV_Extracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = "produtos.csv";

            string[] linhas =
            {
                "Nome,Preco,Quantidade",
                "Bola,10,5",
                "Carrinho,25,2"
            };

            File.WriteAllLines(caminho, linhas);

            Console.WriteLine("CSV criado!");

            var produtos = new List<Produto>();

            // Percorre a partir de 1 para pular o header (linha 0).
            for (int i = 1; i < linhas.Length; i++)
            {
                // Divide por vírgula — atenção: não trata aspas nem vírgulas dentro de campo
                string[] dados = linhas[i].Split(',');

                var p = new Produto
                {
                    Nome = dados[0],
                    Preco = decimal.Parse(dados[1]),
                    Quantidade = int.Parse(dados[2])
                };

                produtos.Add(p);
            }

            // Exibe os produtos carregados.
            foreach (var p in produtos)
            {
                Console.WriteLine($"{p.Nome} | {p.Preco:F2} | {p.Quantidade}");
            }
        }
    }
}
