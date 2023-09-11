using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    enum Role
    {
        admin,
        user
    }
    internal class User
    {


        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public string Email { get; private set; }
        public string Password { get; private set; }
        public string PhoneNumber { get; private set; }
        public Role UserRole { get; private set; }

        public User(string firstName, string lastName, string email, string password, string phoneNumber, Role userRole)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.PhoneNumber = phoneNumber;
            this.UserRole = userRole;
        }

        public string getUserData()
        {
            return ($@"Here is a recap of your data:
                    Role: {getUserRole()}
                    First name: {FirstName}
                    Last name: {LastName}
                    Email: {Email}
                    Password: {hidePassword()}
                    Phone number: {PhoneNumber}
                   ");
        }

        private string hidePassword()
        {
            string hiddenPassword = new String('x', Password.Length);
            return hiddenPassword;
        }

        private string getUserRole()
        {
            return UserRole == Role.admin ? "Admin" : "User";
        }
    }
}
