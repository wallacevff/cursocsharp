using System;
using System.Globalization;
using System.Collections.Generic;
using Aula206RestricoesDeGenerics.Services;
using Aula206RestricoesDeGenerics.Entities;

namespace Aula206RestricoesDeGenerics
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> list = new List<Product>();
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] splittedLine = line.Split(",");
                list.Add(new Product(splittedLine[0], double.Parse(splittedLine[1],CultureInfo.InvariantCulture)));
            }
            
            Console.WriteLine("Most Expensive:\n" + CalculationService.Max(list).ToString());

        }
    }
}
