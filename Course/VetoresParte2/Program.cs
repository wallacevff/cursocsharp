using System;
using System.Globalization;

namespace VetoresParte2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());
            string name; double price, media;
            Product[] vect = new Product[n];
            media = 0;
            for (int i = 0; i < n; i++) {

                Console.WriteLine("Produto " + (i+1).ToString("D2") + ":");
                Console.Write("Nome: ");
                name = Console.ReadLine();
                Console.Write("Preço: ");
                price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
                media += vect[i].Price;
                Console.WriteLine(vect[i] + "\n");

            }

            Console.WriteLine("Media de Preços: R$" + (media/n).ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
