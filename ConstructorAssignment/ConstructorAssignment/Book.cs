using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Book
    {

        public string Title { get; set; }
        public string Author { get; set; }

        public int CopiesInStock { get; set; }

        // chain two constructors together
        public Book(string title, string author) : this(title, author, 0)
        {

        }

        public Book(string title, string author, int copiesInStock)
        {
            Title = title;
            Author = author;
            CopiesInStock = copiesInStock;

        }
    }
}
