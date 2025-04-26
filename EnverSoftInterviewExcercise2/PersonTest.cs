using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using EnverSoft_Interview_Excercise_2;
namespace EnverSoftInterviewExcercise2
{
    public class PersonTest
    {
        [Fact]
        public void NameFrequencyTest()
        {
            List<Person> records = new List<Person>
        {
            new Person { FirstName = "Matt", LastName = "Brown" },
            new Person { FirstName = "Heinrich", LastName = "Jones" },
            new Person { FirstName = "Johnson", LastName = "Smith" },
            new Person { FirstName = "Tim", LastName = "Johnson" }
        };
            List<string> result = Frequencies.NameFrequencies(records);
            List<string> expected = new List<string>
        {
            "Johnson, 2",
            "Brown, 1",
            "Heinrich, 1",
            "Jones, 1",
            "Matt, 1",
            "Smith, 1",
            "Tim, 1"
        };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SortedAddressTest()
        {
            List<Person> records = new List<Person>
        {
            new Person { Address = "12 Acton St" },
            new Person { Address = "31 Clifton Rd" },
            new Person { Address = "22 Jones Rd" }
        };
            List<string> result = Sorting.GetSortedAddresses(records);
            List<string> expected = new List<string>
        {
            "12 Acton St",
            "31 Clifton Rd",
            "22 Jones Rd"
        };

            Assert.Equal(expected, result);
        }
    }
}