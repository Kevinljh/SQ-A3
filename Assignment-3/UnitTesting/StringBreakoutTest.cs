/* 
 *   FILE           : StringBreakoutTst.cs
 *   PROJECT        : INFO2180-14F - Assignment 3
 *   PROGRAMMER     : Kevin Li, Michael Da Silva
 *   FIRST VERSION  : Nov 26 2014
 *   DESCRIPTION    : Unit Test Class used to automate testing for StringBrteakout class methods
 */

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Functions;

namespace UnitTesting
{
    /// 
    /// \class StringBreakoutTest
    ///
    /// \brief The StringBreakoutTest Unit Test Class has been created to verificate <br>
    /// the validation and accuracy of StringBreakout methods
    ///
    /// \author <i>Michael Da Silva & Kevin Li</i>
    ///

    [TestClass]
    public class StringBreakoutTest
    {
        /*********************Factorial Testing*********************/

        /// \brief Tests the Calc 
        /// \details <b>Details</b> 
        /// Test calc function in Factorial class with valid input <br>
        ///	<b>Input</b> 
        ///			~ test (int) 
        /// \return
        ///			~ Passed test results<br>
        ///			~ throw exception otherwise
        ///
        [TestMethod]
        public void Calc_WhenValidInPut()
        {
            // arrange
            int test = 5;
            int expected = 120;
            Factorial.Calc(test);

            int actual = Factorial.GetCalcResult;
            Assert.AreEqual(expected, actual);
        }

        /// \brief Tests the Calc 
        /// \details <b>Details</b> 
        /// Test calc function in Factorial class with valid input that would generate a large number <br>
        ///	<b>Input</b> 
        ///			~ test (int) 
        /// \return
        ///			~ Passed test results<br>
        ///			~ throw exception otherwise
        ///
        [TestMethod]
        public void Calc_WhenvalidInPutLarge()
        {
            // arrange
            int test = 12;
            int expected = 479001600;
            Factorial.Calc(test);

            int actual = Factorial.GetCalcResult;
            Assert.AreEqual(expected, actual);
        }

        /*********************NumberOfDigits Testing*********************/

        /// \brief Tests the NumberOfDigits
        /// \details <b>Details</b> 
        /// Runs a string "test" containing 6 numbers vs the function to test for accuracy<br>
        ///	<b>Input</b> 
        ///			~ test (string) 
        /// \return
        ///			~ Passed test results<br>
        ///			~ throw exception otherwise
        ///
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

        /// \brief Tests the NumberOfDigits
        /// \details <b>Details</b> 
        /// Runs an empty string "test" vs the NumberOfDigits function<br>
        ///	<b>Input</b> 
        ///			~ test (string) 
        /// \return
        ///			~ Passed test results<br>
        ///			~ throw exception otherwise
        ///
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

        /// \brief Tests the NumberOfDigits
        /// \details <b>Details</b> 
        /// Runs a string "test" containing only letters vs the NumberOfDigits function<br>
        ///	<b>Input</b> 
        ///			~ test (string) 
        /// \return
        ///			~ Passed test results<br>
        ///			~ throw exception otherwise
        ///
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

        /// \brief Tests the NumberOfDigits
        /// \details <b>Details</b> 
        /// Runs a string "test" containing 6 number 1s vs the NumberOfDigits function<br>
        ///	<b>Input</b> 
        ///			~ test (string) 
        /// \return
        ///			~ Passed test results<br>
        ///			~ throw exception otherwise
        ///
        [TestMethod]
        public void NumberOfDigits_WhenMultipleSameNumber()
        {
            // arrange
            string test = "11111";
            int expected = 5; // 5 number ones
            StringBreakout.NumberOfDigits(test);

            int actual = StringBreakout.NumberDigits;
            Assert.AreEqual(expected, actual);
        }
        
        
        /*********************NumberOfAlphas Testing*********************/

        /// \brief Tests the NumberOfAlphas
        /// \details <b>Details</b> 
        /// Runs a string "test" containing 3 letters and 6 numbers vs the function to test for accuracy<br>
        ///	<b>Input</b> 
        ///			~ test (string) 
        /// \return
        ///			~ Passed test results<br>
        ///			~ throw exception otherwise
        ///
        [TestMethod]
        public void NumberOfAlphas_WhenValidInPut()
        {
            // arrange
            string test = "123abc456";
            int expected = 3;
            StringBreakout.NumberOfAlphas(test);

            int actual = StringBreakout.NumberAlphas;
            Assert.AreEqual(expected, actual);
        }

