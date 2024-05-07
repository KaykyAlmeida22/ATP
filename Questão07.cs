using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor de n: ");
        int n = int.Parse(Console.ReadLine());

        double soma = 0;

        Console.WriteLine("Termos gerados:");

        for (int i = 1; i <= n; i++)
        {
            double termo = 1.0 / i;
            Console.WriteLine($"1/{i} = {termo}");
            soma += termo;
        }

        Console.WriteLine($"Valor final de S: {soma}");
    }
}
