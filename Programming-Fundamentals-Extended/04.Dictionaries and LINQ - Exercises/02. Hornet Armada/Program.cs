using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hornet_Armada
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, long> activity = new Dictionary<string, long>();
            Dictionary<string, Dictionary<string, long>> soudetTypeAndCount = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(new char[] { ' ', '=', '>', '-', ':' }, StringSplitOptions.RemoveEmptyEntries);
                long lastActivity = long.Parse(tokens[0]);
                string legionName = tokens[1];
                string soldierType = tokens[2];
                long soldierCount = long.Parse(tokens[3]);

                if (!soudetTypeAndCount.ContainsKey(legionName))
                {
                    soudetTypeAndCount.Add(legionName, new Dictionary<string, long>());
                    activity.Add(legionName, lastActivity);
                }
                if (!soudetTypeAndCount[legionName].ContainsKey(soldierType))
                {
                    soudetTypeAndCount[legionName][soldierType] = 0;
                }
                soudetTypeAndCount[legionName][soldierType] +=soldierCount;
                if (activity[legionName]<lastActivity)
                {
                    activity[legionName] = lastActivity;
                }
            }
            string[] cmd = Console.ReadLine()
                .Split("\\".ToArray(), StringSplitOptions.RemoveEmptyEntries);

            if (cmd.Length<2)
            {
                string solderTypePrint = cmd[0];
                foreach (var item in activity.OrderByDescending(x=>x.Value))
                {
                    if (soudetTypeAndCount[item.Key].ContainsKey(solderTypePrint))
                    {
                        Console.WriteLine($"{item.Value} : {item.Key}");
                    }
                }
            }
            else
            {
                long curentActivity = long.Parse(cmd[0]);
                string currentSoldier = cmd[1];
                foreach (var legion in soudetTypeAndCount.OrderByDescending(x => x.Value[currentSoldier]))
                {
                    if (activity[legion.Key] < curentActivity && soudetTypeAndCount[currentSoldier].ContainsKey(currentSoldier))
                    {
                        Console.WriteLine($"{legion.Key} -> {soudetTypeAndCount[legion.Key][currentSoldier]}");
                    }
                }
            }
        }
    }
}
