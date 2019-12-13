using System;

namespace Aula71ExercicioFIxacao {
    class Program {
        static void Main(string[] args) {
            int numeroapt, n;
            string nome, email;
            Console.Write("How many will be rented? ");
            n = int.Parse(Console.ReadLine());
            Alocacao[] a = new Alocacao[10];

            for (int i = 1; i <= n; i++) {
                Console.Write("\nRent #" + i.ToString() + ":\nName: "); nome = Console.ReadLine();
                Console.Write("Email: "); email = Console.ReadLine();
                Console.Write("Room: "); numeroapt = int.Parse(Console.ReadLine());
                a[numeroapt] = new Alocacao { Nome = nome, Email = email };

            }
            Console.WriteLine("\nBusy rooms:");
            for (int i = 0; i < a.Length; i++) {
                if (a[i] != null) {
                    Console.WriteLine(i.ToString() + ": " + a[i]);
                }
            }
        }
    }
}
