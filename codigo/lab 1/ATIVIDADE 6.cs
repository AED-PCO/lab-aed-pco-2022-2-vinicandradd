namespace ATIVIDADE_6
{
    internal class Program
    {
        static int Potencia(ref int x)
        {
            int y;
            Console.WriteLine("Digite o expoente");
            y = int.Parse(Console.ReadLine());
            int resultado=1;
            for(int i = 1; i <= y; i++)
            {
                resultado *= x;
            }
            return resultado;
        }
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Digite a base");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine(Potencia(ref a));
        }
    }
}