using System;

class Program
{
    static int EncontrarPalavraNoTexto(string texto, string palavra)
    {
        if (string.IsNullOrEmpty(texto) || string.IsNullOrEmpty(palavra))
            return -1;

        for (int i = 0; i <= texto.Length - palavra.Length; i++)
        {
            bool encontrou = true;
            for (int j = 0; j < palavra.Length; j++)
            {
                if (texto[i + j] != palavra[j])
                {
                    encontrou = false;
                    break;
                }
            }
            if (encontrou)
                return i;
        }
        return -1;
    }

    static void Main()
    {
        string texto = "A busca sequencial é um método simples de pesquisa em listas.";
        string palavra = "simples";
        int posicao = EncontrarPalavraNoTexto(texto, palavra);

        if (posicao != -1)
            Console.WriteLine($"Palavra encontrada na posição: {posicao}");
        else
            Console.WriteLine("Palavra não encontrada no texto.");
    }
}