using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main()
        {
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";
            string input = Console.ReadLine();

            MatchCollection hexNumber = Regex.Matches(input, pattern);
            var number = hexNumber
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();




            Console.WriteLine(String.Join(" ",number));
        }
    }
}
