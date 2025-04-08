using System;

class Program
{
    static void Main()
    {
        int[] vetor = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Digite o número que deseja buscar entre 1 e 10: ");
        int numero = int.Parse(Console.ReadLine());

        int posicao = BuscaLinear(vetor, numero);

        if (posicao == -1)
            Console.WriteLine("Número não encontrado.");
        else
            Console.WriteLine("Número encontrado na posição: " + posicao);
    }

    static int BuscaLinear(int[] vetor, int numero)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == numero)
                return i;
        }

        return -1;
    }
}