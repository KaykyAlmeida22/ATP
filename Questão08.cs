using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o número de elementos da sequência de Fibonacci que você deseja imprimir:");
        int L = int.Parse(Console.ReadLine());

        Console.WriteLine("Os primeiros " + L + " elementos da sequência de Fibonacci são:");
        
        // Chama o método para imprimir os L primeiros elementos da sequência de Fibonacci
        ImprimirFibonacci(L);
    }

    static void ImprimirFibonacci(int L)
    {
        int primeiro = 0, segundo = 1;

        // Imprime os L primeiros elementos da sequência de Fibonacci
        for (int i = 0; i < L; i++)
        {
            Console.Write(primeiro + " ");
            int proximo = primeiro + segundo;
            primeiro = segundo;
            segundo = proximo;
        }
    }
}
