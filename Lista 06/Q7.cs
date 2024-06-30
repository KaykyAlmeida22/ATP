using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de letras (N) que deseja inserir:");
        int N = Convert.ToInt32(Console.ReadLine());

        string caminhoArquivo = "letras.txt";
        using (StreamWriter writer = new StreamWriter(caminhoArquivo))
        {
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Digite a letra {i + 1}:");
                char letra = Console.ReadLine()[0];
                writer.Write(letra);
            }
        }

        string conteudo = File.ReadAllText(caminhoArquivo);

        int quantidadeVogais = CalcularQuantidadeVogais(conteudo);

        Console.WriteLine("A quantidade de vogais no arquivo é: " + quantidadeVogais);
    }

    static int CalcularQuantidadeVogais(string texto)
    {
        int contadorVogais = 0;
        string vogais = "aeiouAEIOU";

        foreach (char c in texto)
        {
            if (vogais.Contains(c))
            {
                contadorVogais++;
            }
        }

        return contadorVogais;
    }
}
