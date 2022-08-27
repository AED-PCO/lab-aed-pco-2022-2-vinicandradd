namespace ATIVIDADE_1
{
    internal class Program
    {
        static int perfeito(int x)
        {
            int soma, primeiro, segundo, quadrado;
            primeiro = x / 100;
            segundo = x % 100;
            soma = primeiro + segundo;
            quadrado = soma * soma;
            return quadrado;
        }
        static void Main(string[] args)
        {
            for(int i = 1000; i <= 9999; i++)
            {
                perfeito(i);
                if (perfeito(i) == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
