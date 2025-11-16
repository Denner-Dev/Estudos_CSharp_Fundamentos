using System;
using System.Collections.Generic;

namespace POO_Heranca_Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista que guarda itens variados (livros e revistas).
            List<ItemBiblioteca> acervo = new List<ItemBiblioteca>();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n======= MENU BIBLIOTECA =======");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Adicionar Revista");
                Console.WriteLine("3. Listar todos os itens");
                Console.WriteLine("4. Buscar itens por título");
                Console.WriteLine("5. Filtrar somente Livros ou Revistas");
                Console.WriteLine("6. Alterar status (Disponível/Emprestado)");
                Console.WriteLine("7. Sair");
                Console.Write("Escolha uma opção: ");

                string resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "1":
                        Livro livro = new Livro();
                        Console.WriteLine("\n=== Adicionar Livro ===");
                        Console.Write("Título: ");
                        livro.titulo = Console.ReadLine();
                        Console.Write("Ano de publicação: ");
                        livro.anoPublicado = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Status: ");
                        livro.status = Console.ReadLine();
                        Console.Write("Autor: ");
                        livro.autor = Console.ReadLine();
                        Console.Write("Número de páginas: ");
                        livro.numeroPaginas = Convert.ToInt32(Console.ReadLine());

                        acervo.Add(livro);
                        Console.WriteLine("Livro adicionado com sucesso!");
                        break;

                    case "2":
                        Revista revista = new Revista();
                        Console.WriteLine("\n=== Adicionar Revista ===");
                        Console.Write("Título: ");
                        revista.titulo = Console.ReadLine();
                        Console.Write("Ano de publicação: ");
                        revista.anoPublicado = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Status: ");
                        revista.status = Console.ReadLine();
                        Console.Write("Edição: ");
                        revista.edicao = Console.ReadLine();
                        Console.Write("Periodicidade: ");
                        revista.periodicidade = Console.ReadLine();

                        acervo.Add(revista);
                        Console.WriteLine("Revista adicionada com sucesso!");
                        break;

                    case "3":
                        Console.WriteLine("\n=== Itens do Acervo ===");
                        if (acervo.Count == 0)
                            Console.WriteLine("Nenhum item cadastrado.");
                        else
                            foreach (var item in acervo)
                                item.ExibirInformacoes();
                        break;

                    case "4":
                        Console.WriteLine("\n=== Buscar por título ===");
                        Console.Write("Digite parte do título: ");
                        string busca = Console.ReadLine().ToLower();
                        bool achou = false;
                        foreach (var item in acervo)
                        {
                            if (item.titulo != null && item.titulo.ToLower().Contains(busca))
                            {
                                item.ExibirInformacoes();
                                achou = true;
                            }
                        }
                        if (!achou) Console.WriteLine("Nenhum item encontrado.");
                        break;

                    case "5":
                        Console.WriteLine("\n=== Filtrar Itens ===");
                        Console.Write("Digite L para Livros ou R para Revistas: ");
                        string filtro = Console.ReadLine().ToUpper();
                        if (filtro == "L")
                        {
                            Console.WriteLine("\n-- Apenas Livros --");
                            foreach (var item in acervo)
                                if (item is Livro) item.ExibirInformacoes();
                        }
                        else if (filtro == "R")
                        {
                            Console.WriteLine("\n-- Apenas Revistas --");
                            foreach (var item in acervo)
                                if (item is Revista) item.ExibirInformacoes();
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida.");
                        }
                        break;

                    case "6":
                        Console.WriteLine("\n=== Alterar Status ===");
                        for (int i = 0; i < acervo.Count; i++)
                        {
                            Console.Write($"{i + 1}. ");
                            acervo[i].ExibirInformacoes();
                        }
                        Console.Write("\nEscolha o item pelo número: ");
                        int index = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (index >= 0 && index < acervo.Count)
                        {
                            Console.Write("Novo status (Disponível/Emprestado): ");
                            acervo[index].status = Console.ReadLine();
                            Console.WriteLine("Status atualizado!");
                        }
                        else
                        {
                            Console.WriteLine("Índice inválido!");
                        }
                        break;

                    case "7":
                        continuar = false;
                        Console.WriteLine("Encerrando sistema...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
