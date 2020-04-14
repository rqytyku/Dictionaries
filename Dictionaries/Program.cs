using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Country albania = new Country("Albania", "AL", "Europe", 2_867_000);
            Country norway = new Country("Norway", "NOR", "Europe", 5_368_000);

            //Dictionary<string Country > countries = new Dictionary<string, Country>();
            var countries= new Dictionary<string, Country>();
            countries.Add(albania.code, albania);
            countries.Add(norway.code, norway);

            //Country selectCountry = countries["AL"];
            //Console.WriteLine(selectCountry.name);
            foreach (var country in countries.Values)
                Console.WriteLine(country.name);
            Console.ReadKey();
        }
    }
}
