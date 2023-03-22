using System;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating the class
            Class1 class1 = new Class1();

            // user enters a number
            Console.WriteLine("Enter any whole number: ");
            int userInput = int.Parse(Console.ReadLine());

            // calling method on the number input by the user
            // the number that will be output to the screen is the user's number divided by 2
            class1.DoMath(userInput);



            Console.ReadLine();

        }
    }
}
