using System;

class Program
{
    static void Main()
    {
        // Array ordenado de exemplo
        int[] arrayOrdenado = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };

        Console.WriteLine("Digite o número que deseja verificar:");
        int numero = Convert.ToInt32(Console.ReadLine());

        bool existe = VerificarNumeroNoArray(arrayOrdenado, numero);

        if (existe)
        {
            Console.WriteLine($"O número {numero} existe no array.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não existe no array.");
        }
    }

    static bool VerificarNumeroNoArray(int[] array, int numero)
    {
        int esquerda = 0;
        int direita = array.Length - 1;

        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

            if (array[meio] == numero)
            {
                return true;
            }

            if (array[meio] < numero)
            {
                esquerda = meio + 1;
            }
            else
            {
                direita = meio - 1;
            }
        }

        return false;
    }
}