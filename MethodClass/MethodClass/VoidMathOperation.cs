using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class MathOperation
    {
        
        // void method that takes two integers as parameters and returns nothing
        public void DoMath(int number1, int number2)
        {
            // math operation performed on the first integer
            int squared = number1 * number1;

            // displays the second integer to the screen
            Console.WriteLine($"The second number is {number2}");
        }
    }
}
