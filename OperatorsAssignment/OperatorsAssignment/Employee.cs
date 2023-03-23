using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    // creating an Employee class with ID, FirstName, and LastName properties
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        // overloading "==" operator; compares employee ID properties and returns true or false
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.ID == employee2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // operators must be overloaded in pairs
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1.ID == employee2.ID);
        }
    }
}
