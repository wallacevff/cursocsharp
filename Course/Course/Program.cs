using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
            double moeda, dolar;

            Console.Write("Qual é a cotação do dólar? ");
            moeda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Qauntos dólares você vai comprar? ");
            dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor pago em reais " + ConversorDeMoeda.Converter(moeda,dolar).ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
