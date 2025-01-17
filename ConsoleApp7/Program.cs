namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final, n1,n2,n3,n4;
            string resultado;

            Console.Write("Digite a primeira nota do aluno : ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a segunda nota do aluno : ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a terceita nota do aluno : ");
            n3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a quarta nota do aluno : ");
            n4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a quinta nota do aluno : ");

            nota_final = (n1 + n2 + n3 + n4) / 4;

            if (nota_final >= 7)
            {
                if(nota_final >= 10)
                {
                    resultado = "Aprovado com louvor";
                }
                else
                {
                    resultado = "Aprovado";
                }
                
            }
            else if (nota_final >= 5)
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "Reprovado";
            }
            Console.WriteLine("Nota do aluno: {0} - Resultado: {1}",nota_final,resultado);
                    

                





       
        }
    }
}
