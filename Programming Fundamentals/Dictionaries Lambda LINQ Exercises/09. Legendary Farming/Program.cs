using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> farming = new Dictionary<string, int>();
            farming.Add("shards", 0);
            farming.Add("fragments", 0);
            farming.Add("motes", 0);

            while (true)
            {
                string[] input = Console.ReadLine()
                    .ToLower()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int i = 1; i < input.Length; i += 2)
                {
                    if (!farming.ContainsKey(input[i]))
                    {
                        farming.Add(input[i], int.Parse(input[i - 1]));
                    }
                    else
                    {
                        farming[input[i]] += int.Parse(input[i - 1]);
                        bool farmings = (input[1] == "shards" || input[1] == "fragments" || input[1] == "fragments");
                        if (farmings && farming.(input[i])>=250)
                        {

                        }
                    }
                }
            }
        }
    }
}
