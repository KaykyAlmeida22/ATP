using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma sequência de valores inteiros separados por espaços:");

        // Lê a entrada do usuário
        string[] input = Console.ReadLine().Split(' ');

        // Variáveis para contar os valores
        int positivos = 0, negativos = 0, zeros = 0;
        int totalValores = input.Length;

        // Percorre cada valor da sequência
        foreach (string item in input)
        {
            int valor = int.Parse(item);

            // Conta os valores
            if (valor > 0)
            {
                positivos++;
            }
            else if (valor < 0)
            {
                negativos++;
            }
            else
            {
                zeros++;
            }
        }

        // Calcula os percentuais
        double percentualPositivos = (double)positivos / totalValores * 100;
        double percentualNegativos = (double)negativos / totalValores * 100;
        double percentualZeros = (double)zeros / totalValores * 100;

        // Exibe o resultado
        Console.WriteLine($"Número de valores positivos: {positivos} ({percentualPositivos:F2}%)");
        Console.WriteLine($"Número de valores negativos: {negativos} ({percentualNegativos:F2}%)");
        Console.WriteLine($"Número de zeros: {zeros} ({percentualZeros:F2}%)");
    }
}
