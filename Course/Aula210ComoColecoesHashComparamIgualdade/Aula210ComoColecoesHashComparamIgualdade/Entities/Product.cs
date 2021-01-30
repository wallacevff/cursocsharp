using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Aula210ComoColecoesHashComparamIgualdade.Entities
{
    class Product
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

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Wrong class!");
            }
            return Name.Equals((obj as Product).Name) && Price.Equals((obj as Product).Price);
        }
    }
}
