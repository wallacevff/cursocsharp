using System;
using Aula207GetHashCodeEEquals.Entities;

namespace Aula207GetHashCodeEEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client("Maria", "maria@gmail.com");
            Client b = new Client("Alex", "maria@gmail.com");

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b); //Compara a referência do ponteiro
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
