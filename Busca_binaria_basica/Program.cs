using System;

class BuscaBinaria
{
    public static int Buscar(int[] array, int valorProcurado)
    {
        int esquerda = 0;
        int direita = array.Length - 1;

        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

            if (array[meio] == valorProcurado)
                return meio;

            if (array[meio] < valorProcurado)
                esquerda = meio + 1;
            else
                direita = meio - 1;
        }

        return -1;
    }

    static void Main(string[] args)
    {
        int[] arrayOrdenado = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
        int valor = 23;

        int resultado = Buscar(arrayOrdenado, valor);

        if (resultado == -1)
            Console.WriteLine("Elemento não encontrado no array");
        else
            Console.WriteLine($"Elemento encontrado no índice: {resultado}");
    }
}