        /// \brief Tests the NumberOfAlphas
        /// \details <b>Details</b> 
        /// Runs an empty string "test" vs the NumberOfAlphas function<br>
        ///	<b>Input</b> 
        ///			~ test (string) 
        /// \return
        ///			~ Passed test results<br>
        ///			~ throw exception otherwise
        ///
        [TestMethod]
        public void NumberOfAlphas_WhenNoInput()
        {
            // arrange
            string test = "";
            int expected = 0;
            StringBreakout.NumberOfAlphas(test);

            int actual = StringBreakout.NumberAlphas;
            Assert.AreEqual(expected, actual);
        }

        /// \brief Tests the NumberOfAlphas
        /// \details <b>Details</b> 
        /// Runs a string "test" containing only Numbers vs the NumberOfAlphas function<br>
        ///	<b>Input</b> 
        ///			~ test (string) 
        /// \return
        ///			~ Passed test results<br>
        ///			~ throw exception otherwise
        ///
        [TestMethod]
        public void NumberOfAlphas_WhenNoLetters()
        {
            // arrange
            string test = "123786!@!#";
            int expected = 0;
            StringBreakout.NumberOfAlphas(test);

            int actual = StringBreakout.NumberAlphas;
            Assert.AreEqual(expected, actual);
        }

        /// \brief Tests the NumberOfAlphas
        /// \details <b>Details</b> 
        /// Runs a string "test" containing 6 Letter As vs the NumberOfAlphas function<br>
        ///	<b>Input</b> 
        ///			~ test (string) 
        /// \return
        ///			~ Passed test results<br>
        ///			~ throw exception otherwise
        ///
        [TestMethod]
        public void NumberOfAlphas_WhenMultipleSameLetter()
        {
            // arrange
            string test = "AAAAAA";
            int expected = 6; 
            StringBreakout.NumberOfAlphas(test);

            int actual = StringBreakout.NumberAlphas;
            Assert.AreEqual(expected, actual);
        }

        /*********************NumberOfOthers Testing*********************/

        /// \brief Tests the NumberOfOthers
        /// \details <b>Details</b> 
        /// Runs a string "test" containing 3 letters, 6 numbers and 6 symbols vs the function to test for accuracy<br>
        ///	<b>Input</b> 
        ///			~ test (string) 
        /// \return
        ///			~ Passed test results<br>
        ///			~ throw exception otherwise
        ///
        [TestMethod]
        public void NumberOfOthers_WhenValidInPut()
        {
            // arrange
            string test = "!@#ABC123$%^";
            int expected = 6;
            StringBreakout.NumberOfOthers(test);

            int actual = StringBreakout.NumberOthers;
            Assert.AreEqual(expected, actual);
        }

        /// \brief Tests the NumberOfAlphas
        /// \details <b>Details</b> 
        /// Runs an empty string "test" vs the NumberOfOthers function<br>
        ///	<b>Input</b> 
        ///			~ test (string) 
        /// \return
        ///			~ Passed test results<br>
        ///			~ throw exception otherwise
        ///
        [TestMethod]
        public void NumberOfOthers_WhenNoInput()
        {
            // arrange
            string test = "";
            int expected = 0;
            StringBreakout.NumberOfOthers(test);

            int actual = StringBreakout.NumberOthers;
            Assert.AreEqual(expected, actual);
        }

        /// \brief Tests the NumberOfOthers
        /// \details <b>Details</b> 
        /// Runs a string "test" containing only Numbers vs the NumberOfOthers function<br>
        ///	<b>Input</b> 
        ///			~ test (string) 
        /// \return
        ///			~ Passed test results<br>
        ///			~ throw exception otherwise
        ///
        [TestMethod]
        public void NumberOfOthers_WhenNoOthers()
        {
            // arrange
            string test = "123786ABCasd";
            int expected = 0;
            StringBreakout.NumberOfOthers(test);

            int actual = StringBreakout.NumberOthers;
            Assert.AreEqual(expected, actual);
        }

