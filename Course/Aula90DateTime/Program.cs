using System;
using System.Globalization;
namespace Aula90DateTime {
    class Program {
        static void Main(string[] args) {           
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2019, 12, 16);
            DateTime d3 = new DateTime(2019, 12, 16, 20, 45, 3);
            DateTime d4 = new DateTime(2019, 12, 16, 20, 45, 3, 98);
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;
            
            
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);


            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d9 = DateTime.Parse("15/08/2000 13:05:58");
            DateTime d10 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",CultureInfo.InvariantCulture);
            DateTime d11 = DateTime.ParseExact("15/08/2000 08:25:37", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine("\n\n" + d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);

            Console.WriteLine("\n\n" + d10);
            Console.WriteLine(d11);
        }
    }
}
