using System;

namespace ParsingEnums
{

    // create an enum for the days of the week
    enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }



    class Program
    {
        static void Main(string[] args)
        {

            // wrapping code inside try/catch block
            try
            { 
            // prompt the user to enter the surrent day of the week
            Console.WriteLine("Please enter the current day of the week: ");

            string userDayInput = Console.ReadLine();

            
            // assinging the value of user's input to variable of created enum data type    
            DaysOfTheWeek Today = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userDayInput);

            Console.WriteLine($"You're correct. Today is {Today}");
            }

            // message will be displayed if the user enters a value that is not in the enum
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }












            Console.ReadLine();
        }
    }
}
