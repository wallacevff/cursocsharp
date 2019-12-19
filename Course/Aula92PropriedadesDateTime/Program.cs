using System;

namespace Aula92PropriedadesDateTime {
    class Program {
        static void Main(string[] args) {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
                       
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            Console.WriteLine("13) ToLongDateString(): " + d.ToLongDateString());
            Console.WriteLine("14) ToLongTimeString(): " + d.ToLongTimeString());
            Console.WriteLine("15) ToShortDateString(): " + d.ToShortDateString());
            Console.WriteLine("16) ToShortTimeString(): " + d.ToShortTimeString());
            Console.WriteLine("17) ToString(): " + d.ToString());
            Console.WriteLine("18) ToString(): " + d.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine("19) ToString(): " + d.ToString("yyyy-MM-dd HH:mm:ss.ffff"));

            Console.WriteLine("\n-------------------------------------------");
            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(3);
            DateTime d4 = d.AddSeconds(10);
            Console.WriteLine(d + "\n" + d2 + "\n" + d3 + "\n" + d4);
            Console.WriteLine("\n--------------------------------------------");
            DateTime d5 = new DateTime(2000, 10, 15);
            DateTime d6 = new DateTime(2000, 10, 18);
            TimeSpan t = d6.Subtract(d5);
            Console.WriteLine(t);

        }
    }
}
