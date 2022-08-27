namespace ATIVIDADE_2
{
    internal class Program
    {
        static int Primo(int x)
        {
            int primo, cont = 0;
            for (int i = 1; i <= x; i++)
            {
                primo = x % i;
                if (primo == 0)
                {
                    cont++;
                }
            }
            if (cont == 2)
            {
                return 2;
            }
            else
            {
                return 10;
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite um número");
            n = int.Parse(Console.ReadLine());
            Primo(n);
            if (Primo(n) == 2)
            {
                Console.WriteLine("O número é Primo");
            }
            else
            {
                Console.WriteLine("O número não é primo");
            }
        }
    }
}
