namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("digite um numero");
             num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0}x{1}= {2}", num, i, num * i);
            }
        }
    }
}
