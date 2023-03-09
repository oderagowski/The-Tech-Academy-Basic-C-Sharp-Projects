using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("What is your age?");
            
            // converts user's input to an int
            int age = int.Parse(Console.ReadLine());


            Console.WriteLine(age);

            Console.WriteLine("Have you ever had a DUI? Please write true or false");
            
            // stores user's input as a string
            string DUI = Console.ReadLine();


            Console.WriteLine(DUI);

            Console.WriteLine("How many speeding tickets do you have?");
            
            // converts user's input to an int
            int speedingTickets = int.Parse(Console.ReadLine());


            Console.WriteLine(speedingTickets);

            // boolean returns 'true' if all conditions are met and 'false' if not all are met
            bool qualified = age > 15 && DUI == "false" && speedingTickets <= 3;
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);




            // prevents the program from ending abruptly
            Console.ReadLine();
        }
    }
}
