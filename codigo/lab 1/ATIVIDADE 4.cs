using System;

namespace ATIVIDADE_4
{
    internal class Program
    {
        static void LeMatriz(int[,] Mat)
        {
            for (int i = 0; i < Mat.GetLength(0); i++)
            {
                for (int j = 0; j < Mat.GetLength(1); j++)
                {
                    Console.WriteLine("Posição: " + i + "," + j);
                    Mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static int SomaMatriz(int[,] Mat)
        {
            int soma = 0;
            for (int i = 0; i < Mat.GetLength(0); i++)
            {
                for (int j = 0; j < Mat.GetLength(1); j++)
                {
                    soma += Mat[i, j];
                }
            }
            return soma;
        }


        static void SomaLinha(int[,] Mat)
        {
            int soma = 0;
            for (int i = 0; i < Mat.GetLength(0); i++)
            {
                soma = 0;
                for (int j = 0; j < Mat.GetLength(1); j++)
                {
                    soma += Mat[i, j];
                }
                Console.WriteLine("A soma da linha " + (i + 1) + " é igual a: " + soma);
            }
        }
        static void SomaColuna(int[,] Mat)
        {
            int soma = 0;
            for (int j = 0; j < Mat.GetLength(1); j++)
            {
                soma = 0;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    soma += Mat[i, j];
                }
                Console.WriteLine("A soma da coluna " + (j + 1) + " é igual a: " + soma);
            }
        }
        static void Main(string[] args)
        {
            int[,] A = new int[5, 3];
            Console.WriteLine("Insira os valores da matriz");
            LeMatriz(A);
            SomaLinha(A);
            SomaColuna(A);
            Console.WriteLine("A soma da matriz inteira é igual a: "+SomaMatriz(A));
        }
    }
}