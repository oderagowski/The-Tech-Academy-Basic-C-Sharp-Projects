using System;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // instantiating class
            MathOperations mathOperations = new MathOperations();

            // numbers that will be passed into methods
            int number1 = 10;
            decimal number2 = 44.5M;
            string number3 = "1000";

            // calling first method, passing in an integer
            int result1 = MathOperations.DoMath(number1);
            Console.WriteLine(result1);

            // calling second method, passing in a decimal
            int result2 = MathOperations.DoMath(number2);
            Console.WriteLine(result2);

            // calling third method, passing in a string
            int result3 = MathOperations.DoMath(number3);
            Console.WriteLine(result3);





            Console.ReadLine();




        }
    }
}
