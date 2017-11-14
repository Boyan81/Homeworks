using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, long> mine = new Dictionary<string, long>();

            string input = Console.ReadLine();
            string temp = input;
            int count = 1;
            while (input!= "stop")
            {
                if (count%2==0)
                {
                    if (mine.ContainsKey(temp))
                    {
                        mine[temp] +=int.Parse(input);
                    }
                }
                else
                {
                    if (!(mine.ContainsKey(input)))
                    {
                        mine[input] = 0;
                    }
                    
                    
                }
                temp = input;
                input = Console.ReadLine();
                count++;
            }
            foreach (var item in mine.Keys)
            {
                Console.WriteLine($"{item} -> {mine[item]}");
            }
        }
    }
}
