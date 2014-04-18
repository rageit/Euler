using System.Globalization;
using EulerSolutions.Common;

namespace EulerSolutions.Problems
{
    public class Problem24 : IProblemSolver<string>
    {
        private char[] _numChars = new char[] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

        public string Title
        {
            get { return "Problem 24: Lexicographic permutations"; }
        }

        public string Definition
        {
            get { return "http://projecteuler.net/problem=24"; }
        }

        public string Solve()
        {
            var iterations = new MathHelper().GetFactorial(_numChars.Length);

            return iterations.ToString(CultureInfo.InvariantCulture);
        }

        private string[] GetPermutation(string numChars)
        {
            
        }
    }
}