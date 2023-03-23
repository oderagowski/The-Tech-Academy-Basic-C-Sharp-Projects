using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
{
    // employee class inherits from IQuittable
    public class Employee : Person, IQuittable
    {
        
        public override void SayName()
        {
            Console.Write($"Hello, I'm an employee and my name is {firstName} {lastName} ");
        }

        // implementing the Quit() method
        public void Quit()
        {
            Console.WriteLine($"{firstName} {lastName} has quit");
        }
    }
}
