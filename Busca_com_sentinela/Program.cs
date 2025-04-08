using System;

class Program
{
    static int BuscaComSentinela(int[] array, int valor)
    {
        // Criar novo array com tamanho +1
        int[] novoArray = new int[array.Length + 1];
        Array.Copy(array, novoArray, array.Length);
        novoArray[array.Length] = valor; // Adicionar o valor como sentinela

        int i = 0;
        while (novoArray[i] != valor)
        {
            i++;
        }

        return (i < array.Length) ? i : -1;
    }

    static void Main()
    {
        int[] numeros = { 12, 5, 23, 9, 37, 4, 17 };
        int valor = 37;
        int posicao = BuscaComSentinela(numeros, valor);

        if (posicao != -1)
            Console.WriteLine($"Valor {valor} encontrado na posição: {posicao}");
        else
            Console.WriteLine($"Valor {valor} não encontrado.");
    }
}