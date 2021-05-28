using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "****/ Media dos Alunos /****";

            Console.WriteLine("#################################");
            Console.WriteLine("# Histórico de notas dos alunos #");
            Console.WriteLine("#################################");

            Console.WriteLine("Quantos alunos você fará a média?");
            int nAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Aluno[] alunos = new Aluno[nAlunos];

            for(int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Aluno:" + (i + 1) + "Nome..:");
                string nome = Console.ReadLine();

                int provas = 2;

                alunos[i] = new Aluno(nome, provas);

                Console.WriteLine("Adicione as notas do aluno" + nome);
                alunos[i].InserirNotas();
            }

            Console.Clear();

            double mediaGeral = 0;

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine("Aluno: " + aluno.Nome);
                Console.WriteLine("Media: " + aluno.Media);
                Console.WriteLine();

                mediaGeral += aluno.Media;



                if (aluno.Media >= 70)
                {
                    Console.WriteLine("O aluno está aprovado, Parabéns.");
                }
                else
                {
                    Console.WriteLine("O aluno está reprovado, Favor fazer exame.");
                }
                Console.ReadKey();
            }

            double resultadoFinal = mediaGeral / alunos.Length;

            Console.WriteLine(" Média geral dos alunos: " +  resultadoFinal);

            Console.ReadKey();
        }
    }   
}
