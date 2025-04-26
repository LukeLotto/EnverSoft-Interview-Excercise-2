using CsvHelper;
using EnverSoft_Interview_Excercise_2;
using System.Globalization;



public class Program
{
    static void Main(string[] args)
    {
        //path: bin\debug\net8.0\Assets
        List<Person> records = ReadCSV.ReadData("Assets\\Data.csv");

        //path: bin\Debug\net8.0\
        var nameFrequencies = Frequencies.NameFrequencies(records);
        File.WriteAllLines("name_frequencies.txt", nameFrequencies);

        //path: bin\Debug\net8.0\
        var sortedAddresses = Sorting.GetSortedAddresses(records);
        File.WriteAllLines("sorted_addresses.txt", sortedAddresses);
    }
}

