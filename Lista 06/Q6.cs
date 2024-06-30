using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número:");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Os divisores de " + numero + " são:");

        int somaDivisores = 0;

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                Console.WriteLine(i);
                somaDivisores += i;
            }
        }

        string caminhoArquivo = "soma_divisores.txt";

        try
        {
            File.WriteAllText(caminhoArquivo, "A soma total dos divisores de " + numero + " é: " + somaDivisores);
            Console.WriteLine("A soma total dos divisores foi salva no arquivo: " + caminhoArquivo);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocorreu um erro ao salvar o arquivo: " + ex.Message);
        }
    }
}
