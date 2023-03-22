using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    // creating a new class
    class Class1
    {
       // void method that divides the data passed to it by 2 and outputs an integer
        public void DoMath(int number1)
        {
            int result = number1 / 2;
            Console.WriteLine($"{number1} divided by 2 is {result}");
        }

        // overload a method
        public void DoMath(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine($"{number1} multiplied by {number2} is {result}");
        }

        // create a method with output parameters
        public void BasicMath(int number1, int number2, out int addition, out int subtraction)
        {
            addition = number1 + number2;
            subtraction = number1 - number2;
        }




    }
}
