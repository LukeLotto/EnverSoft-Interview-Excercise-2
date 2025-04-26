using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnverSoft_Interview_Excercise_2
{
    public class Sorting
    {
        public static List<string> GetSortedAddresses(List<Person> people)
        {
            return people
                .Select(r => r.Address)
                .OrderBy(address => GetStreetName(address))
                .ToList();
        }

        public static string GetStreetName(string address)
        {
            var firstSpaceIndex = address.IndexOf(' ');
            return firstSpaceIndex >= 0 ? address.Substring(firstSpaceIndex + 1) : address;
        }
    }
}
