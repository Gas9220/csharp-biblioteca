using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Library
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

        public void RentDocument(User user, int numberOfDays)
        {
            Rent newRent = new Rent(user, DateTime.Now, DateTime.Now.AddDays(numberOfDays));
            rents.Add(newRent);
        }
    }
}
