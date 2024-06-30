using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string caminhoArquivo = "numeros.txt";

        // Verifica se o arquivo existe
        if (!File.Exists(caminhoArquivo))
        {
            Console.WriteLine($"Arquivo {caminhoArquivo} não encontrado.");
            return;
        }

        // Leitura do arquivo e cálculo dos valores
        try
        {
            string[] linhas = File.ReadAllLines(caminhoArquivo);

            if (linhas.Length == 0)
            {
                Console.WriteLine($"O arquivo {caminhoArquivo} está vazio.");
                return;
            }

            double[] numeros = new double[linhas.Length];

            for (int i = 0; i < linhas.Length; i++)
            {
                if (double.TryParse(linhas[i], out double numero))
                {
                    numeros[i] = numero;
                }
                else
                {
                    Console.WriteLine($"Erro ao converter linha {i + 1} para número.");
                    return;
                }
            }

            // Calculando o valor máximo, mínimo e média
            double valorMaximo = numeros.Max();
            double valorMinimo = numeros.Min();
            double media = numeros.Average();

            // Exibindo os resultados na tela
            Console.WriteLine($"Valor máximo: {valorMaximo}");
            Console.WriteLine($"Valor mínimo: {valorMinimo}");
            Console.WriteLine($"Média dos valores: {media}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
        }
    }
}
