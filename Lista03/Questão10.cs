using System;

class Program
{
    static void Main(string[] args)
    {
        double precoCompra, precoVenda;
        int mercadoriasLucroMenor10 = 0, mercadoriasLucroEntre10e20 = 0, mercadoriasLucroMaior20 = 0;
        double totalCompra = 0, totalVenda = 0, lucroTotal = 0;

        Console.WriteLine("Informe o preço de compra da mercadoria (digite 0 para encerrar):");
        precoCompra = double.Parse(Console.ReadLine());

        while (precoCompra != 0)
        {
            Console.WriteLine("Informe o preço de venda da mercadoria:");
            precoVenda = double.Parse(Console.ReadLine());

            totalCompra += precoCompra;
            totalVenda += precoVenda;

            double lucro = ((precoVenda - precoCompra) / precoCompra) * 100;

            if (lucro < 10)
                mercadoriasLucroMenor10++;
            else if (lucro >= 10 && lucro <= 20)
                mercadoriasLucroEntre10e20++;
            else
                mercadoriasLucroMaior20++;

            Console.WriteLine("Informe o preço de compra da próxima mercadoria (digite 0 para encerrar):");
            precoCompra = double.Parse(Console.ReadLine());
        }

        lucroTotal = totalVenda - totalCompra;

        Console.WriteLine("\nResumo do Levantamento:");
        Console.WriteLine("Mercadorias com lucro < 10%: " + mercadoriasLucroMenor10);
        Console.WriteLine("Mercadorias com lucro entre 10% e 20%: " + mercadoriasLucroEntre10e20);
        Console.WriteLine("Mercadorias com lucro > 20%: " + mercadoriasLucroMaior20);
        Console.WriteLine("Valor total de compra: " + totalCompra);
        Console.WriteLine("Valor total de venda: " + totalVenda);
        Console.WriteLine("Lucro total: " + lucroTotal);
    }
}
