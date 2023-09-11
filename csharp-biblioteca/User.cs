using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class User
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public string Email { get; private set; }
        public string Password { get; private set; }
        public string PhoneNumber { get; private set; }

        public User(string firstName, string lastName, string email, string password, string phoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.PhoneNumber = phoneNumber;
        }
    }
}
