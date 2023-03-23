using System;

namespace PolymorphismSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // object of type IQuittable
            IQuittable employee2 = new Employee { firstName = "Bad", lastName = "Worker" };

            // calling Quit() method on object
            employee2.Quit();


            Console.ReadLine();


        }
    }
}
