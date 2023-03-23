using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating two objects and assigning values to their properties
            Employee employee1 = new Employee { ID = 4480, FirstName = "Bruce", LastName = "Wayne" };

            Employee employee2 = new Employee { ID = 4580, FirstName = "Peter", LastName = "Parker" };


            // comparing two Employee objects using overloaded operator and displaying results
            Console.Write($"Do the employees have the same ID?: {employee1 == employee2} \n");

            Console.Write($"Do these two employees have different IDs?: {employee1 != employee2}");




            Console.ReadLine();
        }
    }
}
