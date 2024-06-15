using System;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[10];

            // Preenche o vetor com as notas informadas pelo usuário
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Insira a nota do aluno {i + 1}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Calcula a média das notas
            double somaNotas = 0;
            foreach (double nota in notas)
            {
                somaNotas += nota;
            }
            double media = somaNotas / notas.Length;

            // Conta quantos alunos obtiveram nota acima da média
            int acimaDaMedia = 0;
            foreach (double nota in notas)
            {
                if (nota > media)
                {
                    acimaDaMedia++;
                }
            }

            Console.WriteLine($"A média da turma é {media:F2}.");
            Console.WriteLine($"{acimaDaMedia} alunos obtiveram nota acima da média.");
        }
    }
}
