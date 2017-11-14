using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Armada
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, long>> legion = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, int> activityArm = new Dictionary<string, int>();
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { "=", "-", ">", ":", " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int activity = int.Parse(input[0]);
                string legionName = input[1];
                string soldierType = input[2];
                long soldierCount = long.Parse(input[3]);

               
                    if (!legion.ContainsKey(legionName))
                    {
                        legion.Add(legionName, new Dictionary<string, long>());
                        legion[legionName].Add(soldierType, soldierCount);
                    }
                    else
                    {
                        if (!legion[legionName].ContainsKey(soldierType))
                        {
                            legion[legionName].Add(soldierType, soldierCount);
                        }
                        else
                        {
                            legion[legionName][soldierType] += soldierCount;
                        }
                    }
                
            }

        }
    }
}
