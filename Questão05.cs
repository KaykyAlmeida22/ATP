using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um valor inteiro e positivo para N:");
        int N = int.Parse(Console.ReadLine());

        if (N < 0)
        {
            Console.WriteLine("Número inválido. O número deve ser positivo.");
        }
        else
        {
            double E = CalcularE(N);
            Console.WriteLine($"O valor de E é: {E}");
        }
    }

    static double CalcularE(int N)
    {
        double resultado = 1.0; // Inicializa E com 1, pois a série começa com 1

        for (int i = 1; i <= N; i++)
        {
            resultado += 1.0 / CalcularFatorial(i);
        }

        return resultado;
    }

    static long CalcularFatorial(int num)
    {
        if (num == 0 || num == 1)
        {
            return 1;
        }
        else
        {
            long resultado = 1;
            for (int i = 2; i <= num; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
