using System;

class Aluno
{
    public string Nome { get; set; }
    public int Matricula { get; set; }
}

class Program
{
    static Aluno BuscarAlunoPorMatricula(Aluno[] alunos, int matricula)
    {
        foreach (Aluno aluno in alunos)
        {
            if (aluno.Matricula == matricula)
                return aluno;
        }
        return null;
    }

    static void Main()
    {
        Aluno[] alunos = {
            new Aluno { Nome = "João", Matricula = 1001 },
            new Aluno { Nome = "Maria", Matricula = 1002 },
            new Aluno { Nome = "Pedro", Matricula = 1003 }
        };

        int matriculaBuscada = 1002;
        Aluno alunoEncontrado = BuscarAlunoPorMatricula(alunos, matriculaBuscada);

        if (alunoEncontrado != null)
            Console.WriteLine($"Aluno encontrado: {alunoEncontrado.Nome}");
        else
            Console.WriteLine("Aluno não encontrado.");
    }
}