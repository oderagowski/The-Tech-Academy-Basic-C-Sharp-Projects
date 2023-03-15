using System;
using System.Collections.Generic;

namespace IterationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // *** Assignment #1 ***
            
            Console.WriteLine("Hello World!");

            // one-dimensional array of strings
            string[] arrayOfGreetings = { "Hello, ", "How are you, ", "Good morning, ", "Goodbye, " };
            
            // asks user to input text
            Console.WriteLine("Write the name of your best friend on the line below: ");
            string friendName = Console.ReadLine();

            //iterates through array and adds user input to the end of each element
            for (int i = 0; i < arrayOfGreetings.Length; i++)
            {
                arrayOfGreetings[i] += friendName;
            }

            // second loop that prints off each string in the array one at a time
            for (int i = 0; i < arrayOfGreetings.Length; i++)
            {
                Console.WriteLine(arrayOfGreetings[i]);
            }


            // ** Assignment #2 **

            // infinite loop
            //for(int i = 1; i > 0; i++)

            // There was an infinite loop because i will always be greater than 0. The way to fix this is to make sure i will reach a number where the condition will no longer be true
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            // ** Assignment #3 **

            // a loop where "<" is used to determine whether to continue looping

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // a loop where "<=" is used to determine whether to continue looping
            // the only difference is that this loop will run one more time
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }


            // ** Assignment #4 **

            // a list of strings where each item in the list is unique
            List<string> availableCitrusFruits = new List<string>() { "lemon", "grapefruit", "clementine", "lime" };

            // ask the user to input text to search for in the list
            Console.Write("Enter the citrus fruit to search for: ");
            string userFruitSearch = Console.ReadLine();

            // a loop that iterates through the list and then displays the index of the list item that contains matching text
            bool citrusFruitIsAvailable = false;
            for (int i = 0; i < availableCitrusFruits.Count; i++)
            {
                if (availableCitrusFruits[i].Contains(userFruitSearch))
                {
                    Console.WriteLine($"The fruit was found at index {i}");

                    // stops the loop from executing once a match has been found
                    citrusFruitIsAvailable = true;
                    
                    break;
                } 
            
            }
            
            // checks if the user put text that isn't on the list and tells the user their input is not on the list
            if(!citrusFruitIsAvailable)
            {
                Console.WriteLine($"{userFruitSearch} was not found");
            }

            // ** Assignment #5 **

            // A list of strings that has at least two identical strings
            List<string> duplicateList = new List<string>() { "lion", "tiger", "bear", "gorilla", "tiger", "hippopotamus", "tiger" };

            // Ask user to select text to search for in the llist
            Console.Write("Enter the animal you want to search for: ");
            string userAnimalSearch = Console.ReadLine();

            bool animalFound = false;
            
            // loop iterates through the list
            for (int i = 0; i < duplicateList.Count; i++)
            {
                // displays the indices of the items matching the user-seelected text without break statements
                if (duplicateList[i].Equals(userAnimalSearch))
                {
                    Console.WriteLine($"The animal has been found at index {i}");
                    animalFound = true;
                }
            }

            // checks if the user put in text that isn't on the list, telling user theri input is not on the list
            if (!animalFound)
            {
                Console.WriteLine($"Sorry, you cannot see a {userAnimalSearch}  at this zoo");
            }

            // ** Assignment #6 **

            // Create a list of strings that has at least two identical strings in the list
            List<string> paintColorsList = new List<string> { "red", "orange", "gold", "purple", "green", "blue", "red", "purple", "pink", "black", "gray", "gold" };

            
            // lists used to keep track of duplicates and unique colors
            
            List<string> duplicateColors = new List<string>();

            List<string> uniqueColors = new List<string>();

            // for loop evaluates each item in the list and displays a message showing the string whether or not it has already appeared
            foreach (string color in paintColorsList)
            {
                if (uniqueColors.Contains(color))
                {
                    if(!duplicateColors.Contains(color))
                    {
                        Console.WriteLine($"This {color} paint in this box is a duplicate color ");
                        duplicateColors.Add(color);
                    }
                }
                else
                {
                    Console.WriteLine($"This {color} paint in this box is a unique color");
                    uniqueColors.Add(color);
                }
            }

                Console.ReadLine();
        }
    }
}
