using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[5, 5];

        PreencherMatriz(matriz);

        Console.WriteLine("Matriz preenchida:");
        ImprimirMatriz(matriz);

        Console.WriteLine("\nResultados das somas:");

        // Calculando e exibindo os resultados das funções
        Console.WriteLine($"Soma da linha 4: {SomaLinha(matriz, 4)}");
        Console.WriteLine($"Soma da coluna 2: {SomaColuna(matriz, 2)}");
        Console.WriteLine($"Soma da diagonal principal: {SomaDiagonalPrincipal(matriz)}");
        Console.WriteLine($"Soma da diagonal secundária: {SomaDiagonalSecundaria(matriz)}");
        Console.WriteLine($"Soma de todos os elementos da matriz: {SomaTodosElementos(matriz)}");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    // Procedimento para preencher a matriz com valores digitados pelo usuário
    static void PreencherMatriz(int[,] matriz)
    {
        Console.WriteLine("Digite os valores para preencher a matriz 5x5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Digite o valor para M[{i},{j}]: ");
                if (!int.TryParse(Console.ReadLine(), out matriz[i, j]))
                {
                    Console.WriteLine("Valor inválido. Digite novamente.");
                    j--; // Repete para a mesma coluna
                }
            }
        }
    }

    // Função para calcular a soma dos elementos de uma linha específica da matriz
    static int SomaLinha(int[,] matriz, int linha)
    {
        int soma = 0;
        for (int j = 0; j < 5; j++)
        {
            soma += matriz[linha, j];
        }
        return soma;
    }

    // Função para calcular a soma dos elementos de uma coluna específica da matriz
    static int SomaColuna(int[,] matriz, int coluna)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++)
        {
            soma += matriz[i, coluna];
        }
        return soma;
    }

    // Função para calcular a soma dos elementos da diagonal principal da matriz
    static int SomaDiagonalPrincipal(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++)
        {
            soma += matriz[i, i];
        }
        return soma;
    }

    // Função para calcular a soma dos elementos da diagonal secundária da matriz
    static int SomaDiagonalSecundaria(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++)
        {
            soma += matriz[i, 4 - i];
        }
        return soma;
    }

    // Função para calcular a soma de todos os elementos da matriz
    static int SomaTodosElementos(int[,] matriz)
    {
        int soma = 0;
        foreach (int elemento in matriz)
        {
            soma += elemento;
        }
        return soma;
    }

    // Procedimento para imprimir a matriz na tela
    static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
