/*Em um portal de cursos online, cada usuário possui um código único, representado por um número inteiro.
 * Cada instrutor do portal pode ter vários cursos, sendo que um mesmo aluno pode se matricular em quantos
 * cursos quiser. Assim o número total de alunos de um instrutor não é simplesmente a soma dos alunos de todos
 * os cursos que ele possui, pois pode haver alunos repetidos em mais de um curso.
 * O instrutor Alex possui três cursos A, B e C, e deseja saber seu número total de alunos.
 * Seu programa deve ler os alunos dos cursos A, B e C do instrutor Alex, depois mostrar a quantidade total de
 * alunos dele, conforme exemplo. 
 */

using System;
using System.Collections.Generic;
using Aula212ExercicioPropostoSobreConjuntos.Entities;
namespace Aula212ExercicioPropostoSobreConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Curso> cursos = new SortedSet<Curso>() { new Curso("A"), new Curso("B"), new Curso("C") };
            foreach (Curso curso in cursos)
            {
                Console.Write("Entre com o número de alunos do curso " + curso.Nome + ": ");
                int qtdAlunos = int.Parse(Console.ReadLine());
                for (int i = 0; i < qtdAlunos; i++)
                {
                    curso.alunos.Add(new Aluno(int.Parse(Console.ReadLine())));
                }

            }
            HashSet<Aluno> a = new HashSet<Aluno>();
            
            foreach (Curso curso in cursos)
            {
                a.UnionWith(curso.alunos);                
            }
            Console.WriteLine("Total students: " + a.Count);
        }
    }
}
