using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EulerSolutions.Common;

namespace EulerSolutions.Problems
{
    public class Problem21 : IProblemSolver<string>
    {
        public string Title
        {
            get { return "Problem 21: Amicable Numbers"; }
        }

        public string Definition
        {
            get { return "http://projecteuler.net/problem=21"; }
        }

        /// <summary>
        ///     Evaluate the sum of all the amicable numbers under 10000.
        /// </summary>
        /// <returns>Answer</returns>
        public string Solve()
        {
            const int maxNumber = 10000;

            IEnumerable<int> amicableNumbers = GetAmicableNumbers(maxNumber).Distinct();

            return amicableNumbers.Sum().ToString(CultureInfo.InvariantCulture);
        }

        private IEnumerable<int> GetAmicableNumbers(int maxNumber)
        {
            var mathHelper = new MathHelper();
            var amicableNumbers = new List<int>();

            for (int i = 1; i < maxNumber; i++)
            {
                int amicableCandidate1 = mathHelper.GetDivisors(i).Sum();

                int amicableCandidate2 = mathHelper.GetDivisors(amicableCandidate1).Sum();

                if (i != amicableCandidate1 && i == amicableCandidate2)
                {
                    amicableNumbers.Add(amicableCandidate1);
                    amicableNumbers.Add(amicableCandidate2);
                }
            }

            return amicableNumbers.ToArray();
        }
    }
}