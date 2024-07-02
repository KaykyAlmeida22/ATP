using System;
using System.IO;

namespace ControleDeVendas
{
    class Program
    {
        const int numProdutos = 4;
        const int diasDoMes = 30;
        static string[] produtos = new string[numProdutos];
        static int[] estoque = new int[numProdutos];
        static int[,] vendas = new int[diasDoMes, numProdutos];

        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("Menu Principal:");
                Console.WriteLine("1 – Importar arquivo de produtos");
                Console.WriteLine("2 – Registrar venda");
                Console.WriteLine("3 – Relatório de vendas");
                Console.WriteLine("4 – Relatório de estoque");
                Console.WriteLine("5 – Criar arquivo de vendas");
                Console.WriteLine("6 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ImportarArquivoDeProdutos();
                        break;
                    case 2:
                        RegistrarVenda();
                        break;
                    case 3:
                        RelatorioDeVendas();
                        break;
                    case 4:
                        RelatorioDeEstoque();
                        break;
                    case 5:
                        CriarArquivoDeVendas();
                        break;
                    case 6:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            } while (opcao != 6);
        }

        // Método para importar arquivo de produtos
        static void ImportarArquivoDeProdutos()
        {
            Console.WriteLine("Digite o caminho do arquivo de produtos:");
            string caminhoArquivo = Console.ReadLine();

            try
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);

                for (int i = 0; i < numProdutos; i++)
                {
                    string[] dados = linhas[i].Split(',');
                    produtos[i] = dados[0];
                    estoque[i] = Convert.ToInt32(dados[1]);
                }

                Console.WriteLine("Arquivo importado com sucesso!");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao ler o arquivo: {e.Message}");
            }
        }

        // Método para registrar venda
        static void RegistrarVenda()
        {
            Console.WriteLine("Digite o número do produto (0 a 3):");
            int numProduto = Convert.ToInt32(Console.ReadLine());

            if (numProduto < 0 || numProduto >= numProdutos)
            {
                Console.WriteLine("Produto inválido.");
                return;
            }

            Console.WriteLine("Digite o dia do mês (1 a 30):");
            int dia = Convert.ToInt32(Console.ReadLine()) - 1;

            if (dia < 0 || dia >= diasDoMes)
            {
                Console.WriteLine("Dia inválido.");
                return;
            }

            Console.WriteLine("Digite a quantidade vendida:");
            int quantidadeVendida = Convert.ToInt32(Console.ReadLine());

            if (quantidadeVendida > estoque[numProduto])
            {
                Console.WriteLine("Quantidade vendida excede o estoque disponível.");
                return;
            }

            vendas[dia, numProduto] += quantidadeVendida;
            estoque[numProduto] -= quantidadeVendida;

            Console.WriteLine("Venda registrada com sucesso!");
        }

        // Método para exibir relatório de vendas
        static void RelatorioDeVendas()
        {
            Console.WriteLine("Relatório de Vendas:");
            Console.WriteLine("Dia\tProduto A\tProduto B\tProduto C\tProduto D");

            for (int dia = 0; dia < diasDoMes; dia++)
            {
                Console.Write($"{dia + 1}\t");

                for (int produto = 0; produto < numProdutos; produto++)
                {
                    Console.Write($"{vendas[dia, produto]}\t\t");
                }

                Console.WriteLine();
            }
        }

        // Método para exibir relatório de estoque
        static void RelatorioDeEstoque()
        {
            Console.WriteLine("Relatório de Estoque Atualizado:");

            for (int i = 0; i < numProdutos; i++)
            {
                Console.WriteLine($"{produtos[i]}: {estoque[i]}");
            }
        }

        // Método para criar arquivo de vendas
        static void CriarArquivoDeVendas()
        {
            string caminhoArquivo = "RelatorioDeVendas.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    writer.WriteLine("Produto\tTotal Vendido");

                    for (int i = 0; i < numProdutos; i++)
                    {
                        int totalVendido = 0;

                        for (int dia = 0; dia < diasDoMes; dia++)
                        {
                            totalVendido += vendas[dia, i];
                        }

                        writer.WriteLine($"{produtos[i]}\t{totalVendido}");
                    }
                }

                Console.WriteLine("Arquivo de vendas criado com sucesso!");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao criar o arquivo: {e.Message}");
            }
        }
    }
}
