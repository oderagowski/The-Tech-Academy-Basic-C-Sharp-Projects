using System;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // prints the current date and time to the console
            DateTime currentTime = DateTime.Now;
            Console.WriteLine($"The current time is {currentTime}");


            // asks the user for a number
            Console.WriteLine("Please enter a number of hours: ");
            int userNumber = int.Parse(Console.ReadLine());

            // prints to the console the exact time it will be in X hours
            DateTime laterTime = currentTime.AddHours(userNumber);
            Console.WriteLine($"In {userNumber} hours, the time will be {laterTime}");


            Console.ReadLine();


        }
    }
}
