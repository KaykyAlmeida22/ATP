using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos números deseja verificar?");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o {i+1}º número: ");
            int numero = int.Parse(Console.ReadLine());

            bool positivo = VerificaPositivo(numero);

            if (positivo)
            {
                Console.WriteLine($"{numero} é positivo.");
            }
            else
            {
                Console.WriteLine($"{numero} é negativo.");
            }
        }
    }

    static bool VerificaPositivo(int num)
    {
        return num >= 0;
    }
}
