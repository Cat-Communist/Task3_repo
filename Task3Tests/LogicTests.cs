using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void ManySameLetters_ReturnsHndred()
        {
            var str = "llll";

            var result = Logic.CalcFractions(str);

            Assert.AreEqual("l = 100,00%\n", result);
        }

        [TestMethod()]
        public void CapitalLetters_NotCountingLettersTwice()
        {
            var str = "AaBbCc";

            var result = Logic.CalcFractions(str);

            Assert.AreEqual("a = 33,33%\n" +
                            "b = 33,33%\n" +
                            "c = 33,33%\n", result);
        }

        [TestMethod()]
        public void WithPunctuation_ReturnsWithoutMarks()
        {
            var str = "Hello, World!";

            var result = Logic.CalcFractions(str);

            Assert.AreEqual("h = 10,00%\n" +
                            "e = 10,00%\n" +
                            "l = 30,00%\n" +
                            "o = 20,00%\n" +
                            "w = 10,00%\n" +
                            "r = 10,00%\n" +
                            "d = 10,00%\n", result);
        }
    }
}