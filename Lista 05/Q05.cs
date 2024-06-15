using System;

class Program
{
    static void Main(string[] args)
    {
        // Chama a função para sortear os números
        int[] numerosSorteados = SortearNumeros();

        Console.WriteLine("Bem-vindo ao jogo de adivinhação de números!");
        Console.WriteLine("Tente adivinhar um dos números sorteados.");

        bool acertou = false;
        while (!acertou)
        {
            Console.Write("Digite um número entre 10 e 50: ");
            int tentativa;
            
            // Lê a tentativa do usuário
            if (int.TryParse(Console.ReadLine(), out tentativa))
            {
                // Verifica se o número está entre 10 e 50
                if (tentativa >= 10 && tentativa <= 50)
                {
                    // Verifica se a tentativa está entre os números sorteados
                    foreach (int numero in numerosSorteados)
                    {
                        if (tentativa == numero)
                        {
                            acertou = true;
                            break;
                        }
                    }

                    if (acertou)
                    {
                        Console.WriteLine("Parabéns! Você acertou um dos números sorteados.");
                    }
                    else
                    {
                        Console.WriteLine("Você errou. Tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Número fora do intervalo permitido. Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
            }
        }

        Console.WriteLine("Fim do programa.");
    }

    // Função para sortear 3 números entre 10 e 50 e retornar em um vetor
    static int[] SortearNumeros()
    {
        Random random = new Random();
        int[] numerosSorteados = new int[3];

        for (int i = 0; i < 3; i++)
        {
            // Gera um número aleatório entre 10 e 50 (inclusive)
            numerosSorteados[i] = random.Next(10, 51);
        }

        return numerosSorteados;
    }
}
