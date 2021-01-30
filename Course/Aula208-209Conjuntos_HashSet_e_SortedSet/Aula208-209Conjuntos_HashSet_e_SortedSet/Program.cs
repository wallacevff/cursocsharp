using System;
using System.Collections.Generic;

namespace Aula208_209Conjuntos_HashSet_e_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Computer"));

            foreach (string s in set)
            {
                Console.WriteLine(s);
            }
        }
    }
}
