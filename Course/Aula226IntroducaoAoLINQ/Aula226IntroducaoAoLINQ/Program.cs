using System;
using System.Linq;
using System.Collections.Generic;

namespace Aula226IntroducaoAoLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query expression
            IEnumerable<int> result = numbers.Where(n => n % 2 == 0).Select(n => n * 10);
            
            //Execute the query            
            foreach (int n in result)
            {
                Console.WriteLine(n);
            }

        }
    }
}
