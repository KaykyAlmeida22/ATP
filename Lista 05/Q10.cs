using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[10, 10];

        PreencherMatriz(matriz);

        Console.WriteLine("\nMatriz original:");
        ImprimirMatriz(matriz);

        TrocarLinhas(matriz, 2, 8);
        Console.WriteLine("\nMatriz após trocar a linha 2 com a linha 8:");
        ImprimirMatriz(matriz);

        TrocarColunas(matriz, 4, 10);
        Console.WriteLine("\nMatriz após trocar a coluna 4 com a coluna 10:");
        ImprimirMatriz(matriz);

        TrocarDiagonais(matriz);
        Console.WriteLine("\nMatriz após trocar a diagonal principal com a diagonal secundária:");
        ImprimirMatriz(matriz);

        TrocarLinhaComColuna(matriz, 5, 10);
        Console.WriteLine("\nMatriz após trocar a linha 5 com a coluna 10:");
        ImprimirMatriz(matriz);

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    // Procedimento para preencher a matriz com valores digitados pelo usuário
    static void PreencherMatriz(int[,] matriz)
    {
        Console.WriteLine("Digite os valores para preencher a matriz 10x10:");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
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

    // Procedimento para trocar duas linhas da matriz
    static void TrocarLinhas(int[,] matriz, int linha1, int linha2)
    {
        for (int j = 0; j < 10; j++)
        {
            int temp = matriz[linha1, j];
            matriz[linha1, j] = matriz[linha2, j];
            matriz[linha2, j] = temp;
        }
    }

    // Procedimento para trocar duas colunas da matriz
    static void TrocarColunas(int[,] matriz, int coluna1, int coluna2)
    {
        for (int i = 0; i < 10; i++)
        {
            int temp = matriz[i, coluna1];
            matriz[i, coluna1] = matriz[i, coluna2];
            matriz[i, coluna2] = temp;
        }
    }

    // Procedimento para trocar a diagonal principal com a diagonal secundária
    static void TrocarDiagonais(int[,] matriz)
    {
        for (int i = 0; i < 10; i++)
        {
            int temp = matriz[i, i];
            matriz[i, i] = matriz[i, 9 - i];
            matriz[i, 9 - i] = temp;
        }
    }

    // Procedimento para trocar uma linha com uma coluna da matriz
    static void TrocarLinhaComColuna(int[,] matriz, int linha, int coluna)
    {
        for (int i = 0; i < 10; i++)
        {
            int temp = matriz[linha, i];
            matriz[linha, i] = matriz[i, coluna - 1]; // coluna - 1 porque coluna é indexada a partir de 1
            matriz[i, coluna - 1] = temp; // coluna - 1 porque coluna é indexada a partir de 1
        }
    }

    // Procedimento para imprimir a matriz na tela
    static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
