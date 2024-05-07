using System;

class Program
{
    static void Main(string[] args)
    {
        int candidato1 = 0, candidato2 = 0, candidato3 = 0, candidato4 = 0, votosNulos = 0, votosBrancos = 0;
        
        Console.WriteLine("Informe o código do candidato (ou 0 para encerrar):");
        int voto = int.Parse(Console.ReadLine());

        while (voto != 0)
        {
            switch (voto)
            {
                case 1:
                    candidato1++;
                    break;
                case 2:
                    candidato2++;
                    break;
                case 3:
                    candidato3++;
                    break;
                case 4:
                    candidato4++;
                    break;
                case 5:
                    votosNulos++;
                    break;
                case 6:
                    votosBrancos++;
                    break;
                default:
                    Console.WriteLine("Código inválido! Voto não contabilizado.");
                    break;
            }

            Console.WriteLine("Informe o código do próximo voto (ou 0 para encerrar):");
            voto = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nResultado da Eleição:");
        Console.WriteLine("Total de votos para o Candidato 1: " + candidato1);
        Console.WriteLine("Total de votos para o Candidato 2: " + candidato2);
        Console.WriteLine("Total de votos para o Candidato 3: " + candidato3);
        Console.WriteLine("Total de votos para o Candidato 4: " + candidato4);
        Console.WriteLine("Total de votos nulos: " + votosNulos);
        Console.WriteLine("Total de votos em branco: " + votosBrancos);
    }
}
