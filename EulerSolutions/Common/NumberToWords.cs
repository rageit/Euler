using System.Collections.Generic;
using System.Text;

namespace EulerSolutions.Common
{
    public class NumberToWords
    {
        private const string And = "and";

        private static readonly Dictionary<int, string> NumberToWordMap = new Dictionary<int, string>
        {
            {0, "zero"},
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"},
            {6, "six"},
            {7, "seven"},
            {8, "eight"},
            {9, "nine"},
            {10, "ten"},
            {11, "eleven"},
            {12, "twelve"},
            {13, "thirteen"},
            {14, "fourteen"},
            {15, "fifteen"},
            {16, "sixteen"},
            {17, "seventeen"},
            {18, "eighteen"},
            {19, "nineteen"},
            {20, "twenty"},
            {30, "thirty"},
            {40, "forty"},
            {50, "fifty"},
            {60, "sixty"},
            {70, "seventy"},
            {80, "eighty"},
            {90, "ninety"},
            {100, "hundred"},
            {1000, "thousand"}
        };

        public string GetWordsForNumber(int number)
        {
            int thousands = (number/1000);
            int hundreds = (number - thousands*1000)/100;
            int tens = (number - thousands*1000 - hundreds*100)/10;
            int ones = (number - thousands*1000 - hundreds*100 - tens*10);

            bool andFlag = false;

            var numberToWord = new StringBuilder();
            if (thousands > 0)
            {
                numberToWord.Append(string.Format("{0} {1}", NumberToWordMap[thousands], NumberToWordMap[1000]));

                if (tens > 0 || ones > 0)
                    andFlag = true;
            }
            if (hundreds > 0)
            {
                string formatString = thousands > 0 ? " {0} {1}" : "{0} {1}";
                numberToWord.Append(string.Format(formatString, NumberToWordMap[hundreds], NumberToWordMap[100]));

                if (tens > 0 || ones > 0)
                    andFlag = true;
            }

            string conjunction = andFlag ? " and " : " ";
            if (tens > 1)
            {
                numberToWord.Append(conjunction + NumberToWordMap[tens*10]);
            }
            else if (tens == 1)
            {
                numberToWord.Append(conjunction + NumberToWordMap[tens*10 + ones]);
            }
            if (ones > 0 && tens != 1)
            {
                conjunction = tens == 0 ? conjunction : " ";
                numberToWord.Append(conjunction + NumberToWordMap[ones]);
            }

            return numberToWord.ToString();
        }
    }
}