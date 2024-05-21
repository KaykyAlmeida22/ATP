using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o número de conjuntos de 3 valores: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Conjunto {i + 1}:");
            Console.Write("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            ExibeOrdemCrescente(valor1, valor2, valor3);
        }
    }

    static void ExibeOrdemCrescente(int a, int b, int c)
    {
        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        if (b > c)
        {
            int temp = b;
            b = c;
            c = temp;
        }
        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        Console.WriteLine($"Valores em ordem crescente: {a}, {b}, {c}");
    }
}
