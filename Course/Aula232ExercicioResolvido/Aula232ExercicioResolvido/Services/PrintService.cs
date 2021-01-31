using System;
using System.Collections.Generic;
using System.Text;
using Aula232ExercicioResolvido.Entities;

namespace Aula232ExercicioResolvido.Services
{
    public static class PrintService
    {
        static public void PrintProdList(List<Product> prods)
        {
            foreach (Product p in prods)
            {
                Console.WriteLine(p);
            }
        }
    }
}
