using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o número de alunos: ");
        int numeroAlunos = int.Parse(Console.ReadLine());

        double mediaAprovados = CalcularMediaAprovados(numeroAlunos);

        Console.WriteLine($"A média das notas dos alunos aprovados é: {mediaAprovados}");
    }

    static double CalcularMediaAprovados(int numeroAlunos)
    {
        double somaNotas = 0;
        int quantidadeAprovados = 0;

        for (int i = 1; i <= numeroAlunos; i++)
        {
            Console.Write($"Digite a nota do aluno {i}: ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 6)
            {
                somaNotas += nota;
                quantidadeAprovados++;
            }
        }

        if (quantidadeAprovados > 0)
        {
            return somaNotas / quantidadeAprovados;
        }
        else
        {
            Console.WriteLine("Nenhum aluno foi aprovado.");
            return 0;
        }
    }
}
