using System;
using System.Collections;

namespace lista_simples
{
    internal class Program
    {
        static void LeLista(ref int[] vet, ref int tam)
        {
            int num;
            Console.WriteLine("Quando acabar insira -1");
            for (int i = 0; i > -1; i++)
            {
                Console.WriteLine("Insira o item " + (i + 1));
                num = int.Parse(Console.ReadLine());
                if (num == -1)
                {
                    break;
                }
                Array.Resize(ref vet, vet.Length + 1);
                vet[i] = num;
            }
            tam = vet.Length;
        }
        static void ImprimeLista(ref int[] vet, ref int tam)
        {
            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine((i+1) + ": " + vet[i]);
            }
        }
        static void InserirItem(ref int[] vet, ref int tam)
        {
            int num;
            Console.WriteLine("Insira o item");
            num = int.Parse(Console.ReadLine());
            Array.Resize(ref vet, vet.Length + 1);
            tam = vet.Length;
            vet[tam - 1] = num;

        }
        static void RemoverItem(ref int[] vet, ref int tam)
        {
            int remocao;
            Console.WriteLine("Esta é sua lista.");
            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine((i + 1) + ": " + vet[i]);
            }
            Console.WriteLine("Qual item deseja remover?");
            remocao = int.Parse(Console.ReadLine());
            remocao -= 1;
            for (int i = 0; i < vet.Length; i++)
            {
                if (i == remocao)
                {
                    remocao = vet[i];
                    for (int j = i; i <= tam; j++)
                    {
                        if (j == (tam - 1))
                        {
                            break;
                        }
                        vet[j] = vet[j + 1];
                    }
                }
                
            }
            Array.Resize(ref vet, vet.Length - 1);
            tam = vet.Length;
        }
        static void Main(string[] args)
        {
            int[] lista = new int[0];
            int tam = 0, decisao = 0;
            LeLista(ref lista, ref tam);
            while (decisao != 4)
            {
                Console.WriteLine("1: Imprimir Lista | 2: Inserir item | 3: Remover item | 4: Encerrar");
                decisao = int.Parse(Console.ReadLine());
                if (decisao == 1)
                {
                    ImprimeLista(ref lista, ref tam);
                }
                if (decisao == 2)
                {
                    InserirItem(ref lista, ref tam);
                }
                if (decisao == 3)
                {
                    RemoverItem(ref lista, ref tam);
                }
            }
            Console.WriteLine("Programa encerrado. Até a próxima!!");
        }
    }
}