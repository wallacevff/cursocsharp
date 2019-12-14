using System;
using System.Collections.Generic;

namespace Aula77Listas {
    class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();
            list.Add("Wallace");
            list.Add("Andressa");
            list.Add("Ricardo");
            list.Add("Dayse");
            list.Add("Armando");

            list.Insert(2, "Xulepa");
            foreach (string obj in list) {
                Console.WriteLine("[" + list.FindIndex(x => x == obj) + "] => " + obj);
            }

            Console.WriteLine("\nList count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position  'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position  'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 7);
            Console.WriteLine("\n________________________________________");

            foreach(string obj in list2) {
                Console.WriteLine("[" + list.FindIndex(x => x == obj) + "] => " + obj);
            }

            list.Remove("Xulepa");
            Console.WriteLine( "\n________________________________________");
            foreach (string obj in list) {
                Console.WriteLine("[" + list.FindIndex(x => x == obj) + "] => " + obj);
            }

            list.RemoveAll(x => x[0] == 'A');
            Console.WriteLine("\n________________________________________");
            foreach (string obj in list) {
                Console.WriteLine("[" + list.FindIndex(x => x == obj) + "] => " + obj);
            }

            list.RemoveAt(0);
            Console.WriteLine("\n________________________________________");
            foreach (string obj in list) {
                Console.WriteLine("[" + list.FindIndex(x => x == obj) + "] => " + obj);
            }

            list.Add("Wallace");
            list.Add("Andressa");
            list.Add("Ricardo");
            list.Add("Dayse");
            list.Add("Armando");

            list.RemoveRange(0,6);
            Console.WriteLine("\n________________________________________");
            foreach (string obj in list) {
                Console.WriteLine("[" + list.FindIndex(x => x == obj) + "] => " + obj);
            }
        }
        
    }
}
