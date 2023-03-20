using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // asks the user what number they want to do the math operations on
            Console.WriteLine("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());

            
            // calling method 1
            int NumTimesTwo = MathOperations.MultiplyByTwo(userNumber);
            Console.WriteLine($"{userNumber} multiplied by two is {NumTimesTwo}");

            // calling method 2
            int NumSquared = MathOperations.NumberSquared(userNumber);
            Console.WriteLine($"{userNumber} squared is {NumSquared}");

            // calling method 3
            int NumCheck = MathOperations.EvenOrOdd(userNumber);
            if (NumCheck == 0)
            {
                Console.WriteLine($"{userNumber} is an even number");
            }
            else
            {
                Console.WriteLine($"{userNumber} is an odd number");
            }






            Console.ReadLine();

        }
    }
}
