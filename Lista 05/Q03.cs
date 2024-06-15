using System;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] X = new int[10];
            PreencherVetor(X);
            int[] valoresNegativos = CopiarValoresNegativos(X);

            Console.WriteLine("Vetor X:");
            ExibirVetor(X);

            Console.WriteLine("\nValores negativos copiados para o novo vetor:");
            ExibirVetor(valoresNegativos);
        }

        static void PreencherVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Insira o valor para X[{i}]: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static int[] CopiarValoresNegativos(int[] vetor)
        {
            int countNegativos = 0;
            foreach (int valor in vetor)
            {
                if (valor < 0)
                    countNegativos++;
            }

            int[] novoVetor = new int[countNegativos];
            int index = 0;
            foreach (int valor in vetor)
            {
                if (valor < 0)
                {
                    novoVetor[index] = valor;
                    index++;
                }
            }

            return novoVetor;
        }

        static void ExibirVetor(int[] vetor)
        {
            foreach (int valor in vetor)
            {
                Console.Write($"{valor} ");
            }
            Console.WriteLine();
        }
    }
}
