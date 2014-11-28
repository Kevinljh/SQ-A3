//This code was borrowed from the VS2008 C# Samples and was modified by S. Clarke

// Factorial.cs
// compile with: /target:library
using System; 

// Declares a namespace. You need to package your libraries according
// to their namespace so the .NET runtime can correctly load the classes.
namespace Functions 
{ 
    public class Factorial 
    {
        static int CalcResult;
        static int output;
        // The "Calc" static method calculates the factorial value for the
        // specified integer passed in:
        public static int Calc(int i)
        {
            output = ((i <= 1) ? 1 : (i * Calc(i - 1)));
            CalcResult = output;           

            return output;
        }

        public static int GetCalcResult
        {
            get { return CalcResult;  }
        }
    }
}

