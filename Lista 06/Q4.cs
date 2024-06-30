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

            string conteudo = File.ReadAllText(caminhoArquivo);
            int contadorA = ContarCaracteresA(conteudo);

            Console.WriteLine("A quantidade de caracteres 'a' no arquivo é: " + contadorA);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocorreu um erro: " + ex.Message);
        }
    }

    static int ContarCaracteresA(string texto)
    {
        int contador = 0;

        foreach (char c in texto)
        {
            if (c == 'a' || c == 'A')
            {
                contador++;
            }
        }

        return contador;
    }
}
