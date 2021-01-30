using System;
using System.Collections.Generic;
using System.Text;

namespace Aula212ExercicioPropostoSobreConjuntos.Entities
{
    class Curso : IComparable
    {
        public string Nome { get; set; }
        public HashSet<Aluno> alunos = new HashSet<Aluno>();
        public Curso(string nome)
        {
            Nome = nome;            
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Curso))
            {
                return false;
            }
            return Nome.Equals((obj as Curso).Nome);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Curso))
            {
                throw new ArgumentException("Wrong Class");
            }
            return Nome.CompareTo((obj as Curso).Nome);
        }
    }
}
