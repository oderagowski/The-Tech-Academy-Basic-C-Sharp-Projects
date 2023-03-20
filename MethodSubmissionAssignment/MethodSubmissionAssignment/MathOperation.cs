using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class MathOperation
    {
        // setting default value of second parameter to 0 in order to make it optional
        public static int DoMath(int number1, int number2 = 0)
        {
            return (number1 + number2) * 100;
        }
    }
}
