using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos alunos deseja calcular a média? ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine($"Aluno {i}:");
            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite 'A' para média aritmética ou 'P' para média ponderada: ");
            char opcao = char.Parse(Console.ReadLine());

            if (opcao == 'A')
            {
                CalculaMediaAritmetica(nota1, nota2, nota3);
            }
            else if (opcao == 'P')
            {
                CalculaMediaPonderada(nota1, nota2, nota3);
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
        }
    }

    static void CalculaMediaAritmetica(double nota1, double nota2, double nota3)
    {
        double media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine($"Média aritmética: {media}");
    }

    static void CalculaMediaPonderada(double nota1, double nota2, double nota3)
    {
        double media = (nota1 * 5 + nota2 * 3 + nota3 * 2) / 10;
        Console.WriteLine($"Média ponderada: {media}");
    }
}
