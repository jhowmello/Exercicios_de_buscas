using System;

class program
{

    static void Main()
    {
        string[] nomes = new string[10];
        int i;
        string nome;
        bool achou = false;
        for (i = 0; i < 10; i++)
        {
            Console.Write("Digite o nome: ");
            nomes[i] = Console.ReadLine();
        }
        Console.Write("Digite o nome a ser pesquisado: ");
        nome = Console.ReadLine();
        for (i = 0; i < 10; i++)
        {
            if (nomes[i] == nome)
            {
                achou = true;
                break;
            }
        }
        if (achou)
            Console.WriteLine("Nome encontrado na posição {0}", i);
        else
            Console.WriteLine("Nome não encontrado");
    }
}