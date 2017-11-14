using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Match_Dates
{
    class Program
    {
        static void Main()
        {
            string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            string input = Console.ReadLine();
            var dat = Regex.Matches(input, pattern);

            foreach (Match m in dat)
            {
                var days = m.Groups["day"].Value;
                var months = m.Groups["month"].Value;
                var years = m.Groups["year"].Value;

                Console.WriteLine($"Day: {days}, Month: {months}, Year: {years}");
            }
        }
    }
}
