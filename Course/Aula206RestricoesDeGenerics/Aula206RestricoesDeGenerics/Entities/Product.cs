using System;
using System.Globalization;

namespace Aula206RestricoesDeGenerics.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public Product()
        {
            ;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", price: " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Invalid Object class");
            }
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}
