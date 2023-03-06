using System;

namespace DailyReportSubmission
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("The Tech Academy \nStudent Daily Report");

            // stores user's input as a string
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            // stores user's input as a string
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            // converts user's input from a string to a ushort
            Console.WriteLine("What page number?");
            ushort pageNumber = Convert.ToUInt16(Console.ReadLine());

            // converts user's answer from a string to a boolean
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            // stores user's input as a string
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string feedback = Console.ReadLine();

            // converts user's input as a byte
            Console.WriteLine("How many hours did you study today?");
            byte hoursStudied = Convert.ToByte(Console.ReadLine());

            // Console.ReadLine() is so this last line will appear instead of having the program end abruptly 
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
