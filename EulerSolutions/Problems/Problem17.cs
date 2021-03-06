﻿using System;
using System.Globalization;
using EulerSolutions.Common;

namespace EulerSolutions.Problems
{
    public class Problem17 : IProblemSolver<string>
    {
        public string Title
        {
            get { return "Problem 17: Number letter counts"; }
        }

        public string Definition
        {
            get
            {
                return "If the numbers 1 to 5 are written out in words: one, two, three, four, five, " +
                       "then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total." +
                       Environment.NewLine +
                       "If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, " +
                       "how many letters would be used?" +
                       Environment.NewLine +
                       Environment.NewLine +
                       "NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) " +
                       "contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of " +
                       "and when writing out numbers is in compliance with British usage.";
            }
        }

        public string Solve()
        {
            int letterCount = 0;
            var numberToWord = new NumberToWords();

            for (int i = 1; i <= 1000; i++)
            {
                string words = numberToWord.GetWordsForNumber(i);
                words = words.Replace(" ", "");

                letterCount += words.Length;
            }

            return letterCount.ToString(CultureInfo.InvariantCulture);
        }
    }
}