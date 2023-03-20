using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    
    // Create a class
    public class MathOperations
    {
        // takes an integer multiplies it by 2
        public static int MultiplyByTwo(int number)
        {
            return number * 2;
        }

        // takes an integer and multiplies it by itself
        public static int NumberSquared (int number)
        {
            return number * number;
        }

        // takes and integer and returns either 0 or 1
        public static int EvenOrOdd (int number)
        {
            return number % 2;
        }

    }
}
