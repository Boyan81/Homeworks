using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main()
        {
            string pattern = @"([\w.-]+\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+";
            string input = Console.ReadLine();
            MatchCollection emails = Regex.Matches(input, pattern);

            foreach (Match m in emails)
            {
                string email = m.ToString();
                if (!(email.StartsWith(".")|| email.StartsWith("-")|| email.StartsWith("_")))
                {
                    Console.WriteLine(m.Value);
                }
                
                
            }
        }
    }
}
