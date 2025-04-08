using System;

class Program
{
    static int? EncontrarPrimeiroPar(int[] array)
    {
        foreach (int num in array)
        {
            if (num % 2 == 0)
                return num;
        }
        return null;
    }

    static void Main()
    {
        int[] numeros = { 13, 5, 23, 9, 37, 4, 17 };
        int? primeiroPar = EncontrarPrimeiroPar(numeros);

        if (primeiroPar.HasValue)
            Console.WriteLine($"Primeiro número par: {primeiroPar}");
        else
            Console.WriteLine("Nenhum número par encontrado.");
    }
}