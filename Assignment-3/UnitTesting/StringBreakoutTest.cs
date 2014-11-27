using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Functions;

namespace UnitTesting
{
    [TestClass]
    public class StringBreakoutTest
    {
        // normal testing for NumberOfDigits
        [TestMethod]
        public void NumberOfDigits_WhenValidInPut()
        {
            // arrange
            string test = "123abc456";
            int expected = 6;
            StringBreakout.NumberOfDigits(test);

            int actual = StringBreakout.NumberDigits;
            Assert.AreEqual(expected, actual);
        }

        // Testing no input
        [TestMethod]
        public void NumberOfDigits_WhenNoInput()
        {
            // arrange
            string test = "";
            int expected = 0;
            StringBreakout.NumberOfDigits(test);

            int actual = StringBreakout.NumberDigits;
            Assert.AreEqual(expected, actual);
        }

        // Testing No Numbers are input
        [TestMethod]
        public void NumberOfDigits_WhenNoNumbers()
        {
            // arrange
            string test = "Hello!";
            int expected = 0;
            StringBreakout.NumberOfDigits(test);

            int actual = StringBreakout.NumberDigits;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberOfDigits_WhenMultipleSameNumber()
        {
            // arrange
            string test = "11111!";
            int expected = 5; // 5 number ones
            StringBreakout.NumberOfDigits(test);

            int actual = StringBreakout.NumberDigits;
            Assert.AreEqual(expected, actual);
        }

    }
}
