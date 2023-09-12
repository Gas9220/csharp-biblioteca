using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    sealed class Library
    {
        public List<User> users = new List<User>();
        public List<Document> documents = new List<Document>();
        public List<Rent> rents = new List<Rent>();

        public Library() {
            documents = Store.FillStore();
        }


        public Document[] SearchDocument(string name)
        {
            List<Document> results = new List<Document>();

            foreach (Document document in documents)
            {
                if (document.Title.ToLower().Contains(name.ToLower()))
                {
                    results.Add(document);
                }
            }

            return results.ToArray();
        }

        public void RentDocument(Document document, User user, int numberOfDays)
        {
            Rent newRent = new Rent(document, user, DateTime.Now, DateTime.Now.AddDays(numberOfDays));
            rents.Add(newRent);
        }

        public void getAllRents()
        {
            foreach (Rent rent in rents)
            {
                Console.WriteLine(rent.getRentDetails());
            }
        }

        public void getAllUsers()
        {
            foreach (User user in users)
            {
                Console.WriteLine(user.getUserData());
            }
        }

        public void getAllDocuments()
        {
            foreach (Document document in documents)
            {
                Console.WriteLine(document.getDocumentData());
            }
        }
    }
}
