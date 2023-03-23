using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
{
    // create an interface
    public interface IQuittable
    {
        // define a void method called Quit()
        public void Quit()
        {
            Console.WriteLine("The employee has quit");
        }
    }
}
