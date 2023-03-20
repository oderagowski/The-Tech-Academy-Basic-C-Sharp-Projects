using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class MathOperations
    {
        // takes in an integer and performs a math operation
        public static int DoMath(int number)
        {
            return number * 10;
        }

        // takes in a decimal, converts decimal to integer, and performs a math operation
        public static int DoMath(decimal number)
        {
            int newNumber = Convert.ToInt32(number);;
            return newNumber * 100;

        }

        // takes in a string, converts string to integer, and performs a math operation
        public static int DoMath(string number)
        {
            int newNumber = Int32.Parse(number);
            return newNumber + 1500;
        }
    }
}
