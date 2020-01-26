using System;
using System.Collections.Generic;
using System.Globalization;
using _136ExercicioProposto_MetodosAbstratos_.Entities;

namespace _136ExercicioProposto_MetodosAbstratos_ {
    class Program {
        static void Main(string[] args) {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i++) {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char taxpayer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualincome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                switch (taxpayer) {
                    case 'i':
                        Console.Write("Health expendures: ");
                        double healthexpendures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new Individual(name, anualincome, healthexpendures));
                        break;

                    case 'c':
                        Console.Write("Number of employees: ");
                        int numberofemployees = int.Parse(Console.ReadLine());
                        list.Add(new Company(name, anualincome, numberofemployees));
                        break;
                }

            }

            Console.WriteLine("\nTAXES PAID:");
            foreach (TaxPayer taxpayer in list) {
                Console.WriteLine(taxpayer.Name + ": $ " + taxpayer.Tax().ToString("F2",CultureInfo.InvariantCulture));
            }

        }
    }
}
