using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        string fraseCodificada = CodificarCesar(frase, 3);

        Console.WriteLine("A frase codificada é: " + fraseCodificada);
    }

    static string CodificarCesar(string texto, int deslocamento)
    {
        string resultado = "";

        foreach (char c in texto)
        {
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                char letraCodificada = (char)(((c + deslocamento - offset) % 26) + offset);
                resultado += letraCodificada;
            }
            else
            {
                resultado += c;
            }
        }

        return resultado;
    }
}
