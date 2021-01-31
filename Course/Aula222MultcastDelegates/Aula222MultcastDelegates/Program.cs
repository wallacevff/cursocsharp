using System;
using Aula222MultcastDelegates.Services;
namespace Aula222MultcastDelegates
{
    delegate void BinayNumecOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            BinayNumecOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            op.Invoke(a, b);

        }
    }
}