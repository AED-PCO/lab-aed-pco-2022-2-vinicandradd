namespace lista_estática
{
    internal class Program
    {
        static void InserirItem(ref int[] vet, ref int tam)
        {
            int num,cont = 0;
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] == 0)
                {
                    Console.WriteLine("Insira o item " + (i + 1));
                    num = int.Parse(Console.ReadLine());
                    vet[i] = num;
                    cont++;
                    break;
                }
            }
            if (cont == 0)
            {
                Console.WriteLine("A lista está cheia");
                RemoverItem(ref vet, ref tam);
            }
            tam = vet.Length;
        }
        static void ImprimeLista(ref int[] vet, ref int tam)
        {
            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine((i + 1) + ": " + vet[i]);
            }
        }
        static void RemoverItem(ref int[] vet, ref int tam)
        {
            int remocao,referencia,item;
            Console.WriteLine("Esta é sua lista.");
            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine((i + 1) + ": " + vet[i]);
            }
            Console.WriteLine("Qual item deseja remover?");
            remocao = int.Parse(Console.ReadLine());
            item = remocao;
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
            for (int i = item; i < vet.Length; i++)
            {
                if (vet[i] == vet[i - 1])
                {
                    referencia = vet[i-1];
                    vet[i] = 0;
                }
            }
            tam = vet.Length;
        }
        static void Main(string[] args)
        {
            int[] lista = new int[5] {10,20,30,40,50};
            int tam = lista.Length,decisao = 0;
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