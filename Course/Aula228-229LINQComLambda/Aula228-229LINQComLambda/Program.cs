﻿using System;
using Aula228_229LINQComLambda.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Aula228_229LINQComLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Eletronics", 1);

            static void Print<T>(string message, IEnumerable<T> collection)
            {
                Console.WriteLine(message);
                foreach (T t in collection)
                {
                    Console.WriteLine(t);
                }
                Console.WriteLine();
            }

            List<Product> products = new List<Product>()
            {
                new Product(1, "Computer", 1100.0, c2),
                new Product(2, "Hammer", 90.0, c1),
                new Product(3, "TV", 1700.0, c3),
                new Product(4, "Notebook", 1300.0, c2),
                new Product(5, "Saw",80.0, c1),
                new Product(6, "Tablet", 700.0, c2),
                new Product(7, "Camera", 700.0, c3),
                new Product(8, "Printer", 350.0, c3),
                new Product(9, "MacBook", 1800.0, c2),
                new Product(10, "Sound Bar", 700.0, c3),
                new Product(11, "Level", 70.0, c1)
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            Print("TIER 1 AND PRICE < 900", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAME OF PRODUCTS FROM TOOLS", r2);

            var r3 = products.Where(p => p.Name.Substring(0, 1).ToLower() == "c").Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("NAME OF PRODUCTS STARTED WITH C", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            var r6 = products.FirstOrDefault();
            Console.WriteLine("First or default test1: " + r6);

            var r7 = products.Where(p => p.Price > 3000).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);
            Console.WriteLine();

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1: " + r8);

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test1: " + r9);

            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);

            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);

            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 sum Prices: " + r12);

            try
            {
                var r13 = products.Where(p => p.Category.Id == 5).Average(p => p.Price);
                Console.WriteLine("Category 1 avarage Prices: " + r13);
            }
            catch (Exception e)
            {
              
                if (e is DivideByZeroException || e is System.InvalidOperationException) {
                    Console.WriteLine("Category 1 avarage Prices: 0");
                }
                
            }
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 1 avarage Prices: " + r14);

            var r15 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x,y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + r15);
            Console.WriteLine();
            var r16 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category,Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
