using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Book : Document
    {
        public int NumberOfPages { get; private set; }
        public Book(int iD, string title, string year, Subject subject, string shelf, Author author, int numberOfPages) : base(iD, title, year, subject, shelf, author)
        {
            this.NumberOfPages = numberOfPages;
        }
    }
}
