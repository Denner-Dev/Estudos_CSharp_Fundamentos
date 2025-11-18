using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Arquivos_JSON_Basico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var produtos = new List<Produto>()
            {
                new Produto {Nome = "Bola", Preco = 10, Quantidade = 5},
                new Produto {Nome = "Carrinho", Preco = 25, Quantidade = 2}
            };

            // JsonSerializer.Serialize = transforma objeto em texto JSON              // WriteIndented = true deixa o JSON bonito/formatado.
            string json = JsonSerializer.Serialize(produtos, new JsonSerializerOptions { WriteIndented = true });

            // Agora escrevemos essa string JSON dentro do arquivo produtos.json.
            File.WriteAllText("produtos.json", json);

            Console.WriteLine("JSON criado!");

            string conteudo = File.ReadAllText("produtos.json");

            // Deserialize<List<Produto>> = transforma o JSON em uma lista real de Produto.
            var lista = JsonSerializer.Deserialize<List<Produto>>(conteudo);

            foreach (var p in lista)
            {
                Console.WriteLine($"{p.Nome} | {p.Preco} | {p.Quantidade}");

            }
        }
    }
}