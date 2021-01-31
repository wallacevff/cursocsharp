/* Fazer um programa para ler um conjunto de produtos a partir de um arquivo em formato .csv
 * (suponha que exista pelo menos um produto).
 * Em seguida mostrar o preço médio dos produtos. Depois, mostrar os nomes, em ordem decrescente,
 * dos produtos que possuem preço inferior ao preço médio.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using Aula232ExercicioResolvido.Entities;
using Aula232ExercicioResolvido.Services;


namespace Aula232ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter filename: ");
            string filename = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(@"..\..\..\" + filename + ".txt"))
                {
                    List<Product> products = new List<Product>();
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        products.Add(new Product(line));
                    }


                    //PrintService.PrintProdList(products);
                    var avarage = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                    var prods =
                        from p in products
                        where p.Price < avarage
                        orderby p.Name descending
                        select p.Name;
                    Console.WriteLine("Avarage price: " + avarage.ToString("F2",CultureInfo.InvariantCulture));
                    foreach(string s in prods)
                    {
                        Console.WriteLine(s);
                    }
                }
                
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
