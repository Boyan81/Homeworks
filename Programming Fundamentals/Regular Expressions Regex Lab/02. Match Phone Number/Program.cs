using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main()
        {
            string pattern = @"(\+359-2-\d{3}-\d{4})\b|(\+359 2 \d{3} \d{4})\b";
            string input = Console.ReadLine();
            MatchCollection number = Regex.Matches(input, pattern);

            var phoneNumber = number
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            Console.WriteLine(String.Join(", ",phoneNumber));

        }
    }
}
