using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, HashSet<string>> teame = new Dictionary<string, HashSet<string>>();
            string input = "";
            while ((input = Console.ReadLine()) != "Blaze it!")
            {
                string separator = " -> ";
                string[] tokens = input.Split(separator.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string creature = tokens[0];
                string squadMate = tokens[1];
                
                if (!teame.ContainsKey(creature))
                {
                    teame.Add(creature, new HashSet<string>());

                }
                if (creature != squadMate)
                {
                    teame[creature].Add(squadMate);
                }

            }

            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            foreach (var item in teame)
            {
                result.Add(item.Key, new List<string>());

                foreach (var mete in item.Value)
                {
                    if (teame.ContainsKey(mete) && teame[mete].Contains(item.Key))//
                    {
                        continue;
                    }
                    else
                    {
                        result[item.Key].Add(mete);
                    }
                }
            }

            foreach (var item in result.OrderByDescending(a=>a.Value.Count))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count}");
            }
        }
    }
}
