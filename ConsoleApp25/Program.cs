namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string genero;

            Console.Write("Digite o gênero:");  
            genero = Console.ReadLine().ToUpper();

            while(genero != "F" && genero != "M")
            {
                Console.Write("Digite o gênero:");
                genero = Console.ReadLine();
            }
            Console.WriteLine("ok ");

        }
    }
}
