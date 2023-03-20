using System;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiates the class
            
            MathOperation mathOperation = new MathOperation();
            
            
            // asks user to input two numbers one at a time
            Console.WriteLine("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            // user can skip number, which will cause the "if" statement to execute
            Console.WriteLine("Enter the second number (optional): ");
            string optionalNumber = Console.ReadLine();

            if (optionalNumber == "")
            {
                Console.WriteLine($"{number1} multiplied by 100 equals: " + MathOperation.DoMath(number1));
            }
            
            // executes if the user inputs two numbers
            else
            {
                int number2 = Convert.ToInt32(optionalNumber);
                Console.WriteLine($"{number1} plus {number2} multiplied by 100 equals: " + MathOperation.DoMath(number1, number2));
            }






            Console.ReadLine();
        }
    
    
    
    
    
    
    }




}
