using System.Collections.Generic;

namespace EulerSolutions.Common
{
    public class MathHelper
    {
        public int[] GetDivisors(int number)
        {
            var divisors = new List<int>();
            for (var i = 1; i < number; i++)
            {
                if (number%i == 0)
                    divisors.Add(i);
            }
            return divisors.ToArray();
        }
    }
}