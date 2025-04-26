using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnverSoft_Interview_Excercise_2
{
    public class Frequencies
    {
        public static List<string> NameFrequencies(List<Person> people)
        {
            Dictionary<string, int> nameFrequencies = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            foreach (Person person in people)
            {
                if (!string.IsNullOrWhiteSpace(person.FirstName))
                {
                    nameFrequencies[person.FirstName] = nameFrequencies.GetValueOrDefault(person.FirstName, 0) + 1;
                }
                if (!string.IsNullOrWhiteSpace(person.LastName))
                {
                    nameFrequencies[person.LastName] = nameFrequencies.GetValueOrDefault(person.LastName, 0) + 1;
                }
            }
            return nameFrequencies
               .OrderByDescending(x => x.Value)
               .ThenBy(x => x.Key, StringComparer.OrdinalIgnoreCase)
               .Select(x => $"{x.Key}, {x.Value}")
               .ToList();

        }
    }
}
