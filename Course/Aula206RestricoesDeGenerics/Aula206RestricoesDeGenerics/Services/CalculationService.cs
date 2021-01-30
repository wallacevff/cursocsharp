using System;
using System.Collections.Generic;
using System.Text;

namespace Aula206RestricoesDeGenerics.Services
{
    static class CalculationService
    {
        public static T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("This list can not be empty");
            }
            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (max.CompareTo(list[i]) < 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
