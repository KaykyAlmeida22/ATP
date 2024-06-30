using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Digite o caminho do arquivo de texto:");
            string caminhoArquivo = Console.ReadLine();

            string[] linhas = File.ReadAllLines(caminhoArquivo);
            int quantidadeLinhas = linhas.Length;

            Console.WriteLine("Conteúdo do arquivo:");

            foreach (string linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.WriteLine("A quantidade de linhas no arquivo é: " + quantidadeLinhas);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocorreu um erro: " + ex.Message);
        }
    }
}
