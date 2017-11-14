using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Match_Full_Name
{
    class Program
    {
        static void Main()
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();

            MatchCollection nameMatch = Regex.Matches(input, pattern);

            foreach (Match m in nameMatch)
            {
                Console.Write(m.Value+" ");
            }
            Console.WriteLine();
        }
    }
}
