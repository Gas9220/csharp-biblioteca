using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Rent
    {
        public User User { get; private set; }
        public DateTime StartDate {  get; private set; }
        public DateTime EndDate { get; private set; }

        public Rent(User user, DateTime startDate, DateTime endDate) {
            this.User = user;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
    }
}
