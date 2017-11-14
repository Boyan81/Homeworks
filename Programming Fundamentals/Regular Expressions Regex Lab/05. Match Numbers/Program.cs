using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Match_Numbers
{
    class Program
    {
        static void Main()
        {

            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            string input = Console.ReadLine();
            MatchCollection number = Regex.Matches(input, pattern);

            var numArr = number
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();
            Console.WriteLine(String.Join(" ",numArr));
        }
    }
}
