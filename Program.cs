using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        int opcao = 0;
        string nomeDoAluno = "";
        double[] notas = new double[3];

        while (opcao != 4)
        {
            Console.WriteLine("CALCULADORA DE NOTAS");
            Console.WriteLine();
            Console.WriteLine("1. Cadastrar aluno");
            Console.WriteLine("2. Lançar notas");
            Console.WriteLine("3. Calcular média");
            Console.WriteLine("4. Sair");
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    nomeDoAluno = CadastrarAluno();
                    Console.WriteLine($"Aluno cadastrado: {nomeDoAluno}" );
                    break;
                case 2:
                    LancarNotas(notas);
                    Console.WriteLine("Notas preparadas para lançar");
                    break;
                case 3:
                    Console.WriteLine("Calcula média");
                    break;
                case 4:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine();
        }
    }
    static string CadastrarAluno()
    {
        Console.WriteLine("Digite o nome do aluno: ");
        string NomeDoAluno = Console.ReadLine();

        return NomeDoAluno;
    }
    static void LancarNotas(double[] notas) 
    {
        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine($"Digite a nota {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }


    }
}
