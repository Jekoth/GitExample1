using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker_Nuget
{

    internal class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 3; i++)
            {
                PrintPerson();
            }
        }

        private static void PrintPerson()
        {
            var firstName = Faker.Name.First();
            var lastName = Faker.Name.Last();
            var city = Faker.Address.City();
            Console.WriteLine(firstName + " " + lastName + " " + city);
        }
    }
}
