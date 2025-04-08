using System;

class Program
{
    static int? EncontrarPrimeiroMultiplo(int[] array, int x)
    {
        foreach (int num in array)
        {
            if (num % x == 0)
                return num;
        }
        return null;
    }

    static void Main()
    {
        int[] numeros = { 12, 5, 23, 9, 37, 4, 17 };
        int x = 3;
        int? multiplo = EncontrarPrimeiroMultiplo(numeros, x);

        if (multiplo.HasValue)
            Console.WriteLine($"Primeiro múltiplo de {x}: {multiplo}");
        else
            Console.WriteLine($"Nenhum múltiplo de {x} encontrado.");
    }
}