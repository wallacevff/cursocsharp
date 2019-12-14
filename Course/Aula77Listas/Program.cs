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

            list.Insert(2, "Xulepa");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("\nList count: " + list.Count);

            string s1 = list.Find(Test);
            Console.WriteLine("First 'A': " + s1);

            static bool Test (string s) {
                return s[0] == 'A';

            }
        }


    }
}
