namespace ATIVIDADE_2B
{
    internal class Program
    {
        static int Perfeito(int x)
        {
            int somatorio = 0;
            for (int j = 1; j < x; j++)
            {
                /* este if serve para somar os numeros que sao divisores de i*/
                if (x % j == 0)
                {
                    somatorio += j;
                }
            }
            if (somatorio == x)
            {
                return x;
            }
            else
            {
                return -5;
            }

        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                Perfeito(i);
                if (Perfeito(i) == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}