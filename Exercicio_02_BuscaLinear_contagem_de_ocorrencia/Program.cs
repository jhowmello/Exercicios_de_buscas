using System;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 2, 2 };
        Console.Write("Digite o valor a ser buscado: ");
        int valor = int.Parse(Console.ReadLine());
        int contador = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == valor)
            {
                contador++;
            }
        }
        Console.WriteLine($"O valor {valor} foi encontrado {contador} vezes no vetor.");
    }
}