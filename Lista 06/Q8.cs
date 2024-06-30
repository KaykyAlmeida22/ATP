using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de veículos que a locadora possui:");
        int quantidadeVeiculos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor que a locadora cobra por cada aluguel:");
        decimal valorAluguel = Convert.ToDecimal(Console.ReadLine());

        // Calculando o faturamento mensal
        decimal faturamentoMensal = (quantidadeVeiculos * valorAluguel) / 3;

        // Calculando o faturamento anual
        decimal faturamentoAnual = faturamentoMensal * 12;

        // Calculando o valor ganho com multas no mês
        decimal valorMultasMensal = (faturamentoMensal / 10) * 0.2m;

        // Calculando o valor gasto com manutenção anual
        decimal valorManutencaoAnual = (quantidadeVeiculos * 0.02m) * 600m;

        // Mostrando os resultados na tela
        Console.WriteLine($"Faturamento mensal: {faturamentoMensal:C}");
        Console.WriteLine($"Faturamento anual: {faturamentoAnual:C}");
        Console.WriteLine($"Valor ganho com multas no mês: {valorMultasMensal:C}");
        Console.WriteLine($"Valor gasto com manutenção anual: {valorManutencaoAnual:C}");

        // Gravando os resultados em um arquivo
        string caminhoArquivo = "resultado.txt";
        using (StreamWriter writer = new StreamWriter(caminhoArquivo))
        {
            writer.WriteLine($"Faturamento mensal: {faturamentoMensal:C}");
            writer.WriteLine($"Faturamento anual: {faturamentoAnual:C}");
            writer.WriteLine($"Valor ganho com multas no mês: {valorMultasMensal:C}");
            writer.WriteLine($"Valor gasto com manutenção anual: {valorManutencaoAnual:C}");
        }

        Console.WriteLine($"Os resultados foram gravados no arquivo: {caminhoArquivo}");
    }
}
