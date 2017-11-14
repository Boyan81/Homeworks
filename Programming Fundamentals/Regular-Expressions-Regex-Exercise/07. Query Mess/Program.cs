using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Query_Mess
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"([^&=?\s]*)(?=\=)=(?<=\=)([^&=\s]*)";
            string pat = @"((%20|\+)+)";


            while (input != "END")
            {
                Dictionary<string, List<string>> ivancho = new Dictionary<string, List<string>>();
                Regex regex = new Regex(pattern);
                MatchCollection match = regex.Matches(input);

                foreach (Match item in match)
                {
                    string key = item.Groups[1].ToString();
                    key = Regex.Replace(key, pat, w => " ").Trim();
                    string vaule = item.Groups[2].ToString();
                    vaule = Regex.Replace(vaule, pat, w => " ").Trim();
                    if (!ivancho.ContainsKey(key))
                    {
                        ivancho.Add(key, new List<string>());
                        ivancho[key].Add(vaule);
                    }
                    else
                    {
                        ivancho[key].Add(vaule);
                    }
                }

                foreach (var item in ivancho)
                {
                    Console.Write("{0}=[{1}]", item.Key, String.Join(", ", item.Value));
                }
                Console.WriteLine();

                input = Console.ReadLine();
            }

        }
    }
}
