using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Dvd : Document
    {
        public int Duration { get; private set; }
        public Dvd(int iD, string title, string year, Subject subject, string shelf, Author author, int duration) : base(iD, title, year, subject, shelf, author)
        {
            this.Duration = duration;
        }
        public override string getDocumentData()
        {
            return ($@"
                    Title: {Title}
                    Year: {Year}
                    Subject: {Subject}
                    Shelf: {Shelf}
                    Author: {Author.FirstName} {Author.LastName}
                    Duration: {Duration}
                   ");
        }
    }
}
