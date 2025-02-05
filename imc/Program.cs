namespace imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(" Digite seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua altura :");
            double altura= Convert.ToDouble(Console.ReadLine());
           
            Double imc = peso / (altura * altura);
           
            
            
            Console.WriteLine($" Seu imc é {imc:F2}  ");


        }
    }
}
