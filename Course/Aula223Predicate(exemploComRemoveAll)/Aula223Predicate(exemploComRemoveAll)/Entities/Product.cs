using System.Collections.Generic;
using System.Globalization;

namespace Aula223Predicate_exemploComRemoveAll_.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string str)
        {
            string[] s = str.Split(",");
            Name = s[0];
            Price = double.Parse(s[1],CultureInfo.InvariantCulture);
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
