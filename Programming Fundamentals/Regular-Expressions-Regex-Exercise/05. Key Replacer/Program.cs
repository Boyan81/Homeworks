using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main()
        {
            string inkey = Console.ReadLine();
            string patternKey = @"(?<start>[A-Za-z]+)([<\\|])\w+([<\\|])(?<end>[A-Za-z]+)";

            Match key = Regex.Match(inkey, patternKey);
            string start = key.Groups["start"].ToString();
            string end = key.Groups["end"].ToString();

            string pattern = $"({start})(.{{0,}}?)({end})";
            string input = Console.ReadLine();
            MatchCollection collection = Regex.Matches(input, pattern);
            string result = string.Empty;
            foreach (Match item in collection)
            {
              result+= item.Groups[2].ToString();
            }
            if (result== string.Empty)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(result);
            }
            

        }
    }
}
