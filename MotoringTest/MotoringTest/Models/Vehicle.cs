using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoringTest.Models
{
    public class Vehicle
    {
        public int OrderId { get; set; }
        public string Registration { get; set; }
        public int CustomerId { get; set; }
        public int? Year { get; set;  }

        public Vehicle( int orderId, string registration, int customerId)
        {
            this.OrderId = orderId;
            this.Registration = registration;
            this.CustomerId = customerId;
        }
    }
}
