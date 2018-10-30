using System;
using ExtentionMethods;

using static System.Console;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteLine($"Local function result: {LocalFunctions(3, 5)}");  // Local functions
            //string str = "How are you bro!";                              // Test string
            //WriteLine(str.Reverse());                                     // String reverse          
        }

        // Local Functions
        static int LocalFunctions(int a, int b)
        {
            int result = 0;

            int Sum(int x, int y)
            {
                return x + y;
            }

            bool IsEven(int num)
            {
                return (num % 2) == 0 ? true : false;
            }

            for (int i = 0; i < Sum(a, b); ++i)
            {
                if (IsEven(i))
                    continue;
                result += i;
            }

            return result;
        }
    }

}
