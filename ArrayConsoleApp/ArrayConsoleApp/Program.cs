using System;
using System.Collections.Generic; // necessary in order to use lists

namespace ArrayConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // array of strings
            string[] array1 = { "americano", "expresso", "cappuccino", "macchiato", "frappuccino" };
            Console.WriteLine("Congratulations! You've been selected to win a random coffee. Please enter a number between 1 and 5");
            
            // converts and stores user choice as an int
            int userNumber = Int32.Parse(Console.ReadLine());
            if (userNumber > 0 && userNumber < 6)
            {
                Console.WriteLine($"Congratulations, you won: {array1[userNumber - 1]}");// -1 since index starts at 0
            } 
            else // displays if user selects an index that doesn't exist
            {
                Console.WriteLine("Error! You did not choose a number between 1 and 5. Because you can't read, you don't get a free coffee.");
            }

            Console.WriteLine("Now we'll see how much money you won! Enter a number between 1 and 10");

            // array of integers
            int[] array2 = { 4, 89, 49, 71, 22, 10000, 53, 77, 63, 76 };
            int userNumber2 = Int32.Parse(Console.ReadLine());
            if (userNumber2 > 0 && userNumber2 < 11)
            {
                Console.WriteLine($"Congratulations, you won ${array2[userNumber2 - 1]}!"); // -1 since index starts at 0
            }
            else // displays if user selects index that doesn't exist
            {
                Console.WriteLine("Error! You did not choose a number between 1 and 5. You don't win any money.");
            }

            // list of strings
            List<string> destinationList = new List<string>() { "Paris", "Maui", "Rome", "Phuket", "New York City" };
            Console.WriteLine("You have one more chance to win a great prize. Please enter a number between 1 and 5");
            int userNumber3 = Int32.Parse(Console.ReadLine());
            if (userNumber > 0 && userNumber < 6)
            {
                Console.WriteLine($"Congratulations, you won a trip to {destinationList[userNumber3 - 1]}");
            }
            else
            {
                Console.WriteLine("Error! You did not choose a number between 1 and 5. Looks like you'll be stuck at your house.");
            }

            Console.WriteLine("Thank you for playing!");







            Console.ReadLine();

        }
    }
}
