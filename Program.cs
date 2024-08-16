using System;
using System.Collections.Generic;

namespace RankingDeFilmes{};

class Program
{
    static void Main(string[] args)
    {
        List<Filme> filmes = new List<Filme>();

        while (true)
        {
            Console.WriteLine("Escolha uma opcao");
            Console.WriteLine("1 - Adicionar filme");
            Console.WriteLine("2 - Exibir ranking de filmes");
            Console.WriteLine("3 -  Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Digite o nome do filme: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite a nota do filme (0 a 10): ");
                    double nota = Convert.ToDouble(Console.ReadLine());

                    filmes.Add(new Filme { Nome = nome, Nota = nota });
                    break;

                case "2":
                    filmes.Sort(CompararPorNota);
                    Console.WriteLine("\nRanking de Filmes:");
                    for (int i = 0; i < filmes.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {filmes[i].Nome} - Nota: {filmes[i].Nota}");
                    }

                    break;

                case "3":
                    return;

                default:
                    Console.WriteLine("Opcao invalida, tente novamente");
                    break;
            }
        }
        // Método de comparação para ordenar os filmes por nota de forma decrescente
        static int CompararPorNota(Filme x, Filme y)
        {
            // Se y.Nota for maior que x.Nota, y vem antes de x (ordem decrescente)
            return y.Nota.CompareTo(x.Nota);
        }
    }
}
