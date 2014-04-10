using System;
using System.Globalization;
using EulerSolutions.Common;

namespace EulerSolutions.Problems
{
    public class Problem18 : IProblemSolver<string>
    {
        // jagged array
        private readonly int[][] bermudaTriangle =
        {
            new[] {75},
            new[] {95, 64},
            new[] {17, 47, 82},
            new[] {18, 35, 87, 10},
            new[] {20, 04, 82, 47, 65},
            new[] {19, 01, 23, 75, 03, 34},
            new[] {88, 02, 77, 73, 07, 63, 67},
            new[] {99, 65, 04, 28, 06, 16, 70, 92},
            new[] {41, 41, 26, 56, 83, 40, 80, 70, 33},
            new[] {41, 48, 72, 33, 47, 32, 37, 16, 94, 29},
            new[] {53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14},
            new[] {70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57},
            new[] {91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48},
            new[] {63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31},
            new[] {04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23}
        };

        public string Title
        {
            get { return "Problem 18: Maximum path sum"; }
        }

        public string Definition
        {
            get { return "http://projecteuler.net/problem=18"; }
        }

        public string Solve()
        {
            int depth = bermudaTriangle.GetLength(0) - 2;

            // Start from the leaf nodes
            while (depth >= 0)
            {
                for (int j = 0; j <= depth; j++)
                {
                    // Adds larger of the two numbers
                    bermudaTriangle[depth][j] += Math.Max(bermudaTriangle[depth + 1][j],
                        bermudaTriangle[depth + 1][j + 1]);
                }
                depth += -1;
            }

            return bermudaTriangle[0][0].ToString(CultureInfo.InvariantCulture);
        }
    }
}