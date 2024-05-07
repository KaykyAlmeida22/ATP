using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor limite (L) para a soma dos elementos da sequência de Fibonacci:");
        int L = int.Parse(Console.ReadLine());

        int soma = SomaFibonacciMenoresQue(L);

        Console.WriteLine("A soma de todos os elementos da série de Fibonacci menores que " + L + " é: " + soma);
    }

    static int SomaFibonacciMenoresQue(int L)
    {
        int primeiro = 0, segundo = 1, proximo, soma = 0;

        // Calcula a soma dos elementos da série de Fibonacci menores que L
        while (primeiro < L)
        {
            soma += primeiro;
            proximo = primeiro + segundo;
            primeiro = segundo;
            segundo = proximo;
        }

        return soma;
    }
}
