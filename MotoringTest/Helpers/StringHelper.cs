using MotoringTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoringTest.Helpers
{
    public static class StringHelper
    {
        public static List<Customer> CustomerParser(string csvString)
        {
            List<Customer> customerList = new List<Customer>();
            string[] parts = csvString.Split('\u002C', '\r', '\n', '\t');
            for (int i = 0; i < parts.Length; i++)
            {
                int tempNumber = 0;
                if (Int32.TryParse(parts[i], out tempNumber))
                {
                    Customer customer = new Customer(tempNumber, parts[i + 1], parts[i + 2]);
                    customerList.Add(customer);
                }
            }
            return customerList;
        }

        public static List<Vehicle> VehicleParser(string csvString)
        {
            List<Vehicle> vehicleList = new List<Vehicle>();
            string[] parts = csvString.Split('\u002C', '\r', '\n', '\t');
            for (int i = 0; i < parts.Length; i++)
            {
                int tempOrderId = 0;
                int tempCustomerId = 0;
                if (Int32.TryParse(parts[i], out tempOrderId) && parts.Length > i+2 && Int32.TryParse(parts[i+2],out tempCustomerId))
                {

                    Vehicle vehicle = new Vehicle(tempOrderId, parts[i + 1], tempCustomerId);
                    vehicleList.Add(vehicle);
                }
            }


            return vehicleList;
        }
    }
}
