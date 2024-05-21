using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite os dados dos habitantes (para encerrar, digite um salário negativo):");
        CalculaMediaSalarioPopulacao();
    }

    static void CalculaMediaSalarioPopulacao()
    {
        int totalHabitantes = 0;
        double somaSalarios = 0;

        while (true)
        {
            Console.Write("Salário do habitante (digite um valor negativo para encerrar): ");
            double salario = double.Parse(Console.ReadLine());

            if (salario < 0)
            {
                break;
            }

            Console.Write("Número de filhos do habitante: ");
            int numFilhos = int.Parse(Console.ReadLine());

            somaSalarios += salario;
            totalHabitantes++;
        }

        if (totalHabitantes > 0)
        {
            double mediaSalario = somaSalarios / totalHabitantes;
            Console.WriteLine($"Média de salário da população: {mediaSalario}");
        }
        else
        {
            Console.WriteLine("Nenhum dado foi inserido.");
        }
    }
}
