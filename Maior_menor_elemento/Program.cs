using System;

class Program
{
    static void EncontrarMaiorEMenor(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine("Array vazio ou nulo.");
            return;
        }

        int maior = array[0];
        int menor = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maior)
                maior = array[i];
            if (array[i] < menor)
                menor = array[i];
        }

        Console.WriteLine($"Maior elemento: {maior}");
        Console.WriteLine($"Menor elemento: {menor}");
    }

    static void Main()
    {
        int[] numeros = { 12, 5, 23, 9, 37, 4, 17 };
        EncontrarMaiorEMenor(numeros);
    }
}