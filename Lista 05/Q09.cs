using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrizA = new int[4, 6];
        int[,] matrizB = new int[4, 6];

        PreencherMatrizes(matrizA, matrizB);

        Console.WriteLine("\nMatriz A:");
        ImprimirMatriz(matrizA);

        Console.WriteLine("\nMatriz B:");
        ImprimirMatriz(matrizB);

        int[,] matrizSoma = SomaMatrizes(matrizA, matrizB);
        Console.WriteLine("\nMatriz Soma (A + B):");
        ImprimirMatriz(matrizSoma);

        int[,] matrizDiferenca = DiferencaMatrizes(matrizA, matrizB);
        Console.WriteLine("\nMatriz Diferença (A - B):");
        ImprimirMatriz(matrizDiferenca);

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    // Procedimento para preencher as matrizes A e B com valores digitados pelo usuário
    static void PreencherMatrizes(int[,] matrizA, int[,] matrizB)
    {
        Console.WriteLine("Digite os valores para preencher a matriz A 4x6:");
        PreencherMatriz(matrizA);

        Console.WriteLine("\nDigite os valores para preencher a matriz B 4x6:");
        PreencherMatriz(matrizB);
    }

    // Procedimento genérico para preencher uma matriz com valores digitados pelo usuário
    static void PreencherMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++) // número de linhas
        {
            for (int j = 0; j < matriz.GetLength(1); j++) // número de colunas
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

    // Função para calcular a soma de duas matrizes
    static int[,] SomaMatrizes(int[,] matrizA, int[,] matrizB)
    {
        int[,] matrizSoma = new int[matrizA.GetLength(0), matrizA.GetLength(1)];
        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                matrizSoma[i, j] = matrizA[i, j] + matrizB[i, j];
            }
        }
        return matrizSoma;
    }

    // Função para calcular a diferença de duas matrizes (A - B)
    static int[,] DiferencaMatrizes(int[,] matrizA, int[,] matrizB)
    {
        int[,] matrizDiferenca = new int[matrizA.GetLength(0), matrizA.GetLength(1)];
        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                matrizDiferenca[i, j] = matrizA[i, j] - matrizB[i, j];
            }
        }
        return matrizDiferenca;
    }

    // Procedimento para imprimir uma matriz na tela
    static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++) // número de linhas
        {
            for (int j = 0; j < matriz.GetLength(1); j++) // número de colunas
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
