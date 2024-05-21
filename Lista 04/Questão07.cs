using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o número de alunos: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite a média final do aluno {i + 1}: ");
            double media = double.Parse(Console.ReadLine());

            ExibeConceito(media);
        }
    }

    static void ExibeConceito(double media)
    {
        char conceito;

        if (media < 40)
        {
            conceito = 'F';
        }
        else if (media < 60)
        {
            conceito = 'E';
        }
        else if (media < 70)
        {
            conceito = 'D';
        }
        else if (media < 80)
        {
            conceito = 'C';
        }
        else if (media < 90)
        {
            conceito = 'B';
        }
        else
        {
            conceito = 'A';
        }

        Console.WriteLine($"Conceito: {conceito}");
    }
}
