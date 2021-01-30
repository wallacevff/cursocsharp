using System;
using System.Collections.Generic;
using System.Text;

namespace Aula211ExercicioResolvidoSobreConjuntos.Entities
{
    public class LogRegister
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public LogRegister(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public LogRegister(string str)
        {
            string[] values = str.Split(" ");
            Name = values[0];
            Date = DateTime.Parse(values[1]);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is LogRegister))
            {
                return false;
            }
            return Name.Equals((obj as LogRegister).Name);
        }
    }
}
