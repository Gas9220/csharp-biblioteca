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

        public Document? SearchDocument(string name)
        {

            foreach (Document document in documents)
            {
                if (document.Title.ToLower().Contains(name.ToLower()))
                {
                    return document;
                }
            }

            return null;
        }
    }
}
