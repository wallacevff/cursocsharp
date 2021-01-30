using System;
using System.Collections.Generic;
using System.Text;

namespace Aula212ExercicioPropostoSobreConjuntos.Entities
{
    class Aluno : IComparable
    {
        public int Codigo { get; set; }

        public Aluno(int codigo)
        {
            Codigo = codigo;
        }

        public override int GetHashCode()
        {
            return Codigo.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Aluno))
            {
                return false;
            }
            return Codigo.Equals((obj as Aluno).Codigo);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Aluno))
            {
                throw new ArgumentException("Wrong Class");
            }

            return Codigo.CompareTo((obj as Aluno).Codigo);
        }
    }
}