        /// \brief Tests the NumberOfOthers
        /// \details <b>Details</b> 
        /// Runs a string "test" containing 6 symbols ! vs the NumberOfOthers function<br>
        ///	<b>Input</b> 
        ///			~ test (string) 
        /// \return
        ///			~ Passed test results<br>
        ///			~ throw exception otherwise
        ///
        [TestMethod]
        public void NumberOfOthers_WhenMultipleSameSymbol()
        {
            // arrange
            string test = "!!!!!!";
            int expected = 6;
            StringBreakout.NumberOfOthers(test);

            int actual = StringBreakout.NumberOthers;
            Assert.AreEqual(expected, actual);
        }
        /*********************FindAndExtractDigits Testing*********************/

        /// \brief Tests the FindAndExtractDigits
        /// \details <b>Details</b> 
        /// Runs a string "test" with no input vs the FindAndExtractDigits function to <br>
        /// well Find and extract the digits and convert the findings into an int.
        ///	<b>Input</b> 
        ///			~ test (string) 
        /// \return
        ///			~ Passed test results<br>
        ///			~ throw exception otherwise
        ///
        [TestMethod]
        public void FindAndExtractDigits_WhenNoInput()
        {
            // arrange
            string test = "";
            int expected = 0;
            StringBreakout.FindAndExtractDigits(test);

            int actual = StringBreakout.ExtractNumbers;
            Assert.AreEqual(expected, actual);
        }

        /// \brief Tests the FindAndExtractDigits
        /// \details <b>Details</b> 
        /// Runs a string "test" containing no input vs the FindAndExtractDigits function to <br>
        /// well Find and extract the digits and convert the findings into an int .
        ///	<b>Input</b> 
        ///			~ test (string) 
        /// \return
        ///			~ Passed test results<br>
        ///			~ throw exception otherwise
        ///
        [TestMethod]
        public void FindAndExtractDigits_WithOnlyNumbers()
        {
            // arrange
            string test = "2013";
            int expected = 2013;
            StringBreakout.FindAndExtractDigits(test);

            int actual = StringBreakout.ExtractNumbers;
            Assert.AreEqual(expected, actual);
        }

        /// \brief Tests the FindAndExtractDigits
        /// \details <b>Details</b> 
        /// Runs a string "test" containing hellowWorld1 vs the FindAndExtractDigits function to <br>
        /// well Find and extract the digits and convert the findings into an int.
        ///	<b>Input</b> 
        ///			~ test (string) 
        /// \return
        ///			~ Passed test results<br>
        ///			~ throw exception otherwise
        ///
        [TestMethod]
        public void FindAndExtractDigits_ExtractSingleNumber()
        {
            // arrange
            string test = "helloWorld1";
            int expected = 1;
            StringBreakout.FindAndExtractDigits(test);

            int actual = StringBreakout.ExtractNumbers;
            Assert.AreEqual(expected, actual);
        }

        /// \brief Tests the FindAndExtractDigits
        /// \details <b>Details</b> 
        /// Runs a string "test" vs the FindAndExtractDigits function to <br>
        /// well Find and extract the digits and convert the findings into an int.
        ///	<b>Input</b> 
        ///			~ test (string) 
        /// \return
        ///			~ Passed test results<br>
        ///			~ throw exception otherwise
        ///
        [TestMethod]
        public void FindAndExtractDigits_ExtractMultipleNumbers()
        {
            // arrange
            string test = "helloWo32rld1";
            int expected = 321;
            StringBreakout.FindAndExtractDigits(test);

            int actual = StringBreakout.ExtractNumbers;
            Assert.AreEqual(expected, actual);
        }

        /// \brief Tests the FindAndExtractDigits
        /// \details <b>Details</b> 
        /// Runs a string "test" vs the FindAndExtractDigits function to <br>
        /// well Find and extract the digits and convert the findings into an int * this test will contain symbols.
        ///	<b>Input</b> 
        ///			~ test (string) 
        /// \return
        ///			~ Passed test results<br>
        ///			~ throw exception otherwise
        ///
        [TestMethod]
        public void FindAndExtractDigits_ExtractMultipleNumbersWithSymbols()
        {
            // arrange
            string test = "helloWo32r@#ld1";
            int expected = 321;
            StringBreakout.FindAndExtractDigits(test);

            int actual = StringBreakout.ExtractNumbers;
            Assert.AreEqual(expected, actual);
        }


 
    }
}
