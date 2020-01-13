using System;
using System.Globalization;
using System.Collections.Generic;
using Aula132Exercicio_HerancaEPolimorfismo_.Entities;

namespace Aula132Exercicio_HerancaEPolimorfismo_ {
    class Program {
        static void Main(string[] args) {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                
                switch (type){
                    case 'i':
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new ImportedProduct(name, price, customsFee));
                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        list.Add(new UsedProduct(name, price, manufactureDate));
                        break;
                    default:
                        list.Add(new Product(name, price));   
                        break;
                }
            }
            Console.WriteLine("PRODUCT TAGS");
            foreach (Product p in list) {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
