using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, double> cityWithTemp = new Dictionary<string, double>();
            Dictionary<string, string> cityWithWeather = new Dictionary<string, string>();

            string input = Console.ReadLine();
            string pattern = @"([A-Z]{2})([0-9]+\.[0-9]+)([A-Za-z][a-z]+)\|";

            while (input!="end")
            {
                if (Regex.IsMatch(input,pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    string city = match.Groups[1].Value;
                    double temp =double.Parse( match.Groups[2].Value);
                    string weather = match.Groups[3].Value;
                    cityWithTemp[city] = temp;
                    cityWithWeather[city] = weather;
                }
               
                input = Console.ReadLine();
            }
            Dictionary<string, double> sortrCityTemp = cityWithTemp
                   .OrderBy(s => s.Value)
                   .ToDictionary(x => x.Key, x => x.Value);
            foreach (var cit in sortrCityTemp)
            {
                Console.WriteLine($"{cit.Key} => {cit.Value} => {cityWithWeather[cit.Key]}");//cityWithWeather[cit.Key]-вадиме стоиноста на друго диктонари 
            }
        }
    }
}
