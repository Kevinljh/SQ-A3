/* 
 *   FILE           : StringBreakout.cs
 *   PROJECT        : INFO2180-14F - Assignment 3
 *   PROGRAMMER     : Kevin Li, Michael Da Silva
 *   FIRST VERSION  : Nov 26 2014
 *   DESCRIPTION    : Provided by SET at conestoga college.
 */

//This code was borrowed from the VS2008 C# Samples and was modified by S. Clarke

// StringBreakout.cs
// compile with: /target:library
using System; 
using System.Text.RegularExpressions;

// Declare the same namespace as the one in Factorial.cs. This simply 
// allows types to be added to the same namespace.
namespace Functions 
{
    /// 
    /// \class StringBreakout
    ///
    /// \brief The StringBreakout Class contains methods used to count <br>
    /// the number of Numbers, Letters , etc in a string
    ///
    /// \author <i>Michael Da Silva & Kevin Li</i>
    ///

    public class StringBreakout
    {
        static  int numDigits;
        static  int numAlphas;
        static  int numOthers;
        static  int extractNums;
        // The NumberOfDigits static method calculates the number of
        // digit characters in the passed string:

        /// \brief NumberOfDigits counts numbers
        /// \details <b>Details</b> 
        /// The NumberOfDigits static method calculates the number of<br>
        /// digit characters in the passed stringS
        ///	<b>Input</b> 
        ///			~ theString (string) 
        /// \return
        ///			~ Returns (int) number of digits<br>
        ///
        public static int NumberOfDigits(string theString) 
        {
            int count = 0; 
            for ( int i = 0; i < theString.Length; i++ ) 
            {
                if ( Char.IsDigit(theString[i]) ) 
                {
                    count++; 
                }
            }
            // let's hold onto this count
            numDigits = count;
            
            return count;
        }

        // The NumberOfAlphas static method calculates the number of
        // alphabetic characters in the passed string:

        /// \brief NumberOfAlphas counts Letters
        /// \details <b>Details</b> 
        /// The NumberOfAlphas static method calculates the number of<br>
        /// alphabetic characters in the passed string
        ///	<b>Input</b> 
        ///			~ theString (string) 
        /// \return
        ///			~ Returns (int) number of Letters<br>
        ///
        public static int NumberOfAlphas(string theString)
        {
            int count = 0;
            for (int i = 0; i < theString.Length; i++)
            {
                if (Char.IsLetter(theString[i]))
                {
                    count++;
                }
            }
            // let's hold onto this count
            numAlphas = count;

            return count;
        }

        /// \brief NumberOfOthers counts "Others"
        /// \details <b>Details</b> 
        /// The NumberOfOthers static method calculates the number of<br>
        /// other (anything but numbers or letters) characters in the passed string
        ///	<b>Input</b> 
        ///			~ theString (string) 
        /// \return
        ///			~ Returns (int) number of Others<br>
        ///
        public static int NumberOfOthers(string theString)
        {
            int count = theString.Length;

            for (int i = 0; i < theString.Length; i++)
            {
                if (Char.IsLetterOrDigit(theString[i]))
                {
                    count--;
                }
            }
            numOthers = count;
            return count;
        }

        /// \brief FindAndExtractDigits Extracts Digits
        /// \details <b>Details</b> 
        /// The FindAndExtractDigits static method Etracts numbers and<br>
        /// stores them into a string.
        ///	<b>Input</b> 
        ///			~ theString (string) 
        /// \return
        ///			~ Returns (int) number of Letters<br>
        ///
        public static int FindAndExtractDigits(string theString)
        {
            int digits = 0;
            string stringDigits = "";

            for (int i = 0; i < theString.Length; i++)
            {
                if (Char.IsDigit(theString[i]))
                {
                    stringDigits += theString[i];
                }
            }
            
            // converts string to int
            int.TryParse(stringDigits, out digits);
            extractNums = digits;
            return digits;
        }

        /// \brief Gets numDigits
        /// \details <b>Details</b> 
        /// Gets numDigits from StringBreakout class<br>
        ///	<b>Input</b> 
        ///			~ none ()
        /// \return
        ///			~ numDigits<br>
        ///	
        public static int NumberDigits
        {
            get { return numDigits; }
        }

        /// \brief Gets numAlphas
        /// \details <b>Details</b> 
        /// Gets numAlphas from StringBreakout class<br>
        ///	<b>Input</b> 
        ///			~ none ()
        /// \return
        ///			~ numDigits<br>
        ///
        public static int NumberAlphas
        {
            get { return numAlphas; }
        }

        /// \brief Gets NumberOthers
        /// \details <b>Details</b> 
        /// Gets numOthers from StringBreakout class<br>
        ///	<b>Input</b> 
        ///			~ none ()
        /// \return
        ///			~ numOthers<br>
        ///
        public static int NumberOthers
        {
            get { return numOthers; }
        }

        /// \brief Gets ExtractNumbers
        /// \details <b>Details</b> 
        /// Gets extractNums from StringBreakout class<br>
        ///	<b>Input</b> 
        ///			~ none ()
        /// \return
        ///			~ numOthers<br>
        ///
        public static int ExtractNumbers
        {
            get { return extractNums; }
        }
    }
}

