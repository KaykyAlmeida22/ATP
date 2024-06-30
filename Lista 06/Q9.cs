using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        List<Aluno> alunos = new List<Aluno>();
        string caminhoArquivo = "alunos.txt";

        // Menu principal
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Inserir dados de alunos");
            Console.WriteLine("2 - Ler dados de alunos do arquivo");
            Console.WriteLine("3 - Sair");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    InserirDadosAlunos(alunos);
                    SalvarDadosEmArquivo(alunos, caminhoArquivo);
                    break;
                case "2":
                    LerDadosDeArquivo(alunos, caminhoArquivo);
                    break;
                case "3":
                    Console.WriteLine("Saindo do programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            Console.WriteLine(); // Linha em branco para separar visualmente os menus
        }
    }

    // Função para inserir dados de alunos
    static void InserirDadosAlunos(List<Aluno> alunos)
    {
        while (true)
        {
            Console.WriteLine("Digite a matrícula do aluno (ou 'sair' para encerrar):");
            string matricula = Console.ReadLine();

            if (matricula.ToLower() == "sair")
                break;

            Console.WriteLine("Digite o telefone do aluno:");
            string telefone = Console.ReadLine();

            alunos.Add(new Aluno(matricula, telefone));

            Console.WriteLine("Aluno cadastrado com sucesso!");
        }
    }

    // Função para salvar dados em arquivo
    static void SalvarDadosEmArquivo(List<Aluno> alunos, string caminhoArquivo)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(caminhoArquivo))
            {
                foreach (Aluno aluno in alunos)
                {
                    writer.WriteLine($"{aluno.Matricula},{aluno.Telefone}");
                }
            }

            Console.WriteLine($"Dados dos alunos foram salvos no arquivo: {caminhoArquivo}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao salvar dados no arquivo: {ex.Message}");
        }
    }

    // Função para ler dados de arquivo
    static void LerDadosDeArquivo(List<Aluno> alunos, string caminhoArquivo)
    {
        alunos.Clear(); // Limpa a lista atual de alunos

        try
        {
            using (StreamReader reader = new StreamReader(caminhoArquivo))
            {
                string linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    string[] dados = linha.Split(',');

                    if (dados.Length == 2)
                    {
                        string matricula = dados[0];
                        string telefone = dados[1];
                        alunos.Add(new Aluno(matricula, telefone));
                    }
                }
            }

            Console.WriteLine($"Dados dos alunos foram carregados do arquivo: {caminhoArquivo}");

            // Exibir os alunos carregados
            Console.WriteLine("Alunos carregados:");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Matrícula: {aluno.Matricula}, Telefone: {aluno.Telefone}");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Arquivo {caminhoArquivo} não encontrado.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao ler dados do arquivo: {ex.Message}");
        }
    }
}

// Classe Aluno para representar os dados de cada aluno
class Aluno
{
    public string Matricula { get; set; }
    public string Telefone { get; set; }

    public Aluno(string matricula, string telefone)
    {
        Matricula = matricula;
        Telefone = telefone;
    }
}
