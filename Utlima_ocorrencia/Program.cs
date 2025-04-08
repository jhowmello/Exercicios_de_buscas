using System;

class Program
{
    static int? EncontrarUltimaOcorrencia(int[] array, int valor)
    {
        int? ultimaPosicao = null;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == valor)
                ultimaPosicao = i;
        }

        return ultimaPosicao;
    }

    static void Main()
    {
        int[] numeros = { 12, 5, 23, 5, 37, 4, 5 };
        int valor = 5;
        int? posicao = EncontrarUltimaOcorrencia(numeros, valor);

        if (posicao.HasValue)
            Console.WriteLine($"Última ocorrência de {valor} na posição: {posicao}");
        else
            Console.WriteLine($"Valor {valor} não encontrado.");
    }
}