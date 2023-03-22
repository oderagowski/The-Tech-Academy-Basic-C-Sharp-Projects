using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // inherit from Person class
    public class Employee : Person
    {
        // implementing SayMethod()
        public override void SayName()
        {
            Console.Write($"Hello, I'm an employee and my name is {firstName} {lastName} ");
        }
    }
}
