using System;

class Program
{
    const double MEDIA_APROVACAO = 7.0;
    const double MEDIA_RECUPERACAO = 5.0;
    static void Main()
    {
        int opcao = 0;
        string nomeDoAluno = "";
        double[] notas = new double[3];

        bool alunoCadastrado = false;

        while (opcao != 4)
        {
            Console.WriteLine("CALCULADORA DE NOTAS");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Cadastrar aluno");
            Console.WriteLine("2. Lançar notas");
            Console.WriteLine("3. Calcular média");
            Console.WriteLine("4. Sair");
            Console.WriteLine("==============================");

            Console.WriteLine("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Entrada inválida. Digite um número de 1 a 4.");
                Console.WriteLine();
                Console.Write("Pressione ENTER para continuar...");
                Console.ReadLine();
                continue;
            }

            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    nomeDoAluno = CadastrarAluno();
                    alunoCadastrado = true;

                    Console.WriteLine($"Aluno cadastrado: {nomeDoAluno}" );
                    break;

                case 2:
                    if (!alunoCadastrado) 
                    {
                        Console.WriteLine("ERRO: cadastre um aluno antes de lançar as notas.");
                        break;
                    }

                    LancarNotas(notas);
                    Console.WriteLine();
                    Console.WriteLine("Notas cadastradas!");
                    break;

                case 3:
                    if (!alunoCadastrado)
                    {
                        Console.WriteLine("ERRO: cadastre um aluno antes de calcular a média.");
                        break;
                    }

                    double media = CalcularMedia(notas);

                    Console.WriteLine("-------- RESULTADO --------");
                    Console.WriteLine($"Aluno: {nomeDoAluno}");
                    Console.WriteLine($"Média: {media:F2}");

                    ExibirResultado(media);

                    Console.WriteLine("---------------------------");
                    break;

                case 4:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Escolha uma opção de 1 a 4.");
                    break;
            }
            
            if (opcao != 4)
            {
                Console.WriteLine();
                Console.Write("Pressione ENTER para voltar ao menu...");
                Console.ReadLine();
            }
        }
    }
    static string CadastrarAluno()
    {
        Console.WriteLine("Digite o nome do aluno: ");
        string nomeDoAluno = Console.ReadLine();

        return nomeDoAluno;
    }
    static void LancarNotas(double[] notas) 
    {
        for (int i = 0; i < notas.Length; i++)
        {
            bool notaValida = false;

            while (!notaValida)
            {
                Console.WriteLine($"Digite a nota {i + 1}: ");

                if (double.TryParse(Console.ReadLine(), out double nota)) 
                {
                    if (nota >= 0 && nota <= 10)
                    {
                        notas[i] = nota;
                        notaValida = true;
                    }
                    else 
                    {
                        Console.WriteLine("Nota Inválida. Digite uma nota entre 0 e 10.");
                    
                    }
                
                }
                else 
                {
                    Console.WriteLine("Entrada inválida. Digite um número válido.");
                }

            }
        }
    }
    static double CalcularMedia(double[] notas) 
    {
        double soma = 0;

        for(int i = 0; i < notas.Length; i++)
        {
            soma += notas[i];
        }

        double media = soma / notas.Length;

        return media;

    }
    static void ExibirResultado(double media) 
    {
        if (media >= MEDIA_APROVACAO)
        {
            Console.WriteLine("Situação: Aprovado!");
        
        }
        else if (media >= MEDIA_RECUPERACAO)
        {
            Console.WriteLine("Situação: Em recuperação.");
        }
        else
        {
            Console.WriteLine("Situação: Reprovado.");
        }
    }
}
