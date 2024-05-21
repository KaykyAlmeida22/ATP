using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor de N: ");
        int N = int.Parse(Console.ReadLine());

        double resultado = CalcularS(N);

        Console.WriteLine($"O valor de S é: {resultado}");
    }

    static double CalcularS(int N)
    {
        double S = 0.0;

        for (int n = 1; n <= N; n++)
        {
            S += (Math.Pow(n, 2) + 1) / (double)(n + 3);
        }

        return S;
    }
}
