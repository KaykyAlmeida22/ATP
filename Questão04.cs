using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número natural para calcular o fatorial:");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Número inválido. O número deve ser não negativo.");
        }
        else
        {
            long fatorial = CalcularFatorial(n);
            Console.WriteLine($"{n}! = {fatorial}");
        }
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
