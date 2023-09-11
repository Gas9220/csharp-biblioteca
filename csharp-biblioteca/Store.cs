using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Store
    {

        public static List<Document> FillStore()
        {
        // Create some book
        Book lordOfTheRingBook = new Book(Random.Shared.Next(0, 1000),
                                  "Lord of the rings",
                                   "1968",
                                   Subject.fantasy,
                                   Random.Shared.Next(1, 100).ToString(),
                                   new Author("John Ronald Reuel", "Tolkien"),
                                   529
                                   );
        Book iamThor = new Book(Random.Shared.Next(0, 1000),
                              "I'am Thor",
                               "2022",
                               Subject.Comics,
                               Random.Shared.Next(1, 100).ToString(),
                               new Author("Stan", "Lee"),
                               529
                               );
        Book wordWarII = new Book(Random.Shared.Next(0, 1000),
                              "World War II: The Definitive Visual History: From Blitzkrieg to the Atom Bomb",
                               "2011",
                               Subject.history,
                               Random.Shared.Next(1, 100).ToString(),
                               new Author("Ferdie", "McDonald"),
                               529
                               );
        // Create some DVD
        Dvd avatar = new Dvd(Random.Shared.Next(0, 1000),
                              "Avatar: The Way of Water",
                               "2022",
                               Subject.fantasy,
                               Random.Shared.Next(1, 100).ToString(),
                               new Author("James", "Cameron"),
                               192
                               );
        Dvd batman = new Dvd(Random.Shared.Next(0, 1000),
                              "Batman: The Dark Knight",
                               "2012",
                               Subject.Comics,
                               Random.Shared.Next(1, 100).ToString(),
                               new Author("Christopher", "Nolan"),
                               164
                               );
        Dvd planetLife = new Dvd(Random.Shared.Next(0, 1000),
                              "David Attenborough: A Life on Our Planet",
                               "2020",
                               Subject.Comics,
                               Random.Shared.Next(1, 100).ToString(),
                               new Author("David ", "Attenborough"),
                               200
                               );

            List<Document> documentsCollection = new List<Document>
            {
                lordOfTheRingBook,
                iamThor,
                wordWarII,
                avatar,
                batman,
                planetLife
            };

            return documentsCollection;
        }

    }
}
