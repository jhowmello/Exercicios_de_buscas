class Program
{
    static int BuscaSequencial(int[] vetor, int valor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == valor)
            {
                return i;
            }
        }
        return -1;
    }
    static void Main(string[] args)
    {
        int[] vetor = { 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
        int valor = 13;
        int posicao = BuscaSequencial(vetor, valor);
       
        Console.WriteLine("Valor {0} encontrado na posição {1}", valor, posicao);
    }
}