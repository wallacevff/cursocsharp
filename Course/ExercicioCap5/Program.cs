using System;
using System.Globalization;

namespace ExercicioCap5 {
    class Program {
        static void Main(string[] args) {
            ContaBancaria cb;
            string nome, dep;
            int numero;
            double movimento;

            Console.Write("Entre com o número da conta: "); numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: "); nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n): "); dep = Console.ReadLine();

            if (dep == "s") {
                Console.Write("Entre com o valor de depósio inicial: ");
                movimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cb = new ContaBancaria(numero, nome, movimento);
            } else {
                cb = new ContaBancaria(numero, nome);
            }

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(cb);

            Console.Write("Entre com um valor de depósito: "); 
            cb.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("\nDados Atualizados:\n" + cb);

            Console.Write("\nEntre com um valor de saque: ");
            cb.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("\nDados Atualizados:\n" + cb);


        }
    }
}
