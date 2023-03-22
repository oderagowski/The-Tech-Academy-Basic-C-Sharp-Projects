using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // create an abstract class called Person
    public abstract class Person
    {
        // two properties of method
        public string firstName { get; set; }
        public string lastName { get; set; }

        // abstract method
        public abstract void SayName();
    }
}
