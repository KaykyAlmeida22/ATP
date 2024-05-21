using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a idade do nadador: ");
        int idade = int.Parse(Console.ReadLine());

        char categoria = DeterminarCategoria(idade);

        Console.WriteLine($"Categoria do nadador: {categoria}");
    }

    static char DeterminarCategoria(int idade)
    {
        char categoria;

        if (idade >= 5 && idade <= 7)
        {
            categoria = 'F';
        }
        else if (idade >= 8 && idade <= 10)
        {
            categoria = 'E';
        }
        else if (idade >= 11 && idade <= 13)
        {
            categoria = 'D';
        }
        else if (idade >= 14 && idade <= 15)
        {
            categoria = 'C';
        }
        else if (idade >= 16 && idade <= 17)
        {
            categoria = 'B';
        }
        else
        {
            categoria = 'A';
        }

        return categoria;
    }
}
