using System;
using System.Collections.Generic;
using System.IO;

namespace Arquivos_CSV_CadastroProdutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            // 1 - Coletar os dados
            for (int i = 0; i < 3; i++)
            {
                Produto produto = new Produto();

                Console.Write("\nDigite o nome do produto:");
                produto.Nome = Console.ReadLine();
                Console.Write("Digite o preço do produto:");
                produto.Preco = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Digite a quantidade do produto:");
                produto.Quantidade = Convert.ToInt32((Console.ReadLine()));

                produtos.Add(produto);
            }

            // 2 - Criar CSV com cabeçalho
            List<string> linhas = new List<string>();
            linhas.Add("Nome,Preco,Quantidade");

            // 3 - Transformar cada produto em uma linha CSV
            foreach (var p in produtos)
            {
                string linha = $"{p.Nome},{p.Preco},{p.Quantidade}";
                linhas.Add(linha);
            }
            // 4 - Salvar no arquivo
            File.WriteAllLines("produtos.csv", linhas);
            Console.WriteLine("\nCSV criado com sucesso!\n");

            string[] linhasLidas = File.ReadAllLines("produtos.csv");

            Console.WriteLine("Produtos carregados do CSV:\n");

            // Começa por 1 para pular o cabeçalho
            for (int i = 1; i < linhasLidas.Length; i++)
            {
                string[] dados = linhasLidas[i].Split(',');

                var p = new Produto
                {
                    Nome = dados[0],
                    Preco = decimal.Parse(dados[1]),
                    Quantidade = int.Parse(dados[2])
                };
            }

            foreach (var produto in produtos)
            {
                Console.WriteLine($"Nome: {produto.Nome} | Preço: {produto.Preco} | Quantidade: {produto.Quantidade}");
            }
        }
    }
}
