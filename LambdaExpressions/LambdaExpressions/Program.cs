using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a list of 10 employees
            
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee { ID = 1, FirstName = "Amanda", LastName = "Jordan" });
            employees.Add(new Employee { ID = 2, FirstName = "Bobby", LastName = "Jordan" });
            employees.Add(new Employee { ID = 3, FirstName = "Joe", LastName = "Adams" });
            employees.Add(new Employee { ID = 4, FirstName = "Cindy", LastName = "Adams" });
            employees.Add(new Employee { ID = 5, FirstName = "David", LastName = "Williams" });
            employees.Add(new Employee { ID = 6, FirstName = "Joe", LastName = "Williams" });
            employees.Add(new Employee { ID = 7, FirstName = "Elphaba", LastName = "Gomez" });
            employees.Add(new Employee { ID = 8, FirstName = "Frank", LastName = "Gomez" });
            employees.Add(new Employee { ID = 9, FirstName = "Joe", LastName = "Kim" });
            employees.Add(new Employee { ID = 10, FirstName = "Ginny", LastName = "Smith" });


            // new list for employees named Joe
            List<Employee> employeesNamedJoe = new List<Employee>();

            // finds all employees with the first name "Joe" and adds them to a new list
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    employeesNamedJoe.Add(employee);
                }
            }

            // lambda expression finds all employees with the first name "Joe" and adds them to a new list
            List<Employee> employeesNamedJoeLambda = employees.Where(e => e.FirstName == "Joe").ToList();


            // lambda expression finds all Id numbers that are greater than 5 and adds them to a list
            List<Employee> employeeIDGreaterThanFive = employees.Where(e => e.ID > 5).ToList();


            Console.ReadLine();
        
        }
    }
}
