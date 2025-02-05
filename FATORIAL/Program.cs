namespace FATORIAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool mostrar = false;   

            Console.WriteLine("Digite um número : ");
            int num= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Você quer ver os calculos ? (s/n)  : ");
            string resp= Console.ReadLine();

            

            if (res
           
        }
        static int fatorial(int n, bool show = false)
        {
            int f = 1;
            for (int i = n; i > 0; i--)
            {
                if (show)
                    Console.Write(i + " ");
                if (i > 1)
                {
                    Console.Write("x  ");

                }
                else
                {
                    Console.Write("= ");

                }
                f *= i;
                {

                }
            }
            return f;
                    

                    
            
        }


        
       
    }
}

