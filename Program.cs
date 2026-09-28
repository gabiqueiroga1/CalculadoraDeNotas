using System;
class Program
{
    static void Main()
    {
        int opcao = 0;

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
                    Console.WriteLine("Cadastra aluno");
                    break;
                case 2:
                    Console.WriteLine("Lança notas");
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
}
