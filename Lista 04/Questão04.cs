using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Digite os comprimentos dos lados do triângulo (ou digite '0' para encerrar):");
            Console.Write("Lado X: ");
            double x = double.Parse(Console.ReadLine());

            if (x == 0)
                break;

            Console.Write("Lado Y: ");
            double y = double.Parse(Console.ReadLine());

            Console.Write("Lado Z: ");
            double z = double.Parse(Console.ReadLine());

            VerificaTriangulo(x, y, z);
        }
    }

    static void VerificaTriangulo(double x, double y, double z)
    {
        if (x < y + z && y < x + z && z < x + y)
        {
            if (x == y && y == z)
            {
                Console.WriteLine("Triângulo Equilátero");
            }
            else if (x == y || x == z || y == z)
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno");
            }
        }
        else
        {
            Console.WriteLine("Os comprimentos dos lados não formam um triângulo.");
        }
    }
}
