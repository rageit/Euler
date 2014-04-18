using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EulerSolutions.Common;

namespace EulerSolutions.Problems
{
    public class Problem23 : IProblemSolver<string>
    {
        public string Title
        {
            get { return "Problem 23: Non-Abundant Sum"; }
        }

        public string Definition
        {
            get { return @"http://projecteuler.net/problem=23"; }
        }

        public string Solve()
        {
            const int max = 28123;
            SortedSet<int> abundantSummedNumbers = GetAbundantSummedNumbers(max);

            int nonAbundantSummedNumbers = 0;
            for (int i = 0; i < max; i++)
            {
                if (!abundantSummedNumbers.Contains(i))
                {
                    nonAbundantSummedNumbers += i;
                }
            }

            return nonAbundantSummedNumbers.ToString(CultureInfo.InvariantCulture);
        }

        private SortedSet<int> GetAbundantSummedNumbers(int max)
        {
            var abundantSummedNumbers = new SortedSet<int>();
            int[] abundantNumbers = GetAbundantNumbers(max);

            for (int i = 0; i < abundantNumbers.Length; i++)
            {
                for (int j = i; j < abundantNumbers.Length; j++)
                {
                    abundantSummedNumbers.Add(abundantNumbers[i] + abundantNumbers[j]);
                }
            }

            return abundantSummedNumbers;
        }

        private int[] GetAbundantNumbers(int max)
        {
            var abundantNumbers = new List<int>();
            for (int i = 1; i <= max; i++)
            {
                // Would be faster if divisors are summed up here instead
                int[] divisors = new MathHelper().GetDivisors(i);

                if (divisors.Sum() > i)
                    abundantNumbers.Add(i);
            }

            return abundantNumbers.OrderBy(a => a).ToArray();
        }
    }
}