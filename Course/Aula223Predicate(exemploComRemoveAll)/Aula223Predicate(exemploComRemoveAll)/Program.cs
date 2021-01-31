/* Fazer um programa que, a partir de uma lista de produos, temva da lista somente
 * aqueles cujo preço mpinimo seja 100.
 */

using System;
using Aula223Predicate_exemploComRemoveAll_.Entities;
using System.Collections.Generic;

namespace Aula223Predicate_exemploComRemoveAll_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV,900.00"));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet,350.50"));
            list.Add(new Product("HD Case", 80.90));
     
            list.RemoveAll(p => p.Price >= 100);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
