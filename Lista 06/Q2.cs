using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        string fraseSemVogais = RemoverVogais(frase);

        Console.WriteLine("A frase sem as vogais é: " + fraseSemVogais);
    }

    static string RemoverVogais(string frase)
    {
        string vogais = "aeiouAEIOU";
        string resultado = "";

        foreach (char c in frase)
        {
            if (!vogais.Contains(c))
            {
                resultado += c;
            }
        }

        return resultado;
    }
}
