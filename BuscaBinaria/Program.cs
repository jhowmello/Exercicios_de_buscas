using System;

class Program
{
    static void Main()
    {
        int[] vetor = { 10, 20, 30, 40, 50, 60, 70};
        int valor = 40;
        int posicao = BuscaBinaria(vetor, valor);
        if (posicao == -1)
            Console.WriteLine("Valor não encontrado");
        else
            Console.WriteLine("Valor encontrado na posição {0}", posicao);
    }
    static int BuscaBinaria(int[] vetor, int valor)
    {
        int inicio = 0;
        int fim = vetor.Length - 1;
        while (inicio <= fim)
        {
            int meio = (inicio + fim) / 2;
            if (vetor[meio] == valor)
                return meio;
            else if (vetor[meio] < valor)
                inicio = meio + 1;
            else
                fim = meio - 1;
        }
        return -1;
    }
}