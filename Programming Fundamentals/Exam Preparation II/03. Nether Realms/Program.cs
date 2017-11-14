using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x=>x.ToString())
                .ToArray();
            foreach (string item in input)
            {
                double health = HealtPoint(item);
                decimal damage = DamagePoint(item);
                Console.WriteLine($"{item} - {health} health, {damage:f2} damage");
            }
        }

        private static decimal DamagePoint(string item)
        {
            decimal result = 0.0m;
            string pattern = @"[\-\+]?[\d]+(?:[\.]*[\d]+|[\d]*)";
            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(item);
            foreach (Match ch in matchCollection)
            {
                result += decimal.Parse(ch.ToString());
            }
            foreach (char c in item.Where(c=>c=='*'||c=='/'))
            {
                if (c=='*')
                {
                    result *= 2;
                }
                else
                {
                    result /= 2;
                }
            }
            return result;
        }

        private static double HealtPoint(string item)
        {
            double result = 0.0;
            string pattern = @"[^\d\.\+\-\*\/\s\,]";
            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(item);
            foreach (Match ch in matchCollection)
            {
                foreach (char c in ch.ToString())
                {
                    result += (int)c;
                }
            }
            return result;
        }
    }
}
