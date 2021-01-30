using System.Collections.Generic;
using Aula211ExercicioResolvidoSobreConjuntos.Entities;

namespace System
{
    public static class HashSetExtensions
    {
        public static void PrintItens<T>(this HashSet<T> obj) where T : LogRegister
        {
            foreach (T o in obj)
            {
                Console.WriteLine("Name: " + o.Name + " Date: " + o.Date);
            }
        }
    }
}
