using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] N = new int[20];
            int menorElemento = int.MaxValue;
            int posicaoMenor = -1;

            // Preenche o vetor N com valores informados pelo usuário
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Insira o valor para N[{i}]: ");
                N[i] = Convert.ToInt32(Console.ReadLine());

                // Verifica se o valor é menor que o menorElemento atual
                if (N[i] < menorElemento)
                {
                    menorElemento = N[i];
                    posicaoMenor = i;
                }
            }

            Console.WriteLine($"O menor elemento de N é {menorElemento} e sua posição dentro do vetor é {posicaoMenor}.");
        }
    }
}
