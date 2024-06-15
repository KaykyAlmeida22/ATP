using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[4, 4];

        PreencherMatriz(matriz);

        Console.WriteLine("\nMatriz preenchida:");
        ImprimirMatriz(matriz);

        int somaAbaixoDiagonal = SomaElementosAbaixoDiagonal(matriz);
        Console.WriteLine($"\nSoma dos elementos abaixo da diagonal principal: {somaAbaixoDiagonal}");

        Console.WriteLine("\nElementos da diagonal principal:");
        MostrarDiagonalPrincipal(matriz);

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    // Procedimento para preencher a matriz com valores digitados pelo usuário
    static void PreencherMatriz(int[,] matriz)
    {
        Console.WriteLine("Digite os valores para preencher a matriz 4x4:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
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

    // Função para calcular a soma dos elementos abaixo da diagonal principal da matriz
    static int SomaElementosAbaixoDiagonal(int[,] matriz)
    {
        int soma = 0;
        for (int i = 1; i < 4; i++) // Começa a partir da linha 1 (abaixo da diagonal principal)
        {
            for (int j = 0; j < i; j++)
            {
                soma += matriz[i, j];
            }
        }
        return soma;
    }

    // Procedimento para mostrar os elementos da diagonal principal da matriz
    static void MostrarDiagonalPrincipal(int[,] matriz)
    {
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(matriz[i, i]);
        }
    }

    // Procedimento para imprimir a matriz na tela
    static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
