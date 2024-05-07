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

        // Exibe o resultado
        Console.WriteLine($"Número de valores positivos: {positivos}");
        Console.WriteLine($"Número de valores negativos: {negativos}");
        Console.WriteLine($"Número de zeros: {zeros}");
    }
}
