using System;
using Aula221IntroducaoADelegates.Services;
namespace Aula221IntroducaoADelegates
{
    delegate double BinayNumecOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            BinayNumecOperation op = CalculationService.Sum;
            double result = op(a,b);

            Console.WriteLine(result);
        }
    }
}
