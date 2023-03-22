using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    
    // create a class called Person
    public class Person
    {
        // create two properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        
        // void method, takes no parameters and writes the person's full name to the console
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
