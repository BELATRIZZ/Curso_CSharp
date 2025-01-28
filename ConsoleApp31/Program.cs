namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123"; // senha correta
            string senhaDigitada;// Senha digitada pelo usuario 
            int tentativas = 0; // Contador de tentativas 

            
            // lop para solicitar a senha ao usuario 
            do
            {
                Console.Clear();
                Console.Write("Digite a senha: ");
                senhaDigitada = Console.ReadLine();
                tentativas++;

                if (senhaDigitada != senha && tentativas < 3)
                {
                    Console.WriteLine("Senha incorreta!");
                    Console.WriteLine("Você tem ainda " + (3 - tentativas) + " tentativa(s)");
                    Console.ReadKey();
                }
                else if (senhaDigitada != senha )
                {
                    Console.WriteLine("A senha incorreta! Seu acesso esta bloqueado!");
                    return;
                }
                else
                {
                    break;
                }
            }while (senhaDigitada != senha);

            Console.Clear() ;
            Console.WriteLine("Senha correta! - Tentativas: " + tentativas);



        }
    }
}
