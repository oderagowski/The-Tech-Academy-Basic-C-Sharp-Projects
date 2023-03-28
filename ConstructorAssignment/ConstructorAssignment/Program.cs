using System;
using System.Collections.Generic;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a const variable
            const string storeName = "Barnes and Noble";

            // creating variable using keyword "var"
            var shelfK = new List<Book>();

            
            // initializing objects to make sure code works properly
            Book book1 = new Book("It", "King, Stephen", 100);
            Book book2 = new Book("Demon Copperhead", "Kingsolver, Barbara", 55);
            Book book3 = new Book("A Separate Peace", "Knowles, John");


            shelfK.Add(book1);
            shelfK.Add(book2);
            shelfK.Add(book3);

            Console.WriteLine("On Shelf K: ");
            foreach (Book book in shelfK)
            {
                Console.WriteLine($"There are {book.CopiesInStock} copies of {book.Title} by {book.Author}");
            }




            Console.ReadLine();



        }
    }
}
