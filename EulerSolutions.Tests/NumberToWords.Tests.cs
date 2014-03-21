using System.Diagnostics;
using EulerSolutions.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerSolutions.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OnesTests()
        {
            var numberToWords = new NumberToWords();

            for (int i = 0; i <= 1000; i++)
            {
                var w = numberToWords.GetWordsForNumber(i);
                Debug.WriteLine(w);    
            }
        }
    }
}
