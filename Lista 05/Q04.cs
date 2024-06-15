using System;

namespace VetoresIntercalados
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorX = new int[10];
            int[] vetorY = new int[10];

            PreencherVetor(vetorX, "X");
            PreencherVetor(vetorY, "Y");

            int[] vetorIntercalado = IntercalarVetores(vetorX, vetorY);

            Console.WriteLine("Vetor Intercalado:");
            ExibirVetor(vetorIntercalado);
        }

        static void PreencherVetor(int[] vetor, string nomeVetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o {i}° número do vetor {nomeVetor}: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static int[] IntercalarVetores(int[] vetor1, int[] vetor2)
        {
            int[] vetorIntercalado = new int[vetor1.Length + vetor2.Length];
            int index = 0;

            for (int i = 0; i < vetor1.Length; i++)
            {
                vetorIntercalado[index] = vetor1[i];
                index++;
                vetorIntercalado[index] = vetor2[i];
                index++;
            }

            return vetorIntercalado;
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
