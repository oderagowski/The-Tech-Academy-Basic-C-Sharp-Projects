using System;
using System.Linq;
using System.Data.Entity;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            using (var ctx = new SchoolContext())
            {
                var student1 = new Student() { StudentID = 20245, StudentFirstName = "Johnny", StudentLastName = "Smith", StudentGPA = 2.5m };


                ctx.Students.Add(student1);
                ctx.SaveChanges();

                Console.WriteLine($"{student1.StudentFirstName} {student1.StudentLastName} has been added to the database")

                Console.ReadLine();
            }
            
        }
    }


  

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public decimal StudentGPA {get; set;}


    }



    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }


    }

}
