using System;

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
                    Console.WriteLine("Notas cadastradas!");
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
}
