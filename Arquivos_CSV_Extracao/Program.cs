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
            var produtos = new List<Produto>();

            // Substitua pelo caminho correto do arquivo CSV.
            var linhas = File.ReadAllLines(@"dados.csv");

            // Percorre a partir de 1 para pular o header (linha 0).
            for (int i = 1; i < linhas.Length; i++)
            {
                // Divide por vírgula — atenção: não trata aspas nem vírgulas dentro de campos.
                var cols = linhas[i].Split(',');

                var p = new Produto
                {
                    Nome = cols[0],
                    Codigo = cols[1],
                    Quantidade = int.Parse(cols[2]),
                    Preco = decimal.Parse(cols[3], CultureInfo.InvariantCulture)
                };

                produtos.Add(p);
            }

            // Exibe os produtos carregados.
            foreach (var p in produtos)
            {
                Console.WriteLine($"{p.Nome} - {p.Codigo} - {p.Quantidade} - {p.Preco:C}");
            }
        }
    }
}
