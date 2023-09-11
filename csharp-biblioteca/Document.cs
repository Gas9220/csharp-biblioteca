using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    enum Subject
    {
        math,
        science,
        history,
        computerScience,
        english,
        geography,
        fantasy,
        Comics
    }
    internal class Document
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Year { get; private set; }
        public Subject Subject { get; private set; }
        public string Shelf { get; private set; }
        public Author Author { get; private set; }

        public Document(int iD, string title, string year, Subject subject, string shelf, Author author)
        {
            Id = iD;
            Title = title;
            Year = year;
            Subject = subject;
            Shelf = shelf;
            Author = author;
        }
    }
}
