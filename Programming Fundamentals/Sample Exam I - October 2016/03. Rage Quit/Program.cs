using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(\D+)(\d+)";
            StringBuilder output = new StringBuilder();
            MatchCollection collections = Regex.Matches(input, pattern);
            foreach (Match item in collections)
            {
                string str = item.Groups[1].ToString().ToUpper();
                int n = int.Parse(item.Groups[2].ToString());
                for (int i = 0; i < n; i++)
                {
                    output.Append(str);
                }
            }
            Console.WriteLine(output);
        }
    }
}
