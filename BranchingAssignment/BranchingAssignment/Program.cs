using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight: ");

            // converts user input to integer
            int packageWeight = int.Parse(Console.ReadLine());
            
            // checks if package weighs less than 50. Ends program if it is
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            else
            {
                Console.WriteLine("Please enter the package width: ");
                // converts user input to integer
                int packageWidth = int.Parse(Console.ReadLine());



                Console.WriteLine("Please enter the package width: ");
                // converts user input to integer
                int packageHeight = int.Parse(Console.ReadLine());



                Console.WriteLine("Please enter the package length: "); 
                // converts user input to integer
                int packageLength = int.Parse(Console.ReadLine());

                // program will end if combined height and length is greater than 50
                if (packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express");
                }
                else // will run if combined height and length is less than 50
                {
                    int priceQuote = ((packageHeight * packageWidth * packageLength) * packageWeight) / 100;

                    Console.WriteLine("Your estimated total for shipping this package is: $" + priceQuote + "\nThank you! ");
                }
            }



            

            Console.ReadLine();
        }
    }
}
