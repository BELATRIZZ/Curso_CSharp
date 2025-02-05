namespace Contador
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Escrever("Agora é sua vez de personalizar a contagem!");
            Console.WriteLine("Digite o início: ");
            int ini = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o fim: ");
            int fim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o passo: ");
            int passo = Convert.ToInt32(Console.ReadLine());
            //passo = Math.Abs(passo);
        
            Contador(ini, fim, passo);
        }

        static void Contador(int i, int f, int p)
        {
          
            if (p < 0)
            {
                p = -p;
            }
            
            Escrever($"Contagem de {i} até {f} de {p} em {p}");
            Thread.Sleep(1000);

            if (i < f)
            {
                int cont = i;
                while (cont <= f)
                {
                    Console.Write($"{cont} ");
                    cont += p;
                    Thread.Sleep(500);
                }
                Console.WriteLine("FIM!");
               
            }
            else
            {
                int cont = i;
                while (cont >= f)
                {
                    Console.Write($"{cont} ");
                    cont -= p;
                    Thread.Sleep(500);
                }
            }
        }

        static void Escrever(string texto)
        {
            int tam = texto.Length + 4;
            string linha = new string('=', tam);
            string textoCentralizado = texto.PadLeft(tam - 2).PadRight(tam - 2);

            Console.WriteLine(linha);
            Console.WriteLine(textoCentralizado);
            Console.WriteLine(linha);
        }
    }
}

