namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, res, opcao = 0;

            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());



            while (opcao != 5)
            {
                Console.WriteLine("Escolha uma opção :");
                Console.WriteLine("1- Somar");
                Console.WriteLine("2- Subtrair");
                Console.WriteLine("3- Multiplicar");
                Console.WriteLine("4- Novos Números");
                Console.WriteLine("5- Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {

                    case 1:
                        res = n1 + n2;
                        Console.WriteLine(" A soma de {0} + {1} é igual a {2}.", n1, n2, res);
                        break;

                    case 2:
                        res = n1 - n2;
                        Console.WriteLine("A subtração de {0} - {1} é igual a {2}. ", n1,n2, res);
                        break;

                    case 3:
                        res = n1 * n2;
                        Console.WriteLine("A multiplicação de {0} x {1} é igual a {2}.", n1, n2, res);
                        break;

                    case 4:
                        Console.Write("Digite o primeiro número: ");
                        n1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Digite o segundo número: ");
                        n2 = Convert.ToInt32(Console.ReadLine()) ;
                        break;

                    case 5:
                        Console.WriteLine(" Saindo ... ");
                        break;

                    default:
                        Console.WriteLine(" Opção inválida!");
                        break ;


                }
            }

        }
    }
}
