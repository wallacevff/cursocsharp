using System;


namespace Aula217ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Escolha o Exercicio Demo [1 ou 2]: ");
            int opt = int.Parse(Console.ReadLine());
            if (opt == 1)
            {
                DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
                Console.WriteLine(dt.ElapsedTime());
            }
            else if (opt == 2)
            {
                String s1 = "Good morning dear students!";
                Console.WriteLine(s1.Cut(10));
            }
            else {; }
        }
    }
}
