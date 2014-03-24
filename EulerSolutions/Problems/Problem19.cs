using System;
using System.Globalization;
using EulerSolutions.Common;

namespace EulerSolutions.Problems
{
    public class Problem19 : IProblemSolver<string>
    {
        public string Title
        {
            get { return "Problem 19: Counting Sundays"; }
        }

        public string Definition { get { return "http://projecteuler.net/problem=19"; } }

        /// <summary>
        /// How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
        /// </summary>
        /// <returns>Answer</returns>
        public string Solve()
        {
            var startDate = DateTime.Parse("1/1/1901");
            var endDate = DateTime.Parse("12/31/2000");

            var sundayMorningCounter = 0;

            while (startDate <= endDate)
            {
                if (startDate.Day == 1 && startDate.DayOfWeek == DayOfWeek.Sunday)
                    sundayMorningCounter ++;

                startDate = startDate.AddDays(1);
            }

            return sundayMorningCounter.ToString(CultureInfo.InvariantCulture);
        }
    }
}