using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExGenerics
{
    class CalculationService
    {

        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
                throw new ArgumentException("A lista está vazia.");

            T max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
