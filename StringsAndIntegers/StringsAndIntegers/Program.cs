using System;
using System.Collections.Generic;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a list of integers
            
            List<int> numbers = new List<int>() { 36, 77, 57, 16, 79, 21, 2, 1 };

            // asks the user for a number to divide each number in the list by
            Console.WriteLine("Enter a number to divide each number in the list by: ");
            
       
            try
            {
                // converts user's input from a string
                decimal divisor = decimal.Parse(Console.ReadLine());

                // takes each integer in the list, divides it by the number the user entered, and displays the result to the screen
                foreach (int number in numbers)
                {
                    decimal result = number / divisor;
                    Console.WriteLine($"{number} divided by {divisor} equals {result}");

                }
            }
            // will be displayed if the user enters a string instead of an integer
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            
            // will be displayed if the user enters a 0
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }

            // runs once the code in the try/catch block has executed
            Console.WriteLine("The program has emerged from the try/catch block and has continued on with execution");
            
            

            Console.ReadLine();

        }
    }
}



  