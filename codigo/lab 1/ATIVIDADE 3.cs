namespace ATIVIDADE_3
{
    internal class Program
    {
        static int Comuns(int x, int y)
        {
            if (x - y == 0 || y - x == 0)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
        static void Main(string[] args)
        {
            int[] A = new int[5] { 5, 10, 15, 20, 25 };
            int[] B = new int[5] { 7, 12, 15, 18, 25 };
            int[] C = new int[5];
            int[] D = new int[5];
            for (int i = 0; i < A.Length; i++)
            {
                if (Comuns(A[i], B[i]) == 2)
                {
                    C[i] = A[i];
                }
                else
                {
                    D[i] = A[i];
                }
            }
            Console.WriteLine("Os numeros comuns entre A e B são:");
            for (int i = 0; i < A.Length; i++)
            {
                if (C[i] != 0)
                {
                    Console.Write(C[i] + "\t");
                }
            }
            Console.WriteLine("\nOs numeros contidos somente em A são:");
            for (int i = 0; i < A.Length; i++)
            {
                if (D[i] != 0)
                {
                    Console.Write(D[i] + "\t");
                }
            }
            


        }
    }
}