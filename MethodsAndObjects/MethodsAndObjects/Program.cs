using System;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating and initializing Employee object
            Employee employee = new Employee { FirstName = "Sample", LastName = "Student" };
            
            // calling superclass method SayName();
            employee.SayName();


            Console.ReadLine();

            
        }
    }
}
