using System;

namespace Aula93PropriedadesEOperacoesComTimeSpan {
    class Program {
        static void Main(string[] args) {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);

            //----Operações------
            TimeSpan t5 = new TimeSpan(1, 30, 10);
            TimeSpan t6 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t5.Add(t6);
            TimeSpan diff = t5.Subtract(t6);
            TimeSpan mult = t6.Multiply(2.0);
            TimeSpan div = t6.Divide(2.0);

            //--------//---------


            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);

            Console.WriteLine("\n---------Funções-----------");
            Console.WriteLine("Days: " + t4.Days);
            Console.WriteLine("Hours: " + t4.Hours);
            Console.WriteLine("Minutes: " + t4.Minutes);
            Console.WriteLine("Milliseconds: " + t4.Milliseconds);
            Console.WriteLine("Seconds: " + t4.Seconds);
            Console.WriteLine("Ticks: " + t4.Ticks);

            Console.WriteLine("TotalDays: " + t4.TotalDays);
            Console.WriteLine("TotalHours: " + t4.TotalHours);
            Console.WriteLine("TotalMinutes: " + t4.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t4.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t4.TotalMilliseconds);

            Console.WriteLine("\n--------Operações------------");
            Console.WriteLine(sum);
            Console.WriteLine(diff);
            Console.WriteLine(mult);
            Console.WriteLine(div);

        }
    }
}
