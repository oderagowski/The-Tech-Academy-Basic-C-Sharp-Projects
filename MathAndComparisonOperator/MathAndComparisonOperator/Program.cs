using System;

namespace MathAndComparisonOperator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Programs");

            // Person 1 Salary Information
            Console.WriteLine("Person 1");
            
            Console.WriteLine("Please enter your hourly rate: ");
            
            // converts user's input to an int
            int person1HourlyRate = int.Parse(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");

            // converts user's input to an int
            int person1HoursPerWeek = int.Parse(Console.ReadLine());
            int person1AnnualSalary = (person1HourlyRate * person1HoursPerWeek) * 52;
            Console.WriteLine("Annual salary of Person 1: "+ person1AnnualSalary);


            // Person 2 Salary Information
            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your hourly rate: ");
            
            // converts user's input to an int
            int person2HourlyRate = int.Parse(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            
            
            // converts user's input to an int
            int person2HoursPerWeek = int.Parse(Console.ReadLine());
            int person2AnnualSalary = (person2HourlyRate * person2HoursPerWeek) * 52;
            Console.WriteLine("Annual salary of Person 2: " + person2AnnualSalary);

            // Boolean comparing person 1's salary to person 2's salary
            bool person1HigherSalary = person1AnnualSalary > person2AnnualSalary;
            Console.Write("Does Person 1 make more money than Person 2?\n");
            Console.Write(person1HigherSalary);


            // prevents program from ending abruptly
            Console.ReadLine();
        }
    }
}
