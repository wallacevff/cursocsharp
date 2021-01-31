/* Fazer um programa que, a partir de uma lista de produtos, gere uma nova lista contendo os nomes em caixa alta.
 */
using System;
using System.Collections.Generic;
using Aula225Func_exemploComSelect_.Entities;
using System.Linq;
namespace Aula225Func_exemploComSelect_
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

            Func<Product, string> func = NameUpper;

            List<string> result = list.Select(func).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }

        }
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
        
    }
}
