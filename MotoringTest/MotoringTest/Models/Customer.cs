using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoringTest.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public Customer(int customerId, string firstName, string surname)
        {
            this.CustomerId = customerId;
            this.FirstName = firstName;
            this.Surname = surname;
        }
    }
}
