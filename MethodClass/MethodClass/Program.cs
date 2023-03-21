using System;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating the class
            MathOperation mathOperation = new MathOperation();

            // passing in two numbers
            mathOperation.DoMath(10, 20);

            // specifying the parameters by name
            mathOperation.DoMath(number1: 5, number2: 25);




            Console.ReadLine();
        }
    }
}
