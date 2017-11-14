using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class userLogs
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> counties = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            while (input != "report")
            {
                string[] parameter = input.Split('|');
                string country = parameter[1];
                string city = parameter[0];
                long pop = long.Parse(parameter[2]);

                if (!counties.ContainsKey(country))
                {
                    counties.Add(country, new Dictionary<string, long>());
                    counties[country].Add(city, pop);
                }
                else
                {
                    if (!counties[country].ContainsKey(city))
                    {
                        counties[country].Add(city, pop);
                    }

                }
                input = Console.ReadLine();
            }

            foreach (var country in counties.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (var city in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }

        }
    }
}
