using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnverSoft_Interview_Excercise_2
{
    public class ReadCSV
    {
        public static List<Person> ReadData(string path)
        {
            List<Person> people = new List<Person>();
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                people = csv.GetRecords<Person>().ToList();
            }

            return people;
        }
    }
}
