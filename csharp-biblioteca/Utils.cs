using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    sealed class Utils
    {
        static public Document[] PerformSearch(Library library)
        {
            Console.Write("Search for a document: ");
            string documentToFind = Console.ReadLine();
            Document[] possibleMatches = library.SearchDocument(documentToFind);

            while (possibleMatches.Length <= 0)
            {
                Console.WriteLine("No results, try again...");
                Console.Write("Search for a document: ");
                documentToFind = Console.ReadLine();

                possibleMatches = library.SearchDocument(documentToFind);
            }

            Console.WriteLine("Here is the result...");

            foreach (var (possibleMatch, i) in possibleMatches.Select((value, i) => (value, i)))
            {
                Console.WriteLine($"[{i}]{possibleMatch.getDocumentData()}");
            }

            return possibleMatches;
        }



        static public void PerformRent(Library library, Document[] documents, User user)
        {
            Console.Write("To rent a document, insert the result number (example 0 or 1):");
            int userSelection = Convert.ToInt32(Console.ReadLine());
            Document documentToRent = documents[userSelection];

            library.RentDocument(user, 5);

            Console.WriteLine($"Congratulation, you have rent: {documentToRent.getDocumentData()}");
            Console.WriteLine($"Here is the recap of your rent: {library.rents.Last().getRentDetails()}");
        }
    }
}
