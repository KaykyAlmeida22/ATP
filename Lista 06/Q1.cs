using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        int contadorEspacos = 0;

        foreach (char c in frase)
        {
            if (c == ' ')
            {
                contadorEspacos++;
            }
        }

        Console.WriteLine("O número de espaços em branco na frase é: " + contadorEspacos);
    }
}
