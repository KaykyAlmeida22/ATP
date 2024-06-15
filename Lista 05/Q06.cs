using System;

class Program
{
    static void Main(string[] args)
    {
        // Definindo o tamanho do vetor para 31 dias de outubro
        int[] temperaturas = new int[31];

        // Lendo as temperaturas de cada dia de outubro
        for (int i = 0; i < 31; i++)
        {
            Console.Write($"Digite a temperatura para o dia {i + 1} de outubro: ");
            if (int.TryParse(Console.ReadLine(), out int temperatura))
            {
                // Verifica se a temperatura está dentro do intervalo permitido
                if (temperatura >= 15 && temperatura <= 40)
                {
                    temperaturas[i] = temperatura;
                }
                else
                {
                    Console.WriteLine("Temperatura fora do intervalo permitido (15°C a 40°C).");
                    i--; // Decrementa i para repetir a leitura deste dia
                }
            }
            else
            {
                Console.WriteLine("Valor inserido não é um número válido.");
                i--; // Decrementa i para repetir a leitura deste dia
            }
        }

        // Calculando a menor e a maior temperatura
        int menorTemperatura = temperaturas[0];
        int maiorTemperatura = temperaturas[0];
        for (int i = 1; i < 31; i++)
        {
            if (temperaturas[i] < menorTemperatura)
            {
                menorTemperatura = temperaturas[i];
            }
            if (temperaturas[i] > maiorTemperatura)
            {
                maiorTemperatura = temperaturas[i];
            }
        }

        // Calculando a temperatura média
        double somaTemperaturas = 0;
        foreach (int temp in temperaturas)
        {
            somaTemperaturas += temp;
        }
        double temperaturaMedia = somaTemperaturas / 31;

        // Contando os dias com temperatura inferior à média
        int diasInferioresMedia = 0;
        foreach (int temp in temperaturas)
        {
            if (temp < temperaturaMedia)
            {
                diasInferioresMedia++;
            }
        }

        // Exibindo os resultados
        Console.WriteLine($"Menor temperatura: {menorTemperatura}°C");
        Console.WriteLine($"Maior temperatura: {maiorTemperatura}°C");
        Console.WriteLine($"Temperatura média: {temperaturaMedia:F2}°C");
        Console.WriteLine($"Número de dias com temperatura inferior à média: {diasInferioresMedia}");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
