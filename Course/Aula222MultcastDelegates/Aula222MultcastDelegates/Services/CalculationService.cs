using System;
namespace Aula222MultcastDelegates.Services
{
    class CalculationService
    {
        public static double Max(double x, double y)
        {
            return (x > y) ? x : y;
        }

        public static void ShowMax(double x, double y)
        {
            double max = Max(x, y);
            System.Console.WriteLine(max);
        }

        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static void ShowSum(double x, double y)
        {
            double sum = Sum(x, y);
            System.Console.WriteLine(sum);
        }

        public static double Square(double x)
        {
            return x * x;
        }
    }
}
