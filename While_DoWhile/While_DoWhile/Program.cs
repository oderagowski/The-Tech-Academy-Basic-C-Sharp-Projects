using System;

namespace While_DoWhile
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Can you guess my favorite number? It's between 1 and 10.");
            int userNumberGuess = Convert.ToInt32(Console.ReadLine());
            bool numberIsGuessed = userNumberGuess == 6;

            // while loop
            while (!numberIsGuessed)
            {
                switch(userNumberGuess)
                {
                    // will continue running if the user does not guess the correct number
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        Console.WriteLine($"You guessed {userNumberGuess}. That is incorrect. Try again.");
                        Console.WriteLine("Guess my favorite number");
                        userNumberGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    
                    // 'numberIsGuessed' is set to true, causing the while loop to end
                    case 6:
                        Console.WriteLine("Congratulations! You guessed the correct number. Move on to the next question.");
                        numberIsGuessed = true;
                        break;
                    
                    // Runs if the user inputs a number greater than 10
                    default:
                        Console.WriteLine("You did not read the directions carefully. Enter a number between 1 and 10.");
                        userNumberGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                }


            }


            Console.WriteLine("Now can you guess my favorite color primary color? Please only use lowercase letters");
            string userColorGuess = Console.ReadLine();
            bool colorIsGuessed = userColorGuess == "red";

            // do while loop
            
            do
            {
                switch (userColorGuess)
                {
                    
                    // will continue looping as long as the user inputs the wrong color
                    case "yellow":
                    case "blue":
                        Console.WriteLine($"You guessed {userColorGuess}. That is incorrect. Try again.");
                        userColorGuess = Console.ReadLine();
                        break;
                    
                    // will exit out of loop and end program if the correct color is guessed
                    case "red":
                        Console.WriteLine("You guessed the correct color! Good job!");
                        colorIsGuessed = true;
                        break;
                    
                    // runs if the user inputs something other than the 3 primary colors
                    default:
                        Console.WriteLine("That is not a primary color. Try again.");
                        userColorGuess = Console.ReadLine();
                        break;
                }
            }
            while (!colorIsGuessed);

            // prevents the program from ending abruptly
            Console.ReadLine();






        }
    }
}
