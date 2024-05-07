using System;

class Program
{
    static void Main()
    {
        int totalPessoas = 0;
        double totalSalario = 0;
        int totalFilhos = 0;
        double maiorSalario = double.MinValue;
        int pessoasAte100 = 0;

        Console.WriteLine("Digite o salário e o número de filhos de cada habitante (digite um salário negativo para encerrar):");

        while (true)
        {
            double salario = double.Parse(Console.ReadLine());

            if (salario < 0)
            {
                break;
            }

            int filhos = int.Parse(Console.ReadLine());

            totalPessoas++;
            totalSalario += salario;
            totalFilhos += filhos;

            if (salario > maiorSalario)
            {
                maiorSalario = salario;
            }

            if (salario <= 100)
            {
                pessoasAte100++;
            }
        }

        if (totalPessoas == 0)
        {
            Console.WriteLine("Nenhum dado foi inserido.");
        }
        else
        {
            double mediaSalario = totalSalario / totalPessoas;
            double mediaFilhos = (double)totalFilhos / totalPessoas;
            double percentualAte100 = (double)pessoasAte100 / totalPessoas * 100;

            Console.WriteLine($"Média do salário da população: {mediaSalario:F2}");
            Console.WriteLine($"Média do número de filhos: {mediaFilhos:F2}");
            Console.WriteLine($"Maior salário: {maiorSalario:F2}");
            Console.WriteLine($"Percentual de pessoas com salário até R$100,00: {percentualAte100:F2}%");
        }
    }
}
