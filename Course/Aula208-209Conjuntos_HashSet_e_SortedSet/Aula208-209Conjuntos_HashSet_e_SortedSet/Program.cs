using System;
using System.Collections.Generic;

namespace Aula208_209Conjuntos_HashSet_e_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            

            //Union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);

            //Intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);

            //Differs
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);

            PrintCollection(a, b, c, d, e);
        }

        static void PrintCollection<T>(params IEnumerable<T>[] collection)
        {
            foreach (IEnumerable<T> ob in collection)
            {
                foreach (T obj in ob)
                {
                    Console.Write(obj + " ");
                }
                Console.WriteLine();
            }
        }

        
    }
}
