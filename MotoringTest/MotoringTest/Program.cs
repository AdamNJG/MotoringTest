
using MotoringTest.Helpers;
using MotoringTest.Models;

public class Program
{
    public static void Main()
    {
        List<Customer> customers = StringHelper.CustomerParser(InputConstants.CustomerCSVContent);
        List<Vehicle> vehicles = StringHelper.VehicleParser(InputConstants.OrderCSVContent);

        vehicles = ObjectHelper.AddAgeToVehicle(vehicles);

        foreach(Vehicle vehicle in vehicles)
        {
            if(vehicle.Year != null)
            {
                Customer customer = customers.FirstOrDefault(c => c.CustomerId == vehicle.CustomerId);
                if (customer != null)
                {
                    Console.WriteLine(String.Format("The customer {0} {1} ordered a vehicle registered in the year {2}, registration: {3}", customer.FirstName, customer.Surname, vehicle.Year, vehicle.Registration));
                }
                else
                {
                    Console.WriteLine(String.Format("The vehicle with a registration of {0} and order ID of {2}, has no valid customer"),vehicle.Registration, vehicle.OrderId);
                }
            }
            else
            {
                Customer customer = customers.FirstOrDefault(c => c.CustomerId == vehicle.CustomerId);
                if (customer != null)
                {
                    Console.WriteLine(String.Format("The customer {0} {1} ordered a vehicle with the registration of {3}, the vehicle either has a custom plate or a data input error occured, unable to calculate date", customer.FirstName, customer.Surname, vehicle.Year, vehicle.Registration));
                }
                else
                {
                    Console.WriteLine(String.Format("The vehicle with a registration of {0} and order ID of {2}, has no valid customer"), vehicle.Registration, vehicle.OrderId);
                }
            }
        }
    }
}

