namespace ATIVIDADE_5
{
    internal class Program
    {
        static int Fat(int x)
        {
            int fatorial=1;
            for (int i = x; i >= 1; i--)
            {
                fatorial *= i; 
            }
            return fatorial;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Insira um número:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fat(n));
        }
    }
}