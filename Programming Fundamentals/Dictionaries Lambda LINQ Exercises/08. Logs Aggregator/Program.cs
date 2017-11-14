using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, Dictionary<string, int>> user = new SortedDictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] arr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string iP = arr[0];
                string nameUser = arr[1];
                int duration = int.Parse(arr[2]);

                if (!user.ContainsKey(nameUser))
                {
                    user.Add(nameUser, new Dictionary<string, int>());
                    user[nameUser].Add(iP, duration);
                }
                else
                {
                    if (!user[nameUser].ContainsKey(iP))
                    {
                        user[nameUser].Add(iP, duration);
                    }
                    else
                    {
                        user[nameUser][iP] += duration;
                    }
                }

            }
            foreach (var name in user)
            {
                Console.WriteLine($"{name.Key}: {name.Value.Values.Sum()} [{String.Join(", ",name.Value.Keys.OrderBy(x=>x))}]");
            }
            
        }
    }
}
