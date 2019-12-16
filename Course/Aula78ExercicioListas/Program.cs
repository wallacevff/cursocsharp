using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula78ExercicioListas {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many emolyees will be registred? ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++) {
                Employee e = new Employee();
                Console.WriteLine("Employee #" + (i + 1).ToString() + ":");
                Console.Write("Id: ");
                e.Id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                e.Name = Console.ReadLine();
                Console.Write("Salary: ");
                e.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(e);
                Console.WriteLine();
                e = null;
            }

            Console.Write("\nEnter the employee's id that will have salary increase: ");
            int id = int.Parse(Console.ReadLine());

            Employee e3 = list.Find(x => x.Id == id);

            if (e3 == null) Console.WriteLine("This id does not exist!");
            else {
                Console.Write("Enter the percentage: ");
                double p = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                e3.increaseSalary(p);
            }

            Console.WriteLine("\nUpdated list of emloyees:");
            foreach (Employee e2 in list) {
                Console.WriteLine("Funcionario: " + e2);
            }

        }
    }
}
