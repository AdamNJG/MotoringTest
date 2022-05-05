using MotoringTest.Models;
using System.Text.RegularExpressions;

namespace MotoringTest.Helpers
{
    public static class ObjectHelper
    {
        public static List<Vehicle> AddAgeToVehicle(List<Vehicle> vehicleList)
        {
            Regex r = new Regex(@"^[A-Z]{2}(?<number>\d+)\s?[A-Z]{3}$");
            Match m = null;

            foreach (Vehicle vehicle in vehicleList)
            {
                m = r.Match(vehicle.Registration);
                if (m.Success)
                {
                    int year = GetYearFromRegistrationNumbers(m.Groups["number"].Value);
                    if (year > 10 && year <= 22)
                    {
                        vehicle.Year = year > 0 ? year + 2000 : null ;

                    }
                }
            }
            return vehicleList;
        }

        public static int GetYearFromRegistrationNumbers(string input)
        {
            int year = 0;
            Int32.TryParse(input, out year);
            if(year != 0)
            {
                if(year >= 10 && year <= 22)
                {
                    return year;
                }
                else if(year > 60 && year <= 72)
                {
                    return year - 50;
                }
            }

            return year;
        }
    }
}
