using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating an Employee object
            Employee employee1 = new Employee() { firstName = "Sample", lastName = "Student" };

            // calling SayName() method
            employee1.SayName();


            Console.ReadLine();

        }
    }
}
