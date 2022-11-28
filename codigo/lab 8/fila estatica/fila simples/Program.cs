using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace fila_simples
{
    internal class Program
    {
        static void Inserir(ref int[] vet, ref int tam)
        {
            int num, cont = 0, referencia = 0;
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] != 0)
                {
                    cont++;
                }
            }
            if (cont == tam)
            {
                Console.WriteLine("A fila está cheia.");
                Remover(ref vet);
            }
            else
            {
                cont = 0;
                for (int i = 0; i < vet.Length; i++)
                {
                    if (vet[i] == 0)
                    {
                        referencia = i;
                        break;
                    }
                }
                Console.WriteLine("Insira um número");
                num = int.Parse(Console.ReadLine());
                vet[referencia] = num;
            }
        }
        static void Remover(ref int[] vet)
        {
            int quant, referencia = 0,sobra;
            Console.WriteLine("Quantos números deseja remover?");
            quant = int.Parse(Console.ReadLine());
            if (quant > 5)
            {
                Console.WriteLine("Voce ultrapassou o tamanho do vetor escolha de 1 a 5");
                Console.WriteLine("Quantos números deseja remover?");
                quant = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= (quant - 1); i++)
            {
                vet[i] = 0;
            }
            sobra = 5 - quant;
            if (sobra != 0)
            {
                shiftar(ref vet, ref quant);
                for (int i = 0; i < vet.Length; i++)
                {
                    if (i == 0)
                    {
                        i++;
                    }
                    if (vet[i] == vet[i - 1])
                    {
                        referencia = vet[i - 1];
                        vet[i] = 0;
                    }
                    if (vet[i] == referencia)
                    {
                        vet[i] = 0;
                    }
                }
            }
            
        }
        static void ImprimeFila(ref int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine((i + 1) + ": " + vet[i]);
            }
        }
        static void shiftar(ref int[] vet, ref int quant)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                if (i == 4)
                {
                    break;
                }
                vet[i] = vet[i + 1];
            }
            while (vet[0] == 0)
            {
                for (int i = 0; i < vet.Length; i++)
                {
                    if (i == 4)
                    {
                        break;
                    }
                    vet[i] = vet[i + 1];
                }
            }
        }
        static void Main(string[] args)
        {
            int[] fila = new int[5];
            int tam = fila.Length, num = 0;
            //LeFila(fila, ref tam);
            while (num != 4)
            {
                Console.WriteLine("1: Inserir um número | 2: Remover um número | 3: Mostrar fila | 4: Encerrar");
                num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    Inserir(ref fila, ref tam);
                }
                if (num == 2)
                {
                    Remover(ref fila);
                }
                if (num == 3)
                {
                    ImprimeFila(ref fila);
                }
            }
            Console.WriteLine("Programa encerrado meu jovem!! Até a próxima");
        }
    }
}