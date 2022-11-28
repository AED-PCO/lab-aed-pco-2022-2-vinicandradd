namespace pilha_simples
{
    internal class Program
    {
        static void ImprimePilha(ref int[] vet, ref int quant)
        {
            for (int i = 0; i <vet.Length; i++)
            {
                Console.WriteLine((i) + ": " + vet[i]);
            }
        }
        static void InserirPilha(ref int[] vet, ref int quant)
        {
            int num,referencia;
            if (quant == 0)
            {
                Console.WriteLine("Insira um número:");
                num = int.Parse(Console.ReadLine());
                vet[0] = num;
                quant++;
            }
            else
            {
                shift(ref vet);
            }
        }
        static void shift(ref int[] vet)
        {
            int referencia;
            for (int i = 0; i < vet.Length-1; i++)
            {
                vet[i+1] = vet[i];
            }
            referencia = vet.Length - 1;
        }
        static void Main(string[] args)
        {
            int[] pilha = new int[5];
            int quant = 0, decisao = 0;
            while (decisao != 4)
            {
                Console.WriteLine("1: Imprime pilha | 2: Inserir item | 3: Remover item | 4: Encerrar");
                decisao = int.Parse(Console.ReadLine());
                if (decisao == 1)
                {
                    ImprimePilha(ref pilha, ref quant);
                }
                if (decisao == 2)
                {
                    InserirPilha(ref pilha, ref quant);
                }
                //if (decisao == 3)
                //{
                //    RemoverPilha(ref pilha, ref tam);
                //}
            }
        }
    }
}